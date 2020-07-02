using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRMiniproject
{
    public partial class GetQRForm : Form
    {
        public GetQRForm()
        {
            InitializeComponent();
        }

        public void initializeDateTimePicker()
        {
            DtpQRCode.CustomFormat = "yyyy-MM-dd";
            DtpQRCode.Format = DateTimePickerFormat.Custom;
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(TxtQRCode1.Text + "/" +
                                              DtpQRCode.Text + "/" +
                                              TxtQRCode3.Text + "/" +
                                              TxtQRCode4.Text + "/" +
                                              CboQRCode.Text + "/" +
                                              TxtQRCode6.Text + "/",
                                              QRCodeGenerator.ECCLevel.Q); //ECCLevel 오류복원 등급
            QRCode code = new QRCode(data);
            PbxQRCode.Image = code.GetGraphic(5);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Title = "다른 이름으로 저장";
            dlg.DefaultExt = "png";
            dlg.Filter = "JPEG (*.jpg) | *.jpg | Bitmap (*.bmp)|*.bmp | GIF (*.gif)|*.gif | Png (*.png)|*.png";
            dlg.FilterIndex = 0;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                PbxQRCode.Image.Save(dlg.FileName);
            }
        }

        private void GetQRForm_Load(object sender, EventArgs e)
        {
            initializeDateTimePicker();
            using (SqlConnection conn = new SqlConnection(Commons.ConnString))
            {
                conn.Open();

            }
        }
    }
}
