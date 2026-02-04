using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;

namespace LM2DBarcodeReader_New.Squence
{
    class BarcodeRead : TBaseThread
    {
        Thread thread;

        private new TStep step;
        string sRecvData;

        // e-SIM server data Parsing시, 사용 할 변수.
        string strServerAllData;        

        public BarcodeRead()
        {
            ModuleName = "PM1";
            module = (byte)MODULE._PM1;

            thread = new Thread(new ThreadStart(Execute));            
            thread.Start();
        }

        public void Dispose()
        {
            thread.Abort();
        }

        private void Execute()
        {
            try
            {
                while (true)
                {                    
                    Process_Progress();                    

                    Thread.Sleep(100);
                }
            }
            catch (Exception)
            {

            }
        }

        private void AlarmAction(string sAction)
        {
            if (sAction == "Abort")
            {                
                Define.seqMode[module] = Define.MODE_IDLE;
                Define.seqCtrl[module] = Define.CTRL_IDLE;
                Define.seqSts[module] = Define.STS_ABORTOK;                               

                Global.EventLog("Stopped reading barcode : " + sAction, ModuleName, "Event");
            }
        }        

        // PROCESS PROGRESS /////////////////////////////////////////////////////////////////
        #region PROCESS_PROGRESS
        private void Process_Progress()
        {
            if ((Define.seqMode[module] == Define.MODE_PROCESS) && (Define.seqCtrl[module] == Define.CTRL_RUN))
            {
                Thread.Sleep(500);
                step.Layer = 1;
                step.Times = 1;
                step.Flag = true;

                sRecvData = string.Empty;                
                strServerAllData = string.Empty;

                Define.sUnit_ID = string.Empty;                

                // Lot 정보 초기화
                Define.sLot_No = string.Empty;
                Define.sDCC = string.Empty;
                Define.sOperation_Code = string.Empty;
                Define.sStrip_Mark = string.Empty;
                Define.sPDL = string.Empty;
                Define.sTarget_Device = string.Empty;

                Define.sLot_No2 = string.Empty;
                Define.sDCC2 = string.Empty;
                Define.sOperation_Code2 = string.Empty;
                Define.sStrip_Mark2 = string.Empty;
                Define.sPDL2 = string.Empty;
                Define.sTarget_Device2 = string.Empty;


                Define.seqCtrl[module] = Define.CTRL_RUNNING;
                Define.seqSts[module] = Define.STS_PROCESS_ING;

                Global.EventLog("START READING BARCODE", ModuleName, "Event");                
            }
            else if ((Define.seqMode[module] == Define.MODE_PROCESS) && (Define.seqCtrl[module] == Define.CTRL_RUNNING))
            {                
                switch (step.Layer)
                {
                    case 1:
                        {
                            P_PROCESS_BarcodeRead(10);
                        }
                        break;

                    case 2:
                        {
                            P_PROCESS_InfoParsing(sRecvData);
                        }
                        break;
                                                                                
                    case 3:
                        {
                            step.Flag = true;
                            step.Layer++;
                        }
                        break;
                    
                    case 4:
                        {
                            P_PROCESS_End();
                        }
                        break;

                    case 10:
                        {
                            P_PROCESS_AbnormalEnd();
                        }
                        break;
                }
            }
        }
        #endregion
        /////////////////////////////////////////////////////////////////////////////////////
        ///
        // FUNCTION /////////////////////////////////////////////////////////////////////////
        #region PROCESS FUNCTION
        private void P_PROCESS_BarcodeRead(byte nStep)
        {
            if (step.Flag)
            {
                sRecvData = Global.m_reader.ExecCommand("LON");
                Global.EventLog("Reader command : LON", ModuleName, "Event");

                Define.sUnit_ID = sRecvData;
                Global.EventLog(string.Format("Data : {0}", Define.sUnit_ID), ModuleName, "Event");       
                
                step.Flag = false;
                step.Times = 1;
            }
            else
            {
                if ((sRecvData != "") && (sRecvData != string.Empty))
                {
                    step.Flag = true;
                    step.Layer++;
                }
                else
                {
                    if (step.Times >= Configure_List.iTimeout1)
                    {
                        Global.EventLog(string.Format("Barcode read time out : {0} sec..", Configure_List.iTimeout1.ToString()), ModuleName, "Event");

                        Global.m_reader.ExecCommand("LOFF");

                        step.Flag = true;
                        step.Layer = nStep;
                    }
                    else
                    {
                        sRecvData = Global.m_reader.ExecCommand("LON");                        

                        Define.sUnit_ID = sRecvData;
                        Global.EventLog(string.Format("Data : {0}", Define.sUnit_ID), ModuleName, "Event");

                        
                        step.INC_TIMES();
                    }
                }
            }
        }

