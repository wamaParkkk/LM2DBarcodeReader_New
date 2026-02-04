
namespace LM2DBarcodeReader_New
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timerDisplay = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Tray_Icon = new System.Windows.Forms.NotifyIcon(this.components);
            this.context_TrayIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.pictureBoxLotValidation = new System.Windows.Forms.PictureBox();
            this.btnLotValidation = new System.Windows.Forms.Button();
            this.pictureBoxConfigure = new System.Windows.Forms.PictureBox();
            this.btnConfigure = new System.Windows.Forms.Button();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.btnMaintnance = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnGuide = new System.Windows.Forms.Button();
            this.pictureBoxUserGuide = new System.Windows.Forms.PictureBox();
            this.pictureBoxEventLog = new System.Windows.Forms.PictureBox();
            this.btnEventLog = new System.Windows.Forms.Button();
            this.laUserLevel = new System.Windows.Forms.Label();
            this.labelPageName = new System.Windows.Forms.Label();
            this.laTime = new System.Windows.Forms.Label();
            this.laDate = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.context_TrayIcon.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLotValidation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConfigure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserGuide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEventLog)).BeginInit();
            this.SuspendLayout();
            // 
            // timerDisplay
            // 
            this.timerDisplay.Interval = 500;
            this.timerDisplay.Tick += new System.EventHandler(this.timerDisplay_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 100);
            this.panel1.TabIndex = 31;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(275, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1005, 100);
            this.panel4.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelLogo);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(276, 100);
            this.panel2.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 924);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1280, 100);
            this.panel9.TabIndex = 38;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(1194, 100);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(86, 824);
            this.panel7.TabIndex = 40;
            // 
            // Tray_Icon
            // 
            this.Tray_Icon.Icon = ((System.Drawing.Icon)(resources.GetObject("Tray_Icon.Icon")));
            this.Tray_Icon.Text = "PCB Lid 2D Barcode reader";
            this.Tray_Icon.Visible = true;
            this.Tray_Icon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Tray_Icon_MouseDoubleClick);
            // 
            // context_TrayIcon
            // 
            this.context_TrayIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.context_TrayIcon.Name = "context_TrayIcon";
            this.context_TrayIcon.Size = new System.Drawing.Size(105, 48);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel8.BackgroundImage")));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(86, 824);
            this.panel8.TabIndex = 41;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 100);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(22, 824);
            this.panel6.TabIndex = 39;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel10.BackgroundImage")));
            this.panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel10.Controls.Add(this.pictureBoxLotValidation);
            this.panel10.Controls.Add(this.btnLotValidation);
            this.panel10.Controls.Add(this.pictureBoxConfigure);
            this.panel10.Controls.Add(this.btnConfigure);
            this.panel10.Controls.Add(this.pictureBoxExit);
            this.panel10.Controls.Add(this.pictureBoxMain);
            this.panel10.Controls.Add(this.btnMaintnance);
            this.panel10.Controls.Add(this.btnExit);
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1286, 106);
            this.panel10.TabIndex = 34;
            // 
            // pictureBoxLotValidation
            // 
            this.pictureBoxLotValidation.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLotValidation.BackgroundImage = global::LM2DBarcodeReader_New.Properties.Resources.Validation;
            this.pictureBoxLotValidation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLotValidation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLotValidation.Location = new System.Drawing.Point(498, 45);
            this.pictureBoxLotValidation.Name = "pictureBoxLotValidation";
            this.pictureBoxLotValidation.Size = new System.Drawing.Size(42, 42);
            this.pictureBoxLotValidation.TabIndex = 736;
            this.pictureBoxLotValidation.TabStop = false;
            this.pictureBoxLotValidation.Click += new System.EventHandler(this.btnLotValidation_Click);
            // 
            // btnLotValidation
            // 
            this.btnLotValidation.BackColor = System.Drawing.Color.Transparent;
            this.btnLotValidation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLotValidation.Font = new System.Drawing.Font("Nirmala UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLotValidation.ForeColor = System.Drawing.Color.White;
            this.btnLotValidation.Location = new System.Drawing.Point(539, 45);
            this.btnLotValidation.Name = "btnLotValidation";
            this.btnLotValidation.Size = new System.Drawing.Size(132, 42);
            this.btnLotValidation.TabIndex = 735;
            this.btnLotValidation.Text = "Lot validation";
            this.btnLotValidation.UseVisualStyleBackColor = false;
            this.btnLotValidation.Click += new System.EventHandler(this.btnLotValidation_Click);
            // 
            // pictureBoxConfigure
            // 
            this.pictureBoxConfigure.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxConfigure.BackgroundImage = global::LM2DBarcodeReader_New.Properties.Resources.ConfigButton;
            this.pictureBoxConfigure.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxConfigure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxConfigure.Location = new System.Drawing.Point(677, 45);
            this.pictureBoxConfigure.Name = "pictureBoxConfigure";
            this.pictureBoxConfigure.Size = new System.Drawing.Size(42, 42);
            this.pictureBoxConfigure.TabIndex = 43;
            this.pictureBoxConfigure.TabStop = false;
            this.pictureBoxConfigure.Click += new System.EventHandler(this.btnConfigure_Click);
            // 
            // btnConfigure
            // 
            this.btnConfigure.BackColor = System.Drawing.Color.Transparent;
            this.btnConfigure.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConfigure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfigure.FlatAppearance.BorderSize = 0;
            this.btnConfigure.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfigure.Font = new System.Drawing.Font("Nirmala UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigure.ForeColor = System.Drawing.Color.White;
            this.btnConfigure.Location = new System.Drawing.Point(718, 45);
            this.btnConfigure.Name = "btnConfigure";
            this.btnConfigure.Size = new System.Drawing.Size(111, 42);
            this.btnConfigure.TabIndex = 42;
            this.btnConfigure.Text = "Configure";
            this.btnConfigure.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnConfigure.UseVisualStyleBackColor = false;
            this.btnConfigure.Click += new System.EventHandler(this.btnConfigure_Click);
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxExit.BackgroundImage = global::LM2DBarcodeReader_New.Properties.Resources.ExitButton;
            this.pictureBoxExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxExit.Location = new System.Drawing.Point(962, 45);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(42, 42);
            this.pictureBoxExit.TabIndex = 39;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMain.BackgroundImage = global::LM2DBarcodeReader_New.Properties.Resources.Maint;
            this.pictureBoxMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMain.Location = new System.Drawing.Point(340, 45);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(42, 42);
            this.pictureBoxMain.TabIndex = 35;
            this.pictureBoxMain.TabStop = false;
            this.pictureBoxMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // btnMaintnance
            // 
            this.btnMaintnance.BackColor = System.Drawing.Color.Transparent;
            this.btnMaintnance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMaintnance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaintnance.FlatAppearance.BorderSize = 0;
            this.btnMaintnance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMaintnance.Font = new System.Drawing.Font("Nirmala UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaintnance.ForeColor = System.Drawing.Color.White;
            this.btnMaintnance.Location = new System.Drawing.Point(381, 45);
            this.btnMaintnance.Name = "btnMaintnance";
            this.btnMaintnance.Size = new System.Drawing.Size(111, 42);
            this.btnMaintnance.TabIndex = 33;
            this.btnMaintnance.Text = "Process";
            this.btnMaintnance.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMaintnance.UseVisualStyleBackColor = false;
            this.btnMaintnance.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Nirmala UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(1003, 45);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 42);
            this.btnExit.TabIndex = 31;
            this.btnExit.Text = "Exit";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.btnGuide);
            this.panel5.Controls.Add(this.pictureBoxUserGuide);
            this.panel5.Controls.Add(this.pictureBoxEventLog);
            this.panel5.Controls.Add(this.btnEventLog);
            this.panel5.Controls.Add(this.laUserLevel);
            this.panel5.Controls.Add(this.labelPageName);
            this.panel5.Controls.Add(this.laTime);
            this.panel5.Controls.Add(this.laDate);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1005, 100);
            this.panel5.TabIndex = 20;
            // 
            // btnGuide
            // 
            this.btnGuide.BackColor = System.Drawing.Color.Transparent;
            this.btnGuide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuide.FlatAppearance.BorderSize = 0;
            this.btnGuide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuide.Font = new System.Drawing.Font("Nirmala UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuide.ForeColor = System.Drawing.Color.White;
            this.btnGuide.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuide.Location = new System.Drawing.Point(729, 29);
            this.btnGuide.Name = "btnGuide";
            this.btnGuide.Size = new System.Drawing.Size(111, 42);
            this.btnGuide.TabIndex = 158;
            this.btnGuide.Text = "Guide";
            this.btnGuide.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGuide.UseVisualStyleBackColor = false;
            this.btnGuide.Click += new System.EventHandler(this.btnGuide_Click);
            // 
            // pictureBoxUserGuide
            // 
            this.pictureBoxUserGuide.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxUserGuide.BackgroundImage = global::LM2DBarcodeReader_New.Properties.Resources.UserGuide;
            this.pictureBoxUserGuide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxUserGuide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxUserGuide.Location = new System.Drawing.Point(687, 29);
            this.pictureBoxUserGuide.Name = "pictureBoxUserGuide";
            this.pictureBoxUserGuide.Size = new System.Drawing.Size(42, 42);
            this.pictureBoxUserGuide.TabIndex = 157;
            this.pictureBoxUserGuide.TabStop = false;
            this.pictureBoxUserGuide.Click += new System.EventHandler(this.btnGuide_Click);
            // 
            // pictureBoxEventLog
            // 
            this.pictureBoxEventLog.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEventLog.BackgroundImage = global::LM2DBarcodeReader_New.Properties.Resources.log;
            this.pictureBoxEventLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxEventLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxEventLog.Location = new System.Drawing.Point(529, 29);
            this.pictureBoxEventLog.Name = "pictureBoxEventLog";
            this.pictureBoxEventLog.Size = new System.Drawing.Size(42, 42);
            this.pictureBoxEventLog.TabIndex = 156;
            this.pictureBoxEventLog.TabStop = false;
            this.pictureBoxEventLog.Click += new System.EventHandler(this.btnEventLog_Click);
            // 
            // btnEventLog
            // 
            this.btnEventLog.BackColor = System.Drawing.Color.Transparent;
            this.btnEventLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEventLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEventLog.FlatAppearance.BorderSize = 0;
            this.btnEventLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEventLog.Font = new System.Drawing.Font("Nirmala UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventLog.ForeColor = System.Drawing.Color.White;
            this.btnEventLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEventLog.Location = new System.Drawing.Point(570, 29);
            this.btnEventLog.Name = "btnEventLog";
            this.btnEventLog.Size = new System.Drawing.Size(111, 42);
            this.btnEventLog.TabIndex = 155;
            this.btnEventLog.Text = "Event Log";
            this.btnEventLog.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEventLog.UseVisualStyleBackColor = false;
            this.btnEventLog.Click += new System.EventHandler(this.btnEventLog_Click);
            // 
            // laUserLevel
            // 
            this.laUserLevel.AutoSize = true;
            this.laUserLevel.BackColor = System.Drawing.Color.Transparent;
            this.laUserLevel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laUserLevel.ForeColor = System.Drawing.Color.Yellow;
            this.laUserLevel.Location = new System.Drawing.Point(896, 17);
            this.laUserLevel.Name = "laUserLevel";
            this.laUserLevel.Size = new System.Drawing.Size(17, 14);
            this.laUserLevel.TabIndex = 151;
            this.laUserLevel.Text = "--";
            this.laUserLevel.Visible = false;
            // 
            // labelPageName
            // 
            this.labelPageName.AutoSize = true;
            this.labelPageName.BackColor = System.Drawing.Color.Transparent;
            this.labelPageName.Font = new System.Drawing.Font("Nirmala UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPageName.ForeColor = System.Drawing.Color.White;
            this.labelPageName.Location = new System.Drawing.Point(50, 16);
            this.labelPageName.Name = "labelPageName";
            this.labelPageName.Size = new System.Drawing.Size(55, 54);
            this.labelPageName.TabIndex = 149;
            this.labelPageName.Text = "--";
            this.labelPageName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // laTime
            // 
            this.laTime.AutoSize = true;
            this.laTime.BackColor = System.Drawing.Color.Transparent;
            this.laTime.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTime.ForeColor = System.Drawing.SystemColors.Window;
            this.laTime.Location = new System.Drawing.Point(896, 57);
            this.laTime.Name = "laTime";
            this.laTime.Size = new System.Drawing.Size(63, 14);
            this.laTime.TabIndex = 148;
            this.laTime.Text = "00:00:00";
            // 
            // laDate
            // 
            this.laDate.AutoSize = true;
            this.laDate.BackColor = System.Drawing.Color.Transparent;
            this.laDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laDate.ForeColor = System.Drawing.SystemColors.Window;
            this.laDate.Location = new System.Drawing.Point(896, 37);
            this.laDate.Name = "laDate";
            this.laDate.Size = new System.Drawing.Size(79, 14);
            this.laDate.TabIndex = 147;
            this.laDate.Text = "0000.00.00";
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(146)))), ((int)(((byte)(190)))));
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(276, 100);
            this.panelLogo.TabIndex = 18;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1280, 1024);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "PCB Lid 2D Barcode reader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.context_TrayIcon.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLotValidation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConfigure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserGuide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEventLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerDisplay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.Label labelPageName;
        private System.Windows.Forms.Label laTime;
        private System.Windows.Forms.Label laDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.Button btnMaintnance;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label laUserLevel;
        private System.Windows.Forms.PictureBox pictureBoxEventLog;
        private System.Windows.Forms.Button btnEventLog;
        private System.Windows.Forms.PictureBox pictureBoxConfigure;
        private System.Windows.Forms.Button btnConfigure;
        private System.Windows.Forms.PictureBox pictureBoxUserGuide;
        private System.Windows.Forms.Button btnGuide;
        private System.Windows.Forms.NotifyIcon Tray_Icon;
        private System.Windows.Forms.ContextMenuStrip context_TrayIcon;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnLotValidation;
        private System.Windows.Forms.PictureBox pictureBoxLotValidation;
    }
}