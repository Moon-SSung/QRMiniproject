﻿using MetroFramework;
using MetroFramework.Forms;
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
    public partial class ClientForm : MetroForm
    {
        string mode = "";
        public ClientForm()
        {
            InitializeComponent();
        }
        private void UpdateData()
        {
            using (SqlConnection conn = new SqlConnection(Commons.ConnString))
            {
                conn.Open();
                string strQuery = "SELECT C_Idx AS 거래처번호 " +
                    " ,Number AS 등록번호 " +
                    " ,Personnal AS 사업자구분 " +
                    " ,Name AS 거래처명" +
                    " ,Owner AS 대표자 " +
                    " ,Address AS 주소 " +
                    " ,PhoneNumber AS 전화번호 " +
                    " ,Sort AS 업종 " +
                    " ,Part AS 종목 " +
                    " ,Situation AS 거래상태 " +
                                  "  FROM dbo.ClientTbl ";
                SqlCommand cmd = new SqlCommand(strQuery, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn);

                DataSet data = new DataSet();
                dataAdapter.Fill(data, "ClientTbl");
                GrdClientTbl.DataSource = data;
                GrdClientTbl.DataMember = "ClientTbl";
            }

            //DataGridViewColumn column = GrdClientTbl.Columns[2];
            //column.Visible = false;
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void GrdClientTbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow data = GrdClientTbl.Rows[e.RowIndex];
                TxtClientidx.Text = data.Cells[0].Value.ToString();
                TxtClientidx.ReadOnly = true;
                TxtClientidx.BackColor = Color.AntiqueWhite;
                TxtClientpersonnal.Text = data.Cells[2].Value.ToString();
                TxtClientNumber.Text = data.Cells[1].Value.ToString();
                TxtClientName.Text = data.Cells[3].Value.ToString();
                TxtClientOwner.Text = data.Cells[4].Value.ToString();
                TxtClientAddress.Text = data.Cells[5].Value.ToString();
                TxtClientphoneNum.Text = data.Cells[6].Value.ToString();
                TxtClientSort.Text = data.Cells[7].Value.ToString();
                TxtClientpart.Text = data.Cells[8].Value.ToString();
                TxtClientsituation.Text = data.Cells[9].Value.ToString();


                mode = "UPDATE";
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TxtClientpersonnal.Text) ||
                String.IsNullOrEmpty(TxtClientNumber.Text) ||
                String.IsNullOrEmpty(TxtClientOwner.Text) ||
                String.IsNullOrEmpty(TxtClientName.Text) ||
                String.IsNullOrEmpty(TxtClientAddress.Text) ||
                String.IsNullOrEmpty(TxtClientsituation.Text) ||
                String.IsNullOrEmpty(TxtClientphoneNum.Text) ||
                String.IsNullOrEmpty(TxtClientSort.Text) ||
                String.IsNullOrEmpty(TxtClientpart.Text))
            {
                MetroMessageBox.Show(this, "빈값은 저장할 수 없습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SaveProcess(); //DB저장프로세스
            UpdateData();
            ClearTextControls();
        }

        private void ClearTextControls()
        {
            TxtClientpersonnal.Text = TxtClientNumber.Text = TxtClientOwner.Text =
            TxtClientName.Text = TxtClientAddress.Text = TxtClientsituation.Text = TxtClientphoneNum.Text =
            TxtClientSort.Text = TxtClientpart.Text = TxtClientidx.Text = "";
            TxtClientidx.ReadOnly = true;
            TxtClientidx.BackColor = Color.White;
            TxtClientidx.Focus();
        }

        private void SaveProcess()
        {
            if (string.IsNullOrEmpty(mode))
            {
                MetroMessageBox.Show(this, "신규버튼을 누르고 데이터를 저장하십시오", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection conn = new SqlConnection(Commons.ConnString))//다른 창에 STATIC 문으로 작성하여  연결하는 방법 만약 링크를 바꿔야하면 창을 모두 다 열어서 
                                                                              //바꿔야하는데 이렇게 코딩을 하면 해당 창에만 링크 주소를 바꾸면 모두 다 적용된다. 
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                String strQuery = "";

                if (mode == "UPDATE")
                {
                    strQuery = "UPDATE dbo.ClientTbl " +
                              " SET Personnal = @Personnal " +
                                 //" , Number = @Number "+
                                 " , Name = @Name " +
                                 " , Owner = @Owner " +
                                 " , Address = @Address " +
                                 " , PhoneNumber = @PhoneNumber " +
                                 " , Sort = @Sort " +
                                 " , Part = @Part " +
                                 " , Situation = @Situation " +
                                 " WHERE Number = @Number ";
                }
                else if (mode == "INSERT")
                {
                    strQuery = "INSERT INTO dbo.ClientTbl " +
                               " (Number, Personnal, Name, Owner, Address, PhoneNumber, Sort, Part, Situation) " +
                               " VALUES (@Number, @Personnal, @Name, @Owner, @Address, @PhoneNumber, @Sort, @Part, @Situation) ";


                }
                cmd.CommandText = strQuery;
                ////////////////////////////////////////////////////////////////names
                SqlParameter parmClientOwner = new SqlParameter("@Owner", SqlDbType.NVarChar, 50);                                              //CommandText 를  파라미터
                parmClientOwner.Value = TxtClientOwner.Text;
                cmd.Parameters.Add(parmClientOwner);
                ///////////////////////////////////////////////////////////////// division
                SqlParameter parmClientpersonnal = new SqlParameter("@Personnal", SqlDbType.NVarChar, 50);                                                 //CommandText 를  파라미터
                parmClientpersonnal.Value = TxtClientpersonnal.Text;  // 아이템즈가 맞음 !
                cmd.Parameters.Add(parmClientpersonnal);
                //////////////////////////////////////////////////////////////////level
                SqlParameter parmClientName = new SqlParameter("@Name", SqlDbType.NVarChar, 50);                                            //CommandText 를  파라미터
                parmClientName.Value = TxtClientName.Text;
                cmd.Parameters.Add(parmClientName);
                //////////////////////////////////////////////////////////////////addr
                SqlParameter parmClientphoneNum = new SqlParameter("@PhoneNumber", SqlDbType.NVarChar, 50);                                                //CommandText 를  파라미터
                parmClientphoneNum.Value = TxtClientphoneNum.Text;
                cmd.Parameters.Add(parmClientphoneNum);
                /////////////////////////////////////////////////////////////////////// email
                SqlParameter parmClientNumber = new SqlParameter("@Number", SqlDbType.Int, 10);                                              //CommandText 를  파라미터
                parmClientNumber.Value = TxtClientNumber.Text;
                cmd.Parameters.Add(parmClientNumber);
                /////////////////////////////////////////////////////////////////////// price
                SqlParameter parmClientpart = new SqlParameter("@Part", SqlDbType.NVarChar, 50);                                              //CommandText 를  파라미터
                parmClientpart.Value = TxtClientpart.Text;
                cmd.Parameters.Add(parmClientpart);
                /////////////////////////////////////////////////////////////////////// price
                SqlParameter parmClientAddress = new SqlParameter("@Address", SqlDbType.NVarChar, 50);                                              //CommandText 를  파라미터
                parmClientAddress.Value = TxtClientAddress.Text;
                cmd.Parameters.Add(parmClientAddress);
                /////////////////////////////////////////////////////////////////////// price
                SqlParameter parmClientsituation = new SqlParameter("@Situation", SqlDbType.NVarChar, 50);                                              //CommandText 를  파라미터
                parmClientsituation.Value = TxtClientsituation.Text;
                cmd.Parameters.Add(parmClientsituation);
                /////////////////////////////////////////////////////////////////////// price
                SqlParameter parmClientSort = new SqlParameter("@Sort", SqlDbType.NVarChar, 50);                                              //CommandText 를  파라미터
                parmClientSort.Value = TxtClientSort.Text;
                cmd.Parameters.Add(parmClientSort);
                //////////////////////////////////////////////////////////////////// Idex
                //SqlParameter parmClientidx = new SqlParameter("@C_Idx", SqlDbType.Int,2);                                                  //CommandText 를  파라미터
                //parmClientidx.Value = TxtClientidx.Text;
                //cmd.Parameters.Add(parmClientidx);

                cmd.ExecuteNonQuery();
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            ClearTextControls();
            mode = "INSERT"; //신규는 INSERT
        }

        private void TxtClientNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (char.IsLetter((char)e.KeyCode) || char.IsWhiteSpace((char)e.KeyCode))
            {
                MetroMessageBox.Show(this, "숫자만 입력이가능합니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtClientNumber.Text = TxtClientNumber.Text.Substring(0, TxtClientNumber.Text.Length - 1);
                TxtClientNumber.Focus();
                return;
            }
        }
    }
}
