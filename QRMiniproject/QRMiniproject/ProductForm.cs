using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QRMiniproject
{
    public partial class ProductForm : MetroForm
    {
        string mode = "";
        string sqlQuery = "";

        SqlConnection conn = new SqlConnection(Commons.ConnString); // MS_SQL 연결


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
            mode = "UPDATE";
            if (String.IsNullOrEmpty(TxtpdtID.Text) || String.IsNullOrEmpty(TxtpdtName.Text) || String.IsNullOrEmpty(TxtpdtStandard.Text) || String.IsNullOrEmpty(TxtpdtUnit.Text) || String.IsNullOrEmpty(TxtpdtPrice.Text))
            {
                MetroMessageBox.Show(this, "빈값은 저장할 수 없습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SaveProcess();
        }
        private void BtnNew_Click(object sender, EventArgs e)
        {
            mode = "INSERT";
            if (String.IsNullOrEmpty(TxtpdtID.Text) || String.IsNullOrEmpty(TxtpdtName.Text) || String.IsNullOrEmpty(TxtpdtStandard.Text) || String.IsNullOrEmpty(TxtpdtUnit.Text) || String.IsNullOrEmpty(TxtpdtPrice.Text))
            {
                MetroMessageBox.Show(this, "빈값은 저장할 수 없습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ClearTextControls();
            SaveProcess();
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
                TxtpdtName.Text = data.Cells[2].Value.ToString();
                TxtpdtStandard.Text = data.Cells[3].Value.ToString();
                TxtpdtUnit.Text = data.Cells[4].Value.ToString();
                TxtpdtPrice.Text = data.Cells[5].Value.ToString();
                if (!string.IsNullOrEmpty(data.Cells[6].Value.ToString()))
                {

                    byte[] bytes = (byte[])data.Cells[6].Value;;
                    MemoryStream ms = new MemoryStream(bytes);
                    PrdpictureBox.Image = Image.FromStream(ms);
                }
                else {
                    PrdpictureBox.Image = null;
                }
            }
        }
        /// <summary>
        /// Save 프로세스
        /// </summary>
        private void SaveProcess()
        {
            conn.Open();

            if (mode == "UPDATE")
            {
                Image img = PrdpictureBox.Image;
                ImageConverter converter = new ImageConverter();

                byte[] arr = (byte[])converter.ConvertTo(img, typeof(byte[]));

                try
                {
                    sqlQuery = " UPDATE dbo.ProductTbl SET ID = @ID, NAME = @NAME, STANDARD = @STANDARD, " +
                               "                           UNIT = @UNIT, PRICE = @PRICE, PICTURE = @PICTURE " +
                               "                           WHERE ID = @ID";
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                    //cmd.Parameters.AddWithValue("@IDX", metroLabel1.Text);
                    cmd.Parameters.AddWithValue("@ID", TxtpdtID.Text);
                    cmd.Parameters.AddWithValue("@NAME", TxtpdtName.Text);
                    cmd.Parameters.AddWithValue("@STANDARD", TxtpdtStandard.Text);
                    cmd.Parameters.AddWithValue("@UNIT", TxtpdtUnit.Text);
                    cmd.Parameters.AddWithValue("@PRICE", TxtpdtPrice.Text);
                    cmd.Parameters.AddWithValue("@PICTURE", arr);
                    cmd.ExecuteNonQuery();
                    MetroMessageBox.Show(this, "제품 사진이 저장되었습니다.");

                    SqlCommand updateDatagridviewCmd = new SqlCommand(" SELECT * FROM dbo.ProductTbl ", conn);
                    DataTable dt = new DataTable();
                    dt.Load(updateDatagridviewCmd.ExecuteReader());
                    PrdGridBox.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, $"ERROR : {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (mode == "INSERT")
            {
                sqlQuery = " INSERT INTO dbo.ProductTbl(ID, Name, Standard, Unit, Price) " +
                           " VALUES(@ID, @Name, @Standard, @Unit, @Price) ";
            }
            conn.Close();
        }
        /// <summary>
        /// 텍스트박스 클리어 메소드
        /// </summary>
        private void ClearTextControls()
        {
            TxtpdtID.Text = TxtpdtName.Text = TxtpdtPrice.Text = TxtpdtStandard.Text = TxtpdtUnit.Text = "";
        }
    }
}
