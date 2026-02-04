using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Keyence.AutoID.SDK;

namespace LM2DBarcodeReader_New
{
    public partial class LotValidationForm : Form
    {
        // ===== AL Tag(기준) LotInfo 저장 =====
        private Dictionary<string, string> _alLotMap = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        private List<string> _alLotOrder = new List<string>();
        private string _alLotNoValue = string.Empty;   // "5번째 배열 값"(values[4])
                                                      
        // ===== Unit 5개 각각 LotInfo 저장 =====
        private class LotSnapshot
        {
            public Dictionary<string, string> Map = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            public List<string> Order = new List<string>();
            public string LotNoValue = string.Empty;
            public string LotNoHex = string.Empty;
        }

        private TextBox[] _unitTextBoxes;
        private DataGridView[] _unitGrids;
        private DataTable[] _unitTables;
        private LotSnapshot[] _unitSnaps;
        
        private DataTable _dtAl;

        int module;
        string ModuleName;

        public LotValidationForm()
        {
            InitializeComponent();

            module = (int)MODULE._PM1;
            ModuleName = "PM1";

            // 1) Unit 배열 준비
            _unitTextBoxes = new[] { textBoxUnit1, textBoxUnit2, textBoxUnit3, textBoxUnit4, textBoxUnit5 };
            _unitGrids = new[] { dataGridViewUnit1, dataGridViewUnit2, dataGridViewUnit3, dataGridViewUnit4, dataGridViewUnit5 };
            _unitTables = new DataTable[5];
            _unitSnaps = new LotSnapshot[5];
            for (int i = 0; i < 5; i++) _unitSnaps[i] = new LotSnapshot();
            
            // 2) 이벤트 연결
            textBoxAlTag.KeyDown += AlTag_KeyDown;
            foreach (var tb in _unitTextBoxes) tb.KeyDown += Unit_KeyDown;
            
            btnReset.Click += btnReset_Click;
            
            // 3) 그리드 초기화
            InitGrids();
            
            // 시작 포커스
            this.ActiveControl = textBoxAlTag;
            textBoxAlTag.Focus();
        }

        private void LotValidationForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            /*
            var screens = Screen.AllScreens;
            if (screens.Length > 1)
            {
                var second = screens[1];    // 두 번째 모니터
                this.Location = new Point(
                    second.Bounds.Left,
                    second.Bounds.Top
                );
            }
            else
            {
                // 모니터 한개일 땐 가운데 띄우기
                this.StartPosition = FormStartPosition.CenterScreen;
            }*/
            this.StartPosition = FormStartPosition.CenterScreen;

