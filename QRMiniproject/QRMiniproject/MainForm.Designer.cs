﻿namespace QRMiniproject
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ClientManaged = new System.Windows.Forms.Button();
            this.BtnInOutPut = new System.Windows.Forms.Button();
            this.EmployeeManaged = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "QR코드를 이용한 입출고 관리시스템";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(302, 364);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 49);
            this.button6.TabIndex = 2;
            this.button6.Text = "QR코드관리";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(136, 364);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 49);
            this.button5.TabIndex = 3;
            this.button5.Text = "품목관리";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(302, 271);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 50);
            this.button4.TabIndex = 4;
            this.button4.Text = "출고현황";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // ClientManaged
            // 
            this.ClientManaged.Location = new System.Drawing.Point(136, 271);
            this.ClientManaged.Name = "ClientManaged";
            this.ClientManaged.Size = new System.Drawing.Size(100, 50);
            this.ClientManaged.TabIndex = 5;
            this.ClientManaged.Text = "거래처관리";
            this.ClientManaged.UseVisualStyleBackColor = true;
            this.ClientManaged.Click += new System.EventHandler(this.ClientManaged_Click);
            // 
            // BtnInOutPut
            // 
            this.BtnInOutPut.Location = new System.Drawing.Point(302, 191);
            this.BtnInOutPut.Name = "BtnInOutPut";
            this.BtnInOutPut.Size = new System.Drawing.Size(100, 50);
            this.BtnInOutPut.TabIndex = 6;
            this.BtnInOutPut.Text = "입.출관리";
            this.BtnInOutPut.UseVisualStyleBackColor = true;
            // 
            // EmployeeManaged
            // 
            this.EmployeeManaged.Location = new System.Drawing.Point(136, 191);
            this.EmployeeManaged.Name = "EmployeeManaged";
            this.EmployeeManaged.Size = new System.Drawing.Size(100, 50);
            this.EmployeeManaged.TabIndex = 7;
            this.EmployeeManaged.Text = "사원관리";
            this.EmployeeManaged.UseVisualStyleBackColor = true;
            this.EmployeeManaged.Click += new System.EventHandler(this.EmployeeManaged_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 499);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ClientManaged);
            this.Controls.Add(this.BtnInOutPut);
            this.Controls.Add(this.EmployeeManaged);
            this.Name = "MainForm";
            this.Text = "QR";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button ClientManaged;
        private System.Windows.Forms.Button BtnInOutPut;
        private System.Windows.Forms.Button EmployeeManaged;
    }
}

