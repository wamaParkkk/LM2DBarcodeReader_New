using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Input;

namespace LM2DBarcodeReader_New
{
    public partial class MainForm : Form
    {        
        MaintnanceForm m_maintnanceForm;     
        ConfigureForm m_configureForm;                
        EventLogForm m_eventLogForm;        

        Squence.BarcodeRead barcodeRead;

        bool isKeyRunning = true;

        [DllImport("user32.dll")] private static extern int RegisterHotKey(IntPtr hwnd, int id, int fsModifiers, int vk);
        [DllImport("user32.dll")] private static extern int UnregisterHotKey(IntPtr hwnd, int id);

        public const int WM_HOTKEY = 0x0312;
        bool mb_show = true;

        public MainForm()
        {
            InitializeComponent();

            this.Load += TrayIcon_Load;
            
            Tray_Icon.MouseDoubleClick += Tray_Icon_MouseDoubleClick;
            showToolStripMenuItem.Click += showToolStripMenuItem_Click;
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;

            RegisterHotKey(this.Handle, 26000, 0, 0x13);


            SubFormCreate();

            Global.Init();

            CreateThread();
        }        

        private void MainForm_Load(object sender, EventArgs e)
        {
            Width = 1280;
            Height = 1024;
            Top = 0;
            Left = 0;

            Define.bLogin = false;
            Define.bMainActivate = false;            

            
            MyNativeWindows myNativeWindows = new MyNativeWindows();
            for (int i = 0; i < this.Controls.Count; i++)
            {
                MdiClient mdiClient = this.Controls[i] as MdiClient;
                if (mdiClient != null)
                {
                    myNativeWindows.ReleaseHandle();
                    myNativeWindows.AssignHandle(mdiClient.Handle);
                }
            }            
            
            timerDisplay.Enabled = true;
            
            SubFormShow((byte)Page.MaintnancePage);

            F_ButtonVisible(true, true, true);

            // 키 입력 감지 Thread
            Thread thread_Keyboard = new Thread(_input_Keyboard);
            thread_Keyboard.SetApartmentState(ApartmentState.STA);
            CheckForIllegalCrossThreadCalls = false;
            thread_Keyboard.Start();
        }

        public class MyNativeWindows : NativeWindow
        {
            public MyNativeWindows()
            {
            }

            private const int WM_NCCALCSIZE = 0x0083;
            private const int SB_BOTH = 3;            

            [DllImport("user32.dll")]
            private static extern int ShowScrollBar(IntPtr hWnd, int wBar, int bShow);
            
            protected override void WndProc(ref Message m)
            {
                switch (m.Msg)
                {
                    case WM_NCCALCSIZE:
                        ShowScrollBar(m.HWnd, SB_BOTH, 0);
                        break;
                }
                base.WndProc(ref m);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerDisplay.Enabled = false;            

            FreeThread();

            Global.m_reader.Dispose();

            Dispose();
        }

        private void SubFormCreate()
        {                        
            m_maintnanceForm = new MaintnanceForm();
            m_maintnanceForm.MdiParent = this;
            m_maintnanceForm.Dock = DockStyle.Fill;
            m_maintnanceForm.Show();
            
            m_configureForm = new ConfigureForm();
            m_configureForm.MdiParent = this;
            m_configureForm.Dock = DockStyle.Fill;
            m_configureForm.Show();                        

            m_eventLogForm = new EventLogForm();
            m_eventLogForm.MdiParent = this;
            m_eventLogForm.Dock = DockStyle.Fill;
            m_eventLogForm.Show();
        }

        private void CreateThread()
        {
            barcodeRead = new Squence.BarcodeRead();
        }

        private void FreeThread()
        {
            barcodeRead.Dispose();
        }

