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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.GrdInput = new MetroFramework.Controls.MetroGrid();
            this.Picturebox = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.CbowhereHouse = new System.Windows.Forms.ComboBox();
            this.DtpReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.BtnQRNew = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtClientidx = new System.Windows.Forms.TextBox();
            this.TxtProductUnit = new System.Windows.Forms.TextBox();
            this.TxtProductidx = new System.Windows.Forms.TextBox();
            this.Txtidx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblinoutidx = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblinoutput = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CboDevice = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CboContainer = new System.Windows.Forms.ComboBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
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
            this.splitContainer1.Location = new System.Drawing.Point(20, 60);
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
            this.splitContainer1.Size = new System.Drawing.Size(1496, 751);
            this.splitContainer1.SplitterDistance = 883;
            this.splitContainer1.TabIndex = 1;
            // 
            // GrdInput
            // 
            this.GrdInput.AllowUserToResizeRows = false;
            this.GrdInput.BackgroundColor = System.Drawing.SystemColors.Window;
            this.GrdInput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GrdInput.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GrdInput.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdInput.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.GrdInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrdInput.DefaultCellStyle = dataGridViewCellStyle20;
            this.GrdInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdInput.EnableHeadersVisualStyles = false;
            this.GrdInput.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GrdInput.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GrdInput.Location = new System.Drawing.Point(0, 0);
            this.GrdInput.Name = "GrdInput";
            this.GrdInput.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdInput.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.GrdInput.RowHeadersWidth = 51;
            this.GrdInput.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GrdInput.RowTemplate.Height = 27;
            this.GrdInput.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdInput.Size = new System.Drawing.Size(883, 751);
            this.GrdInput.TabIndex = 0;
            // 
            // Picturebox
            // 
            this.Picturebox.BackColor = System.Drawing.SystemColors.Window;
            this.Picturebox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Picturebox.Location = new System.Drawing.Point(16, 32);
            this.Picturebox.Name = "Picturebox";
            this.Picturebox.Size = new System.Drawing.Size(345, 293);
            this.Picturebox.TabIndex = 0;
            this.Picturebox.TabStop = false;
            // 
            // CbowhereHouse
            // 
            this.CbowhereHouse.FormattingEnabled = true;
            this.CbowhereHouse.Location = new System.Drawing.Point(282, 715);
            this.CbowhereHouse.Name = "CbowhereHouse";
            this.CbowhereHouse.Size = new System.Drawing.Size(176, 23);
            this.CbowhereHouse.TabIndex = 5;
            this.CbowhereHouse.Visible = false;
            // 
            // DtpReleaseDate
            // 
            this.DtpReleaseDate.Location = new System.Drawing.Point(65, 677);
            this.DtpReleaseDate.Name = "DtpReleaseDate";
            this.DtpReleaseDate.Size = new System.Drawing.Size(176, 25);
            this.DtpReleaseDate.TabIndex = 4;
            this.DtpReleaseDate.Visible = false;
            // 
            // BtnQRNew
            // 
            this.BtnQRNew.Location = new System.Drawing.Point(384, 167);
            this.BtnQRNew.Name = "BtnQRNew";
            this.BtnQRNew.Size = new System.Drawing.Size(75, 40);
            this.BtnQRNew.TabIndex = 3;
            this.BtnQRNew.Text = "QR등록";
            this.BtnQRNew.UseVisualStyleBackColor = true;
            this.BtnQRNew.Click += new System.EventHandler(this.BtnQRNew_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 523);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "뒤로";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(176, 523);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(76, 40);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "입고등록";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TxtClientidx
            // 
            this.TxtClientidx.Location = new System.Drawing.Point(185, 329);
            this.TxtClientidx.Name = "TxtClientidx";
            this.TxtClientidx.Size = new System.Drawing.Size(176, 25);
            this.TxtClientidx.TabIndex = 0;
            // 
            // TxtProductUnit
            // 
            this.TxtProductUnit.Location = new System.Drawing.Point(185, 476);
            this.TxtProductUnit.Name = "TxtProductUnit";
            this.TxtProductUnit.Size = new System.Drawing.Size(176, 25);
            this.TxtProductUnit.TabIndex = 2;
            this.TxtProductUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtProductUnit_KeyPress);
            // 
            // TxtProductidx
            // 
            this.TxtProductidx.Location = new System.Drawing.Point(185, 383);
            this.TxtProductidx.Name = "TxtProductidx";
            this.TxtProductidx.Size = new System.Drawing.Size(176, 25);
            this.TxtProductidx.TabIndex = 1;
            // 
            // Txtidx
            // 
            this.Txtidx.Location = new System.Drawing.Point(95, 708);
            this.Txtidx.Name = "Txtidx";
            this.Txtidx.Size = new System.Drawing.Size(176, 25);
            this.Txtidx.TabIndex = 1;
            this.Txtidx.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 683);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "일자";
            this.label3.Visible = false;
            // 
            // lblinoutidx
            // 
            this.lblinoutidx.AutoSize = true;
            this.lblinoutidx.Location = new System.Drawing.Point(49, 713);
            this.lblinoutidx.Name = "lblinoutidx";
            this.lblinoutidx.Size = new System.Drawing.Size(37, 15);
            this.lblinoutidx.TabIndex = 0;
            this.lblinoutidx.Text = "번호";
            this.lblinoutidx.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "거래처번호";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 718);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "창고";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 479);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "수량";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "품목코드";
            // 
            // lblinoutput
            // 
            this.lblinoutput.AutoSize = true;
            this.lblinoutput.Location = new System.Drawing.Point(13, 9);
            this.lblinoutput.Name = "lblinoutput";
            this.lblinoutput.Size = new System.Drawing.Size(67, 15);
            this.lblinoutput.TabIndex = 0;
            this.lblinoutput.Text = "입고관리";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CboDevice
            // 
            this.CboDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboDevice.FormattingEnabled = true;
            this.CboDevice.Location = new System.Drawing.Point(384, 123);
            this.CboDevice.Name = "CboDevice";
            this.CboDevice.Size = new System.Drawing.Size(197, 23);
            this.CboDevice.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "창고";
            // 
            // CboContainer
            // 
            this.CboContainer.FormattingEnabled = true;
            this.CboContainer.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.CboContainer.Location = new System.Drawing.Point(185, 430);
            this.CboContainer.Name = "CboContainer";
            this.CboContainer.Size = new System.Drawing.Size(176, 23);
            this.CboContainer.TabIndex = 3;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(230, 586);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(76, 40);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.Text = "종료";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(65, 523);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(76, 40);
            this.BtnNew.TabIndex = 4;
            this.BtnNew.Text = "신규";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // InPutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1536, 831);
            this.Controls.Add(this.splitContainer1);
            this.Name = "InPutForm";
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
    }
}