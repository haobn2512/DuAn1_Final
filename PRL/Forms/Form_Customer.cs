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
    }

   
}
