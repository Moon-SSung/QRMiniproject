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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.GrdEmployeeTbl = new MetroFramework.Controls.MetroGrid();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtPhoneNumber = new System.Windows.Forms.TextBox();
            this.TxtRank = new System.Windows.Forms.TextBox();
            this.TxtDepart = new System.Windows.Forms.TextBox();
            this.TxtIdentityNumber = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtcodeNumber = new System.Windows.Forms.TextBox();
            this.lblphoneNumber = new System.Windows.Forms.Label();
            this.lbllevel = new System.Windows.Forms.Label();
            this.lblcodeNumber = new System.Windows.Forms.Label();
            this.lblPart = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblmemberNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.splitContainer1.Panel2.Controls.Add(this.BtnNew);
            this.splitContainer1.Panel2.Controls.Add(this.BtnSave);
            this.splitContainer1.Panel2.Controls.Add(this.TxtPhoneNumber);
            this.splitContainer1.Panel2.Controls.Add(this.TxtRank);
            this.splitContainer1.Panel2.Controls.Add(this.TxtDepart);
            this.splitContainer1.Panel2.Controls.Add(this.TxtIdentityNumber);
            this.splitContainer1.Panel2.Controls.Add(this.TxtName);
            this.splitContainer1.Panel2.Controls.Add(this.TxtcodeNumber);
            this.splitContainer1.Panel2.Controls.Add(this.lblphoneNumber);
            this.splitContainer1.Panel2.Controls.Add(this.lbllevel);
            this.splitContainer1.Panel2.Controls.Add(this.lblcodeNumber);
            this.splitContainer1.Panel2.Controls.Add(this.lblPart);
            this.splitContainer1.Panel2.Controls.Add(this.lblName);
            this.splitContainer1.Panel2.Controls.Add(this.lblmemberNumber);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(812, 399);
            this.splitContainer1.SplitterDistance = 545;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdEmployeeTbl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GrdEmployeeTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrdEmployeeTbl.DefaultCellStyle = dataGridViewCellStyle5;
            this.GrdEmployeeTbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdEmployeeTbl.EnableHeadersVisualStyles = false;
            this.GrdEmployeeTbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GrdEmployeeTbl.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GrdEmployeeTbl.Location = new System.Drawing.Point(0, 0);
            this.GrdEmployeeTbl.Name = "GrdEmployeeTbl";
            this.GrdEmployeeTbl.ReadOnly = true;
            this.GrdEmployeeTbl.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdEmployeeTbl.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.GrdEmployeeTbl.RowHeadersWidth = 51;
            this.GrdEmployeeTbl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GrdEmployeeTbl.RowTemplate.Height = 27;
            this.GrdEmployeeTbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdEmployeeTbl.Size = new System.Drawing.Size(545, 399);
            this.GrdEmployeeTbl.TabIndex = 0;
            this.GrdEmployeeTbl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdEmployeeTbl_CellClick);
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(75, 326);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(77, 30);
            this.BtnNew.TabIndex = 7;
            this.BtnNew.Text = "신규";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(158, 326);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(77, 30);
            this.BtnSave.TabIndex = 7;
            this.BtnSave.Text = "등록";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TxtPhoneNumber
            // 
            this.TxtPhoneNumber.Location = new System.Drawing.Point(79, 255);
            this.TxtPhoneNumber.Name = "TxtPhoneNumber";
            this.TxtPhoneNumber.Size = new System.Drawing.Size(156, 25);
            this.TxtPhoneNumber.TabIndex = 6;
            // 
            // TxtRank
            // 
            this.TxtRank.Location = new System.Drawing.Point(79, 216);
            this.TxtRank.Name = "TxtRank";
            this.TxtRank.Size = new System.Drawing.Size(156, 25);
            this.TxtRank.TabIndex = 5;
            // 
            // TxtDepart
            // 
            this.TxtDepart.Location = new System.Drawing.Point(79, 177);
            this.TxtDepart.Name = "TxtDepart";
            this.TxtDepart.Size = new System.Drawing.Size(156, 25);
            this.TxtDepart.TabIndex = 4;
            // 
            // TxtIdentityNumber
            // 
            this.TxtIdentityNumber.Location = new System.Drawing.Point(79, 138);
            this.TxtIdentityNumber.Name = "TxtIdentityNumber";
            this.TxtIdentityNumber.Size = new System.Drawing.Size(156, 25);
            this.TxtIdentityNumber.TabIndex = 3;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(79, 99);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(156, 25);
            this.TxtName.TabIndex = 2;
            // 
            // TxtcodeNumber
            // 
            this.TxtcodeNumber.Location = new System.Drawing.Point(79, 63);
            this.TxtcodeNumber.Name = "TxtcodeNumber";
            this.TxtcodeNumber.Size = new System.Drawing.Size(156, 25);
            this.TxtcodeNumber.TabIndex = 1;
            // 
            // lblphoneNumber
            // 
            this.lblphoneNumber.AutoSize = true;
            this.lblphoneNumber.Location = new System.Drawing.Point(21, 258);
            this.lblphoneNumber.Name = "lblphoneNumber";
            this.lblphoneNumber.Size = new System.Drawing.Size(52, 15);
            this.lblphoneNumber.TabIndex = 0;
            this.lblphoneNumber.Text = "연락처";
            // 
            // lbllevel
            // 
            this.lbllevel.AutoSize = true;
            this.lbllevel.Location = new System.Drawing.Point(32, 219);
            this.lbllevel.Name = "lbllevel";
            this.lbllevel.Size = new System.Drawing.Size(37, 15);
            this.lbllevel.TabIndex = 0;
            this.lbllevel.Text = "직급";
            // 
            // lblcodeNumber
            // 
            this.lblcodeNumber.AutoSize = true;
            this.lblcodeNumber.Location = new System.Drawing.Point(6, 141);
            this.lblcodeNumber.Name = "lblcodeNumber";
            this.lblcodeNumber.Size = new System.Drawing.Size(67, 15);
            this.lblcodeNumber.TabIndex = 0;
            this.lblcodeNumber.Text = "주민번호";
            // 
            // lblPart
            // 
            this.lblPart.AutoSize = true;
            this.lblPart.Location = new System.Drawing.Point(32, 177);
            this.lblPart.Name = "lblPart";
            this.lblPart.Size = new System.Drawing.Size(37, 15);
            this.lblPart.TabIndex = 0;
            this.lblPart.Text = "부서";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(32, 102);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "성명";
            // 
            // lblmemberNumber
            // 
            this.lblmemberNumber.AutoSize = true;
            this.lblmemberNumber.Location = new System.Drawing.Point(6, 66);
            this.lblmemberNumber.Name = "lblmemberNumber";
            this.lblmemberNumber.Size = new System.Drawing.Size(67, 15);
            this.lblmemberNumber.TabIndex = 0;
            this.lblmemberNumber.Text = "사원번호";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "사원등록";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 479);
            this.Controls.Add(this.splitContainer1);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
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
        private System.Windows.Forms.TextBox TxtRank;
        private System.Windows.Forms.TextBox TxtDepart;
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
    }
}