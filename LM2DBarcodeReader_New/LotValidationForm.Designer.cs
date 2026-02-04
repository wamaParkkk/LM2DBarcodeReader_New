namespace LM2DBarcodeReader_New
{
    partial class LotValidationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LotValidationForm));
            this.textBoxAlTag = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.dataGridViewAlTag = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxUnit1 = new System.Windows.Forms.TextBox();
            this.textBoxUnit2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUnit3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxUnit4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxUnit5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewUnit1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewUnit2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewUnit3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewUnit4 = new System.Windows.Forms.DataGridView();
            this.dataGridViewUnit5 = new System.Windows.Forms.DataGridView();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblSummary = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlTag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnit5)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxAlTag
            // 
            this.textBoxAlTag.BackColor = System.Drawing.Color.White;
            this.textBoxAlTag.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxAlTag.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAlTag.ForeColor = System.Drawing.Color.Black;
            this.textBoxAlTag.Location = new System.Drawing.Point(15, 47);
            this.textBoxAlTag.Name = "textBoxAlTag";
            this.textBoxAlTag.Size = new System.Drawing.Size(280, 33);
            this.textBoxAlTag.TabIndex = 609;
            this.textBoxAlTag.Tag = "0";
            this.textBoxAlTag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 35);
            this.label1.TabIndex = 608;
            this.label1.Text = "AL Tag";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Scanner.png");
            // 
            // label2
            // 
            this.label2.ImageIndex = 0;
            this.label2.ImageList = this.imageList1;
            this.label2.Location = new System.Drawing.Point(103, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 35);
            this.label2.TabIndex = 610;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label20.ForeColor = System.Drawing.Color.Blue;
            this.label20.Location = new System.Drawing.Point(14, 83);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 13);
            this.label20.TabIndex = 710;
            this.label20.Text = "Lot 정보";
            // 
            // dataGridViewAlTag
            // 
            this.dataGridViewAlTag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlTag.Location = new System.Drawing.Point(15, 99);
            this.dataGridViewAlTag.Name = "dataGridViewAlTag";
            this.dataGridViewAlTag.RowTemplate.Height = 23;
            this.dataGridViewAlTag.Size = new System.Drawing.Size(280, 593);
            this.dataGridViewAlTag.TabIndex = 709;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(305, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 35);
            this.label6.TabIndex = 711;
            this.label6.Text = "Unit ID1";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxUnit1
            // 
            this.textBoxUnit1.BackColor = System.Drawing.Color.White;
            this.textBoxUnit1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxUnit1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUnit1.ForeColor = System.Drawing.Color.Black;
            this.textBoxUnit1.Location = new System.Drawing.Point(310, 47);
            this.textBoxUnit1.Name = "textBoxUnit1";
            this.textBoxUnit1.Size = new System.Drawing.Size(280, 33);
            this.textBoxUnit1.TabIndex = 713;
            this.textBoxUnit1.Tag = "0";
            this.textBoxUnit1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxUnit2
            // 
            this.textBoxUnit2.BackColor = System.Drawing.Color.White;
            this.textBoxUnit2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxUnit2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUnit2.ForeColor = System.Drawing.Color.Black;
            this.textBoxUnit2.Location = new System.Drawing.Point(596, 47);
            this.textBoxUnit2.Name = "textBoxUnit2";
            this.textBoxUnit2.Size = new System.Drawing.Size(280, 33);
            this.textBoxUnit2.TabIndex = 715;
            this.textBoxUnit2.Tag = "0";
            this.textBoxUnit2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(591, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 35);
            this.label3.TabIndex = 714;
            this.label3.Text = "Unit ID2";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxUnit3
            // 
            this.textBoxUnit3.BackColor = System.Drawing.Color.White;
            this.textBoxUnit3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxUnit3.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUnit3.ForeColor = System.Drawing.Color.Black;
            this.textBoxUnit3.Location = new System.Drawing.Point(882, 47);
            this.textBoxUnit3.Name = "textBoxUnit3";
            this.textBoxUnit3.Size = new System.Drawing.Size(280, 33);
            this.textBoxUnit3.TabIndex = 717;
            this.textBoxUnit3.Tag = "0";
            this.textBoxUnit3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(877, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 35);
            this.label4.TabIndex = 716;
            this.label4.Text = "Unit ID3";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxUnit4
            // 
            this.textBoxUnit4.BackColor = System.Drawing.Color.White;
            this.textBoxUnit4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxUnit4.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUnit4.ForeColor = System.Drawing.Color.Black;
            this.textBoxUnit4.Location = new System.Drawing.Point(310, 390);
            this.textBoxUnit4.Name = "textBoxUnit4";
            this.textBoxUnit4.Size = new System.Drawing.Size(280, 33);
            this.textBoxUnit4.TabIndex = 719;
            this.textBoxUnit4.Tag = "0";
            this.textBoxUnit4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(305, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 35);
            this.label5.TabIndex = 718;
            this.label5.Text = "Unit ID4";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxUnit5
            // 
            this.textBoxUnit5.BackColor = System.Drawing.Color.White;
            this.textBoxUnit5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxUnit5.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUnit5.ForeColor = System.Drawing.Color.Black;
            this.textBoxUnit5.Location = new System.Drawing.Point(596, 390);
            this.textBoxUnit5.Name = "textBoxUnit5";
            this.textBoxUnit5.Size = new System.Drawing.Size(280, 33);
            this.textBoxUnit5.TabIndex = 721;
            this.textBoxUnit5.Tag = "0";
            this.textBoxUnit5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(591, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 35);
            this.label7.TabIndex = 720;
            this.label7.Text = "Unit ID5";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridViewUnit1
            // 
            this.dataGridViewUnit1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUnit1.Location = new System.Drawing.Point(310, 99);
            this.dataGridViewUnit1.Name = "dataGridViewUnit1";
            this.dataGridViewUnit1.RowTemplate.Height = 23;
            this.dataGridViewUnit1.Size = new System.Drawing.Size(280, 250);
            this.dataGridViewUnit1.TabIndex = 722;
            // 
            // dataGridViewUnit2
            // 
            this.dataGridViewUnit2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUnit2.Location = new System.Drawing.Point(596, 99);
            this.dataGridViewUnit2.Name = "dataGridViewUnit2";
            this.dataGridViewUnit2.RowTemplate.Height = 23;
            this.dataGridViewUnit2.Size = new System.Drawing.Size(280, 250);
            this.dataGridViewUnit2.TabIndex = 723;
            // 
            // dataGridViewUnit3
            // 
            this.dataGridViewUnit3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUnit3.Location = new System.Drawing.Point(882, 99);
            this.dataGridViewUnit3.Name = "dataGridViewUnit3";
            this.dataGridViewUnit3.RowTemplate.Height = 23;
            this.dataGridViewUnit3.Size = new System.Drawing.Size(280, 250);
            this.dataGridViewUnit3.TabIndex = 724;
            // 
            // dataGridViewUnit4
            // 
            this.dataGridViewUnit4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUnit4.Location = new System.Drawing.Point(310, 442);
            this.dataGridViewUnit4.Name = "dataGridViewUnit4";
            this.dataGridViewUnit4.RowTemplate.Height = 23;
            this.dataGridViewUnit4.Size = new System.Drawing.Size(280, 250);
            this.dataGridViewUnit4.TabIndex = 725;
            // 
            // dataGridViewUnit5
            // 
            this.dataGridViewUnit5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUnit5.Location = new System.Drawing.Point(596, 442);
            this.dataGridViewUnit5.Name = "dataGridViewUnit5";
            this.dataGridViewUnit5.RowTemplate.Height = 23;
            this.dataGridViewUnit5.Size = new System.Drawing.Size(280, 250);
            this.dataGridViewUnit5.TabIndex = 726;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Navy;
            this.btnReset.Location = new System.Drawing.Point(882, 636);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 56);
            this.btnReset.TabIndex = 735;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummary.ForeColor = System.Drawing.Color.Navy;
            this.lblSummary.Location = new System.Drawing.Point(13, 702);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(21, 20);
            this.lblSummary.TabIndex = 736;
            this.lblSummary.Text = "--";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(301, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 653);
            this.panel1.TabIndex = 737;
            // 
            // LotValidationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1180, 737);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dataGridViewUnit5);
            this.Controls.Add(this.dataGridViewUnit4);
            this.Controls.Add(this.dataGridViewUnit3);
            this.Controls.Add(this.dataGridViewUnit2);
            this.Controls.Add(this.dataGridViewUnit1);
            this.Controls.Add(this.textBoxUnit5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxUnit4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxUnit3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxUnit2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxUnit1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.dataGridViewAlTag);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAlTag);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "LotValidationForm";
            this.Text = "Lot validation";
            this.Load += new System.EventHandler(this.LotValidationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlTag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnit5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAlTag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView dataGridViewAlTag;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxUnit1;
        private System.Windows.Forms.TextBox textBoxUnit2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUnit3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxUnit4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxUnit5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridViewUnit1;
        private System.Windows.Forms.DataGridView dataGridViewUnit2;
        private System.Windows.Forms.DataGridView dataGridViewUnit3;
        private System.Windows.Forms.DataGridView dataGridViewUnit4;
        private System.Windows.Forms.DataGridView dataGridViewUnit5;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Panel panel1;
    }
}