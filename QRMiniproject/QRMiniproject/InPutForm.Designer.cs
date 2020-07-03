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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.CbowhereHouse = new System.Windows.Forms.ComboBox();
            this.DtpReleaseDate = new System.Windows.Forms.DateTimePicker();
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
            this.pictureBoxIpl1 = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.BtnQRNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl1)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.pictureBoxIpl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.CbowhereHouse);
            this.splitContainer1.Panel2.Controls.Add(this.DtpReleaseDate);
            this.splitContainer1.Panel2.Controls.Add(this.BtnQRNew);
            this.splitContainer1.Panel2.Controls.Add(this.BtnSave);
            this.splitContainer1.Panel2.Controls.Add(this.TxtClientidx);
            this.splitContainer1.Panel2.Controls.Add(this.TxtProductUnit);
            this.splitContainer1.Panel2.Controls.Add(this.TxtProductidx);
            this.splitContainer1.Panel2.Controls.Add(this.Txtidx);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.lblinoutidx);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.lblinoutput);
            this.splitContainer1.Size = new System.Drawing.Size(816, 466);
            this.splitContainer1.SplitterDistance = 482;
            this.splitContainer1.TabIndex = 1;
            // 
            // CbowhereHouse
            // 
            this.CbowhereHouse.FormattingEnabled = true;
            this.CbowhereHouse.Location = new System.Drawing.Point(118, 272);
            this.CbowhereHouse.Name = "CbowhereHouse";
            this.CbowhereHouse.Size = new System.Drawing.Size(176, 23);
            this.CbowhereHouse.TabIndex = 5;
            // 
            // DtpReleaseDate
            // 
            this.DtpReleaseDate.Location = new System.Drawing.Point(118, 137);
            this.DtpReleaseDate.Name = "DtpReleaseDate";
            this.DtpReleaseDate.Size = new System.Drawing.Size(176, 25);
            this.DtpReleaseDate.TabIndex = 4;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(218, 374);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(76, 40);
            this.BtnSave.TabIndex = 3;
            this.BtnSave.Text = "제품등록";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtClientidx
            // 
            this.TxtClientidx.Location = new System.Drawing.Point(118, 314);
            this.TxtClientidx.Name = "TxtClientidx";
            this.TxtClientidx.Size = new System.Drawing.Size(176, 25);
            this.TxtClientidx.TabIndex = 1;
            // 
            // TxtProductUnit
            // 
            this.TxtProductUnit.Location = new System.Drawing.Point(118, 226);
            this.TxtProductUnit.Name = "TxtProductUnit";
            this.TxtProductUnit.Size = new System.Drawing.Size(176, 25);
            this.TxtProductUnit.TabIndex = 1;
            // 
            // TxtProductidx
            // 
            this.TxtProductidx.Location = new System.Drawing.Point(118, 182);
            this.TxtProductidx.Name = "TxtProductidx";
            this.TxtProductidx.Size = new System.Drawing.Size(176, 25);
            this.TxtProductidx.TabIndex = 1;
            // 
            // Txtidx
            // 
            this.Txtidx.Location = new System.Drawing.Point(118, 94);
            this.Txtidx.Name = "Txtidx";
            this.Txtidx.Size = new System.Drawing.Size(176, 25);
            this.Txtidx.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "일자";
            // 
            // lblinoutidx
            // 
            this.lblinoutidx.AutoSize = true;
            this.lblinoutidx.Location = new System.Drawing.Point(72, 99);
            this.lblinoutidx.Name = "lblinoutidx";
            this.lblinoutidx.Size = new System.Drawing.Size(37, 15);
            this.lblinoutidx.TabIndex = 0;
            this.lblinoutidx.Text = "번호";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "거래처번호";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "창고";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "수량";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "품목코드";
            // 
            // lblinoutput
            // 
            this.lblinoutput.AutoSize = true;
            this.lblinoutput.Location = new System.Drawing.Point(26, 50);
            this.lblinoutput.Name = "lblinoutput";
            this.lblinoutput.Size = new System.Drawing.Size(67, 15);
            this.lblinoutput.TabIndex = 0;
            this.lblinoutput.Text = "입고관리";
            // 
            // pictureBoxIpl1
            // 
            this.pictureBoxIpl1.Location = new System.Drawing.Point(49, 73);
            this.pictureBoxIpl1.Name = "pictureBoxIpl1";
            this.pictureBoxIpl1.Size = new System.Drawing.Size(370, 323);
            this.pictureBoxIpl1.TabIndex = 0;
            this.pictureBoxIpl1.TabStop = false;
            // 
            // BtnQRNew
            // 
            this.BtnQRNew.Location = new System.Drawing.Point(118, 374);
            this.BtnQRNew.Name = "BtnQRNew";
            this.BtnQRNew.Size = new System.Drawing.Size(75, 40);
            this.BtnQRNew.TabIndex = 3;
            this.BtnQRNew.Text = "QR등록";
            this.BtnQRNew.UseVisualStyleBackColor = true;
            this.BtnQRNew.Click += new System.EventHandler(this.BtnQRNew_Click);
            // 
            // InPutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 546);
            this.Controls.Add(this.splitContainer1);
            this.Name = "InPutForm";
            this.Text = "InPutForm";
            this.Load += new System.EventHandler(this.InPutForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl1)).EndInit();
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
        private OpenCvSharp.UserInterface.PictureBoxIpl pictureBoxIpl1;
        private System.Windows.Forms.Button BtnQRNew;
    }
}