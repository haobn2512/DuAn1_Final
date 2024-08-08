using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL.Forms
{
    public partial class Form_ManHinhCho : Form
    {
        public Form_ManHinhCho()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btn_HuongDan_Click(object sender, EventArgs e)
        {
            // Thay đổi đường dẫn tới file PDF của bạn
            string pdfUrl = "https://docs.google.com/document/d/10mfpCy6eFt5DXCqUPoMgY5nTZEpHeYO2DRTWZyfL1-w/edit?usp=sharing";

            try
            {
                // Mở URL trong trình duyệt mặc định
                Process.Start(new ProcessStartInfo
                {
                    FileName = pdfUrl,
                    UseShellExecute = true // Sử dụng shell để mở URL
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể mở file PDF: " + ex.Message);
            }
        }

        private void Form_ManHinhCho_Load(object sender, EventArgs e)
        {
            btn_DangXuat.Enabled = false;
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFormDangNhap);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void OpenFormDangNhap()
        {
            Application.Run(new Form_Login());
        }
    }
}
