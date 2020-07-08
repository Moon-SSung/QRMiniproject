using System;
using System.Drawing;
using System.Windows.Forms;

namespace QRMiniproject
{
    public partial class MainForm2 : Form
    {
        public MainForm2()
        {
            InitializeComponent();
        }

        private void InItChildForm(object form, string strFormTitle)
        {
            if (this.panelContainer.Controls.Count > 0)
                this.panelContainer.Controls.RemoveAt(0);
            Form fh = form as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            fh.Text = strFormTitle;
            this.panelContainer.Controls.Add(fh);
            this.panelContainer.Tag = fh;
            fh.Show();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            BtnMain_Click(null, e);
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show(this, "로그아웃 하시겠습니까?", "정보",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                DialogResult resultLogout;
                LoginForm loginForm = new LoginForm();
                resultLogout = loginForm.ShowDialog();
                LblUserID.Text = Commons.LoginUserid;
                LblUserCode.Text = Commons.LoginUserCode;
                LblUserName.Text = Commons.LoginUserName;
            }
        }

        private void EmployeeManaged_Click(object sender, EventArgs e)
        {
            InItChildForm(new EmployeeForm(), "사원관리");
        }

        private void ClientManaged_Click(object sender, EventArgs e)
        {
            InItChildForm(new ClientForm(), "거래처관리");

        }

        private void ProductManaged_Click(object sender, EventArgs e)
        {
            InItChildForm(new ProductForm(), "품목관리");

        }

        private void BtnInPut_Click(object sender, EventArgs e)
        {
            InItChildForm(new InPutForm(), "입고관리");

        }

        private void BtnOutPut_Click(object sender, EventArgs e)
        {
            InItChildForm(new GetQRForm(), "출고관리");

        }

        private void BtnInOut_Click(object sender, EventArgs e)
        {
            InItChildForm(new InOutPutVisualForm(), "입출고현황");

        }

        private void BtnMain_Click(object sender, EventArgs e)
        {
            InItChildForm(new EntryForm(), "Entry");

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            LblUserCode.Text = Commons.LoginUserCode;
            LblUserID.Text = Commons.LoginUserid;
            LblUserName.Text = Commons.LoginUserName;
        }

        private void MainForm2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(this, "정말 종료하시겠습니까?", "종료", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panelContainer.ClientRectangle,
                Color.White, 0, ButtonBorderStyle.Solid,
                Color.White, 0, ButtonBorderStyle.Solid,
                Color.DimGray, 2, ButtonBorderStyle.Solid,
                Color.DimGray, 0, ButtonBorderStyle.Solid);
        }
    }
}
