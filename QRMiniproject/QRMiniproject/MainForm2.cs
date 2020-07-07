using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace QRMiniproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;
            }
            else
                MenuVertical.Width = 250;
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "정말 종료하시겠습니까?", "종료", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void iconmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconrestaurar.Visible = true;
            iconmaximizar.Visible = false;
        }

        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconrestaurar.Visible = false;
            iconmaximizar.Visible = true;
        }

        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       

        private void InItChildForm(object form, string strFormTitle)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = form as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            fh.Text = strFormTitle;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            BtnMain_Click(null,e);
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
            InItChildForm(new InOutPutVisualForm(), "입출고현황");

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            LblUserCode.Text = Commons.LoginUserCode;
            LblUserID.Text = Commons.LoginUserid;
            LblUserName.Text = Commons.LoginUserName;
        }
    }
}
