using Keyence.AutoID.SDK;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace LM2DBarcodeReader_New
{
    public partial class PM1Form : UserControl
    {
        AnalogDlg AnaDlg;        

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        private MaintnanceForm m_Parent;               

        int module;
        string ModuleName;                        

        public PM1Form(MaintnanceForm parent)
        {
            InitializeComponent();

            m_Parent = parent;            

            module = (int)MODULE._PM1;
            ModuleName = "PM1";            
        }

        private void PM1Form_Load(object sender, EventArgs e)
        {
            Width = 1172;
            Height = 824;
            Top = 0;
            Left = 0;

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

        public void Display()
        {
            try
            {
                textBox_UnitID.Text = Define.sUnit_ID;

                textBox_LotNo.Text = Define.sLot_No;
                textBox_DCC.Text = Define.sDCC;
                textBox_OperationCode.Text = Define.sOperation_Code;
                textBox_StripMark.Text = Define.sStrip_Mark;
                textBox_PDL.Text = Define.sPDL;
                textBox_TargetDevice.Text = Define.sTarget_Device;

                textBox_LotNo2.Text = Define.sLot_No2;
                textBox_DCC2.Text = Define.sDCC2;
                textBox_OperationCode2.Text = Define.sOperation_Code2;
                textBox_StripMark2.Text = Define.sStrip_Mark2;
                textBox_PDL2.Text = Define.sPDL2;
                textBox_TargetDevice2.Text = Define.sTarget_Device2;

                if (Define.bPM1Event)
                {
                    Eventlog_File_Read();
                }                
            }
            catch (Exception) 
            {
                
            }            
        }        

        private void Eventlog_File_Read()
        {
            Define.bPM1Event = false;

            try
            {
                string sTmpData;

                string sYear = string.Format("{0:yyyy}", DateTime.Now).Trim();
                string sMonth = string.Format("{0:MM}", DateTime.Now).Trim();
                string sDay = string.Format("{0:dd}", DateTime.Now).Trim();
                string FileName = string.Format("{0}.txt", sDay);

                if (File.Exists(string.Format("{0}{1}\\{2}\\{3}\\{4}", Global.logfilePath, ModuleName, sYear, sMonth, FileName)))
                {
                    byte[] bytes;
                    using (var fs = File.Open(string.Format("{0}{1}\\{2}\\{3}\\{4}", Global.logfilePath, ModuleName, sYear, sMonth, FileName), FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    {
                        try
                        {
                            bytes = new byte[fs.Length];
                            fs.Read(bytes, 0, (int)fs.Length);
                            sTmpData = Encoding.Default.GetString(bytes);                                                        

                            string[] data = sTmpData.Split('\n');
                            int iLength = data.Length;
                            if (iLength >= 2)
                            {
                                string sVal = data[iLength - 2].ToString();

                                Invoke((Action)(() =>
                                {
                                    listBoxEventLog.Update();

                                    if (listBoxEventLog.Items.Count >= 10)
                                        listBoxEventLog.Items.Clear();

                                    listBoxEventLog.Items.Add(sVal);
                                    listBoxEventLog.SelectedIndex = listBoxEventLog.Items.Count - 1;                                    
                                }));
                            }
                        }
                        catch (ArgumentException)
                        {

                        }
                    }
                }
            }
            catch (IOException)
            {

            }
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
