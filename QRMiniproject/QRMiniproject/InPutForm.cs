using MetroFramework.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using AForge;
using AForge.Video.DirectShow;
using ZXing.QrCode.Internal;
using AForge.Video;
using System.Data.SqlClient;
using System.Diagnostics;
using MetroFramework;

namespace QRMiniproject
{
    public partial class InPutForm : MetroForm
    {
        string mode = "";
        FilterInfoCollection FilterInfoCollection;
        VideoCaptureDevice captureDevice = null;

        public InPutForm()
        {
            InitializeComponent();
        }

        private void InPutForm_Load(object sender, EventArgs e)
        {
            FilterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterinfo in FilterInfoCollection)
            {
                CboDevice.Items.Add(filterinfo.Name);
                CboDevice.SelectedIndex = 0;
                UpdateData();
            }
        }

        private void UpdateData()
        {
            using (SqlConnection conn = new SqlConnection(Commons.ConnString))
            {
                conn.Open();
                string strQuery = @"SELECT I_Idx, Indate, ID, Count, Storage, C.Name As '거래처' FROM InputTbl As I
                                    INNER JOIN ClientTbl AS C ON I.ClientIdx = C.C_Idx ";           //grid에 데이터 불러오기

                SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, " InputTbl ");

                GrdInput.DataSource = ds;
                GrdInput.DataMember = " InputTbl ";
            }
        }

        private void BtnQRNew_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(FilterInfoCollection[CboDevice.SelectedIndex].MonikerString);
            captureDevice.NewFrame += captureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }

        private void captureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            //throw new NotImplementedException();
            Picturebox.Image = (Bitmap)eventArgs.Frame.Clone();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Picturebox.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)Picturebox.Image);

                if (result != null)
                {
                    string[] space = result.ToString().Split(new char[] { '/' }, StringSplitOptions.None);


                    TxtClientidx.Text = space[1];    // 거래처번호
                    TxtProductidx.Text = space[2];   // 품목코드     //qr코드 데이터를 한줄씩 띄어주기
                    TxtProductUnit.Text = space[4];  // 수량

                    timer1.Stop();
                    if (captureDevice.IsRunning)
                        captureDevice.Stop();
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Saveprocess();

        }

        private void Saveprocess()
        {
            if(string.IsNullOrEmpty(mode))
            {
                MetroMessageBox.Show(this, "신규버튼을 누르고 데이터를 저장하세요.", "경고",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            using (SqlConnection conn = new SqlConnection(Commons.ConnString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                string strQuery = "";


                if(mode == "UPDATE")
                {
                    strQuery = @"UPDATE @dbo.@InputTbl SET Indate = @Indate, ID = @ID 
                                , Count = @Count , Storage = Storage , ClientIdx = @ClientIdx ";
                    cmd.CommandText = strQuery;

                }

                else if (mode == "INSERT")               
                {
                    strQuery = @"INSERT INTO dbo.InputTbl
                                (Indate, ID, Count, Storage, ClientIdx)
                                VALUES (@Indate, @ID, @Count, @Storage, @ClientIdx)";
                    cmd.CommandText = strQuery;
                }

                //거래처번호
                SqlParameter parmClientIdx = new SqlParameter("@ClientIdx", SqlDbType.Int);
                parmClientIdx.Value = TxtClientidx.Text;
                cmd.Parameters.Add(parmClientIdx);
                //품목코드
                SqlParameter parmID = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
                parmID.Value = TxtProductidx.Text;
                cmd.Parameters.Add(parmID);
                //수량
                SqlParameter parmCount = new SqlParameter("@Count", SqlDbType.Int);
                parmCount.Value = TxtProductUnit.Text;
                cmd.Parameters.Add(parmCount);
                //창고(콤보박스)
                SqlParameter parmContainer = new SqlParameter("@Storage", SqlDbType.NVarChar, 50);
                parmContainer.Value = CboContainer.SelectedItem;
                cmd.Parameters.Add(parmContainer);
                //오늘날짜
                SqlParameter parmIndate = new SqlParameter("@Indate", SqlDbType.Date);
                parmIndate.Value = DateTime.Now.ToString("yyyy-MM-dd");
                cmd.Parameters.Add(parmIndate);

                cmd.ExecuteNonQuery();
                UpdateData();
              
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            mode = "INSERT";
            ClearTextprocess();
        }

        //출력된 값들을 없애주는 메서드
        private void ClearTextprocess()        
        {
            TxtClientidx.Text = TxtProductidx.Text = TxtProductUnit.Text = "";
            CboContainer.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            // 왜 로그인폼이 뜨나
        }

        private void TxtProductUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                Saveprocess();
            }
        }
    }
}
