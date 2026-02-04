
namespace LM2DBarcodeReader_New
{
    partial class PM1Form
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxEventLog = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_2DID_Read = new System.Windows.Forms.Button();
            this.textBox_LotNo = new System.Windows.Forms.TextBox();
            this.textBox_DCC = new System.Windows.Forms.TextBox();
            this.textBox_OperationCode = new System.Windows.Forms.TextBox();
            this.liveviewForm1 = new Keyence.AutoID.SDK.LiveviewForm();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_StripMark = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_PDL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_TargetDevice = new System.Windows.Forms.TextBox();
            this.textBox_UnitID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_TargetDevice2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_PDL2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_StripMark2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_OperationCode2 = new System.Windows.Forms.TextBox();
            this.textBox_DCC2 = new System.Windows.Forms.TextBox();
            this.textBox_LotNo2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxEventLog
            // 
            this.listBoxEventLog.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxEventLog.ForeColor = System.Drawing.Color.Black;
            this.listBoxEventLog.FormattingEnabled = true;
            this.listBoxEventLog.ItemHeight = 17;
            this.listBoxEventLog.Location = new System.Drawing.Point(3, 732);
            this.listBoxEventLog.Name = "listBoxEventLog";
            this.listBoxEventLog.Size = new System.Drawing.Size(1156, 89);
            this.listBoxEventLog.TabIndex = 504;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(611, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 33);
            this.label1.TabIndex = 517;
            this.label1.Text = "Lot no";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_2DID_Read
            // 
            this.btn_2DID_Read.BackColor = System.Drawing.Color.White;
            this.btn_2DID_Read.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_2DID_Read.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2DID_Read.ForeColor = System.Drawing.Color.Navy;
            this.btn_2DID_Read.Location = new System.Drawing.Point(4, 609);
            this.btn_2DID_Read.Name = "btn_2DID_Read";
            this.btn_2DID_Read.Size = new System.Drawing.Size(600, 80);
            this.btn_2DID_Read.TabIndex = 535;
            this.btn_2DID_Read.Tag = "0";
            this.btn_2DID_Read.Text = "Read";
            this.btn_2DID_Read.UseVisualStyleBackColor = false;
            this.btn_2DID_Read.Click += new System.EventHandler(this.btn_2DID_Read_Click);
            // 
            // textBox_LotNo
            // 
            this.textBox_LotNo.BackColor = System.Drawing.Color.Black;
            this.textBox_LotNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_LotNo.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_LotNo.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_LotNo.Location = new System.Drawing.Point(782, 85);
            this.textBox_LotNo.Name = "textBox_LotNo";
            this.textBox_LotNo.ReadOnly = true;
            this.textBox_LotNo.Size = new System.Drawing.Size(377, 33);
            this.textBox_LotNo.TabIndex = 534;
            this.textBox_LotNo.Tag = "0";
            this.textBox_LotNo.Text = "--";
            this.textBox_LotNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_DCC
            // 
            this.textBox_DCC.BackColor = System.Drawing.Color.Black;
            this.textBox_DCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_DCC.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_DCC.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_DCC.Location = new System.Drawing.Point(782, 124);
            this.textBox_DCC.Name = "textBox_DCC";
            this.textBox_DCC.ReadOnly = true;
            this.textBox_DCC.Size = new System.Drawing.Size(377, 33);
            this.textBox_DCC.TabIndex = 537;
            this.textBox_DCC.Tag = "1";
            this.textBox_DCC.Text = "--";
            this.textBox_DCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_OperationCode
            // 
            this.textBox_OperationCode.BackColor = System.Drawing.Color.Black;
            this.textBox_OperationCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_OperationCode.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_OperationCode.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_OperationCode.Location = new System.Drawing.Point(782, 163);
            this.textBox_OperationCode.Name = "textBox_OperationCode";
            this.textBox_OperationCode.ReadOnly = true;
            this.textBox_OperationCode.Size = new System.Drawing.Size(377, 33);
            this.textBox_OperationCode.TabIndex = 540;
            this.textBox_OperationCode.Tag = "2";
            this.textBox_OperationCode.Text = "--";
            this.textBox_OperationCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // liveviewForm1
            // 
            this.liveviewForm1.BackColor = System.Drawing.Color.Black;
            this.liveviewForm1.BinningType = Keyence.AutoID.SDK.LiveviewForm.ImageBinningType.OneQuarter;
            this.liveviewForm1.ImageFormat = Keyence.AutoID.SDK.LiveviewForm.ImageFormatType.Jpeg;
            this.liveviewForm1.ImageQuality = 5;
            this.liveviewForm1.IpAddress = "192.168.100.100";
            this.liveviewForm1.Location = new System.Drawing.Point(4, 3);
            this.liveviewForm1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.liveviewForm1.Name = "liveviewForm1";
            this.liveviewForm1.PullTimeSpan = 100;
            this.liveviewForm1.Size = new System.Drawing.Size(600, 600);
            this.liveviewForm1.TabIndex = 541;
            this.liveviewForm1.TimeoutMs = 2000;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(611, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 33);
            this.label2.TabIndex = 542;
            this.label2.Text = "DCC";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(611, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 33);
            this.label3.TabIndex = 543;
            this.label3.Text = "Operation code";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(611, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 33);
            this.label4.TabIndex = 545;
            this.label4.Text = "Strip mark";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_StripMark
            // 
            this.textBox_StripMark.BackColor = System.Drawing.Color.Black;
            this.textBox_StripMark.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_StripMark.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_StripMark.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_StripMark.Location = new System.Drawing.Point(782, 202);
            this.textBox_StripMark.Name = "textBox_StripMark";
            this.textBox_StripMark.ReadOnly = true;
            this.textBox_StripMark.Size = new System.Drawing.Size(377, 33);
            this.textBox_StripMark.TabIndex = 544;
            this.textBox_StripMark.Tag = "2";
            this.textBox_StripMark.Text = "--";
            this.textBox_StripMark.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(611, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 33);
            this.label5.TabIndex = 547;
            this.label5.Text = "PDL";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_PDL
            // 
            this.textBox_PDL.BackColor = System.Drawing.Color.Black;
            this.textBox_PDL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_PDL.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PDL.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_PDL.Location = new System.Drawing.Point(782, 241);
            this.textBox_PDL.Name = "textBox_PDL";
            this.textBox_PDL.ReadOnly = true;
            this.textBox_PDL.Size = new System.Drawing.Size(377, 33);
            this.textBox_PDL.TabIndex = 546;
            this.textBox_PDL.Tag = "2";
            this.textBox_PDL.Text = "--";
            this.textBox_PDL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(611, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 33);
            this.label6.TabIndex = 549;
            this.label6.Text = "Target device";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_TargetDevice
            // 
            this.textBox_TargetDevice.BackColor = System.Drawing.Color.Black;
            this.textBox_TargetDevice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_TargetDevice.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TargetDevice.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_TargetDevice.Location = new System.Drawing.Point(782, 280);
            this.textBox_TargetDevice.Name = "textBox_TargetDevice";
            this.textBox_TargetDevice.ReadOnly = true;
            this.textBox_TargetDevice.Size = new System.Drawing.Size(377, 33);
            this.textBox_TargetDevice.TabIndex = 548;
            this.textBox_TargetDevice.Tag = "2";
            this.textBox_TargetDevice.Text = "--";
            this.textBox_TargetDevice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_UnitID
            // 
            this.textBox_UnitID.BackColor = System.Drawing.Color.MidnightBlue;
            this.textBox_UnitID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_UnitID.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_UnitID.ForeColor = System.Drawing.Color.White;
            this.textBox_UnitID.Location = new System.Drawing.Point(782, 25);
            this.textBox_UnitID.Name = "textBox_UnitID";
            this.textBox_UnitID.ReadOnly = true;
            this.textBox_UnitID.Size = new System.Drawing.Size(377, 33);
            this.textBox_UnitID.TabIndex = 551;
            this.textBox_UnitID.Tag = "0";
            this.textBox_UnitID.Text = "--";
            this.textBox_UnitID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.OrangeRed;
            this.label7.Location = new System.Drawing.Point(611, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 33);
            this.label7.TabIndex = 550;
            this.label7.Text = "Unit ID";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Indigo;
            this.label8.Location = new System.Drawing.Point(611, 570);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 33);
            this.label8.TabIndex = 563;
            this.label8.Text = "Target device#2";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_TargetDevice2
            // 
            this.textBox_TargetDevice2.BackColor = System.Drawing.Color.Black;
            this.textBox_TargetDevice2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_TargetDevice2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TargetDevice2.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_TargetDevice2.Location = new System.Drawing.Point(782, 570);
            this.textBox_TargetDevice2.Name = "textBox_TargetDevice2";
            this.textBox_TargetDevice2.ReadOnly = true;
            this.textBox_TargetDevice2.Size = new System.Drawing.Size(377, 33);
            this.textBox_TargetDevice2.TabIndex = 562;
            this.textBox_TargetDevice2.Tag = "2";
            this.textBox_TargetDevice2.Text = "--";
            this.textBox_TargetDevice2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Indigo;
            this.label9.Location = new System.Drawing.Point(611, 531);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 33);
            this.label9.TabIndex = 561;
            this.label9.Text = "PDL#2";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_PDL2
            // 
            this.textBox_PDL2.BackColor = System.Drawing.Color.Black;
            this.textBox_PDL2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_PDL2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PDL2.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_PDL2.Location = new System.Drawing.Point(782, 531);
            this.textBox_PDL2.Name = "textBox_PDL2";
            this.textBox_PDL2.ReadOnly = true;
            this.textBox_PDL2.Size = new System.Drawing.Size(377, 33);
            this.textBox_PDL2.TabIndex = 560;
            this.textBox_PDL2.Tag = "2";
            this.textBox_PDL2.Text = "--";
            this.textBox_PDL2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Indigo;
            this.label10.Location = new System.Drawing.Point(611, 492);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 33);
            this.label10.TabIndex = 559;
            this.label10.Text = "Strip mark#2";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_StripMark2
            // 
            this.textBox_StripMark2.BackColor = System.Drawing.Color.Black;
            this.textBox_StripMark2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_StripMark2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_StripMark2.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_StripMark2.Location = new System.Drawing.Point(782, 492);
            this.textBox_StripMark2.Name = "textBox_StripMark2";
            this.textBox_StripMark2.ReadOnly = true;
            this.textBox_StripMark2.Size = new System.Drawing.Size(377, 33);
            this.textBox_StripMark2.TabIndex = 558;
            this.textBox_StripMark2.Tag = "2";
            this.textBox_StripMark2.Text = "--";
            this.textBox_StripMark2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Indigo;
            this.label11.Location = new System.Drawing.Point(611, 453);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(165, 33);
            this.label11.TabIndex = 557;
            this.label11.Text = "Operation code#2";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Indigo;
            this.label12.Location = new System.Drawing.Point(611, 414);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(165, 33);
            this.label12.TabIndex = 556;
            this.label12.Text = "DCC#2";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_OperationCode2
            // 
            this.textBox_OperationCode2.BackColor = System.Drawing.Color.Black;
            this.textBox_OperationCode2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_OperationCode2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_OperationCode2.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_OperationCode2.Location = new System.Drawing.Point(782, 453);
            this.textBox_OperationCode2.Name = "textBox_OperationCode2";
            this.textBox_OperationCode2.ReadOnly = true;
            this.textBox_OperationCode2.Size = new System.Drawing.Size(377, 33);
            this.textBox_OperationCode2.TabIndex = 555;
            this.textBox_OperationCode2.Tag = "2";
            this.textBox_OperationCode2.Text = "--";
            this.textBox_OperationCode2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_DCC2
            // 
            this.textBox_DCC2.BackColor = System.Drawing.Color.Black;
            this.textBox_DCC2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_DCC2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_DCC2.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_DCC2.Location = new System.Drawing.Point(782, 414);
            this.textBox_DCC2.Name = "textBox_DCC2";
            this.textBox_DCC2.ReadOnly = true;
            this.textBox_DCC2.Size = new System.Drawing.Size(377, 33);
            this.textBox_DCC2.TabIndex = 554;
            this.textBox_DCC2.Tag = "1";
            this.textBox_DCC2.Text = "--";
            this.textBox_DCC2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_LotNo2
            // 
            this.textBox_LotNo2.BackColor = System.Drawing.Color.Black;
            this.textBox_LotNo2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_LotNo2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_LotNo2.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_LotNo2.Location = new System.Drawing.Point(782, 375);
            this.textBox_LotNo2.Name = "textBox_LotNo2";
            this.textBox_LotNo2.ReadOnly = true;
            this.textBox_LotNo2.Size = new System.Drawing.Size(377, 33);
            this.textBox_LotNo2.TabIndex = 553;
            this.textBox_LotNo2.Tag = "0";
            this.textBox_LotNo2.Text = "--";
            this.textBox_LotNo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Indigo;
            this.label13.Location = new System.Drawing.Point(611, 375);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(165, 33);
            this.label13.TabIndex = 552;
            this.label13.Text = "Lot no#2";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PM1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_TargetDevice2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_PDL2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_StripMark2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox_OperationCode2);
            this.Controls.Add(this.textBox_DCC2);
            this.Controls.Add(this.textBox_LotNo2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox_UnitID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_TargetDevice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_PDL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_StripMark);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.liveviewForm1);
            this.Controls.Add(this.textBox_OperationCode);
            this.Controls.Add(this.textBox_DCC);
            this.Controls.Add(this.btn_2DID_Read);
            this.Controls.Add(this.textBox_LotNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxEventLog);
            this.Name = "PM1Form";
            this.Size = new System.Drawing.Size(1172, 824);
            this.Load += new System.EventHandler(this.PM1Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ListBox listBoxEventLog;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn_2DID_Read;
        public System.Windows.Forms.TextBox textBox_LotNo;
        public System.Windows.Forms.TextBox textBox_DCC;
        public System.Windows.Forms.TextBox textBox_OperationCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public Keyence.AutoID.SDK.LiveviewForm liveviewForm1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBox_StripMark;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBox_PDL;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textBox_TargetDevice;
        public System.Windows.Forms.TextBox textBox_UnitID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox textBox_TargetDevice2;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox textBox_PDL2;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox textBox_StripMark2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox textBox_OperationCode2;
        public System.Windows.Forms.TextBox textBox_DCC2;
        public System.Windows.Forms.TextBox textBox_LotNo2;
        private System.Windows.Forms.Label label13;
    }
}
