using MetroFramework;
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
        //디비연결 string
        string mode = "";
        public GetQRForm()
        {
            InitializeComponent();
        }

        public void initializeDateTimePicker()
        {
            DtpQRCode.CustomFormat = "yyyy-MM-dd";
            DtpQRCode.Format = DateTimePickerFormat.Custom;

            //DtpQRCode.CustomFormat = " ";
            //DtpQRCode.Format = DateTimePickerFormat.Custom;
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(TxtQRCode1.Text + "/" +
                                              TxtQRCode2.Text + "/" +
                                              TxtQRCode3.Text + "/" +
                                              DtpQRCode.Text + "/" +
                                              TxtQRCode4.Text + "/" +
                                              CboQRCode.Text + "/" ,
                                              QRCodeGenerator.ECCLevel.Q); //ECCLevel 오류복원 등급
            QRCode code = new QRCode(data);
            PbxQRCode.Image = code.GetGraphic(3);         
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
            //mode = "UPDATE";
            //GridInputData();

        }

        private void GridInputData()
        {
            using (SqlConnection conn = new SqlConnection(Commons.ConnString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                string strQuery = "";

                if(mode == "UPDATE")
                {
                    strQuery = "UPDATE dbo.OutputTbl " +
                               "   SET ClientIdx = @ClientIdx, " +
                               "       ProductIdx = @ProductIdx, " +
                               "       Outdate = @Outdate, " +
                               "       Count = @Count, " +
                               "       Storage = @Storage " +
                               " WHERE O_Idx = @O_Idx ";
                }
                else if(mode == "INSERT")
                {
                    strQuery = "INSERT INTO dbo.OutputTbl( ClientIdx, ProductIdx, Outdate, Count, Storage ) " +
                               " VALUES ( @ClientIdx, @ProductIdx, @Outdate, @Count, @Storage ) ";
                }
                cmd.CommandText = strQuery;

                if(mode =="UPDATE")
                {
                    SqlParameter pramO_Idx = new SqlParameter("@O_Idx", SqlDbType.Int);
                    pramO_Idx.Value = TxtQRCode1.Text;
                    cmd.Parameters.Add(pramO_Idx);
                }
                SqlParameter pramClientIdx = new SqlParameter("@ClientIdx", SqlDbType.Int);
                pramClientIdx.Value = TxtQRCode2.Text;
                cmd.Parameters.Add(pramClientIdx);

                SqlParameter pramProductIdx = new SqlParameter("@ProductIdx", SqlDbType.Int);
                pramProductIdx.Value = TxtQRCode3.Text;
                cmd.Parameters.Add(pramProductIdx);

                SqlParameter pramOutdate = new SqlParameter("@Outdate", SqlDbType.Date);
                pramOutdate.Value = DtpQRCode.Text;
                cmd.Parameters.Add(pramOutdate);

                SqlParameter pramCount = new SqlParameter("@Count", SqlDbType.Int);
                pramCount.Value = TxtQRCode4.Text;
                cmd.Parameters.Add(pramCount);

                SqlParameter pramStorage = new SqlParameter("@Storage", SqlDbType.NVarChar, 50);
                pramStorage.Value = CboQRCode.Text;
                cmd.Parameters.Add(pramStorage);

                cmd.ExecuteNonQuery();
            }

        }

        private void BtnDataInput_Click(object sender, EventArgs e)
        {
            mode = "UPDATE";
            GridInputData();
        }

        private void GetQRForm_Load(object sender, EventArgs e)
        {
            //ClearTextControls();
            initializeDateTimePicker();
            ViewGridData();
            UpdateCboQRCode();
            


        }

        private void UpdateCboQRCode()
        {        
                //throw new NotImplementedException();
                using (SqlConnection conn = new SqlConnection(Commons.ConnString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT O_Idx, Storage FROM OutputTbl";
                    SqlDataReader reader = cmd.ExecuteReader();
                    Dictionary<string, string> temps = new Dictionary<string, string>();
                    while (reader.Read())
                    {
                        temps.Add(reader[0].ToString(), reader[1].ToString());
                    }
                    CboQRCode.DataSource = new BindingSource(temps, null);
                    CboQRCode.DisplayMember = "Value";
                    CboQRCode.ValueMember = "Key";
                    CboQRCode.SelectedIndex = -1;                
                }
        }

        private void ViewGridData()
        {
            using (SqlConnection conn = new SqlConnection(Commons.ConnString))
            {
                conn.Open();
                string strQuery = "SELECT O_Idx, ClientIdx, ProductIdx, Outdate, Count, Storage " +
                                  "  FROM dbo.OutputTbl ";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "OutputTbl");

                MtrGetQRGrid.DataSource = ds;
                MtrGetQRGrid.DataMember = "OutputTbl";
            }
        }

        private void ClearTextControls()
        {
            TxtQRCode1.Text = "";
            CboQRCode.SelectedIndex = -1;

            TxtQRCode1.ReadOnly = true; //txtIdx는 자동 증가
            TxtQRCode1.BackColor = Color.Beige;

            

            TxtQRCode2.Focus();
        }


    }
}