            if (Global.DEVICE_LOAD())
            {
                setLiveview();
            }
            else
            {
                MessageBox.Show("바코드 리더기가 연결되지 않았습니다", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setLiveview()
        {
            string key = string.Format("{0}/SR-X300W/READER", Define.sIPAddress);
            ReaderSearchResult res = getSearchResultFromKey(key);
            liveviewForm1.EndReceive();
            liveviewForm1.IpAddress = res.IpAddress;
            liveviewForm1.BeginReceive();
        }

        private ReaderSearchResult getSearchResultFromKey(string key)
        {
            String[] readerInfo = key.Split('/');
            if (readerInfo.Length == 3)
            {
                return new ReaderSearchResult(readerInfo[1], readerInfo[2], readerInfo[0]);
            }
            return new ReaderSearchResult();
        }

        private void InitGrids()
        {
            // 공통 테이블 구조: No, Name, Data
            _dtAl = CreateInfoTable();
            dataGridViewAlTag.AutoGenerateColumns = true;
            dataGridViewAlTag.DataSource = _dtAl;
            
            for (int i = 0; i < 5; i++)
            {
                _unitTables[i] = CreateInfoTable();
                _unitGrids[i].AutoGenerateColumns = true;
                _unitGrids[i].DataSource = _unitTables[i];
            }
            
            SetupGrid(dataGridViewAlTag);
            foreach (var g in _unitGrids) SetupGrid(g);
        }

        private DataTable CreateInfoTable()
        {
            var dt = new DataTable();
            dt.Columns.Add("No", typeof(int));
            dt.Columns.Add("Name");
            dt.Columns.Add("Data");
            return dt;
        }

        private void SetupGrid(DataGridView dgv)
        {
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            if (dgv.Columns["No"] != null) dgv.Columns["No"].Width = 50;
        }

        // =========================
        // 1) AL TAG 스캔
        // =========================
        private void AlTag_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            
            e.Handled = true;
            e.SuppressKeyPress = true;
            
            var tb = sender as TextBox;
            if (tb == null) return;
            
            try
            {
                string raw = (tb.Text ?? "").Trim();
                if (string.IsNullOrEmpty(raw)) return;
                
                // AL Tag 입력이 "hex"일 수도 있고, "문자열"일 수도 있어
                // - 전부 0-9A-F이고 길이가 짝수면 hex로 간주
                // - 아니면 UTF8->Hex로 변환
                string alTagHex = LooksLikeHex(raw) ? raw : ByteToHex(raw);
                
                // LotInfo 조회
                if (!Get_lot_info(alTagHex, out _alLotMap, out _alLotOrder, out _alLotNoValue))
                {
                    tb.BackColor = Color.Red;
                    tb.SelectAll();
                    return;
                }
                
                tb.BackColor = Color.White;
                UpdateGrid(_dtAl, alTagHex, _alLotMap, _alLotOrder);
                
                // 비교 갱신
                CompareAndMark();
                
                // 다음 입력으로 포커스(첫 번째 Unit)
                _unitTextBoxes[0].Focus();
                _unitTextBoxes[0].SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb.SelectAll();
            }
        }

        // =========================
        // 2) UNIT ID 스캔(5개)
        // =========================
        private void Unit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            
            e.Handled = true;
            e.SuppressKeyPress = true;
            
            var tb = sender as TextBox;
            if (tb == null) return;
            
            int idx = Array.IndexOf(_unitTextBoxes, tb);
            if (idx < 0) return;
            
            try
            {
                string unitId = (tb.Text ?? "").Trim();
                if (string.IsNullOrEmpty(unitId)) return;
                
                // UnitID -> LotNo 조회
                string lotNo = Get_lot_info_by_unit_id(unitId);
                if (string.IsNullOrEmpty(lotNo))
                {
                    tb.BackColor = Color.Red;
                    tb.SelectAll();
                    return;
                }
                
                // LotNo -> ALTag Hex 변환 후 LotInfo 조회
                string lotHex = ByteToHex("L" + lotNo + ";;");
                _unitSnaps[idx].LotNoHex = lotHex;
                
                if (!Get_lot_info(lotHex, out _unitSnaps[idx].Map, out _unitSnaps[idx].Order, out _unitSnaps[idx].LotNoValue))
                {
                    tb.BackColor = Color.Red;
                    tb.SelectAll();
                    return;
                }
                
                tb.BackColor = Color.White;
                
                // 해당 Unit Grid 업데이트
                UpdateGrid(_unitTables[idx], lotHex, _unitSnaps[idx].Map, _unitSnaps[idx].Order);
                
                // 비교 갱신 (AL 기준과 비교)
                CompareAndMark();
                
                // 다음 Unit으로 포커스 이동
                if (idx < _unitTextBoxes.Length - 1)
                {
                    _unitTextBoxes[idx + 1].Focus();
                    _unitTextBoxes[idx + 1].SelectAll();
                }
                else
                {
                    tb.Focus();
                    tb.SelectAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb.SelectAll();
            }
        }

        // =========================
        // 비교 로직: 5번째 값 비교
        // =========================
        private void CompareAndMark()
        {
            // 기준(AL)이 없으면 비교 안 함
            if (string.IsNullOrEmpty(_alLotNoValue))
            {
                lblSummary.Text = "AL Tag 기준 LotInfo(5번째 값) 없음";
                return;
            }

            int ok = 0, diff = 0, empty = 0;
            
            for (int i = 0; i < 5; i++)
            {
                var tb = _unitTextBoxes[i];
                string v = _unitSnaps[i].LotNoValue;
                
                if (string.IsNullOrEmpty(v))
                {
                    empty++;
                    // 입력 전이면 기본색
                    if (string.IsNullOrEmpty((tb.Text ?? "").Trim()))
                        tb.BackColor = Color.White;
                    continue;
                }
                
                if (!string.Equals(_alLotNoValue, v, StringComparison.OrdinalIgnoreCase))
                {
                    diff++;
                    tb.BackColor = Color.Red;    // "다른 Unit" 표시
                }
                else
                {
                    ok++;
                    tb.BackColor = Color.White;
                }
            }

            lblSummary.Text = $"BASE(LotNo)={_alLotNoValue} | OK={ok}, DIFF={diff}, EMPTY={empty}";
        }

        // =========================
        // Reset
        // =========================
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetAll();
        }

