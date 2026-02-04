using Keyence.AutoID.SDK;
using System;
using System.IO;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace LM2DBarcodeReader_New
{
    public struct TStep
    {
        public bool Flag;
        public byte Layer;
        public double Times;

        public void INC_TIMES()
        {
            Times++;
            Thread.Sleep(900);
        }        
    }

    public class TBaseThread
    {
        public byte module;
        public string ModuleName;

        public TStep step;
    }    

    class Global
    {
        public static string userdataPath = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, @"..\..\..\UserData.accdb"));
        public static string DeviceDataPath = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, @"..\..\..\DeviceRegist.accdb"));
        public static string logfilePath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, @"..\..\..\EventLog\"));
        public static string RecipeFilePath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, @"..\..\..\Recipes"));
        public static string ConfigurePath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, @"..\..\..\Configure\"));
        public static string serialPortInfoPath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, @"..\..\..\"));
        

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);


        public static TcpClient tcpClient = new TcpClient();
        public static ReaderAccessor m_reader = new ReaderAccessor();

        #region 이벤트로그 파일 폴더 및 파일 생성       
        public static void EventLog(string Msg, string moduleName, string Mode)
        {
            string sYear = string.Format("{0:yyyy}", DateTime.Now).Trim();
            string sMonth = string.Format("{0:MM}", DateTime.Now).Trim();
            string sDay = string.Format("{0:dd}", DateTime.Now).Trim();            
            string sDate = string.Format("{0}-{1}-{2}", sYear, sMonth, sDay);
            string sTime = DateTime.Now.ToString("HH:mm:ss");
            string sDateTime;            
            sDateTime = string.Format("[{0}, {1}] ", sDate, sTime);
            
            WriteFile(string.Format("{0}{1}", sDateTime, Msg), moduleName, Mode);

            if (Mode == "Event")
            {
                if (moduleName == "PM1")
                {
                    Define.bPM1Event = true;
                }                               
            }
            else if (Mode == "Alarm")
            {
                if (moduleName == "PM1")
                {
                    //
                }                
            }            
        }

        private static void WriteFile(string Msg, string moduleName, string Mode)
        {            
            string sYear = string.Format("{0:yyyy}", DateTime.Now).Trim();
            string sMonth = string.Format("{0:MM}", DateTime.Now).Trim();
            string sDay = string.Format("{0:dd}", DateTime.Now).Trim();            
            string FileName = string.Format("{0}.txt", sDay);
            string sPath = string.Empty;
            if (Mode == "Event")
            {
                sPath = logfilePath;
            }                            

            try
            {                
                if (!Directory.Exists(string.Format("{0}{1}\\{2}", sPath, moduleName, sYear)))
                {
                    CreateYearFolder(string.Format("{0}{1}", sPath, moduleName));
                }
                
                if (!Directory.Exists(string.Format("{0}{1}\\{2}\\{3}", sPath, moduleName, sYear, sMonth)))
                {
                    CreateMonthFolder(string.Format("{0}{1}", sPath, moduleName));
                }
                
                if (File.Exists(string.Format("{0}{1}\\{2}\\{3}\\{4}", sPath, moduleName, sYear, sMonth, FileName)))
                {
                    StreamWriter writer;                    
                    writer = File.AppendText(string.Format("{0}{1}\\{2}\\{3}\\{4}", sPath, moduleName, sYear, sMonth, FileName));
                    writer.WriteLine(Msg);
                    writer.Close();
                }
                else
                {                    
                    CreateFile(string.Format("{0}{1}", sPath, moduleName), Msg);

                    StreamWriter writer;                    
                    writer = File.AppendText(string.Format("{0}{1}\\{2}\\{3}\\{4}", sPath, moduleName, sYear, sMonth, FileName));
                    writer.WriteLine(Msg);
                    writer.Close();
                }
            }
            catch (IOException)
            {
                
            }
        }

        private static void CreateYearFolder(string Path)
        {
            string sYear = string.Format("{0:yyyy}", DateTime.Now).Trim();
            string FolderName = sYear;
            
            Directory.CreateDirectory(string.Format("{0}\\{1}", Path, FolderName));
        }

        private static void CreateMonthFolder(string Path)
        {
            string sYear = string.Format("{0:yyyy}", DateTime.Now).Trim();
            string sMonth = string.Format("{0:MM}", DateTime.Now).Trim();
            string FolderName = sMonth;
            
            Directory.CreateDirectory(string.Format("{0}\\{1}\\{2}", Path, sYear, FolderName));
        }

        private static void CreateFile(string Path, string Msg)
        {            
            string sYear = string.Format("{0:yyyy}", DateTime.Now).Trim();
            string sMonth = string.Format("{0:MM}", DateTime.Now).Trim();
            string sDay = string.Format("{0:dd}", DateTime.Now).Trim();            
            string FileName = string.Format("{0}.txt", sDay);
            
            if (!File.Exists(string.Format("{0}\\{1}\\{2}\\{3}", Path, sYear, sMonth, FileName)))
            {
                using (File.Create(string.Format("{0}\\{1}\\{2}\\{3}", Path, sYear, sMonth, FileName))) ;
            }
        }
        #endregion        

        public static void Init()
        {
            //
        }

        public static bool DEVICE_LOAD()
        {            
            try
            {
                // Ini file read
                StringBuilder sbAddress = new StringBuilder();
                StringBuilder sbPort = new StringBuilder();

                GetPrivateProfileString("DeviceSetting", "Address", "", sbAddress, sbAddress.Capacity, string.Format("{0}{1}", serialPortInfoPath, "DeviceSetting.ini"));
                GetPrivateProfileString("DeviceSetting", "Port", "", sbPort, sbPort.Capacity, string.Format("{0}{1}", serialPortInfoPath, "DeviceSetting.ini"));

                Define.sIPAddress = sbAddress.ToString().Trim();
                Define.sPortNum = Convert.ToInt16(sbPort.ToString().Trim());

                //tcpClient.BeginConnect(Define.sIPAddress, Define.sPortNum, null, null);                                
                m_reader.IpAddress = Define.sIPAddress;
                bool bConn = m_reader.Connect();
                return bConn;
            }
            catch (Exception)
            {
                return false;
            }
        }        

        public static void _Init_Connect()
        {
            try
            {
                tcpClient = new TcpClient();
                tcpClient.BeginConnect(Define.sIPAddress, Define.sPortNum, null, null);
            }
            catch (Exception)
            {

            }
        }

        public static bool _IsCheckNetwork()
        {
            bool networkState = NetworkInterface.GetIsNetworkAvailable();
            bool pingResult = true;

            // 네트워크 연결이 되어있다면
            if (networkState)
            {
                string sAddr = Define.sIPAddress;
                Ping pingSender = new Ping();

                // Ping체크 (IP, TimeOut 지정)
                PingReply reply = pingSender.Send(sAddr, 100);

                // 상태가 Success이면 true반환
                pingResult = reply.Status == IPStatus.Success;

            }

            return networkState & pingResult;
        }
    }
}
