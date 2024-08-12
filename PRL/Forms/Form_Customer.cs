using DAL_BUS.BUS;
using DAL_BUS.DAL;
using iText.Kernel.Pdf.Canvas.Parser.ClipperLib;
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
    public partial class Form_Customer : Form
    {
        CustomerServives _service;
        public Form_Customer()
        {
            InitializeComponent();
            _service = new CustomerServives();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string phoneNumber = txt_PhoneNumber.Text;
            string name = txt_Name.Text;
            int point = 0; // chưa dùng đến point
            _service.Create(phoneNumber, name, point);
            LoadDataToGridView();
            MessageBox.Show("Thêm thành công");
        }

        public void LoadDataToGridView()
        {
            dtg_Data.DataSource = null;
            var allCustomer = _service.GetAll();
            dtg_Data.DataSource = allCustomer;
        }
        private void Form_Customer_Load(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string phoneNumber = txt_PhoneNumber.Text.Trim();
            string customerName = txt_Name.Text.Trim();
            int point;

            // Kiểm tra xem điểm có phải là số hay không
            if (!int.TryParse(txt_Point.Text.Trim(), out point))
            {
                MessageBox.Show("Điểm phải là một số hợp lệ.");
                return;
            }

            using (var context = new AppDbContext())
            {
                // Tìm khách hàng theo số điện thoại
                var customer = context.Customers.SingleOrDefault(c => c.PhoneNumber == phoneNumber);

                if (customer != null)
                {
                    // Cập nhật thông tin khách hàng
                    customer.Name = customerName;
                    customer.Point = point;

                    // Lưu thay đổi
                    context.SaveChanges();
                    MessageBox.Show("Cập nhật thành công!");
                }
                else
                {
                    MessageBox.Show("Khách hàng không tồn tại.");
                }
            }
        }

        private void dtg_Data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có nhấp vào hàng hợp lệ không
            if (e.RowIndex >= 0)
            {
                // Lấy thông tin từ hàng đã chọn
                var row = dtg_Data.Rows[e.RowIndex];

                // Cập nhật các trường nhập liệu
                txt_PhoneNumber.Text = row.Cells["PhoneNumber"].Value.ToString();
                txt_Name.Text = row.Cells["Name"].Value.ToString();
                txt_Point.Text = row.Cells["Point"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_PhoneNumber.Text = "";
            txt_Name.Text = "";
            txt_Point.Text = "";
        }
    }


}
