﻿using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QRMiniproject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            LoginProcess();
        }

        private void LoginProcess()
        {
            if ((string.IsNullOrEmpty(TxtUserId.Text)) || (string.IsNullOrEmpty(TxtPassword.Text)))
            {
                MetroMessageBox.Show(this, "아이디,패스워드 둘 다 입력하세요", "로그인오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string strUserid = string.Empty;//이부분도
            try
            {
                using (SqlConnection conn = new SqlConnection(Commons.ConnString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT UserID, Name, CodeNumber  FROM EmployeeTbl  " +
                                      "  WHERE UserID = @UserID    " +
                                      "  AND Password = @Password  ";
                    //id
                    SqlParameter parameterid = new SqlParameter("@UserID", SqlDbType.VarChar, 10);
                    parameterid.Value = TxtUserId.Text;
                    cmd.Parameters.Add(parameterid);
                    //password
                    SqlParameter parameterpw = new SqlParameter("@Password", SqlDbType.VarChar, 10);
                    parameterpw.Value = TxtPassword.Text;
                    cmd.Parameters.Add(parameterpw);

                    //여기구문 존재 여부 잘 모르겠음
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    strUserid = reader["UserID"] != null ? reader["UserID"].ToString() : "";

                    if (strUserid != "")
                    {
                        Commons.LoginUserid = strUserid;
                        Commons.LoginUserCode = reader["CodeNumber"].ToString();
                        Commons.LoginUserName = reader["Name"].ToString();
                        MetroMessageBox.Show(this, "접속성공", "로그인");
                        this.Close();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "접속실패", "로그인실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception e)
            {
                MetroMessageBox.Show(this, $"ERROR : {e.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void TxtUserId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                TxtPassword.Focus();
            }
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                LoginProcess();

            }
        }
    }
}
