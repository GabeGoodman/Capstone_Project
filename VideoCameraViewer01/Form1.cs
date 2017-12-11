using System;
using System.Drawing;
using System.Windows.Forms;
using Ozeki.Media;
using Ozeki.Camera;
using FinchAPI;

namespace VideoCameraViewer01
{
    public partial class Form1 : Form
    {
        static Finch myFinch = new Finch();
        static int speed;

        private VideoViewerWF _videoViewer;
        private IWebCamera _webCamera;
        private DrawingImageProvider _imageProvider;
        private MediaConnector _mediaConnector;

        public Form1()
        {
            InitializeComponent();

            _videoViewer = new VideoViewerWF();

            _imageProvider = new DrawingImageProvider();
            _mediaConnector = new MediaConnector();

            SetVideoViewer();
            this.Controls.Add(_videoViewer);
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            _webCamera = new WebCamera();

            if (_webCamera != null)
            {
                _mediaConnector.Connect(_webCamera.VideoChannel, _imageProvider);
                _videoViewer.SetImageProvider(_imageProvider);
                _webCamera.Start();
                _videoViewer.Start();
            }
        }

        private void SetVideoViewer()
        {
            _videoViewer.Location = new Point(10, 10);
            _videoViewer.Size = new Size(250, 200);
            _videoViewer.BackColor = Color.Black;
            _videoViewer.TabStop = false;
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (speed < 1)
            {
                myFinch.setMotors(100, 100);
            }
            else
            {
                myFinch.setMotors(speed, speed);
            }
        }

        private void btnBackward_Click(object sender, EventArgs e)
        {
            if (speed < 1)
            {
                myFinch.setMotors(-100, -100);
            }
            else
            {
                myFinch.setMotors(-speed, -speed);
            }
        }
        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (speed < 1)
            {
                myFinch.setMotors(0, 100);
            }
            else
            {
                myFinch.setMotors(0, speed);
            }
        }
        private void btnRight_Click(object sender, EventArgs e)
        {
            if (speed < 1)
            {
                myFinch.setMotors(100, 0);
            }
            else
            {
                myFinch.setMotors(speed, 0);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            myFinch.setMotors(0, 0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out speed))
            {

            }
        }

        private void rbConnect_CheckedChanged(object sender, EventArgs e)
        {
            myFinch.connect();
        }

        private void rbDisconnect_CheckedChanged(object sender, EventArgs e)
        {
            myFinch.disConnect();
        }
    }
}