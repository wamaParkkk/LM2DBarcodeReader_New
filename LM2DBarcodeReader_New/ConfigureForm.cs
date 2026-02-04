using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace LM2DBarcodeReader_New
{
    public partial class ConfigureForm : Form
    {
        AnalogDlg AnaDlg;

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        public ConfigureForm()
        {            
            InitializeComponent();
        }

        private void ConfigureForm_Load(object sender, EventArgs e)
        {
            Width = 1172;
            Height = 824;
            Top = 0;
            Left = 0;

            PARAMETER_LOAD();            
        }

        private void ConfigureForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }

        private void PARAMETER_LOAD()
        {
            try
            {
                // Ini file read
                StringBuilder sbTimeout1 = new StringBuilder();

                GetPrivateProfileString("Parameter", "Timeout1", "", sbTimeout1, sbTimeout1.Capacity, string.Format("{0}{1}", Global.ConfigurePath, "Configure.ini"));

                Configure_List.iTimeout1 = Convert.ToDouble(sbTimeout1.ToString().Trim());
                txtBoxConfigItem1.Text = (Configure_List.iTimeout1).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }        

        private void txtBoxDoorOpenCloseTimeout_Click(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            AnaDlg = new AnalogDlg();            
            if (AnaDlg.ShowDialog() == DialogResult.OK)
            {
                textBox.Text = AnaDlg.m_strResult.ToString();
                
                bool bChk = double.TryParse(textBox.Text.ToString(), out double dVal);
                if (!bChk)
                {
                    MessageBox.Show("잘못된 값이 입력되었습니다", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox.Text = "0";
                }                
            }
        }

        private void btnParameterSave_Click(object sender, EventArgs e)
        {
            try
            {
                WritePrivateProfileString("Parameter", "Timeout1", txtBoxConfigItem1.Text, string.Format("{0}{1}", Global.ConfigurePath, "Configure.ini"));

                PARAMETER_LOAD();

                MessageBox.Show("Configure 값이 저장 되었습니다.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }          
        }            
    }
}
