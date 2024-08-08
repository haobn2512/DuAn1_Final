using DAL_BUS.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL.Forms
{
    public partial class Form_QuenMk : Form
    {
        AppDbContext _context;
        public Form_QuenMk()
        {
            InitializeComponent();
            _context = new AppDbContext();
        }

        private void btn_laymk_Click(object sender, EventArgs e)
        {
            
            string username = txtUsername.Text;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập.");
                btn_laymk.Enabled = true;
                return;
            }
            else
            {
                var account = _context.Accounts.FirstOrDefault(p => p.UserName == username);
                if (account != null)
                {
                    // Tạo mật khẩu mới ngẫu nhiên
                    string newPassword = GenerateNewPassword();
                    account.Password = newPassword;

                    // Lưu thay đổi vào cơ sở dữ liệu
                    _context.SaveChanges();

                    // Hiển thị mật khẩu mới
                    txt_newMk.Text = newPassword;
                    btn_laymk.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Username không tồn tại trong hệ thống.");
                   
                }
            }
            

        }

        private string GenerateNewPassword(int length = 8)
        {
            const string validChars = "lp6828";
            Random random = new Random();
            char[] newPassword = new char[length];

            for (int i = 0; i < length; i++)
            {
                newPassword[i] = validChars[random.Next(validChars.Length)];
            }

            return new string(newPassword);
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
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
