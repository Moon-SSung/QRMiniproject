using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QRMiniproject
{
    public partial class ProductForm : Form
    {
        string mode = "";

        public ProductForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 폼 로드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductForm_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'qR_ProjectDBDataSet.ProductTbl' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.productTblTableAdapter.Fill(this.qR_ProjectDBDataSet.ProductTbl);
        }
        /// <summary>
        /// 버튼클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TxtpdtID.Text) || String.IsNullOrEmpty(TxtpdtName.Text) || String.IsNullOrEmpty(TxtpdtStandard.Text) || String.IsNullOrEmpty(TxtpdtUnit.Text) || String.IsNullOrEmpty(TxtpdtPrice.Text))
            {
                MetroMessageBox.Show(this, "빈값은 저장할 수 없습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Check())
                return;
            SaveProcess();
            UpdateData();
        }
        // 품목코드체크
        private bool Check()
        {
            using (SqlConnection conn = new SqlConnection(Commons.ConnString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                SqlDataReader reader = null;
                string strUserid = null;
                if (mode == "INSERT")
                {
                    cmd.CommandText = "SELECT ID FROM ProductTbl " +
                                      " WHERE ID = @ID ";
                    SqlParameter paramCode = new SqlParameter("@ID", SqlDbType.NVarChar,50);
                    paramCode.Value = TxtpdtID.Text;
                    cmd.Parameters.Add(paramCode);

                    reader = cmd.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        strUserid = reader["ID"] != null ? reader["ID"].ToString() : "";
                        if (strUserid != "")
                        {
                            MetroMessageBox.Show(this, "이미 존재하는 품목번호입니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            TxtpdtID.Text = "";
                            return false;
                        }
                    }
                    reader.Close();
                }
            }
            return true;
        }
        private void BtnNew_Click(object sender, EventArgs e)
        {
            ClearTextControls();
            mode = "INSERT";
        }
        /// <summary>
        /// 픽쳐박스 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrdpictureBox_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        PrdpictureBox.Image = Image.FromFile(ofd.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"ERROR : {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        /// <summary>
        /// 그리드 셀 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrdGridBox_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow data = PrdGridBox.Rows[e.RowIndex];
                TxtpdtID.Text = data.Cells[1].Value.ToString();
                TxtpdtID.Enabled = false;
                TxtpdtName.Text = data.Cells[2].Value.ToString();
                TxtpdtStandard.Text = data.Cells[3].Value.ToString();
                TxtpdtUnit.Text = data.Cells[4].Value.ToString();
                TxtpdtPrice.Text = string.Format("{0:#,##0}", data.Cells[5].Value);
                if (!string.IsNullOrEmpty(data.Cells[6].Value.ToString()))
                {

                    byte[] bytes = (byte[])data.Cells[6].Value; ;
                    MemoryStream ms = new MemoryStream(bytes);
                    PrdpictureBox.Image = Image.FromStream(ms);
                }
                else
                {
                    PrdpictureBox.Image = null;
                }
            }
            mode = "UPDATE";
        }
        /// <summary>
        /// 텍스트박스 클리어 메소드
        /// </summary>
        private void ClearTextControls()
        {
            TxtpdtID.Text = TxtpdtName.Text = TxtpdtPrice.Text = TxtpdtStandard.Text = TxtpdtUnit.Text = "";
            PrdpictureBox.Image = null;
            TxtpdtID.Enabled = true;
        }
        /// <summary>
        /// UPDATE 프로세스
        /// </summary>
        private void UpdateData()
        {
            using (SqlConnection conn = new SqlConnection(Commons.ConnString))
            {
                conn.Open(); //DB 열기
                string strQuery = "SELECT P_Idx, ID, NAME, STANDARD, UNIT, PRICE, PICTURE" +
                                  "  FROM dbo.ProductTbl "; //sql select문 불러오기
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "ProductTbl");

                PrdGridBox.DataSource = ds;
                PrdGridBox.DataMember = "ProductTbl";
            }
        }
        /// <summary>
        /// Save 프로세스
        /// </summary>
        private void SaveProcess()
        {
            if (String.IsNullOrEmpty(mode))
            {
                MetroMessageBox.Show(this, "신규버튼을 누르고 데이터를 저장하십시오.", "경고",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(Commons.ConnString))
            {
                conn.Open();
                string sqlQuery = "";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                if (mode == "UPDATE")
                {
                    sqlQuery = " UPDATE dbo.ProductTbl SET ID = @ID, NAME = @NAME, STANDARD = @STANDARD, " +
                               "                           UNIT = @UNIT, PRICE = @PRICE, PICTURE = @PICTURE " +
                               "                           WHERE ID = @ID";
                }
                else if (mode == "INSERT")
                {
                    sqlQuery = " INSERT INTO dbo.ProductTbl(ID, Name, Standard, Unit, Price) " +
                               " VALUES(@ID, @Name, @Standard, @Unit, @Price) ";
                }

                cmd.CommandText = sqlQuery;

                SqlParameter paramID = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
                paramID.Value = TxtpdtID.Text;
                cmd.Parameters.Add(paramID);
                SqlParameter paramNAME = new SqlParameter("@NAME", SqlDbType.NVarChar, 50);
                paramNAME.Value = TxtpdtName.Text;
                cmd.Parameters.Add(paramNAME);
                SqlParameter paramSTANDARD = new SqlParameter("@STANDARD", SqlDbType.NVarChar, 50);
                paramSTANDARD.Value = TxtpdtStandard.Text;
                cmd.Parameters.Add(paramSTANDARD);
                SqlParameter paramUNIT = new SqlParameter("@UNIT", SqlDbType.NVarChar, 50);
                paramUNIT.Value = TxtpdtUnit.Text;
                cmd.Parameters.Add(paramUNIT);
                SqlParameter paramPRICE = new SqlParameter("@PRICE", SqlDbType.Decimal, 10);
                paramPRICE.Value = TxtpdtPrice.Text;
                cmd.Parameters.Add(paramPRICE);

                // Picturebox
                Image img = PrdpictureBox.Image;
                ImageConverter converter = new ImageConverter();
                byte[] arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
                SqlCommand updateDatagridviewCmd = new SqlCommand(" SELECT * FROM dbo.ProductTbl ", conn);
                DataTable dt = new DataTable();
                dt.Load(updateDatagridviewCmd.ExecuteReader());
                PrdGridBox.DataSource = dt;
                cmd.Parameters.AddWithValue("@PICTURE", arr);

                cmd.ExecuteNonQuery();

                MetroMessageBox.Show(this, "저장되었습니다.");

            }
        }

        private void TxtpdtPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyCode.ToString(), "[0-9]") && !char.IsControl((char)e.KeyCode) && !((int)e.KeyCode >= 37 && (int)e.KeyCode <= 40))
            {
                MetroMessageBox.Show(this, "숫자만 입력이가능합니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (TxtpdtPrice.Text.Length != 0)
                    TxtpdtPrice.Text = TxtpdtPrice.Text.Substring(0, TxtpdtPrice.Text.Length - 1);
                TxtpdtPrice.Focus();
                return;
            }
        }

        private void PrdGridBox_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}