        public void SubFormShow(byte PageNum)
        {
            try
            {
                Define.currentPage = PageNum;
                byte iPage = PageNum;

                switch (iPage)
                {                    
                    case (byte)Page.MaintnancePage:
                        {
                            m_maintnanceForm.Activate();
                            m_maintnanceForm.BringToFront();                            
                        }
                        break;                    

                    case (byte)Page.ConfigurePage:
                        {
                            m_configureForm.Activate();
                            m_configureForm.BringToFront();
                        }
                        break;                                        

                    case (byte)Page.EventLogPage:
                        {
                            m_eventLogForm.Activate();
                            m_eventLogForm.BringToFront();
                        }
                        break;                    
                }
            }
            catch
            {
                MessageBox.Show("폼 양식을 가져오는 도중 오류가 발생했습니다.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void F_ButtonVisible(bool bMaintBtn, bool bConfigureBtn, bool bEventLogBtn)
        {            
            pictureBoxMain.Enabled = bMaintBtn;
            btnMaintnance.Enabled = bMaintBtn;

            pictureBoxConfigure.Enabled = bConfigureBtn;
            btnConfigure.Enabled = bConfigureBtn;

            pictureBoxEventLog.Enabled = bEventLogBtn;
            btnEventLog.Enabled = bEventLogBtn;
        }                        

        private void btnMain_Click(object sender, EventArgs e)
        {
            SubFormShow((byte)Page.MaintnancePage);
        }

        private void btnLotValidation_Click(object sender, EventArgs e)
        {
            new LotValidationForm().ShowDialog();
        }

        private void btnConfigure_Click(object sender, EventArgs e)
        {
            SubFormShow((byte)Page.ConfigurePage);
        }

        private void btnEventLog_Click(object sender, EventArgs e)
        {
            SubFormShow((byte)Page.EventLogPage);
        }

        private void btnGuide_Click(object sender, EventArgs e)
        {
            String openPDFFile = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, @"..\..\..\..\Document\Manual.pdf"));
            File.WriteAllBytes(openPDFFile, Properties.Resources.Manual);
            System.Diagnostics.Process.Start(openPDFFile);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("프로그램을 종료 하겠습니까?", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                isKeyRunning = false;

                Global.m_reader.Dispose();

                Dispose();
                //Application.Exit();
                Application.ExitThread();
                Environment.Exit(0);
            }
        }            

        private void timerDisplay_Tick(object sender, EventArgs e)
        {
            Display();
        }

        private void Display()
        {
            laDate.Text = System.DateTime.Today.ToShortDateString();
            laTime.Text = System.DateTime.Now.ToLongTimeString();
            //laUserLevel.Text = "Level : " + Define.UserLevel;

            if (Define.currentPage == (byte)Page.MaintnancePage)
            {
                labelPageName.Text = "Process";
                if (Define.bMainActivate)
                {
                    m_maintnanceForm.Activate();
                    m_maintnanceForm.BringToFront();

                    Define.bMainActivate = false;
                }                           
            }            
            else if (Define.currentPage == (byte)Page.ConfigurePage)
            {
                labelPageName.Text = "Configure";
            }                        
            else if (Define.currentPage == (byte)Page.EventLogPage)
            {
                labelPageName.Text = "Event Log";
            }            
            

            // User level에 따른 버튼 활성화
            if (Define.UserLevel == "Master")
            {
                // maint, configure, eventlog                
                F_ButtonVisible(true, true, true);
            }
            else if (Define.UserLevel == "Maintnance")
            {                
                F_ButtonVisible(true, true, true);
            }
            else if (Define.UserLevel == "User")
            {                
                F_ButtonVisible(true, false, true);
            }            
        }

        private void _input_Keyboard()
        {
            while (isKeyRunning)
            {
                Thread.Sleep(40);
                /*
                if ((Keyboard.GetKeyStates(Key.Pause) & KeyStates.Down) > 0)
                {
                    _show_FormWindow();
                }
                */
                if ((Keyboard.GetKeyStates(Key.Scroll) & KeyStates.Down) > 0)
                {
                    Define.seqMode[(int)MODULE._PM1] = Define.MODE_PROCESS;
                    Define.seqCtrl[(int)MODULE._PM1] = Define.CTRL_RUN;
                    Define.seqSts[(int)MODULE._PM1] = Define.STS_IDLE;                    
                }                
            }
        }

        protected override void WndProc(ref Message message)
        {
            switch (message.Msg)
            {
                case WM_HOTKEY:
                    if (message.WParam.ToInt64() == 26000)
                    {
                        
                        if (mb_show)
                        {
                            Hide();
                            mb_show = false;
                        }
                        else
                        {
                            _show_FormWindow();                            
                            mb_show = true;
                        }                        
                    }
                    break;
            }
            base.WndProc(ref message);
        }

        #region Tray_Icon
        public void TrayIcon_Load(object sender, EventArgs e)
        {
            Tray_Icon.ContextMenuStrip = context_TrayIcon;
        }

        private void Tray_Icon_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            _show_FormWindow();
        }
        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _show_FormWindow();
        }

        private void _show_FormWindow()
        {
            this.ShowInTaskbar = true;
            this.Visible = true;
            this.WindowState = FormWindowState.Normal; 
            
            Focus();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("프로그램을 종료 하겠습니까?", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                isKeyRunning = false;

                Global.m_reader.Dispose();

                Dispose();
                //Application.Exit();
                Application.ExitThread();
                Environment.Exit(0);
            }
        }
        #endregion
       
    }
}
