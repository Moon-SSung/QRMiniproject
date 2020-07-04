using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace QRMiniproject
{
    public partial class EmployeeForm : MetroForm
    {
        string mode = "";
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            UpdateData();//데이터 로딩
        }

        private void UpdateData()
        {
            using (SqlConnection conn = new SqlConnection(Commons.ConnString))
            {
                conn.Open();
                string strQuery = "SELECT E_Idx AS 사원코드 " +
                                  " , CodeNumber AS 사번 " +
                                  " , Name AS 이름" +
                                  " , IdentityNumber AS 주민번호 " +
                                  " , Part AS 부서" +
                                  " , Rank AS 직위" +
                                  " , PhoneNumber AS 전화번호 " +
                                  " , UserID AS 아이디" +
                                  " , Password AS 비밀번호"+
                                  " FROM dbo.EmployeeTbl ";  // 퀴리문 입력해야함
                SqlCommand cmd = new SqlCommand(strQuery, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "EmployeeTbl");
                GrdEmployeeTbl.DataSource = ds;
                GrdEmployeeTbl.DataMember = "EmployeeTbl";
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GrdEmployeeTbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow data = GrdEmployeeTbl.Rows[e.RowIndex];
                TxtcodeNumber.Text = data.Cells[0].Value.ToString();
                TxtName.Text = data.Cells[1].Value.ToString();
                TxtIdentityNumber.Text = data.Cells[2].Value.ToString();
                TxtDepart.Text = data.Cells[3].Value.ToString();
                TxtRank.Text = data.Cells[4].Value.ToString();
                TxtPhoneNumber.Text = data.Cells[5].Value.ToString();

                mode = "UPDATE";
            }
        }
        private void TxtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BtnSave_Click(sender, new EventArgs());
            }
        }
        private void BtnNew_Click(object sender, EventArgs e)
        {
            ClearTextControl();
            mode = "INSERT"; //신규는 INSERT
        }

        private void ClearTextControl()
        {
            TxtcodeNumber.Text = TxtName.Text = TxtIdentityNumber.Text = TxtDepart.Text = TxtPhoneNumber.Text = TxtIdentityNumber.Text = TxtRank.Text = "";
            TxtcodeNumber.ReadOnly = false;
            TxtcodeNumber.BackColor = Color.White;
            TxtName.Focus();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TxtName.Text) || 
                String.IsNullOrEmpty(TxtIdentityNumber.Text) ||
                String.IsNullOrEmpty(TxtDepart.Text) || 
                String.IsNullOrEmpty(TxtRank.Text) || 
                String.IsNullOrEmpty(TxtPhoneNumber.Text) ||
                string.IsNullOrEmpty(TxtcodeNumber.Text) ||
                string.IsNullOrEmpty(TxtID.Text) ||
                string.IsNullOrEmpty(TxtPW.Text) 
                )
            {
                MetroMessageBox.Show(this, "빈값은 저장할 수 없습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SaveProcess();
            UpdateData();
            ClearTextControl();
        }

        private void SaveProcess()
        {
            if (string.IsNullOrEmpty(mode))
            {
                MetroMessageBox.Show(this, "신규버튼을 누르고 데이터를 저장하십시오", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            

            using (SqlConnection conn = new SqlConnection(Commons.ConnString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                String strQuery = "";

                if (mode == "UPDATE")
                {
                    strQuery = "UPDATE dbo.EmployeeTbl " +
                                 " SET CodeNumber = @CodeNumber " +
                                 " , Name = @Name " +
                                 " , IdentityNumber = @IdentityNumber " +
                                 " , Part = @Part " +
                                 " , Rank = @Rank " +
                                 " , PhoneNumber = @PhoneNumber " +
                                 "   WHERE  UserID = @UserID , Password = @Password ";

                }
                else if (mode == "INSERT")
                {
                    strQuery = "INSERT INTO dbo.EmployeeTbl "+
                               " (CodeNumber, Name, IdentityNumber, Part, Rank, PhoneNumber, UserID, Password) "+
                               " VALUES "+
                               " (@CodeNumber, @Name, @IdentityNumber, @Part, @Rank, @PhoneNumber, @UserID, @Password) ";
                    cmd.CommandText = strQuery;
                }
                ////////////////////////////////////////////////////////////////이름
                SqlParameter parmName = new SqlParameter("@Name", SqlDbType.NChar, 10);                                              //CommandText 를  파라미터
                parmName.Value = TxtName.Text;
                cmd.Parameters.Add(parmName);
                ///////////////////////////////////////////////////////////////// 직급
                SqlParameter parmRank = new SqlParameter("@Rank", SqlDbType.NChar, 10);                                                 //CommandText 를  파라미터
                parmRank.Value = TxtRank.Text;  // 아이템즈가 맞음 !
                cmd.Parameters.Add(parmRank);
                //////////////////////////////////////////////////////////////////휴대폰번호
                SqlParameter parmPhoneNumber = new SqlParameter("@PhoneNumber", SqlDbType.NVarChar, 50);                                            //CommandText 를  파라미터
                parmPhoneNumber.Value = TxtPhoneNumber.Text;
                cmd.Parameters.Add(parmPhoneNumber);
                //////////////////////////////////////////////////////////////////부서
                SqlParameter parmDepart = new SqlParameter("@Part", SqlDbType.NChar, 10);                                                //CommandText 를  파라미터
                parmDepart.Value = TxtDepart.Text;
                cmd.Parameters.Add(parmDepart);
                /////////////////////////////////////////////////////////////////////// 주민번호
                SqlParameter parmIdentityNumber = new SqlParameter("@IdentityNumber", SqlDbType.NVarChar, 50);                                              //CommandText 를  파라미터
                parmIdentityNumber.Value = TxtIdentityNumber.Text;
                cmd.Parameters.Add(parmIdentityNumber);
                ////////////////////////////////////////////////////////////////// Idex
                SqlParameter parmcodeNumber = new SqlParameter("@CodeNumber", SqlDbType.Int);                                                  //CommandText 를  파라미터
                parmcodeNumber.Value = int.Parse(TxtcodeNumber.Text);
                cmd.Parameters.Add(parmcodeNumber);

                SqlParameter paramUserID = new SqlParameter("@UserID", SqlDbType.NVarChar,50);                                                  //CommandText 를  파라미터
                paramUserID.Value = TxtID.Text;
                cmd.Parameters.Add(paramUserID);

                SqlParameter paramUserPW = new SqlParameter("@Password", SqlDbType.NVarChar,50);                                                  //CommandText 를  파라미터
                paramUserPW.Value = TxtPW.Text;
                cmd.Parameters.Add(paramUserPW);

                cmd.ExecuteNonQuery();
            }
        }

        private void TxtcodeNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (char.IsLetter((char)e.KeyCode) || char.IsWhiteSpace((char)e.KeyCode)) {
                MetroMessageBox.Show(this, "숫자만 입력이가능합니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtcodeNumber.Text = TxtcodeNumber.Text.Substring(0, TxtcodeNumber.Text.Length - 1);
                TxtcodeNumber.Focus();
                return;
            }
        }
    }
}

