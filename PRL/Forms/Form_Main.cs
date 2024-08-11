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
    public partial class Form_Main : Form
    {
        string accountInfo;
        public Form_Main(string accountInfo)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.accountInfo = accountInfo;
        }

        public Form_Main()
        {
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            btn_DangNhap.Enabled = false;
            string[] infor = accountInfo.Split(':');
            lb_Account.Text = infor[1];
            if (infor[0] == "2")
            {
                btn_qlnv.Enabled = false;
                btn_qlsp.Enabled = false;
                btn_ThongKe.Enabled = false;
                btn_Sale.Enabled = false;
            }
        }

        private void btn_DoiMk_Click(object sender, EventArgs e)
        {
            Form_DoiMk doiMk = new Form_DoiMk();
            doiMk.Show();
            this.Hide();
        }

        private void btn_HoSoNv_Click(object sender, EventArgs e)
        {
            Form_DoiMk doiMk = new Form_DoiMk();
            doiMk.Show();
            this.Hide();
        }

        private void btn_qlnv_Click(object sender, EventArgs e)
        {
            pn_MainProgram.Controls.Clear();
            Form_Account form_Account = new Form_Account();
            form_Account.TopLevel = false;
            form_Account.FormBorderStyle = FormBorderStyle.None;
            pn_MainProgram.Controls.Add(form_Account);
            form_Account.Show();
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {

            this.Close();
            Thread thread = new Thread(OpenManHinhCho);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void OpenManHinhCho()
        {
            Application.Run(new Form_ManHinhCho());
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_Sale_Click(object sender, EventArgs e)
        {
            pn_MainProgram.Controls.Clear();
            Form_Sale form_Sale = new Form_Sale();
            form_Sale.TopLevel = false;
            form_Sale.FormBorderStyle = FormBorderStyle.None;
            pn_MainProgram.Controls.Add(form_Sale);
            form_Sale.Show();
        }

        private void btn_qlsp_Click(object sender, EventArgs e)
        {
            pn_MainProgram.Controls.Clear();
            Form_QLSPham form_QLSP = new Form_QLSPham();
            form_QLSP.TopLevel = false;
            form_QLSP.FormBorderStyle = FormBorderStyle.None;
            pn_MainProgram.Controls.Add(form_QLSP);
            form_QLSP.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pn_MainProgram.Controls.Clear();
            Form_BanHang form_BanHang = new Form_BanHang();
            form_BanHang.TopLevel = false;
            form_BanHang.FormBorderStyle = FormBorderStyle.None;
            pn_MainProgram.Controls.Add(form_BanHang);
            form_BanHang.Show();
        }

        private void btn_Hdsd_Click(object sender, EventArgs e)
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

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pn_MainProgram.Controls.Clear();
            Form_Customer form_Cus = new Form_Customer();
            form_Cus.TopLevel = false;
            pn_MainProgram.Controls.Add(form_Cus);
            form_Cus.FormBorderStyle = FormBorderStyle.None;
            form_Cus.Show();
        }

        private void btn_ThongKeSp_Click(object sender, EventArgs e)
        {
            pn_MainProgram.Controls.Clear();
            Form_ThongKe form_tk = new Form_ThongKe();
            form_tk.TopLevel = false;
            pn_MainProgram.Controls.Add(form_tk);
            form_tk.FormBorderStyle = FormBorderStyle.None;
            form_tk.Show();

        }
    }
}
