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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GrdInput = new MetroFramework.Controls.MetroGrid();
            this.CboContainer = new System.Windows.Forms.ComboBox();
            this.CboDevice = new System.Windows.Forms.ComboBox();
            this.Picturebox = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.CameraOff = new System.Windows.Forms.Button();
            this.BtnQRNew = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtClientidx = new System.Windows.Forms.TextBox();
            this.TxtProductUnit = new System.Windows.Forms.TextBox();
            this.TxtProductidx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblinoutput = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.GrdInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picturebox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrdInput
            // 
            this.GrdInput.AllowUserToResizeRows = false;
            this.GrdInput.BackgroundColor = System.Drawing.SystemColors.Window;
            this.GrdInput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GrdInput.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GrdInput.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdInput.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GrdInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrdInput.DefaultCellStyle = dataGridViewCellStyle2;
            this.GrdInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdInput.EnableHeadersVisualStyles = false;
            this.GrdInput.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GrdInput.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GrdInput.Location = new System.Drawing.Point(3, 3);
            this.GrdInput.Name = "GrdInput";
            this.GrdInput.ReadOnly = true;
            this.GrdInput.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdInput.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GrdInput.RowHeadersWidth = 51;
            this.GrdInput.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GrdInput.RowTemplate.Height = 27;
            this.GrdInput.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdInput.Size = new System.Drawing.Size(804, 692);
            this.GrdInput.TabIndex = 0;
            // 
            // CboContainer
            // 
            this.CboContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CboContainer.FormattingEnabled = true;
            this.CboContainer.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.CboContainer.Location = new System.Drawing.Point(248, 460);
            this.CboContainer.Name = "CboContainer";
            this.CboContainer.Size = new System.Drawing.Size(176, 23);
            this.CboContainer.TabIndex = 3;
            // 
            // CboDevice
            // 
            this.CboDevice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CboDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboDevice.FormattingEnabled = true;
            this.CboDevice.Location = new System.Drawing.Point(149, 6);
            this.CboDevice.Name = "CboDevice";
            this.CboDevice.Size = new System.Drawing.Size(275, 23);
            this.CboDevice.TabIndex = 6;
            // 
            // Picturebox
            // 
            this.Picturebox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Picturebox.BackColor = System.Drawing.Color.LightGray;
            this.Picturebox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Picturebox.Location = new System.Drawing.Point(79, 45);
            this.Picturebox.Name = "Picturebox";
            this.Picturebox.Size = new System.Drawing.Size(345, 293);
            this.Picturebox.TabIndex = 0;
            this.Picturebox.TabStop = false;
            // 
            // CameraOff
            // 
            this.CameraOff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CameraOff.Location = new System.Drawing.Point(435, 128);
            this.CameraOff.Name = "CameraOff";
            this.CameraOff.Size = new System.Drawing.Size(90, 40);
            this.CameraOff.TabIndex = 3;
            this.CameraOff.Text = "연결해제";
            this.CameraOff.UseVisualStyleBackColor = true;
            this.CameraOff.Click += new System.EventHandler(this.CameraOff_Click);
            // 
            // BtnQRNew
            // 
            this.BtnQRNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnQRNew.Location = new System.Drawing.Point(435, 73);
            this.BtnQRNew.Name = "BtnQRNew";
            this.BtnQRNew.Size = new System.Drawing.Size(90, 40);
            this.BtnQRNew.TabIndex = 3;
            this.BtnQRNew.Text = "QR등록";
            this.BtnQRNew.UseVisualStyleBackColor = true;
            this.BtnQRNew.Click += new System.EventHandler(this.BtnQRNew_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExit.Location = new System.Drawing.Point(450, 273);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 40);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.Text = "종료";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Visible = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(459, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "뒤로";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNew.Location = new System.Drawing.Point(178, 556);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 40);
            this.BtnNew.TabIndex = 4;
            this.BtnNew.Text = "신규";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.Location = new System.Drawing.Point(292, 556);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 40);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "입고등록";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TxtClientidx
            // 
            this.TxtClientidx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtClientidx.Location = new System.Drawing.Point(248, 359);
            this.TxtClientidx.Name = "TxtClientidx";
            this.TxtClientidx.ReadOnly = true;
            this.TxtClientidx.Size = new System.Drawing.Size(176, 25);
            this.TxtClientidx.TabIndex = 0;
            // 
            // TxtProductUnit
            // 
            this.TxtProductUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtProductUnit.Location = new System.Drawing.Point(248, 506);
            this.TxtProductUnit.Name = "TxtProductUnit";
            this.TxtProductUnit.ReadOnly = true;
            this.TxtProductUnit.Size = new System.Drawing.Size(176, 25);
            this.TxtProductUnit.TabIndex = 2;
            this.TxtProductUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtProductUnit_KeyPress);
            // 
            // TxtProductidx
            // 
            this.TxtProductidx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtProductidx.Location = new System.Drawing.Point(248, 413);
            this.TxtProductidx.Name = "TxtProductidx";
            this.TxtProductidx.ReadOnly = true;
            this.TxtProductidx.Size = new System.Drawing.Size(176, 25);
            this.TxtProductidx.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "거래처번호";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "창고";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 509);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "수량";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "품목코드";
            // 
            // lblinoutput
            // 
            this.lblinoutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblinoutput.AutoSize = true;
            this.lblinoutput.Location = new System.Drawing.Point(76, 9);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.GrdInput, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1350, 698);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.CboContainer);
            this.panel1.Controls.Add(this.CboDevice);
            this.panel1.Controls.Add(this.Picturebox);
            this.panel1.Controls.Add(this.CameraOff);
            this.panel1.Controls.Add(this.BtnQRNew);
            this.panel1.Controls.Add(this.BtnExit);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.BtnNew);
            this.panel1.Controls.Add(this.BtnSave);
            this.panel1.Controls.Add(this.TxtClientidx);
            this.panel1.Controls.Add(this.TxtProductUnit);
            this.panel1.Controls.Add(this.TxtProductidx);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblinoutput);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(813, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 692);
            this.panel1.TabIndex = 1;
            // 
            // InPutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 698);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InPutForm";
            this.Text = "InPutForm";
            this.Load += new System.EventHandler(this.InPutForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picturebox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox TxtClientidx;
        private System.Windows.Forms.TextBox TxtProductUnit;
        private System.Windows.Forms.TextBox TxtProductidx;
        private System.Windows.Forms.Label label6;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
    }
}