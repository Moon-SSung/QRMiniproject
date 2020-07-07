using MetroFramework.Forms;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ZXing;
using AForge.Video.DirectShow;
using AForge.Video;
using System.Data.SqlClient;
using MetroFramework;
/// <summary>
/// 사용한 Nuget패키지 : Zxing(qrcode 인식) , aforge(웹캠실행)
/// </summary>
namespace QRMiniproject
{
    public partial class InPutForm : MetroForm
    {
        string mode = "";
        //FilterInfoCollection 객체생성
        FilterInfoCollection FilterInfoCollection;
        //VideoCaptureDeveice 객체생성
        VideoCaptureDevice captureDevice = null;

        public InPutForm()
        {
            InitializeComponent();
            //그리드 column을 데이터에 맞게 자동으로 설정해줌.
            GrdInput.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        
        /// <summary>
        /// Combobox의 DropDownstyle을 list로 변경하고 노트북에 연결된 웹캠의 정보를 나타낸다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// InputTbl의 I_Idx, Indate, ID(제품코드), count(수량), storage(창고)를 불러오고 ClientTbl과
        /// innerjoin시켜 C_Idx에 맞는 C.Name(거래처를 불러온다. 불러온 데이터를 grid에 나타낸다.
        /// </summary>
        private void UpdateData()
        {
            using (SqlConnection conn = new SqlConnection(Commons.ConnString))
            {
                conn.Open(); 
                string strQuery = @"SELECT I_Idx, Indate AS 입고날짜, ID AS 제품코드 , Count AS 수량, Storage AS 창고, C.Name As '거래처' FROM InputTbl As I
                                    INNER JOIN ClientTbl AS C ON I.ClientIdx = C.C_Idx ";           //grid에 데이터 불러오기

                SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, " InputTbl ");

                GrdInput.DataSource = ds;
                GrdInput.DataMember = " InputTbl ";
                GrdInput.Columns[0].Visible = false;
            }
        }
        /// <summary>
        /// 노트북에 내장된 웹캠을 실행시키는 Code
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnQRNew_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(FilterInfoCollection[CboDevice.SelectedIndex].MonikerString);
            captureDevice.NewFrame += captureDevice_NewFrame;
            captureDevice.Start();
            Picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            timer1.Start();
        }
        //eventArgs.Frame : 웹캠에 떠있는 화면을 clone(복제)해서 Bitmap화 시킨다음 picturebox의 image에 대입한다.
        private void captureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Picturebox.Image = (Bitmap)eventArgs.Frame.Clone();
        }
        /// <summary>
        /// tiemer interval을 1000으로 설정(1초룰 나타냄) QRcode를 인식하는 code
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {       //picturebox에서 출력되는 image를 1초단위로 인식하고 Bitmap화(이미지를 메모리형태로 저장?) 한다? (점 방식)
            if (Picturebox.Image != null)
            {   //barcodeReader 객체생성
                BarcodeReader barcodeReader = new BarcodeReader();
                //픽쳐박스의 이미지를 비트맵화시키고 decode한 값을 barcoderReader에 넣은 것을 result?
                Result result = barcodeReader.Decode((Bitmap)Picturebox.Image);
                //split : '/'을 기준으로 끊어준다. qr코드의 데이터의 원본은 123/456/789 이렇기 때문에 '/'단위로 끊어준다.
                if (result != null)
                {   //space라는 객체를 만듬 > '/' 단위로 끊어서 tostring화 한 다음 배열에 집어넣는다?
                    string[] space = result.ToString().Split(new char[] { '/' }, StringSplitOptions.None);
                    //txtbox순서대로 qrcode의 데이터를 끊어준다.
                    TxtClientidx.Text = space[1];    // 거래처번호
                    TxtProductidx.Text = space[2];   // 품목코드     
                    TxtProductUnit.Text = space[4];  // 수량
                    //타이머 stop
                    timer1.Stop();
                    //capturedevice가 계속 진행되면 연결을 끊어준다.
                    if (captureDevice.IsRunning)
                        captureDevice.Stop();
                }
            }
        }
        //save버튼 클릭시 발생하는 이벤트 : saveprocess메서드 발동
        private void BtnSave_Click(object sender, EventArgs e)
        {
            Saveprocess();
        }

        /// <summary>
        /// 우선 신규버튼을 누르고 데이터를 저장해야한다는 문구가 뜬다. 
        /// DB를 연결하고 쿼리문을 열어 UPDATE할 데이터들을 정한다.
        /// </summary>
        private void Saveprocess()
        {
            if (string.IsNullOrEmpty(mode))
            {
                MetroMessageBox.Show(this, "신규버튼을 누르고 데이터를 저장하세요.", "경고",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            //try~catch문을 이용하여 DB에 저장되어있지않는 데이터를 입력시 에러가 발생하는것을 예외처리함
            try
            {
                using (SqlConnection conn = new SqlConnection(Commons.ConnString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    string strQuery = "";
                    //업데이트 할 데이터들
                    if (mode == "UPDATE")
                    {
                        strQuery = @"UPDATE @dbo.@InputTbl SET Indate = @Indate, ID = @ID 
                                , Count = @Count , Storage = Storage , ClientIdx = @ClientIdx ";
                        cmd.CommandText = strQuery;
                    }
                    //신규로 삽입할 데이터들
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
            //에러 발생시 뜨는 문구를 정한다. 저장되어있지않는 거래처번호를 삽입하면 에러가 뜨게된다.
            //그러면 거래처번호를 저장할 수 있는 form으로 넘어갈 수 있다.
            catch (Exception)
            {
                DialogResult result;
                result = MetroMessageBox.Show(this, "저장된 거래처번호가 존재하지않습니다. 거래처번호를 등록하시겠습니까?", "오류",
                MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    ClientForm clientForm = new ClientForm();
                    clientForm.Show();
                }
            }
        }
        //BtnExit 클릭 시 프로그램 종료
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        //BtnNew 클릭 시 쿼리문에 삽입되는 INSERT 모드가 되고 ClearTextprocess 메서드가 발동
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
        //button1 클릭 시 form이 종료된다
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //수량 text에서 엔터(keychar : 13)을 누르면 saveprocess 메서드가 발동된다.
        private void TxtProductUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                Saveprocess();
            }
        }
        /// <summary>
        /// 웹캠 출력을 정지하는 기능
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CameraOff_Click(object sender, EventArgs e)
        {//captureDeive의 출력값이 null이 아니고(출력이 될 때) and captureDevice가 실행되고 있을 때
            if (captureDevice != null && captureDevice.IsRunning)
            {//captureDevoce를 stop시키고 출력값을 null로 만들어라
                captureDevice.Stop();
                captureDevice = null;
            }

            //픽쳐박스의 이미지가 null이 아닐 때(이미지가 있을 때 > 웹캠이 동작하고 있을 때 ) 픽쳐박스의 이미지를 null로 만들어라
            if (Picturebox.Image != null) //picturebox에 값이 있을 때 초기화
            {
                Picturebox.Image = null;
            }
        }
    }
}
