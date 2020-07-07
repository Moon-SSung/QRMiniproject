namespace QRMiniproject
{
    partial class MainForm2
    {
        /// <summary>
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm2));
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.LblUserName = new System.Windows.Forms.Label();
            this.LblUserCode = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LblUserID = new System.Windows.Forms.Label();
            this.BtnLogOut = new System.Windows.Forms.Button();
            this.BtnInOut = new System.Windows.Forms.Button();
            this.BtnOutPut = new System.Windows.Forms.Button();
            this.BtnInPut = new System.Windows.Forms.Button();
            this.ProductManaged = new System.Windows.Forms.Button();
            this.ClientManaged = new System.Windows.Forms.Button();
            this.EmployeeManaged = new System.Windows.Forms.Button();
            this.BtnMain = new System.Windows.Forms.PictureBox();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMain)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.MenuVertical.Controls.Add(this.LblUserName);
            this.MenuVertical.Controls.Add(this.LblUserCode);
            this.MenuVertical.Controls.Add(this.pictureBox2);
            this.MenuVertical.Controls.Add(this.LblUserID);
            this.MenuVertical.Controls.Add(this.BtnLogOut);
            this.MenuVertical.Controls.Add(this.BtnInOut);
            this.MenuVertical.Controls.Add(this.BtnOutPut);
            this.MenuVertical.Controls.Add(this.BtnInPut);
            this.MenuVertical.Controls.Add(this.ProductManaged);
            this.MenuVertical.Controls.Add(this.ClientManaged);
            this.MenuVertical.Controls.Add(this.EmployeeManaged);
            this.MenuVertical.Controls.Add(this.BtnMain);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(333, 750);
            this.MenuVertical.TabIndex = 0;
            // 
            // LblUserName
            // 
            this.LblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblUserName.AutoSize = true;
            this.LblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserName.ForeColor = System.Drawing.Color.White;
            this.LblUserName.Location = new System.Drawing.Point(102, 708);
            this.LblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(57, 20);
            this.LblUserName.TabIndex = 16;
            this.LblUserName.Text = "사원이름";
            // 
            // LblUserCode
            // 
            this.LblUserCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblUserCode.AutoSize = true;
            this.LblUserCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserCode.ForeColor = System.Drawing.Color.White;
            this.LblUserCode.Location = new System.Drawing.Point(102, 688);
            this.LblUserCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblUserCode.Name = "LblUserCode";
            this.LblUserCode.Size = new System.Drawing.Size(57, 20);
            this.LblUserCode.TabIndex = 16;
            this.LblUserCode.Text = "사원번호";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1, 669);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(93, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // LblUserID
            // 
            this.LblUserID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblUserID.AutoSize = true;
            this.LblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserID.ForeColor = System.Drawing.Color.White;
            this.LblUserID.Location = new System.Drawing.Point(102, 669);
            this.LblUserID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblUserID.Name = "LblUserID";
            this.LblUserID.Size = new System.Drawing.Size(81, 20);
            this.LblUserID.TabIndex = 14;
            this.LblUserID.Text = "사용자아이디";
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.FlatAppearance.BorderSize = 0;
            this.BtnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogOut.ForeColor = System.Drawing.Color.White;
            this.BtnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("BtnLogOut.Image")));
            this.BtnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogOut.Location = new System.Drawing.Point(0, 463);
            this.BtnLogOut.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(333, 46);
            this.BtnLogOut.TabIndex = 6;
            this.BtnLogOut.Text = "Logout";
            this.BtnLogOut.UseVisualStyleBackColor = true;
            this.BtnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // BtnInOut
            // 
            this.BtnInOut.FlatAppearance.BorderSize = 0;
            this.BtnInOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnInOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInOut.ForeColor = System.Drawing.Color.White;
            this.BtnInOut.Image = ((System.Drawing.Image)(resources.GetObject("BtnInOut.Image")));
            this.BtnInOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInOut.Location = new System.Drawing.Point(0, 411);
            this.BtnInOut.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnInOut.Name = "BtnInOut";
            this.BtnInOut.Size = new System.Drawing.Size(333, 46);
            this.BtnInOut.TabIndex = 6;
            this.BtnInOut.Text = "In && Out Status";
            this.BtnInOut.UseVisualStyleBackColor = true;
            this.BtnInOut.Click += new System.EventHandler(this.BtnInOut_Click);
            // 
            // BtnOutPut
            // 
            this.BtnOutPut.FlatAppearance.BorderSize = 0;
            this.BtnOutPut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnOutPut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOutPut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOutPut.ForeColor = System.Drawing.Color.White;
            this.BtnOutPut.Image = ((System.Drawing.Image)(resources.GetObject("BtnOutPut.Image")));
            this.BtnOutPut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOutPut.Location = new System.Drawing.Point(0, 358);
            this.BtnOutPut.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnOutPut.Name = "BtnOutPut";
            this.BtnOutPut.Size = new System.Drawing.Size(333, 46);
            this.BtnOutPut.TabIndex = 5;
            this.BtnOutPut.Text = "Forwarding Manage";
            this.BtnOutPut.UseVisualStyleBackColor = true;
            this.BtnOutPut.Click += new System.EventHandler(this.BtnOutPut_Click);
            // 
            // BtnInPut
            // 
            this.BtnInPut.FlatAppearance.BorderSize = 0;
            this.BtnInPut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnInPut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInPut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInPut.ForeColor = System.Drawing.Color.White;
            this.BtnInPut.Image = ((System.Drawing.Image)(resources.GetObject("BtnInPut.Image")));
            this.BtnInPut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInPut.Location = new System.Drawing.Point(0, 305);
            this.BtnInPut.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnInPut.Name = "BtnInPut";
            this.BtnInPut.Size = new System.Drawing.Size(333, 46);
            this.BtnInPut.TabIndex = 4;
            this.BtnInPut.Text = "Receiving Manage";
            this.BtnInPut.UseVisualStyleBackColor = true;
            this.BtnInPut.Click += new System.EventHandler(this.BtnInPut_Click);
            // 
            // ProductManaged
            // 
            this.ProductManaged.FlatAppearance.BorderSize = 0;
            this.ProductManaged.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ProductManaged.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductManaged.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductManaged.ForeColor = System.Drawing.Color.White;
            this.ProductManaged.Image = ((System.Drawing.Image)(resources.GetObject("ProductManaged.Image")));
            this.ProductManaged.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProductManaged.Location = new System.Drawing.Point(0, 252);
            this.ProductManaged.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ProductManaged.Name = "ProductManaged";
            this.ProductManaged.Size = new System.Drawing.Size(333, 46);
            this.ProductManaged.TabIndex = 3;
            this.ProductManaged.Text = "Product Manage";
            this.ProductManaged.UseVisualStyleBackColor = true;
            this.ProductManaged.Click += new System.EventHandler(this.ProductManaged_Click);
            // 
            // ClientManaged
            // 
            this.ClientManaged.FlatAppearance.BorderSize = 0;
            this.ClientManaged.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientManaged.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientManaged.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientManaged.ForeColor = System.Drawing.Color.White;
            this.ClientManaged.Image = ((System.Drawing.Image)(resources.GetObject("ClientManaged.Image")));
            this.ClientManaged.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClientManaged.Location = new System.Drawing.Point(0, 198);
            this.ClientManaged.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ClientManaged.Name = "ClientManaged";
            this.ClientManaged.Size = new System.Drawing.Size(333, 46);
            this.ClientManaged.TabIndex = 2;
            this.ClientManaged.Text = "Client Manage";
            this.ClientManaged.UseVisualStyleBackColor = true;
            this.ClientManaged.Click += new System.EventHandler(this.ClientManaged_Click);
            // 
            // EmployeeManaged
            // 
            this.EmployeeManaged.FlatAppearance.BorderSize = 0;
            this.EmployeeManaged.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.EmployeeManaged.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmployeeManaged.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeManaged.ForeColor = System.Drawing.Color.White;
            this.EmployeeManaged.Image = ((System.Drawing.Image)(resources.GetObject("EmployeeManaged.Image")));
            this.EmployeeManaged.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmployeeManaged.Location = new System.Drawing.Point(0, 145);
            this.EmployeeManaged.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EmployeeManaged.Name = "EmployeeManaged";
            this.EmployeeManaged.Size = new System.Drawing.Size(333, 46);
            this.EmployeeManaged.TabIndex = 1;
            this.EmployeeManaged.Text = "Employee Manage";
            this.EmployeeManaged.UseVisualStyleBackColor = true;
            this.EmployeeManaged.Click += new System.EventHandler(this.EmployeeManaged_Click);
            // 
            // BtnMain
            // 
            this.BtnMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMain.Image = ((System.Drawing.Image)(resources.GetObject("BtnMain.Image")));
            this.BtnMain.Location = new System.Drawing.Point(4, 7);
            this.BtnMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnMain.Name = "BtnMain";
            this.BtnMain.Size = new System.Drawing.Size(339, 88);
            this.BtnMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMain.TabIndex = 0;
            this.BtnMain.TabStop = false;
            this.BtnMain.Click += new System.EventHandler(this.BtnMain_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(333, 0);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1400, 750);
            this.panelContainer.TabIndex = 2;
            // 
            // MainForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1733, 750);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm2";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm2_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuVertical.ResumeLayout(false);
            this.MenuVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.PictureBox BtnMain;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button EmployeeManaged;
        private System.Windows.Forms.Button BtnInOut;
        private System.Windows.Forms.Button BtnOutPut;
        private System.Windows.Forms.Button BtnInPut;
        private System.Windows.Forms.Button ProductManaged;
        private System.Windows.Forms.Button ClientManaged;
        private System.Windows.Forms.Label LblUserCode;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LblUserID;
        private System.Windows.Forms.Button BtnLogOut;
        private System.Windows.Forms.Label LblUserName;
    }
}

