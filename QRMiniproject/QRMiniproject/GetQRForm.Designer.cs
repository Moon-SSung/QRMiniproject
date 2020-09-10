namespace QRMiniproject
{
    partial class GetQRForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CboQRCode2 = new System.Windows.Forms.ComboBox();
            this.TxtQRCode1 = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.LblQR6 = new System.Windows.Forms.Label();
            this.LblQR1 = new System.Windows.Forms.Label();
            this.TxtQRCode2 = new System.Windows.Forms.TextBox();
            this.CboQRCode1 = new System.Windows.Forms.ComboBox();
            this.LblQR3 = new System.Windows.Forms.Label();
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.LblQR5 = new System.Windows.Forms.Label();
            this.DtpQRCode = new System.Windows.Forms.DateTimePicker();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.LblQR4 = new System.Windows.Forms.Label();
            this.CboQRCode3 = new System.Windows.Forms.ComboBox();
            this.LblQR2 = new System.Windows.Forms.Label();
            this.BtnDataReset = new System.Windows.Forms.Button();
            this.MtrGetQRGrid = new MetroFramework.Controls.MetroGrid();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PbxQRCode = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MtrGetQRGrid)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.MtrGetQRGrid, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1450, 553);
            this.tableLayoutPanel1.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.CboQRCode2);
            this.panel1.Controls.Add(this.TxtQRCode1);
            this.panel1.Controls.Add(this.BtnSave);
            this.panel1.Controls.Add(this.LblQR6);
            this.panel1.Controls.Add(this.LblQR1);
            this.panel1.Controls.Add(this.TxtQRCode2);
            this.panel1.Controls.Add(this.CboQRCode1);
            this.panel1.Controls.Add(this.LblQR3);
            this.panel1.Controls.Add(this.BtnGenerate);
            this.panel1.Controls.Add(this.LblQR5);
            this.panel1.Controls.Add(this.DtpQRCode);
            this.panel1.Controls.Add(this.BtnPrint);
            this.panel1.Controls.Add(this.LblQR4);
            this.panel1.Controls.Add(this.CboQRCode3);
            this.panel1.Controls.Add(this.LblQR2);
            this.panel1.Controls.Add(this.BtnDataReset);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(873, 3);
            this.panel1.Name = "panel1";
            this.tableLayoutPanel1.SetRowSpan(this.panel1, 2);
            this.panel1.Size = new System.Drawing.Size(574, 362);
            this.panel1.TabIndex = 0;
            // 
            // CboQRCode2
            // 
            this.CboQRCode2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CboQRCode2.FormattingEnabled = true;
            this.CboQRCode2.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.CboQRCode2.Location = new System.Drawing.Point(174, 93);
            this.CboQRCode2.Name = "CboQRCode2";
            this.CboQRCode2.Size = new System.Drawing.Size(289, 23);
            this.CboQRCode2.TabIndex = 31;
            // 
            // TxtQRCode1
            // 
            this.TxtQRCode1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtQRCode1.Location = new System.Drawing.Point(174, 3);
            this.TxtQRCode1.Multiline = true;
            this.TxtQRCode1.Name = "TxtQRCode1";
            this.TxtQRCode1.Size = new System.Drawing.Size(289, 27);
            this.TxtQRCode1.TabIndex = 15;
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnSave.Location = new System.Drawing.Point(287, 257);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(85, 60);
            this.BtnSave.TabIndex = 13;
            this.BtnSave.Text = "저장하기";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // LblQR6
            // 
            this.LblQR6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblQR6.Location = new System.Drawing.Point(83, 51);
            this.LblQR6.Name = "LblQR6";
            this.LblQR6.Size = new System.Drawing.Size(85, 15);
            this.LblQR6.TabIndex = 23;
            this.LblQR6.Text = "거래처번호";
            this.LblQR6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblQR1
            // 
            this.LblQR1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblQR1.Location = new System.Drawing.Point(86, 6);
            this.LblQR1.Name = "LblQR1";
            this.LblQR1.Size = new System.Drawing.Size(82, 15);
            this.LblQR1.TabIndex = 20;
            this.LblQR1.Text = "출고번호";
            this.LblQR1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtQRCode2
            // 
            this.TxtQRCode2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtQRCode2.Location = new System.Drawing.Point(174, 181);
            this.TxtQRCode2.Multiline = true;
            this.TxtQRCode2.Name = "TxtQRCode2";
            this.TxtQRCode2.Size = new System.Drawing.Size(289, 27);
            this.TxtQRCode2.TabIndex = 21;
            // 
            // CboQRCode1
            // 
            this.CboQRCode1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CboQRCode1.FormattingEnabled = true;
            this.CboQRCode1.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.CboQRCode1.Location = new System.Drawing.Point(174, 48);
            this.CboQRCode1.Name = "CboQRCode1";
            this.CboQRCode1.Size = new System.Drawing.Size(289, 23);
            this.CboQRCode1.TabIndex = 30;
            // 
            // LblQR3
            // 
            this.LblQR3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblQR3.Location = new System.Drawing.Point(86, 96);
            this.LblQR3.Name = "LblQR3";
            this.LblQR3.Size = new System.Drawing.Size(82, 15);
            this.LblQR3.TabIndex = 18;
            this.LblQR3.Text = "품목코드";
            this.LblQR3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnGenerate.Location = new System.Drawing.Point(196, 257);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(85, 60);
            this.BtnGenerate.TabIndex = 14;
            this.BtnGenerate.Text = "만들기";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // LblQR5
            // 
            this.LblQR5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblQR5.Location = new System.Drawing.Point(86, 229);
            this.LblQR5.Name = "LblQR5";
            this.LblQR5.Size = new System.Drawing.Size(82, 15);
            this.LblQR5.TabIndex = 24;
            this.LblQR5.Text = "창고";
            this.LblQR5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DtpQRCode
            // 
            this.DtpQRCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DtpQRCode.Location = new System.Drawing.Point(174, 138);
            this.DtpQRCode.Name = "DtpQRCode";
            this.DtpQRCode.Size = new System.Drawing.Size(289, 25);
            this.DtpQRCode.TabIndex = 26;
            // 
            // BtnPrint
            // 
            this.BtnPrint.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnPrint.Location = new System.Drawing.Point(378, 257);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(85, 60);
            this.BtnPrint.TabIndex = 29;
            this.BtnPrint.Text = "Print";
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // LblQR4
            // 
            this.LblQR4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblQR4.Location = new System.Drawing.Point(86, 184);
            this.LblQR4.Name = "LblQR4";
            this.LblQR4.Size = new System.Drawing.Size(82, 15);
            this.LblQR4.TabIndex = 25;
            this.LblQR4.Text = "수량";
            this.LblQR4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CboQRCode3
            // 
            this.CboQRCode3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CboQRCode3.FormattingEnabled = true;
            this.CboQRCode3.Items.AddRange(new object[] {
            "M창고",
            "N창고"});
            this.CboQRCode3.Location = new System.Drawing.Point(174, 226);
            this.CboQRCode3.Name = "CboQRCode3";
            this.CboQRCode3.Size = new System.Drawing.Size(289, 23);
            this.CboQRCode3.TabIndex = 27;
            // 
            // LblQR2
            // 
            this.LblQR2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblQR2.Location = new System.Drawing.Point(86, 145);
            this.LblQR2.Name = "LblQR2";
            this.LblQR2.Size = new System.Drawing.Size(82, 15);
            this.LblQR2.TabIndex = 19;
            this.LblQR2.Text = "출고일자";
            this.LblQR2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnDataReset
            // 
            this.BtnDataReset.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnDataReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnDataReset.Location = new System.Drawing.Point(105, 257);
            this.BtnDataReset.Name = "BtnDataReset";
            this.BtnDataReset.Size = new System.Drawing.Size(85, 60);
            this.BtnDataReset.TabIndex = 29;
            this.BtnDataReset.Text = "Reset";
            this.BtnDataReset.UseVisualStyleBackColor = true;
            this.BtnDataReset.Click += new System.EventHandler(this.BtnDataReset_Click);
            // 
            // MtrGetQRGrid
            // 
            this.MtrGetQRGrid.AllowUserToAddRows = false;
            this.MtrGetQRGrid.AllowUserToDeleteRows = false;
            this.MtrGetQRGrid.AllowUserToResizeRows = false;
            this.MtrGetQRGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MtrGetQRGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MtrGetQRGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.MtrGetQRGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MtrGetQRGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MtrGetQRGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MtrGetQRGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.MtrGetQRGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MtrGetQRGrid.EnableHeadersVisualStyles = false;
            this.MtrGetQRGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MtrGetQRGrid.GridColor = System.Drawing.Color.White;
            this.MtrGetQRGrid.Location = new System.Drawing.Point(3, 3);
            this.MtrGetQRGrid.Name = "MtrGetQRGrid";
            this.MtrGetQRGrid.ReadOnly = true;
            this.MtrGetQRGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MtrGetQRGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.MtrGetQRGrid.RowHeadersWidth = 51;
            this.MtrGetQRGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tableLayoutPanel1.SetRowSpan(this.MtrGetQRGrid, 3);
            this.MtrGetQRGrid.RowTemplate.Height = 27;
            this.MtrGetQRGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MtrGetQRGrid.Size = new System.Drawing.Size(864, 547);
            this.MtrGetQRGrid.TabIndex = 28;
            this.MtrGetQRGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MtrGetQRGrid_CellClick);
            this.MtrGetQRGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MtrGetQRGrid_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PbxQRCode);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(873, 371);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(574, 179);
            this.panel2.TabIndex = 1;
            // 
            // PbxQRCode
            // 
            this.PbxQRCode.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PbxQRCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbxQRCode.Location = new System.Drawing.Point(0, 0);
            this.PbxQRCode.Name = "PbxQRCode";
            this.PbxQRCode.Size = new System.Drawing.Size(574, 179);
            this.PbxQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PbxQRCode.TabIndex = 16;
            this.PbxQRCode.TabStop = false;
            // 
            // GetQRForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1450, 553);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GetQRForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GetQRForm";
            this.Load += new System.EventHandler(this.GetQRForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MtrGetQRGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxQRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CboQRCode2;
        private System.Windows.Forms.TextBox TxtQRCode1;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label LblQR6;
        private System.Windows.Forms.Label LblQR1;
        private System.Windows.Forms.TextBox TxtQRCode2;
        private System.Windows.Forms.ComboBox CboQRCode1;
        private System.Windows.Forms.Label LblQR3;
        private System.Windows.Forms.Button BtnGenerate;
        private System.Windows.Forms.Label LblQR5;
        private System.Windows.Forms.DateTimePicker DtpQRCode;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.Label LblQR4;
        private System.Windows.Forms.ComboBox CboQRCode3;
        private System.Windows.Forms.Label LblQR2;
        private System.Windows.Forms.Button BtnDataReset;
        private MetroFramework.Controls.MetroGrid MtrGetQRGrid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox PbxQRCode;
    }
}