        private void ResetAll()
        {
            textBoxAlTag.Text = "";
            textBoxAlTag.BackColor = Color.White;
            
            foreach (var tb in _unitTextBoxes)
            {
                tb.Text = "";
                tb.BackColor = Color.White;
            }
            
            _alLotMap.Clear();
            _alLotOrder.Clear();
            _alLotNoValue = "";
            
            for (int i = 0; i < 5; i++)
            {
                _unitSnaps[i].Map.Clear();
                _unitSnaps[i].Order.Clear();
                _unitSnaps[i].LotNoValue = "";
                _unitSnaps[i].LotNoHex = "";
            }
            
            _dtAl.Rows.Clear();
            for (int i = 0; i < 5; i++) _unitTables[i].Rows.Clear();
            
            lblSummary.Text = "RESET";
            
            this.ActiveControl = textBoxAlTag;
            textBoxAlTag.Focus();
        }

        // =========================
        // WebService: ALTagHex -> LotInfo
        // - out lotNoValue = values[4] (5번째 값)
        // =========================
        private bool Get_lot_info(string alTagHex,
            out Dictionary<string, string> map,
            out List<string> order,
            out string lotNoValue)
        {
            map = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            order = new List<string>();
            lotNoValue = string.Empty;
            
            try
            {
                string strServerAllData = string.Empty;
                var url = "http://cim_service.amkor.co.kr:8080/ysj/lot_info/get_lot_info_by_al_tag/" + Uri.EscapeDataString(alTagHex);
                
                var request = WebRequest.Create(url);
                request.Credentials = CredentialCache.DefaultCredentials;
                
                if (request is HttpWebRequest httpReq)
                {
                    httpReq.Timeout = 8000;
                    httpReq.ReadWriteTimeout = 8000;
                }
                
                using (var response = request.GetResponse())
                using (var dataStream = response.GetResponseStream())
                using (var reader = new StreamReader(dataStream, Encoding.UTF8))
                {
                    strServerAllData = reader.ReadToEnd();
                }
                
                var nonEmptyLines = strServerAllData
                    .Split(new[] { "\r\n", "\n" }, StringSplitOptions.None)
                    .Where(l => !string.IsNullOrWhiteSpace(l))
                    .Select(l => l.TrimEnd('\r'))
                    .ToList();
                
                if (nonEmptyLines.Count < 2) return false;
                
                // Fail/ErrorMsg
                if (nonEmptyLines[0].IndexOf("Fail", StringComparison.OrdinalIgnoreCase) >= 0 ||
                    nonEmptyLines[0].IndexOf("ErrorMsg", StringComparison.OrdinalIgnoreCase) >= 0)
                    return false;
                
                var headers = nonEmptyLines[0].Split('\t');
                var values = nonEmptyLines[1].Split('\t');
                
                int count = Math.Min(headers.Length, values.Length);
                for (int i = 0; i < count; i++)
                {
                    string key = (headers[i] ?? "").Trim();
                    string val = (values[i] ?? "").Trim();
                    if (string.IsNullOrEmpty(key)) key = $"Col{i + 1}";
                    map[key] = val;
                    order.Add(key);
                }
                
                // 5번째 배열 값 = values[4] (0-based)
                if (values.Length >= 4) lotNoValue = (values[4] ?? "").Trim();
                
                return true;
            }
            catch
            {
                return false;
            }
        }

