namespace QRMiniproject
{
    partial class EmployeeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.GrdEmployeeTbl = new MetroFramework.Controls.MetroGrid();
            this.CboRank = new System.Windows.Forms.ComboBox();
            this.CboDepart = new System.Windows.Forms.ComboBox();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtUserId = new System.Windows.Forms.TextBox();
            this.TxtPhoneNumber = new System.Windows.Forms.TextBox();
            this.TxtIdentityNumber = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtPW = new System.Windows.Forms.Label();
            this.TxtcodeNumber = new System.Windows.Forms.TextBox();
            this.TxtID = new System.Windows.Forms.Label();
            this.lblphoneNumber = new System.Windows.Forms.Label();
            this.lbllevel = new System.Windows.Forms.Label();
            this.lblcodeNumber = new System.Windows.Forms.Label();
            this.lblPart = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblmemberNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtEmpCode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdEmployeeTbl)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.GrdEmployeeTbl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.CboRank);
            this.splitContainer1.Panel2.Controls.Add(this.CboDepart);
            this.splitContainer1.Panel2.Controls.Add(this.BtnNew);
            this.splitContainer1.Panel2.Controls.Add(this.BtnSave);
            this.splitContainer1.Panel2.Controls.Add(this.TxtPassword);
            this.splitContainer1.Panel2.Controls.Add(this.TxtUserId);
            this.splitContainer1.Panel2.Controls.Add(this.TxtPhoneNumber);
            this.splitContainer1.Panel2.Controls.Add(this.TxtIdentityNumber);
            this.splitContainer1.Panel2.Controls.Add(this.TxtName);
            this.splitContainer1.Panel2.Controls.Add(this.TxtPW);
            this.splitContainer1.Panel2.Controls.Add(this.TxtEmpCode);
            this.splitContainer1.Panel2.Controls.Add(this.TxtcodeNumber);
            this.splitContainer1.Panel2.Controls.Add(this.TxtID);
            this.splitContainer1.Panel2.Controls.Add(this.lblphoneNumber);
            this.splitContainer1.Panel2.Controls.Add(this.lbllevel);
            this.splitContainer1.Panel2.Controls.Add(this.lblcodeNumber);
            this.splitContainer1.Panel2.Controls.Add(this.lblPart);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.lblName);
            this.splitContainer1.Panel2.Controls.Add(this.lblmemberNumber);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.splitContainer1.Size = new System.Drawing.Size(1220, 517);
            this.splitContainer1.SplitterDistance = 818;
            this.splitContainer1.TabIndex = 1;
            // 
            // GrdEmployeeTbl
            // 
            this.GrdEmployeeTbl.AllowUserToAddRows = false;
            this.GrdEmployeeTbl.AllowUserToDeleteRows = false;
            this.GrdEmployeeTbl.AllowUserToResizeRows = false;
            this.GrdEmployeeTbl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GrdEmployeeTbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GrdEmployeeTbl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GrdEmployeeTbl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdEmployeeTbl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.GrdEmployeeTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrdEmployeeTbl.DefaultCellStyle = dataGridViewCellStyle8;
            this.GrdEmployeeTbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdEmployeeTbl.EnableHeadersVisualStyles = false;
            this.GrdEmployeeTbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GrdEmployeeTbl.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GrdEmployeeTbl.Location = new System.Drawing.Point(0, 0);
            this.GrdEmployeeTbl.Name = "GrdEmployeeTbl";
            this.GrdEmployeeTbl.ReadOnly = true;
            this.GrdEmployeeTbl.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdEmployeeTbl.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.GrdEmployeeTbl.RowHeadersWidth = 51;
            this.GrdEmployeeTbl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GrdEmployeeTbl.RowTemplate.Height = 27;
            this.GrdEmployeeTbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdEmployeeTbl.Size = new System.Drawing.Size(818, 517);
            this.GrdEmployeeTbl.TabIndex = 0;
            this.GrdEmployeeTbl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdEmployeeTbl_CellClick);
            // 
            // CboRank
            // 
            this.CboRank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CboRank.FormattingEnabled = true;
            this.CboRank.Items.AddRange(new object[] {
            "사원",
            "대리",
            "과장",
            "차장",
            "부장",
            "전무",
            "상무",
            "이사",
            "주임"});
            this.CboRank.Location = new System.Drawing.Point(140, 241);
            this.CboRank.Name = "CboRank";
            this.CboRank.Size = new System.Drawing.Size(220, 23);
            this.CboRank.TabIndex = 12;
            // 
            // CboDepart
            // 
            this.CboDepart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CboDepart.FormattingEnabled = true;
            this.CboDepart.Items.AddRange(new object[] {
            "영업팀",
            "재무팀",
            "인사팀",
            "생산팀",
            "영업팀",
            "전산팀",
            "개발팀",
            "경영지원팀",
            "채권관리팀"});
            this.CboDepart.Location = new System.Drawing.Point(140, 202);
            this.CboDepart.Name = "CboDepart";
            this.CboDepart.Size = new System.Drawing.Size(220, 23);
            this.CboDepart.TabIndex = 12;
            // 
            // BtnNew
            // 
            this.BtnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNew.Location = new System.Drawing.Point(79, 418);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(119, 63);
            this.BtnNew.TabIndex = 9;
            this.BtnNew.Text = "신규";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.Location = new System.Drawing.Point(241, 418);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(119, 63);
            this.BtnSave.TabIndex = 10;
            this.BtnSave.Text = "등록";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPassword.Location = new System.Drawing.Point(140, 358);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(220, 25);
            this.TxtPassword.TabIndex = 8;
            // 
            // TxtUserId
            // 
            this.TxtUserId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtUserId.Location = new System.Drawing.Point(140, 319);
            this.TxtUserId.Name = "TxtUserId";
            this.TxtUserId.Size = new System.Drawing.Size(220, 25);
            this.TxtUserId.TabIndex = 7;
            // 
            // TxtPhoneNumber
            // 
            this.TxtPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPhoneNumber.Location = new System.Drawing.Point(140, 278);
            this.TxtPhoneNumber.Name = "TxtPhoneNumber";
            this.TxtPhoneNumber.Size = new System.Drawing.Size(220, 25);
            this.TxtPhoneNumber.TabIndex = 6;
            // 
            // TxtIdentityNumber
            // 
            this.TxtIdentityNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtIdentityNumber.Location = new System.Drawing.Point(140, 161);
            this.TxtIdentityNumber.Name = "TxtIdentityNumber";
            this.TxtIdentityNumber.Size = new System.Drawing.Size(220, 25);
            this.TxtIdentityNumber.TabIndex = 3;
            // 
            // TxtName
            // 
            this.TxtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtName.Location = new System.Drawing.Point(140, 122);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(220, 25);
            this.TxtName.TabIndex = 2;
            // 
            // TxtPW
            // 
            this.TxtPW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPW.AutoSize = true;
            this.TxtPW.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TxtPW.Location = new System.Drawing.Point(44, 363);
            this.TxtPW.Name = "TxtPW";
            this.TxtPW.Size = new System.Drawing.Size(71, 15);
            this.TxtPW.TabIndex = 0;
            this.TxtPW.Text = "패스워드";
            // 
            // TxtcodeNumber
            // 
            this.TxtcodeNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtcodeNumber.Location = new System.Drawing.Point(140, 86);
            this.TxtcodeNumber.Name = "TxtcodeNumber";
            this.TxtcodeNumber.Size = new System.Drawing.Size(220, 25);
            this.TxtcodeNumber.TabIndex = 1;
            this.TxtcodeNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtcodeNumber_KeyDown);
            // 
            // TxtID
            // 
            this.TxtID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtID.AutoSize = true;
            this.TxtID.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TxtID.Location = new System.Drawing.Point(60, 324);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(55, 15);
            this.TxtID.TabIndex = 0;
            this.TxtID.Text = "아이디";
            // 
            // lblphoneNumber
            // 
            this.lblphoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblphoneNumber.AutoSize = true;
            this.lblphoneNumber.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblphoneNumber.Location = new System.Drawing.Point(60, 283);
            this.lblphoneNumber.Name = "lblphoneNumber";
            this.lblphoneNumber.Size = new System.Drawing.Size(55, 15);
            this.lblphoneNumber.TabIndex = 0;
            this.lblphoneNumber.Text = "연락처";
            // 
            // lbllevel
            // 
            this.lbllevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbllevel.AutoSize = true;
            this.lbllevel.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbllevel.Location = new System.Drawing.Point(76, 244);
            this.lbllevel.Name = "lbllevel";
            this.lbllevel.Size = new System.Drawing.Size(39, 15);
            this.lbllevel.TabIndex = 0;
            this.lbllevel.Text = "직급";
            // 
            // lblcodeNumber
            // 
            this.lblcodeNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblcodeNumber.AutoSize = true;
            this.lblcodeNumber.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblcodeNumber.Location = new System.Drawing.Point(44, 166);
            this.lblcodeNumber.Name = "lblcodeNumber";
            this.lblcodeNumber.Size = new System.Drawing.Size(71, 15);
            this.lblcodeNumber.TabIndex = 0;
            this.lblcodeNumber.Text = "주민번호";
            // 
            // lblPart
            // 
            this.lblPart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPart.AutoSize = true;
            this.lblPart.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPart.Location = new System.Drawing.Point(76, 205);
            this.lblPart.Name = "lblPart";
            this.lblPart.Size = new System.Drawing.Size(39, 15);
            this.lblPart.TabIndex = 0;
            this.lblPart.Text = "부서";
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblName.Location = new System.Drawing.Point(76, 125);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "성명";
            // 
            // lblmemberNumber
            // 
            this.lblmemberNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblmemberNumber.AutoSize = true;
            this.lblmemberNumber.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblmemberNumber.Location = new System.Drawing.Point(44, 89);
            this.lblmemberNumber.Name = "lblmemberNumber";
            this.lblmemberNumber.Size = new System.Drawing.Size(71, 15);
            this.lblmemberNumber.TabIndex = 0;
            this.lblmemberNumber.Text = "사원번호";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(23, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "사원등록";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(44, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "사원번호";
            this.label2.Visible = false;
            // 
            // TxtEmpCode
            // 
            this.TxtEmpCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtEmpCode.Enabled = false;
            this.TxtEmpCode.Location = new System.Drawing.Point(140, 55);
            this.TxtEmpCode.Name = "TxtEmpCode";
            this.TxtEmpCode.Size = new System.Drawing.Size(220, 25);
            this.TxtEmpCode.TabIndex = 1;
            this.TxtEmpCode.Visible = false;
            this.TxtEmpCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtcodeNumber_KeyDown);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 597);
            this.Controls.Add(this.splitContainer1);
            this.Name = "EmployeeForm";
            this.Resizable = false;
            this.Text = "직원관리시스템";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdEmployeeTbl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroGrid GrdEmployeeTbl;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox TxtPhoneNumber;
        private System.Windows.Forms.TextBox TxtIdentityNumber;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtcodeNumber;
        private System.Windows.Forms.Label lblphoneNumber;
        private System.Windows.Forms.Label lbllevel;
        private System.Windows.Forms.Label lblcodeNumber;
        private System.Windows.Forms.Label lblPart;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblmemberNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtUserId;
        private System.Windows.Forms.Label TxtPW;
        private System.Windows.Forms.Label TxtID;
        private System.Windows.Forms.ComboBox CboDepart;
        private System.Windows.Forms.ComboBox CboRank;
        private System.Windows.Forms.TextBox TxtEmpCode;
        private System.Windows.Forms.Label label2;
    }
}