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
            GrdEmployeeTbl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
                                  " , Password AS 비밀번호" +
                                  " FROM dbo.EmployeeTbl ";  // 퀴리문 입력해야함
                SqlCommand cmd = new SqlCommand(strQuery, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "EmployeeTbl");
                GrdEmployeeTbl.DataSource = ds;
                GrdEmployeeTbl.DataMember = "EmployeeTbl";
                GrdEmployeeTbl.Columns[0].Visible = false;
            }
        }

        private void GrdEmployeeTbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow data = GrdEmployeeTbl.Rows[e.RowIndex];
                TxtEmpCode.Text = data.Cells[0].Value.ToString();
                TxtcodeNumber.Text = data.Cells[1].Value.ToString();
                TxtcodeNumber.ReadOnly = true;
                TxtName.Text = data.Cells[2].Value.ToString();
                TxtIdentityNumber.Text = data.Cells[3].Value.ToString();
                CboDepart.SelectedIndex = CboDepart.FindString(data.Cells[4].Value.ToString().Trim());
                CboRank.SelectedIndex = CboRank.FindString(data.Cells[5].Value.ToString().Trim());
                TxtPhoneNumber.Text = data.Cells[6].Value.ToString();
                TxtUserId.Text = data.Cells[7].Value.ToString();
                TxtPassword.Text = data.Cells[8].Value.ToString();
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
            TxtEmpCode.Text = TxtcodeNumber.Text = TxtName.Text = TxtIdentityNumber.Text = CboDepart.Text = TxtPhoneNumber.Text = TxtIdentityNumber.Text = CboRank.Text = TxtPassword.Text = TxtUserId.Text = "";
            CboDepart.SelectedIndex = -1;
            CboRank.SelectedIndex = -1;
            TxtcodeNumber.ReadOnly = false;
            TxtcodeNumber.BackColor = Color.White;

            TxtName.Focus();
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TxtName.Text) ||
                String.IsNullOrEmpty(TxtIdentityNumber.Text) ||
                String.IsNullOrEmpty(CboDepart.Text) ||
                String.IsNullOrEmpty(CboRank.Text) ||
                String.IsNullOrEmpty(TxtPhoneNumber.Text) ||
                string.IsNullOrEmpty(TxtcodeNumber.Text) ||
                string.IsNullOrEmpty(TxtID.Text) ||
                string.IsNullOrEmpty(TxtPW.Text)
                )
            {
                MetroMessageBox.Show(this, "빈값은 저장할 수 없습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Check())
                return;
            SaveProcess();
            UpdateData();
            ClearTextControl();
        }
        // 사원번호 아이디 중복체크
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
                    cmd.CommandText = "SELECT UserID FROM EmployeeTbl " +
                                      " WHERE CodeNumber = @UserCode ";
                    SqlParameter paramCode = new SqlParameter("@UserCode", SqlDbType.Int);
                    paramCode.Value = TxtcodeNumber.Text;
                    cmd.Parameters.Add(paramCode);

                    reader = cmd.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        strUserid = reader["UserID"] != null ? reader["UserID"].ToString() : "";
                        if (strUserid != "")
                        {
                            MetroMessageBox.Show(this, "이미 존재하는 사원번호입니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            TxtcodeNumber.Text = "";
                            return false;
                        }
                    }

                    reader.Close();

                }

                cmd.CommandText = "SELECT UserID FROM EmployeeTbl " +
                                  " WHERE UserID = @UserID ";

                SqlParameter paramID = new SqlParameter("@UserID", SqlDbType.VarChar, 10);
                paramID.Value = TxtUserId.Text;
                cmd.Parameters.Add(paramID);

                reader = cmd.ExecuteReader();
                reader.Read();

                if (reader.HasRows)
                {
                    strUserid = reader["UserID"] != null ? reader["UserID"].ToString() : "";
                    if (strUserid != "")
                    {
                        MetroMessageBox.Show(this, "이미 존재하는 아이디입니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtUserId.Text = "";
                        return false;
                    }
                }

            }
            return true;
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
                                 " , UserID = @UserID " +
                                 " , Password = @Password" +
                                 "   WHERE  E_Idx = @E_Idx ";

                }
                else if (mode == "INSERT")
                {
                    strQuery = "INSERT INTO dbo.EmployeeTbl " +
                               " (CodeNumber, Name, IdentityNumber, Part, Rank, PhoneNumber, UserID, Password) " +
                               " VALUES " +
                               " (@CodeNumber, @Name, @IdentityNumber, @Part, @Rank, @PhoneNumber, @UserID, @Password) ";

                }
                cmd.CommandText = strQuery;


                if (mode == "UPDATE")
                {
                    SqlParameter paramIdx = new SqlParameter("@E_Idx", SqlDbType.Int);                                              //CommandText 를  파라미터
                    paramIdx.Value = TxtEmpCode.Text;
                    cmd.Parameters.Add(paramIdx);
                }
                ////////////////////////////////////////////////////////////////이름
                SqlParameter parmName = new SqlParameter("@Name", SqlDbType.NChar, 10);                                              //CommandText 를  파라미터
                parmName.Value = TxtName.Text;
                cmd.Parameters.Add(parmName);
                ///////////////////////////////////////////////////////////////// 직급
                SqlParameter parmRank = new SqlParameter("@Rank", SqlDbType.NChar, 10);                                                 //CommandText 를  파라미터
                parmRank.Value = CboRank.SelectedItem;  // 아이템즈가 맞음 !
                cmd.Parameters.Add(parmRank);
                //////////////////////////////////////////////////////////////////휴대폰번호
                SqlParameter parmPhoneNumber = new SqlParameter("@PhoneNumber", SqlDbType.NVarChar, 50);                                            //CommandText 를  파라미터
                parmPhoneNumber.Value = TxtPhoneNumber.Text;
                cmd.Parameters.Add(parmPhoneNumber);
                //////////////////////////////////////////////////////////////////부서
                SqlParameter parmDepart = new SqlParameter("@Part", SqlDbType.NChar, 10);                                                //CommandText 를  파라미터
                parmDepart.Value = CboDepart.SelectedItem;
                cmd.Parameters.Add(parmDepart);
                /////////////////////////////////////////////////////////////////////// 주민번호
                SqlParameter parmIdentityNumber = new SqlParameter("@IdentityNumber", SqlDbType.NVarChar, 50);                                              //CommandText 를  파라미터
                parmIdentityNumber.Value = TxtIdentityNumber.Text;
                cmd.Parameters.Add(parmIdentityNumber);
                ////////////////////////////////////////////////////////////////// Idex
                SqlParameter parmcodeNumber = new SqlParameter("@CodeNumber", SqlDbType.Int);                                                  //CommandText 를  파라미터
                parmcodeNumber.Value = int.Parse(TxtcodeNumber.Text);
                cmd.Parameters.Add(parmcodeNumber);

                SqlParameter paramUserID = new SqlParameter("@UserID", SqlDbType.NVarChar, 50);                                                  //CommandText 를  파라미터
                paramUserID.Value = TxtUserId.Text;
                cmd.Parameters.Add(paramUserID);

                SqlParameter paramUserPW = new SqlParameter("@Password", SqlDbType.NVarChar, 50);                                                  //CommandText 를  파라미터
                paramUserPW.Value = TxtPassword.Text;
                cmd.Parameters.Add(paramUserPW);

                cmd.ExecuteNonQuery();
            }
        }

        string log = "";
        private void TxtcodeNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (!TxtcodeNumber.Enabled && !System.Text.RegularExpressions.Regex.IsMatch(e.KeyCode.ToString(), "[0-9]") && !char.IsControl((char)e.KeyCode) && !((int)e.KeyCode >= 37 && (int)e.KeyCode <= 40))
            {
                MetroMessageBox.Show(this, "숫자만 입력이가능합니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (TxtcodeNumber.Text.Length != 0)
                    TxtcodeNumber.Text = TxtcodeNumber.Text.Substring(0, TxtcodeNumber.Text.Length - 1);
                TxtcodeNumber.Focus();
                return;
            }
        }
    }
}