        private void P_PROCESS_InfoParsing(string strData)
        {
            try
            {
                if (step.Flag)
                {
                    // Create a request for the URL.
                    // Lot info parameter (Unit ID)
                    WebRequest request = WebRequest.Create("http://cim_service.amkor.co.kr:8080/ysj/ecim/get_lot_info_by_unit_id?unit_id=" + strData);

                    // If required by the server, set the credentials.
                    request.Credentials = CredentialCache.DefaultCredentials;

                    // Get the response.
                    WebResponse response = request.GetResponse();

                    // Get the stream containing content returned by the server.
                    // The using block ensures the stream is automatically closed.
                    using (Stream dataStream = response.GetResponseStream())
                    {
                        // Open the stream using a StreamReader for easy access.
                        StreamReader reader = new StreamReader(dataStream);
                        // Read the content.
                        string responseFromServer = reader.ReadToEnd();
                        // Display the content.
                        strServerAllData = responseFromServer;
                    }

                    // Close the response.
                    response.Close();
                    
                    string[] lines = strServerAllData.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                    bool bStr = lines[0].Contains("Fail");
                    bool bStr1 = lines[0].Contains("ErrorMsg");
                    if ((bStr) || (bStr1))
                    {
                        AlarmAction("Abort");
                        return;
                    }

                    /*
                    foreach (var items in lines)
                    {
                        sWords = items.Split(',');                        
                    }
                    */

                    string[] sWords = null;
                    string strTmp = lines[1];
                    for (int i = 0; i <= strTmp.Length; i ++)
                    {
                        sWords = strTmp.Split(',');
                    }

                    Define.sLot_No = sWords[0];
                    Define.sDCC = sWords[1];
                    Define.sOperation_Code = sWords[2];
                    Define.sStrip_Mark = sWords[3];
                    Define.sPDL = sWords[4];
                    Define.sTarget_Device = sWords[5];

                    sWords = null;
                    strTmp = string.Empty;
                    strTmp = lines[2];
                    for (int i = 0; i <= strTmp.Length; i++)
                    {
                        sWords = strTmp.Split(',');
                    }

                    Define.sLot_No2 = sWords[0];
                    Define.sDCC2 = sWords[1];
                    Define.sOperation_Code2 = sWords[2];
                    Define.sStrip_Mark2 = sWords[3];
                    Define.sPDL2 = sWords[4];
                    Define.sTarget_Device2 = sWords[5];


                    step.Flag = false;
                    step.Times = 1;
                }
                else
                {
                    Global.EventLog(string.Format("Lot_No : {0}\nDCC : {1}\nOperation_Code : {2}\nStrip_Mark : {3}\nPDL : {4}\nTarget_Device : {5}",
                        Define.sLot_No, Define.sDCC, Define.sOperation_Code, Define.sStrip_Mark, Define.sPDL, Define.sTarget_Device), ModuleName, "Event");

                    Global.EventLog(string.Format("Lot_No2 : {0}\nDCC2 : {1}\nOperation_Code2 : {2}\nStrip_Mark2 : {3}\nPDL2 : {4}\nTarget_Device2 : {5}",
                        Define.sLot_No2, Define.sDCC2, Define.sOperation_Code2, Define.sStrip_Mark2, Define.sPDL2, Define.sTarget_Device2), ModuleName, "Event");


                    step.Flag = true;
                    step.Layer++;
                }
            }
            catch
            {
                AlarmAction("Abort");
                return;
            }            
        }


        private void P_PROCESS_End()
        {            
            Define.seqMode[module] = Define.MODE_IDLE;
            Define.seqCtrl[module] = Define.CTRL_IDLE;
            Define.seqSts[module] = Define.STS_PROCESS_END;
            
            Global.EventLog("COMPLETE BARCODE READING", ModuleName, "Event");            
        }

        private void P_PROCESS_AbnormalEnd()
        {
            Define.seqMode[module] = Define.MODE_IDLE;
            Define.seqCtrl[module] = Define.CTRL_IDLE;
            Define.seqSts[module] = Define.STS_PROCESS_END;            
        }
        #endregion
        /////////////////////////////////////////////////////////////////////////////////////
    }
}
