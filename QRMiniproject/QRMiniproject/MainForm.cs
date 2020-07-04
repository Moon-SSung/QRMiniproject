using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;
using QRCoder;
namespace QRMiniproject
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //LoginForm loginForm = new LoginForm();
            //loginForm.ShowDialog();
            InPutForm inPutForm = new InPutForm();
            inPutForm.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MetroMessageBox.Show(this, "정말 종료하시겠습니까?", "종료", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (Form item in this.MdiChildren)
                {
                    item.Close();
                }
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
        private void InItChildForm(Form form, string strFormTitle)
        {
            form.Text = strFormTitle;
            form.Dock = DockStyle.Fill;
            // form.MdiParent = this;
            form.Show();
            //form.WindowState = FormWindowState.Maximized;
        }

        private void EmployeeManaged_Click(object sender, EventArgs e)
        {
            EmployeeForm form = new EmployeeForm();
            InItChildForm(form, "사원관리");
        }

        private void ClientManaged_Click(object sender, EventArgs e)
        {
            ClientForm form = new ClientForm();
            InItChildForm(form, "거래처관리");
        }

        private void ProductManaged_Click(object sender, EventArgs e)
        {
            ProductForm form = new ProductForm();
            InItChildForm(form, "품목관리");
        }
        private void BtnOutPut_Click(object sender, EventArgs e)
        {
            GetQRForm form = new GetQRForm();
            InItChildForm(form, "출고관리");
        }
        private void BtnInPut_Click(object sender, EventArgs e)
        {
            InPutForm form = new InPutForm();
            InItChildForm(form, "입고관리");
        }

        private void BtnInOut_Click(object sender, EventArgs e)
        {
            InOutPutVisualForm form = new InOutPutVisualForm();
            InItChildForm(form, "입출고현황");
        }
    }
}
