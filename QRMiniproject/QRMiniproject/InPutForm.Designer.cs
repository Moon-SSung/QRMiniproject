namespace QRMiniproject
{
    partial class InPutForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.GrdInput = new MetroFramework.Controls.MetroGrid();
            this.CboContainer = new System.Windows.Forms.ComboBox();
            this.CboDevice = new System.Windows.Forms.ComboBox();
            this.Picturebox = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.CbowhereHouse = new System.Windows.Forms.ComboBox();
            this.DtpReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.BtnQRNew = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtClientidx = new System.Windows.Forms.TextBox();
            this.TxtProductUnit = new System.Windows.Forms.TextBox();
            this.TxtProductidx = new System.Windows.Forms.TextBox();
            this.Txtidx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblinoutidx = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblinoutput = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CameraOff = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(25, 72);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.GrdInput);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.CboContainer);
            this.splitContainer1.Panel2.Controls.Add(this.CboDevice);
            this.splitContainer1.Panel2.Controls.Add(this.Picturebox);
            this.splitContainer1.Panel2.Controls.Add(this.CbowhereHouse);
            this.splitContainer1.Panel2.Controls.Add(this.DtpReleaseDate);
            this.splitContainer1.Panel2.Controls.Add(this.CameraOff);
            this.splitContainer1.Panel2.Controls.Add(this.BtnQRNew);
            this.splitContainer1.Panel2.Controls.Add(this.BtnExit);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.BtnNew);
            this.splitContainer1.Panel2.Controls.Add(this.BtnSave);
            this.splitContainer1.Panel2.Controls.Add(this.TxtClientidx);
            this.splitContainer1.Panel2.Controls.Add(this.TxtProductUnit);
            this.splitContainer1.Panel2.Controls.Add(this.TxtProductidx);
            this.splitContainer1.Panel2.Controls.Add(this.Txtidx);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.lblinoutidx);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.lblinoutput);
            this.splitContainer1.Size = new System.Drawing.Size(1870, 901);
            this.splitContainer1.SplitterDistance = 1103;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // GrdInput
            // 
            this.GrdInput.AllowUserToResizeRows = false;
            this.GrdInput.BackgroundColor = System.Drawing.SystemColors.Window;
            this.GrdInput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GrdInput.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GrdInput.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdInput.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.GrdInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrdInput.DefaultCellStyle = dataGridViewCellStyle14;
            this.GrdInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdInput.EnableHeadersVisualStyles = false;
            this.GrdInput.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GrdInput.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GrdInput.Location = new System.Drawing.Point(0, 0);
            this.GrdInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GrdInput.Name = "GrdInput";
            this.GrdInput.ReadOnly = true;
            this.GrdInput.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdInput.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.GrdInput.RowHeadersWidth = 51;
            this.GrdInput.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GrdInput.RowTemplate.Height = 27;
            this.GrdInput.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdInput.Size = new System.Drawing.Size(1103, 901);
            this.GrdInput.TabIndex = 0;
            // 
            // CboContainer
            // 
            this.CboContainer.FormattingEnabled = true;
            this.CboContainer.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.CboContainer.Location = new System.Drawing.Point(231, 516);
            this.CboContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CboContainer.Name = "CboContainer";
            this.CboContainer.Size = new System.Drawing.Size(219, 26);
            this.CboContainer.TabIndex = 3;
            // 
            // CboDevice
            // 
            this.CboDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboDevice.FormattingEnabled = true;
            this.CboDevice.Location = new System.Drawing.Point(480, 148);
            this.CboDevice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CboDevice.Name = "CboDevice";
            this.CboDevice.Size = new System.Drawing.Size(245, 26);
            this.CboDevice.TabIndex = 6;
            // 
            // Picturebox
            // 
            this.Picturebox.BackColor = System.Drawing.SystemColors.Window;
            this.Picturebox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Picturebox.Location = new System.Drawing.Point(20, 38);
            this.Picturebox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Picturebox.Name = "Picturebox";
            this.Picturebox.Size = new System.Drawing.Size(430, 351);
            this.Picturebox.TabIndex = 0;
            this.Picturebox.TabStop = false;
            // 
            // CbowhereHouse
            // 
            this.CbowhereHouse.FormattingEnabled = true;
            this.CbowhereHouse.Location = new System.Drawing.Point(352, 858);
            this.CbowhereHouse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CbowhereHouse.Name = "CbowhereHouse";
            this.CbowhereHouse.Size = new System.Drawing.Size(219, 26);
            this.CbowhereHouse.TabIndex = 5;
            this.CbowhereHouse.Visible = false;
            // 
            // DtpReleaseDate
            // 
            this.DtpReleaseDate.Location = new System.Drawing.Point(81, 812);
            this.DtpReleaseDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DtpReleaseDate.Name = "DtpReleaseDate";
            this.DtpReleaseDate.Size = new System.Drawing.Size(219, 28);
            this.DtpReleaseDate.TabIndex = 4;
            this.DtpReleaseDate.Visible = false;
            // 
            // BtnQRNew
            // 
            this.BtnQRNew.Location = new System.Drawing.Point(480, 200);
            this.BtnQRNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnQRNew.Name = "BtnQRNew";
            this.BtnQRNew.Size = new System.Drawing.Size(94, 48);
            this.BtnQRNew.TabIndex = 3;
            this.BtnQRNew.Text = "QR등록";
            this.BtnQRNew.UseVisualStyleBackColor = true;
            this.BtnQRNew.Click += new System.EventHandler(this.BtnQRNew_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(288, 703);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(95, 48);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.Text = "종료";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 628);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 48);
            this.button1.TabIndex = 6;
            this.button1.Text = "뒤로";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(81, 628);
            this.BtnNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(95, 48);
            this.BtnNew.TabIndex = 4;
            this.BtnNew.Text = "신규";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(220, 628);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(95, 48);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "입고등록";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TxtClientidx
            // 
            this.TxtClientidx.Location = new System.Drawing.Point(231, 395);
            this.TxtClientidx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtClientidx.Name = "TxtClientidx";
            this.TxtClientidx.Size = new System.Drawing.Size(219, 28);
            this.TxtClientidx.TabIndex = 0;
            // 
            // TxtProductUnit
            // 
            this.TxtProductUnit.Location = new System.Drawing.Point(231, 571);
            this.TxtProductUnit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtProductUnit.Name = "TxtProductUnit";
            this.TxtProductUnit.Size = new System.Drawing.Size(219, 28);
            this.TxtProductUnit.TabIndex = 2;
            this.TxtProductUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtProductUnit_KeyPress);
            // 
            // TxtProductidx
            // 
            this.TxtProductidx.Location = new System.Drawing.Point(231, 460);
            this.TxtProductidx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtProductidx.Name = "TxtProductidx";
            this.TxtProductidx.Size = new System.Drawing.Size(219, 28);
            this.TxtProductidx.TabIndex = 1;
            // 
            // Txtidx
            // 
            this.Txtidx.Location = new System.Drawing.Point(119, 850);
            this.Txtidx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txtidx.Name = "Txtidx";
            this.Txtidx.Size = new System.Drawing.Size(219, 28);
            this.Txtidx.TabIndex = 1;
            this.Txtidx.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 820);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "일자";
            this.label3.Visible = false;
            // 
            // lblinoutidx
            // 
            this.lblinoutidx.AutoSize = true;
            this.lblinoutidx.Location = new System.Drawing.Point(61, 856);
            this.lblinoutidx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblinoutidx.Name = "lblinoutidx";
            this.lblinoutidx.Size = new System.Drawing.Size(44, 18);
            this.lblinoutidx.TabIndex = 0;
            this.lblinoutidx.Text = "번호";
            this.lblinoutidx.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 401);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "거래처번호";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 862);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "창고";
            this.label5.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 526);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "창고";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 575);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "수량";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 472);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "품목코드";
            // 
            // lblinoutput
            // 
            this.lblinoutput.AutoSize = true;
            this.lblinoutput.Location = new System.Drawing.Point(16, 11);
            this.lblinoutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblinoutput.Name = "lblinoutput";
            this.lblinoutput.Size = new System.Drawing.Size(80, 18);
            this.lblinoutput.TabIndex = 0;
            this.lblinoutput.Text = "입고관리";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CameraOff
            // 
            this.CameraOff.Location = new System.Drawing.Point(616, 200);
            this.CameraOff.Margin = new System.Windows.Forms.Padding(4);
            this.CameraOff.Name = "CameraOff";
            this.CameraOff.Size = new System.Drawing.Size(94, 48);
            this.CameraOff.TabIndex = 3;
            this.CameraOff.Text = "연결해제";
            this.CameraOff.UseVisualStyleBackColor = true;
            this.CameraOff.Click += new System.EventHandler(this.CameraOff_Click);
            // 
            // InPutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 997);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "InPutForm";
            this.Padding = new System.Windows.Forms.Padding(25, 72, 25, 24);
            this.Text = "InPutForm";
            this.Load += new System.EventHandler(this.InPutForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox CbowhereHouse;
        private System.Windows.Forms.DateTimePicker DtpReleaseDate;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox TxtClientidx;
        private System.Windows.Forms.TextBox TxtProductUnit;
        private System.Windows.Forms.TextBox TxtProductidx;
        private System.Windows.Forms.TextBox Txtidx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblinoutidx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblinoutput;
        private System.Windows.Forms.Timer timer1;
        private OpenCvSharp.UserInterface.PictureBoxIpl Picturebox;
        private System.Windows.Forms.Button BtnQRNew;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroGrid GrdInput;
        private System.Windows.Forms.ComboBox CboDevice;
        private System.Windows.Forms.ComboBox CboContainer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button CameraOff;
    }
}