        // =========================
        // WebService: UnitID -> LotNo
        // =========================
        private string Get_lot_info_by_unit_id(string strData)
        {
            try
            {
                string strServerAllData = string.Empty;
                var url = "http://cim_service.amkor.co.kr:8080/ysj/ecim/get_lot_info_by_unit_id?unit_id=" + Uri.EscapeDataString(strData);
                
                var request = WebRequest.Create(url);
                request.Credentials = CredentialCache.DefaultCredentials;
                
                if (request is HttpWebRequest httpReq)
                {
                    httpReq.Timeout = 8000;
                    httpReq.ReadWriteTimeout = 8000;
                }
                
                using (var response = request.GetResponse())
                using (var dataStream = response.GetResponseStream())
                using (var reader = new StreamReader(dataStream, Encoding.UTF8))
                {
                    strServerAllData = reader.ReadToEnd();
                }
                
                var lines = strServerAllData.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                if (lines.Length < 2) return string.Empty;
                
                bool hasFail = lines[0].IndexOf("Fail", StringComparison.OrdinalIgnoreCase) >= 0;
                bool hasErrorMsg = lines[0].IndexOf("ErrorMsg", StringComparison.OrdinalIgnoreCase) >= 0;
                
                if (hasFail || hasErrorMsg) return string.Empty;
                
                var sWords = lines[1].Split(',');
                if (sWords.Length < 1) return string.Empty;
                
                // sWords[0] = LotNo
                return (sWords[0] ?? "").Trim();
            }
            catch
            {
                return string.Empty;
            }
        }

        // =========================
        // Grid update
        // =========================
        private void UpdateGrid(DataTable dt, string alTagHex, Dictionary<string, string> map, List<string> order)
        {
            dt.Rows.Clear();
            int no = 1;
            
            // 첫 줄에 AL Tag(hex) 넣으려면 유지
            if (!string.IsNullOrEmpty(alTagHex))
                dt.Rows.Add(no++, "AL Tag (hex)", alTagHex);
            
            foreach (var key in order)
            {
                string val = map.TryGetValue(key, out var v) ? v : "";
                dt.Rows.Add(no++, key, val);
            }
        }

        // =========================
        // Hex util
        // =========================
        private bool LooksLikeHex(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return false;
            s = s.Trim();
            if (s.Length < 2 || (s.Length % 2) != 0) return false;

            for (int i = 0; i < s.Length; i++)
            {
                char c = char.ToUpperInvariant(s[i]);
                bool ok = (c >= '0' && c <= '9') || (c >= 'A' && c <= 'F');
                if (!ok) return false;
            }
            return true;
        }

        private string ByteToHex(string strData)
        {
            var sb = new StringBuilder();
            byte[] bytes = Encoding.UTF8.GetBytes(strData);
            foreach (var b in bytes) sb.Append(b.ToString("X2"));
            return sb.ToString();
        }

        private void btn_2DID_Read_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string strTmp = btn.Text.ToString();
            switch (strTmp)
            {
                case "Read":
                    {
                        Define.seqMode[module] = Define.MODE_PROCESS;
                        Define.seqCtrl[module] = Define.CTRL_RUN;
                        Define.seqSts[module] = Define.STS_IDLE;
                    }
                    break;
            }
        }
    }
}
