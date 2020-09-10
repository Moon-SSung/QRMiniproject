namespace ConsoleApp10
{
    partial class Form1
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
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.ResetBT = new System.Windows.Forms.Button();
            this.ISBNtxt = new System.Windows.Forms.TextBox();
            this.BookNametxt = new System.Windows.Forms.TextBox();
            this.Publishertxt = new System.Windows.Forms.TextBox();
            this.PageTxt = new System.Windows.Forms.TextBox();
            this.AddBT = new System.Windows.Forms.Button();
            this.ChangeBT = new System.Windows.Forms.Button();
            this.DeleteBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid
            // 
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Location = new System.Drawing.Point(12, 12);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.RowHeadersWidth = 51;
            this.DataGrid.RowTemplate.Height = 27;
            this.DataGrid.Size = new System.Drawing.Size(596, 401);
            this.DataGrid.TabIndex = 0;
            this.DataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellClick);
            // 
            // ResetBT
            // 
            this.ResetBT.Font = new System.Drawing.Font("굴림", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ResetBT.Location = new System.Drawing.Point(912, 12);
            this.ResetBT.Name = "ResetBT";
            this.ResetBT.Size = new System.Drawing.Size(58, 28);
            this.ResetBT.TabIndex = 1;
            this.ResetBT.Text = "초기화";
            this.ResetBT.UseVisualStyleBackColor = true;
            this.ResetBT.Click += new System.EventHandler(this.button1_Click);
            // 
            // ISBNtxt
            // 
            this.ISBNtxt.Location = new System.Drawing.Point(748, 114);
            this.ISBNtxt.Name = "ISBNtxt";
            this.ISBNtxt.Size = new System.Drawing.Size(175, 25);
            this.ISBNtxt.TabIndex = 2;
            // 
            // BookNametxt
            // 
            this.BookNametxt.Location = new System.Drawing.Point(748, 145);
            this.BookNametxt.Name = "BookNametxt";
            this.BookNametxt.Size = new System.Drawing.Size(175, 25);
            this.BookNametxt.TabIndex = 2;
            // 
            // Publishertxt
            // 
            this.Publishertxt.Location = new System.Drawing.Point(748, 176);
            this.Publishertxt.Name = "Publishertxt";
            this.Publishertxt.Size = new System.Drawing.Size(175, 25);
            this.Publishertxt.TabIndex = 2;
            // 
            // PageTxt
            // 
            this.PageTxt.Location = new System.Drawing.Point(748, 207);
            this.PageTxt.Name = "PageTxt";
            this.PageTxt.Size = new System.Drawing.Size(175, 25);
            this.PageTxt.TabIndex = 2;
            // 
            // AddBT
            // 
            this.AddBT.Location = new System.Drawing.Point(674, 283);
            this.AddBT.Name = "AddBT";
            this.AddBT.Size = new System.Drawing.Size(80, 32);
            this.AddBT.TabIndex = 3;
            this.AddBT.Text = "추가";
            this.AddBT.UseVisualStyleBackColor = true;
            this.AddBT.Click += new System.EventHandler(this.AddBT_Click);
            // 
            // ChangeBT
            // 
            this.ChangeBT.Location = new System.Drawing.Point(760, 283);
            this.ChangeBT.Name = "ChangeBT";
            this.ChangeBT.Size = new System.Drawing.Size(82, 32);
            this.ChangeBT.TabIndex = 3;
            this.ChangeBT.Text = "수정";
            this.ChangeBT.UseVisualStyleBackColor = true;
            this.ChangeBT.Click += new System.EventHandler(this.ChangeBT_Click);
            // 
            // DeleteBT
            // 
            this.DeleteBT.Location = new System.Drawing.Point(848, 283);
            this.DeleteBT.Name = "DeleteBT";
            this.DeleteBT.Size = new System.Drawing.Size(75, 32);
            this.DeleteBT.TabIndex = 3;
            this.DeleteBT.Text = "삭제";
            this.DeleteBT.UseVisualStyleBackColor = true;
            this.DeleteBT.Click += new System.EventHandler(this.DeleteBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(672, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "LSBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(669, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "도서이름";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(670, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "출판사";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(670, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "페이지";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteBT);
            this.Controls.Add(this.ChangeBT);
            this.Controls.Add(this.AddBT);
            this.Controls.Add(this.PageTxt);
            this.Controls.Add(this.Publishertxt);
            this.Controls.Add(this.BookNametxt);
            this.Controls.Add(this.ISBNtxt);
            this.Controls.Add(this.ResetBT);
            this.Controls.Add(this.DataGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.Button ResetBT;
        private System.Windows.Forms.TextBox ISBNtxt;
        private System.Windows.Forms.TextBox BookNametxt;
        private System.Windows.Forms.TextBox Publishertxt;
        private System.Windows.Forms.TextBox PageTxt;
        private System.Windows.Forms.Button AddBT;
        private System.Windows.Forms.Button ChangeBT;
        private System.Windows.Forms.Button DeleteBT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}