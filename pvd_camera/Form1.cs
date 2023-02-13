using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AForge;
using AForge.Controls;
using AForge.Imaging;
using AForge.Video;
using AForge.Video.DirectShow;

namespace pvd_camera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FilterInfoCollection videoDevices;
        VideoCaptureDevice videoSource;
        static int x = 290, y = 80, y1 = 110;
        public int selectedDeviceIndex = 0;
        string foldPath;
        private void Form1_Load(object sender, EventArgs e)
        {
            AutoScroll = true;
            try
            {
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                if (videoDevices.Count == 0)
                    throw new ApplicationException();

                foreach (FilterInfo device in videoDevices)
                {
                    comboBox1.Items.Add(device.Name);
                }

                comboBox1.SelectedIndex = 0;

            }
            catch (ApplicationException)
            {
                comboBox1.Items.Add("No local capture devices");
                videoDevices = null;
            }
        }

        private void open_btn_Click(object sender, EventArgs e)
        {
            videoSource = new VideoCaptureDevice(videoDevices[comboBox1.SelectedIndex].MonikerString);
            videoSource.DesiredFrameSize = new System.Drawing.Size(320, 240);
            videoSource.DesiredFrameRate = 1;

            image.VideoSource = videoSource;            
            image.Start();
        }
       
        private void take_photo_Click(object sender, EventArgs e)
        {
            if (videoSource == null)
                return;
            if (foldPath == null){
                MessageBox.Show("尚未選擇資料夾路徑", "錯誤!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                Bitmap bitmap = image.GetCurrentVideoFrame();               
                string fileName = file_name_value.Text.ToString() + @".jpg";
                Graphics text = Graphics.FromImage(bitmap);              
                Brush brush = new SolidBrush(Color.Red);
                Font font = new Font(new FontFamily("新細明體"), 20, FontStyle.Bold);
                text.DrawString(number.Text, font, brush, x-26, y-60);
                text.DrawString(size.Text, font, brush, x-26, y1-60);
                if (file_name_value.Text.Length == 0)
                {
                    MessageBox.Show("尚未命名檔案", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    Bitmap resized = new Bitmap(bitmap, new Size(3024, 3024));
                    resized.Save(Path.Combine(foldPath + @"\" + fileName), ImageFormat.Jpeg);
                    resized.Dispose();
                    MessageBox.Show("新增成功", "恭喜 ~", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }        
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           image.SignalToStop();
            image.WaitForStop();
        }

        private void select_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "請選擇檔案路徑";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foldPath = dialog.SelectedPath;            
                path.Text = "檔案位置:" + foldPath;
            }
        }
      
        private void paint_Click(object sender, EventArgs e)
        {
            paiint_name.Font = new Font(new FontFamily("新細明體"), 20, FontStyle.Bold);
            paint_size.Font = new Font(new FontFamily("新細明體"), 20, FontStyle.Bold);
          
            paiint_name.Text = number.Text;
            paint_size.Text = size.Text;
            x += (int)right_num.Value;
            x -= (int)left_num.Value;
            y += (int)down_num.Value;
            y -= (int)up_num.Value;
            y1 += (int)size_down.Value;
            y1 -= (int)size_up.Value;
            paiint_name.Location = new System.Drawing.Point(x, y);
            paint_size.Location = new System.Drawing.Point(x, y1);
            right_num.Value = 0;
            left_num.Value = 0;
            down_num.Value= 0;
            up_num.Value = 0;
            size_down.Value = 0;
            size_up.Value = 0;
        }

    }
}
