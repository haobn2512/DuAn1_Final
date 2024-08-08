using DAL_BUS.BUS;
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
    public partial class Form_Login : Form
    {
        AccountServices _accountServices;
        public Form_Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            _accountServices = new AccountServices();
            string ussername = txt_UserName.Text;
            string password = txt_Pass.Text;
            string accountInfo = _accountServices.Login(ussername, password);
            if (string.IsNullOrEmpty(accountInfo))
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
            else if (accountInfo.Split(':')[0] == "0")//cắt ra để lấy role
            {
                MessageBox.Show("Tài khoản đã bị khóa");
            }
            else
            {
                MessageBox.Show("Đăng nhập thành công");
                Form_Main main = new Form_Main(accountInfo);
                main.Show();
            }
            
        }

        private void cb_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_ShowPass.Checked)
            {
                txt_Pass.PasswordChar = '\0';
            }
            else txt_Pass.PasswordChar = '*';
        }

        private void linklable_QuenMk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFormQuenMk);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void OpenFormQuenMk()
        {
            Application.Run(new Form_QuenMk());
        }
    }
}
