﻿namespace QRMiniproject
{
    partial class ClientForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.GrdClientTbl = new MetroFramework.Controls.MetroGrid();
            this.CboSort = new System.Windows.Forms.ComboBox();
            this.CboSituation = new System.Windows.Forms.ComboBox();
            this.CboPersonnal = new System.Windows.Forms.ComboBox();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtClientpart = new System.Windows.Forms.TextBox();
            this.TxtClientOwner = new System.Windows.Forms.TextBox();
            this.TxtClientName = new System.Windows.Forms.TextBox();
            this.TxtClientphoneNum = new System.Windows.Forms.TextBox();
            this.TxtClientNumber = new System.Windows.Forms.TextBox();
            this.TxtClientAddress = new System.Windows.Forms.TextBox();
            this.TxtClientidx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblClienIndex = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdClientTbl)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.GrdClientTbl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.CboSort);
            this.splitContainer1.Panel2.Controls.Add(this.CboSituation);
            this.splitContainer1.Panel2.Controls.Add(this.CboPersonnal);
            this.splitContainer1.Panel2.Controls.Add(this.BtnNew);
            this.splitContainer1.Panel2.Controls.Add(this.BtnSave);
            this.splitContainer1.Panel2.Controls.Add(this.TxtClientpart);
            this.splitContainer1.Panel2.Controls.Add(this.TxtClientOwner);
            this.splitContainer1.Panel2.Controls.Add(this.TxtClientName);
            this.splitContainer1.Panel2.Controls.Add(this.TxtClientphoneNum);
            this.splitContainer1.Panel2.Controls.Add(this.TxtClientNumber);
            this.splitContainer1.Panel2.Controls.Add(this.TxtClientAddress);
            this.splitContainer1.Panel2.Controls.Add(this.TxtClientidx);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.lblClienIndex);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(1264, 591);
            this.splitContainer1.SplitterDistance = 867;
            this.splitContainer1.TabIndex = 1;
            // 
            // GrdClientTbl
            // 
            this.GrdClientTbl.AllowUserToAddRows = false;
            this.GrdClientTbl.AllowUserToDeleteRows = false;
            this.GrdClientTbl.AllowUserToResizeRows = false;
            this.GrdClientTbl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GrdClientTbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GrdClientTbl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GrdClientTbl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdClientTbl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GrdClientTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrdClientTbl.DefaultCellStyle = dataGridViewCellStyle2;
            this.GrdClientTbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdClientTbl.EnableHeadersVisualStyles = false;
            this.GrdClientTbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GrdClientTbl.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GrdClientTbl.Location = new System.Drawing.Point(0, 0);
            this.GrdClientTbl.Name = "GrdClientTbl";
            this.GrdClientTbl.ReadOnly = true;
            this.GrdClientTbl.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdClientTbl.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GrdClientTbl.RowHeadersWidth = 51;
            this.GrdClientTbl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GrdClientTbl.RowTemplate.Height = 27;
            this.GrdClientTbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdClientTbl.Size = new System.Drawing.Size(867, 591);
            this.GrdClientTbl.TabIndex = 0;
            this.GrdClientTbl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdClientTbl_CellClick);
            // 
            // CboSort
            // 
            this.CboSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CboSort.FormattingEnabled = true;
            this.CboSort.Items.AddRange(new object[] {
            "제조업",
            "서비스업",
            "건설업",
            "무역업",
            "유통업"});
            this.CboSort.Location = new System.Drawing.Point(137, 282);
            this.CboSort.Name = "CboSort";
            this.CboSort.Size = new System.Drawing.Size(217, 23);
            this.CboSort.TabIndex = 13;
            // 
            // CboSituation
            // 
            this.CboSituation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CboSituation.FormattingEnabled = true;
            this.CboSituation.Items.AddRange(new object[] {
            "블랙기업",
            "거래 중",
            "거래중",
            "거래 중지",
            "파산/부도",
            "거래중지"});
            this.CboSituation.Location = new System.Drawing.Point(137, 344);
            this.CboSituation.Name = "CboSituation";
            this.CboSituation.Size = new System.Drawing.Size(218, 23);
            this.CboSituation.TabIndex = 12;
            // 
            // CboPersonnal
            // 
            this.CboPersonnal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CboPersonnal.FormattingEnabled = true;
            this.CboPersonnal.Items.AddRange(new object[] {
            "개인",
            "법인"});
            this.CboPersonnal.Location = new System.Drawing.Point(137, 91);
            this.CboPersonnal.Name = "CboPersonnal";
            this.CboPersonnal.Size = new System.Drawing.Size(218, 23);
            this.CboPersonnal.TabIndex = 12;
            // 
            // BtnNew
            // 
            this.BtnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNew.Location = new System.Drawing.Point(84, 407);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(119, 63);
            this.BtnNew.TabIndex = 11;
            this.BtnNew.Text = "신규";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.Location = new System.Drawing.Point(257, 407);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(119, 63);
            this.BtnSave.TabIndex = 11;
            this.BtnSave.Text = "등록";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TxtClientpart
            // 
            this.TxtClientpart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtClientpart.Location = new System.Drawing.Point(137, 313);
            this.TxtClientpart.Name = "TxtClientpart";
            this.TxtClientpart.Size = new System.Drawing.Size(218, 25);
            this.TxtClientpart.TabIndex = 9;
            // 
            // TxtClientOwner
            // 
            this.TxtClientOwner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtClientOwner.Location = new System.Drawing.Point(137, 182);
            this.TxtClientOwner.Name = "TxtClientOwner";
            this.TxtClientOwner.Size = new System.Drawing.Size(218, 25);
            this.TxtClientOwner.TabIndex = 5;
            // 
            // TxtClientName
            // 
            this.TxtClientName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtClientName.Location = new System.Drawing.Point(137, 151);
            this.TxtClientName.Name = "TxtClientName";
            this.TxtClientName.Size = new System.Drawing.Size(218, 25);
            this.TxtClientName.TabIndex = 4;
            // 
            // TxtClientphoneNum
            // 
            this.TxtClientphoneNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtClientphoneNum.Location = new System.Drawing.Point(137, 251);
            this.TxtClientphoneNum.Name = "TxtClientphoneNum";
            this.TxtClientphoneNum.Size = new System.Drawing.Size(218, 25);
            this.TxtClientphoneNum.TabIndex = 7;
            // 
            // TxtClientNumber
            // 
            this.TxtClientNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtClientNumber.Location = new System.Drawing.Point(137, 120);
            this.TxtClientNumber.Name = "TxtClientNumber";
            this.TxtClientNumber.Size = new System.Drawing.Size(218, 25);
            this.TxtClientNumber.TabIndex = 3;
            this.TxtClientNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtClientNumber_KeyDown);
            // 
            // TxtClientAddress
            // 
            this.TxtClientAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtClientAddress.Location = new System.Drawing.Point(137, 216);
            this.TxtClientAddress.Name = "TxtClientAddress";
            this.TxtClientAddress.Size = new System.Drawing.Size(218, 25);
            this.TxtClientAddress.TabIndex = 6;
            // 
            // TxtClientidx
            // 
            this.TxtClientidx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtClientidx.Location = new System.Drawing.Point(137, 58);
            this.TxtClientidx.Name = "TxtClientidx";
            this.TxtClientidx.ReadOnly = true;
            this.TxtClientidx.Size = new System.Drawing.Size(218, 25);
            this.TxtClientidx.TabIndex = 1;
            this.TxtClientidx.Visible = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(94, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "주소";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(92, 318);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "종목";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "대표자명";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(54, 348);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "거래처상태";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "등록번호";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(94, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "업종";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "거래처명";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "전화번호";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "사업자구분";
            // 
            // lblClienIndex
            // 
            this.lblClienIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClienIndex.AutoSize = true;
            this.lblClienIndex.Location = new System.Drawing.Point(56, 61);
            this.lblClienIndex.Name = "lblClienIndex";
            this.lblClienIndex.Size = new System.Drawing.Size(82, 15);
            this.lblClienIndex.TabIndex = 0;
            this.lblClienIndex.Text = "거래처번호";
            this.lblClienIndex.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "거래처등록";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1264, 591);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientForm";
            this.Text = "거래처 관리 시스템";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdClientTbl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroGrid GrdClientTbl;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox TxtClientpart;
        private System.Windows.Forms.TextBox TxtClientOwner;
        private System.Windows.Forms.TextBox TxtClientName;
        private System.Windows.Forms.TextBox TxtClientphoneNum;
        private System.Windows.Forms.TextBox TxtClientNumber;
        private System.Windows.Forms.TextBox TxtClientAddress;
        private System.Windows.Forms.TextBox TxtClientidx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblClienIndex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboPersonnal;
        private System.Windows.Forms.ComboBox CboSituation;
        private System.Windows.Forms.ComboBox CboSort;
    }
}