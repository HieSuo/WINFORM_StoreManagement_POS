using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AForge.Video;
using AForge.Video.DirectShow;
using StoreManagement.DAO;
using StoreManagement.DTO;
using StoreManagement.source;
using ZXing;

namespace StoreManagement.GUI.CustomDialog
{
    public partial class CameraDialog : Form
    {
        private SoundPlayer player;

        private VideoCaptureDevice camera;
     
        private BarcodeReader barcodeReader;

        private DateTime lastScanTime;
        public CameraDialog(VideoCaptureDevice camera)
        {
            InitializeComponent();
            this.camera = camera;

            player = new SoundPlayer();
        }

        private void CameraDialog_Load(object sender, EventArgs e)
        {
            barcodeReader = new BarcodeReader();
            if (camera != null && camera.IsRunning)
            {
                camera.Stop();
            }
            lastScanTime = DateTime.MinValue;
            camera.NewFrame += Camera_NewFrame; ;
            camera.Start();
        }

        private void Camera_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            TimeSpan timeSinceLastScan = DateTime.Now - lastScanTime;
            if (timeSinceLastScan.TotalSeconds >= 1)
            {
                picCamera.Image = (Bitmap)eventArgs.Frame.Clone();
                Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();

                Result result = barcodeReader.Decode(bitmap);

                if(result != null)
                {
                    SanPham sanPhamScaned = SanPhamDAO.Instance.GetSanPhamByBarcode(result.Text);
                    if (sanPhamScaned != null)
                    {
                        if (scanBarcodeSuccess != null)
                        {
                            player.SoundLocation = "C:\\Users\\HIEU\\source\\repos\\StoreManagement\\StoreManagement\\source\\SoundEffect\\ScannerSoungEffectWAV.wav";
                            player.Play();
                            scanBarcodeSuccess(this, new SendSanPham(sanPhamScaned));
                        }
                    }
                    else
                    {
                        player.SoundLocation = "C:\\Users\\HIEU\\source\\repos\\StoreManagement\\StoreManagement\\source\\SoundEffect\\ErrorScanEffectWAVShort.wav";
                        player.Play();
                        MessageBox.Show("Mã: "+ result.Text+"Không hợp lệ!");
                    }
                    lastScanTime=DateTime.Now;
                }
            }
        }

        private void CameraDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (camera.IsRunning)
            {
                camera.Stop();
            }
        }

        private event EventHandler<SendSanPham> scanBarcodeSuccess;
        public event EventHandler<SendSanPham> ScanBarcodeSuccess
        {
            add { scanBarcodeSuccess += value; }
            remove { scanBarcodeSuccess -= value; }
        }
    
    
    }
}
