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

namespace QRMiniproject
{
    public partial class InPutForm : MetroForm
    {
        VideoCapture capture;
        Mat frame;
        Bitmap image;
        private Thread camera;
        int isCameraRunning = 0;
        private void CaptureCamera()
        {

            camera = new Thread(new ThreadStart(CaptureCameraCallback));
            camera.Start();
        }

        private void CaptureCameraCallback()
        {
            frame = new Mat();
            capture = new VideoCapture();
            capture.Open(1);

            while (isCameraRunning == 1)
            {
                capture.Read(frame);
                if (!frame.Empty())
                {
                    image = BitmapConverter.ToBitmap(frame);
                    pictureBoxIpl1.Image = image;
                }
                image = null;
            }

        }

        public InPutForm()
        {
            InitializeComponent();
        }

        private void InPutForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnQRNew_Click(object sender, EventArgs e)
        {
            if (BtnQRNew.Text.Equals("Start"))
            {
                CaptureCamera();
                BtnQRNew.Text = "Stop";
                isCameraRunning = 1;
            }
            else
            {
                if (capture.IsOpened())
                {
                    capture.Release();
                }

                BtnQRNew.Text = "Start";
                isCameraRunning = 0;
            }
        }
    }
}
