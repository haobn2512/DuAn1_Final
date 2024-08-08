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
    public partial class Form_DoiMk : Form
    {
        public Form_DoiMk()
        {
            InitializeComponent();
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
            Application.Run(new Form_ManHinhCho());
        }

        private void btn_DoiMk_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text; // Số điện thoại người dùng nhập
            string oldPassword = txtOldPassword.Text; // Mật khẩu cũ
            string newPassword = txtNewPassword.Text; // Mật khẩu mới
            string confirmPassword = txtConfirmPassword.Text; // Xác nhận mật khẩu mới

            using (var context = new AppDbContext())
            {
                // Tìm người dùng theo số user và pass cũ
                var account = context.Accounts
                    .FirstOrDefault(u => u.UserName == username && u.Password == oldPassword);

                if (account == null)
                {
                    MessageBox.Show("Mật khẩu cũ không đúng hoặc không tìm thấy người dùng.");
                    return;
                }

                if (newPassword != confirmPassword)
                {
                    MessageBox.Show("Mật khẩu mới và mật khẩu xác nhận không khớp.");
                    return;
                }

                // Cập nhật mật khẩu mới
                account.Password = newPassword;

                try
                {
                    context.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
                    MessageBox.Show("Đổi mật khẩu thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                }
            }

            this.Close();
            Thread thread = new Thread(OpenFormDangNhap);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void cb_newmk_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_newmk.Checked)
            {
                txtNewPassword.PasswordChar = '\0';
            }
            else txtNewPassword.PasswordChar = '*';
        }

        private void cb_newmkagain_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_newmkagain.Checked)
            {
                txtConfirmPassword.PasswordChar = '\0';
            }
            else txtConfirmPassword.PasswordChar = '*';
        }

        private void cb_mkcu_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_mkcu.Checked)
            {
                txtOldPassword.PasswordChar = '\0';
            }
            else txtOldPassword.PasswordChar = '*';
        }
    }
}
