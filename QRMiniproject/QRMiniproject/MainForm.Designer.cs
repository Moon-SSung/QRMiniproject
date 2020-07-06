
using System.Drawing;

namespace QRMiniproject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.ProductManaged = new System.Windows.Forms.Button();
            this.BtnInOut = new System.Windows.Forms.Button();
            this.BtnOutPut = new System.Windows.Forms.Button();
            this.ClientManaged = new System.Windows.Forms.Button();
            this.BtnInPut = new System.Windows.Forms.Button();
            this.EmployeeManaged = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LblUserID = new System.Windows.Forms.Label();
            this.BtnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "QR코드를 이용한 입출고 관리시스템";
            // 
            // ProductManaged
            // 
            this.ProductManaged.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ProductManaged.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ProductManaged.Image = ((System.Drawing.Image)(resources.GetObject("ProductManaged.Image")));
            this.ProductManaged.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProductManaged.Location = new System.Drawing.Point(135, 437);
            this.ProductManaged.Name = "ProductManaged";
            this.ProductManaged.Size = new System.Drawing.Size(140, 70);
            this.ProductManaged.TabIndex = 3;
            this.ProductManaged.Text = "품목관리";
            this.ProductManaged.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ProductManaged.UseVisualStyleBackColor = true;
            this.ProductManaged.Click += new System.EventHandler(this.ProductManaged_Click);
            // 
            // BtnInOut
            // 
            this.BtnInOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnInOut.Image = ((System.Drawing.Image)(resources.GetObject("BtnInOut.Image")));
            this.BtnInOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInOut.Location = new System.Drawing.Point(380, 437);
            this.BtnInOut.Name = "BtnInOut";
            this.BtnInOut.Size = new System.Drawing.Size(140, 70);
            this.BtnInOut.TabIndex = 2;
            this.BtnInOut.Text = "입출현황";
            this.BtnInOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnInOut.UseVisualStyleBackColor = true;
            this.BtnInOut.Click += new System.EventHandler(this.BtnInOut_Click);
            // 
            // BtnOutPut
            // 
            this.BtnOutPut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnOutPut.Font = new System.Drawing.Font("맑은 고딕", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnOutPut.Image = ((System.Drawing.Image)(resources.GetObject("BtnOutPut.Image")));
            this.BtnOutPut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOutPut.Location = new System.Drawing.Point(380, 300);
            this.BtnOutPut.Name = "BtnOutPut";
            this.BtnOutPut.Size = new System.Drawing.Size(140, 70);
            this.BtnOutPut.TabIndex = 4;
            this.BtnOutPut.Text = "출고관리";
            this.BtnOutPut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnOutPut.UseVisualStyleBackColor = true;
            this.BtnOutPut.Click += new System.EventHandler(this.BtnOutPut_Click);
            // 
            // ClientManaged
            // 
            this.ClientManaged.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClientManaged.Font = new System.Drawing.Font("맑은 고딕", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ClientManaged.Image = ((System.Drawing.Image)(resources.GetObject("ClientManaged.Image")));
            this.ClientManaged.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClientManaged.Location = new System.Drawing.Point(135, 300);
            this.ClientManaged.Name = "ClientManaged";
            this.ClientManaged.Size = new System.Drawing.Size(140, 70);
            this.ClientManaged.TabIndex = 5;
            this.ClientManaged.Text = "거래처관리";
            this.ClientManaged.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ClientManaged.UseVisualStyleBackColor = true;
            this.ClientManaged.Click += new System.EventHandler(this.ClientManaged_Click);
            // 
            // BtnInPut
            // 
            this.BtnInPut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnInPut.Font = new System.Drawing.Font("맑은 고딕", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnInPut.Image = ((System.Drawing.Image)(resources.GetObject("BtnInPut.Image")));
            this.BtnInPut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInPut.Location = new System.Drawing.Point(380, 178);
            this.BtnInPut.Name = "BtnInPut";
            this.BtnInPut.Size = new System.Drawing.Size(140, 70);
            this.BtnInPut.TabIndex = 6;
            this.BtnInPut.Text = "입고관리";
            this.BtnInPut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnInPut.UseVisualStyleBackColor = true;
            this.BtnInPut.Click += new System.EventHandler(this.BtnInPut_Click);
            // 
            // EmployeeManaged
            // 
            this.EmployeeManaged.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EmployeeManaged.Font = new System.Drawing.Font("맑은 고딕", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EmployeeManaged.Image = ((System.Drawing.Image)(resources.GetObject("EmployeeManaged.Image")));
            this.EmployeeManaged.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmployeeManaged.Location = new System.Drawing.Point(135, 178);
            this.EmployeeManaged.Name = "EmployeeManaged";
            this.EmployeeManaged.Size = new System.Drawing.Size(140, 70);
            this.EmployeeManaged.TabIndex = 7;
            this.EmployeeManaged.Text = "직원관리";
            this.EmployeeManaged.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EmployeeManaged.UseVisualStyleBackColor = true;
            this.EmployeeManaged.Click += new System.EventHandler(this.EmployeeManaged_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "접속아이디 :";
            // 
            // LblUserID
            // 
            this.LblUserID.AutoSize = true;
            this.LblUserID.Location = new System.Drawing.Point(234, 32);
            this.LblUserID.Name = "LblUserID";
            this.LblUserID.Size = new System.Drawing.Size(67, 15);
            this.LblUserID.TabIndex = 10;
            this.LblUserID.Text = "에헤헤헿";
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.Location = new System.Drawing.Point(258, 513);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(140, 48);
            this.BtnLogOut.TabIndex = 11;
            this.BtnLogOut.Text = "로그아웃";
            this.BtnLogOut.UseVisualStyleBackColor = true;
            this.BtnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 584);
            this.Controls.Add(this.BtnLogOut);
            this.Controls.Add(this.LblUserID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductManaged);
            this.Controls.Add(this.BtnInOut);
            this.Controls.Add(this.BtnOutPut);
            this.Controls.Add(this.ClientManaged);
            this.Controls.Add(this.BtnInPut);
            this.Controls.Add(this.EmployeeManaged);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "QR";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ProductManaged;
        private System.Windows.Forms.Button BtnInOut;
        private System.Windows.Forms.Button BtnOutPut;
        private System.Windows.Forms.Button ClientManaged;
        private System.Windows.Forms.Button BtnInPut;
        private System.Windows.Forms.Button EmployeeManaged;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblUserID;
        private System.Windows.Forms.Button BtnLogOut;
    }
}
