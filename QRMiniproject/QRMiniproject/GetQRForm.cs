using MetroFramework;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace QRMiniproject
{
    public partial class GetQRForm : Form
    {
        //쿼리문 실행 string
        string mode = "";
       
        public GetQRForm()
        {
            
            InitializeComponent();
        }

        /// <summary>
        /// Date형식 초기화
        /// </summary>
        public void initializeDateTimePicker()
        {
            DtpQRCode.CustomFormat = "yyyy-MM-dd";
            DtpQRCode.Format = DateTimePickerFormat.Custom;
        }

        /// <summary>
        /// QR코드 생성
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(TxtQRCode1.Text + "/" +
                                              CboQRCode1.Text + "/" +
                                              CboQRCode2.Text + "/" +
                                              DtpQRCode.Text + "/" +
                                              TxtQRCode2.Text + "/" +
                                              CboQRCode3.Text + "/" ,
                                              QRCodeGenerator.ECCLevel.Q); //ECCLevel 오류복원 등급
            QRCode code = new QRCode(data);
            PbxQRCode.Image = code.GetGraphic(3);         
        }

        /// <summary>
        /// 생성된 QR Code 원하는 폴더에 저장
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Title = "다른 이름으로 저장";
            dlg.DefaultExt = ".png";
            dlg.Filter = "JPEG (*.jpg)|*.jpg |Bitmap (*.bmp)|*.bmp|GIF (*.gif)|*.gif|Png (*.png)|*.png";
            dlg.FilterIndex = 4;

            DialogResult result = dlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                PbxQRCode.Image.Save(dlg.FileName);
                mode = "INSERT";
            }
            else if (result == DialogResult.Cancel)
            {
                dlg.Dispose();
                return;
            }
            GridInputData();
            ViewGridData();
        }

        /// <summary>
        /// SQL 쿼리문을 사용하여 UPDATE, INSERT를 할 수 있는 메소드.
        /// <summary>
        private void GridInputData()
        {
            string strQuery = "";

            using (SqlConnection conn = new SqlConnection(Commons.ConnString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                if (mode == "UPDATE")
                {
                    strQuery = "UPDATE dbo.OutputTbl " +
                               "   SET ClientIdx = @ClientIdx, " +
                               "       ProductIdx = @ProductIdx, " +
                               "       Outdate = @Outdate, " +
                               "       Count = @Count, " +
                               "       Storage = @Storage " +
                               " WHERE O_Idx = @O_Idx ";
                }
                else if (mode == "INSERT")
                {
                    strQuery = "INSERT INTO dbo.OutputTbl( ClientIdx, ProductIdx, Outdate, Count, Storage ) " +
                               " VALUES ( @ClientIdx, @ProductIdx, @Outdate, @Count, @Storage ) ";
                }
                cmd.CommandText = strQuery;

                if (mode == "UPDATE")
                {
                    SqlParameter pramO_Idx = new SqlParameter("@O_Idx", SqlDbType.Int);
                    pramO_Idx.Value = TxtQRCode1.Text;
                    cmd.Parameters.Add(pramO_Idx);
                }
                SqlParameter pramClientIdx = new SqlParameter("@ClientIdx", SqlDbType.Int);
                pramClientIdx.Value = CboQRCode1.SelectedValue;
                cmd.Parameters.Add(pramClientIdx);

                SqlParameter pramProductIdx = new SqlParameter("@ProductIdx", SqlDbType.Int);
                pramProductIdx.Value = CboQRCode2.SelectedValue;
                cmd.Parameters.Add(pramProductIdx);

                SqlParameter pramOutdate = new SqlParameter("@Outdate", SqlDbType.Date);
                pramOutdate.Value = DtpQRCode.Text;
                cmd.Parameters.Add(pramOutdate);

                SqlParameter pramCount = new SqlParameter("@Count", SqlDbType.Int);
                pramCount.Value = TxtQRCode2.Text;
                cmd.Parameters.Add(pramCount);

                SqlParameter pramStorage = new SqlParameter("@Storage", SqlDbType.NVarChar, 50);
                pramStorage.Value = CboQRCode3.Text;
                cmd.Parameters.Add(pramStorage);

                cmd.ExecuteNonQuery();
            }
        }

        private void GetQRForm_Load(object sender, EventArgs e)
        {
            MtrGetQRGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MtrGetQRGrid.Width = 750;
            ClearTextControls();
            initializeDateTimePicker();            
            ViewGridData();
            UpdateCboQRCode1();
            UpdateCboQRCode2();

        }

        /// <summary>
        /// ClientTBl에서 거래처번호만 ComboBox에 뿌려준다.
        /// </summary>
        private void UpdateCboQRCode1()  // 거래처번호 ClientTBL
        {        
                using (SqlConnection conn = new SqlConnection(Commons.ConnString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT C_Idx, Number FROM ClientTbl";
                    SqlDataReader reader = cmd.ExecuteReader();
                    Dictionary<string, string> temps = new Dictionary<string, string>();
                    while (reader.Read())
                    {
                        temps.Add(reader[0].ToString(), reader[1].ToString());
                    }
                    CboQRCode1.DataSource = new BindingSource(temps, null);
                    CboQRCode1.DisplayMember = "Value";
                    CboQRCode1.ValueMember = "Key";
                    CboQRCode1.SelectedIndex = -1;                
                }
        }

        /// <summary>
        /// ProductTBL에서 제품코드만 ComboBox에 뿌려준다.
        /// </summary>
        private void UpdateCboQRCode2()  // 제품코드 ProductTBL
        {        
                using (SqlConnection conn = new SqlConnection(Commons.ConnString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT P_Idx, ID FROM ProductTbl";
                    SqlDataReader reader = cmd.ExecuteReader();
                    Dictionary<string, string> temps = new Dictionary<string, string>();
                    while (reader.Read())
                    {
                        temps.Add(reader[0].ToString(), reader[1].ToString());
                    }
                    CboQRCode2.DataSource = new BindingSource(temps, null);
                    CboQRCode2.DisplayMember = "Value";
                    CboQRCode2.ValueMember = "Key";
                    CboQRCode2.SelectedIndex = -1;                
                }
        }

        /// <summary>
        /// GridView에 연결된 DB를 불러오는 코드
        /// </summary>
        private void ViewGridData()
        {
            using (SqlConnection conn = new SqlConnection(Commons.ConnString))
            {
                conn.Open();
                string strQuery = "     SELECT O.O_Idx AS '출고번호', " +
                                  "            C.Number AS '거래처번호', " + 
                                  "            P.ID AS '품목코드', " + 
                                  "            O.Outdate AS '출고일자', " + 
                                  "            O.Count AS '수량', " + 
                                  "            O.Storage AS '창고' " +
                                  "       FROM OutputTbl AS O " +
                                  " INNER JOIN  ClientTbl AS C " +
                                  "         ON O.ClientIdx = C.C_Idx " +
                                  " INNER JOIN ProductTbl as P " +
                                  "         ON O.ProductIdx = P.P_Idx ";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "OutputTbl");

                MtrGetQRGrid.DataSource = ds;
                MtrGetQRGrid.DataMember = "OutputTbl";
            }
        }


        /// <summary>
        /// GridView의 data를 선택했을 때, 각각의 Box에 값이 들어간다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MtrGetQRGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow data = MtrGetQRGrid.Rows[e.RowIndex];
                TxtQRCode1.Text = data.Cells[0].Value.ToString();
                TxtQRCode1.ReadOnly = true;
                TxtQRCode1.BackColor = Color.Red;
                CboQRCode1.SelectedIndex = CboQRCode1.FindString(data.Cells[1].Value.ToString());
                CboQRCode2.SelectedIndex = CboQRCode2.FindString(data.Cells[2].Value.ToString());
                DtpQRCode.Value = DateTime.Parse(data.Cells[3].Value.ToString());
                TxtQRCode2.Text = data.Cells[4].Value.ToString();
                CboQRCode3.SelectedIndex = CboQRCode3.FindString(data.Cells[5].Value.ToString());

                mode = "UPDATE"; // 수정은 UPDATE
            }
        }


        /// <summary>
        /// QR Code 프린트 기능
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPrint_Click(object sender, EventArgs e)
        {
            if (PbxQRCode.Image == null)
            {
                MetroMessageBox.Show(this, "QR코드를 생성해주세요.", "인쇄실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PrintDocument docToPrint = new PrintDocument();
                PageSettings ps = new PageSettings();
                ps.Margins = new Margins(10, 10, 10, 10);
                docToPrint.DefaultPageSettings = ps;
                PrintPreviewDialog pd = new PrintPreviewDialog();
                pd.ClientSize = new Size(500, 500);
                pd.UseAntiAlias = true;
                docToPrint.PrintPage += new PrintPageEventHandler(docToPrint_PrintPage);
                pd.Document = docToPrint;
                pd.Show();
            }
        }
        private void docToPrint_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(PbxQRCode.Image, 0, 0, 400, 400);
        }

        /// <summary>
        /// 데이터 초기화
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDataReset_Click(object sender, EventArgs e)
        {
            ClearTextControls();
        }
        private void ClearTextControls()
        {
            TxtQRCode1.Text = CboQRCode1.Text = CboQRCode2.Text = DtpQRCode.Text = TxtQRCode2.Text = CboQRCode3.Text = "";
            CboQRCode1.SelectedIndex=CboQRCode2.SelectedIndex=CboQRCode3.SelectedIndex = -1;

            TxtQRCode1.ReadOnly = true; //txtIdx는 자동 증가
            TxtQRCode1.BackColor = Color.Beige;

            if (PbxQRCode.Image != null) //picturebox에 값이 있을 때 초기화
            {
                PbxQRCode.Image = null;
            }
        }

        private void MtrGetQRGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
