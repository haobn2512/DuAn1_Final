using DAL_BUS.BUS;
using DAL_BUS.DAL;
using PRL.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PRL.Forms
{
    public partial class Form_BanHang : Form
    {
        CustomerServives _customerServices;
        ProductServices _productServices;
        SaleServices _saleServices;
        BillServices _billServices;
        BillDetailsServices _billDetailsService;
        List<Product> _products;
        List<Customer> _customers;
        public int currentBillId = -1;
        public Form_BanHang()
        {
            InitializeComponent();
            _productServices = new ProductServices();
        }

        public Panel CreateSP(SaleProduct product)
        {
            PictureBox ptb_Img = new PictureBox();
            Label lbName = new Label();
            Label lbGia = new Label();
            Label lbSoluong = new Label();
            Label lb_Mota = new Label();
            Label lb_Xuatxu = new Label();
            Label lbGiaValues = new Label();
            Label lbSoluongValues = new Label();
            Label lb_giacu = new Label();
            System.Windows.Forms.Button btn_Mua = new System.Windows.Forms.Button();
            System.Windows.Forms.TextBox ttx_Soluongban = new System.Windows.Forms.TextBox();
            // 
            // ptb_Img
            // 
            ptb_Img.Location = new Point(18, 25);
            ptb_Img.Name = "ptb_Img";
            ptb_Img.Size = new Size(239, 234);
            ptb_Img.TabIndex = 0;
            ptb_Img.ImageLocation = product.ImgURL;
            ptb_Img.SizeMode = PictureBoxSizeMode.StretchImage;

            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(285, 25);
            lbName.Name = "lbName";
            lbName.Size = new Size(149, 32);
            lbName.TabIndex = 1;
            lbName.Text = product.Name;
            // 
            // lbGia
            // 
            lbGia.AutoSize = true;
            lbGia.Location = new Point(285, 74);
            lbGia.Name = "lbGia";
            lbGia.Size = new Size(95, 32);
            lbGia.TabIndex = 2;
            lbGia.Text = "Gía bán";
            // 
            // lbSoluong
            // 
            lbSoluong.AutoSize = true;
            lbSoluong.Location = new Point(278, 198);
            lbSoluong.Name = "lbSoluong";
            lbSoluong.Size = new Size(156, 32);
            lbSoluong.TabIndex = 3;
            lbSoluong.Text = "Số lượng còn";
            // 
            // lb_Mota
            // 
            lb_Mota.AutoSize = true;
            lb_Mota.Location = new Point(18, 307);
            lb_Mota.Name = "lb_Mota";
            lb_Mota.Size = new Size(105, 32);
            lb_Mota.TabIndex = 3;
            lb_Mota.Text = product.Details;
            // 
            // lb_Xuatxu
            // 
            lb_Xuatxu.AutoSize = true;
            lb_Xuatxu.Location = new Point(18, 369);
            lb_Xuatxu.Name = "lb_Xuatxu";
            lb_Xuatxu.Size = new Size(95, 32);
            lb_Xuatxu.TabIndex = 3;
            lb_Xuatxu.Text = product.From;
            // 
            // lbGiaValues
            // 
            lbGiaValues.AutoSize = true;
            lbGiaValues.Location = new Point(306, 166);
            lbGiaValues.Name = "lbGiaValues";
            lbGiaValues.Size = new Size(92, 32);
            lbGiaValues.TabIndex = 2;
            lbGiaValues.Text = product.Price.ToString();
            lbGiaValues.Font = new Font(lb_Xuatxu.Font, FontStyle.Strikeout);
            // 
            // lbSoluongValues
            // 
            lbSoluongValues.AutoSize = true;
            lbSoluongValues.Location = new Point(306, 240);
            lbSoluongValues.Name = "lbSoluongValues";
            lbSoluongValues.Size = new Size(92, 32);
            lbSoluongValues.TabIndex = 2;
            lbSoluongValues.Text = product.TotalAmount.ToString();

            // 
            // btn_Mua
            // 
            btn_Mua.Location = new Point(237, 362);
            btn_Mua.Name = "btn_Mua";
            btn_Mua.Size = new Size(204, 46);
            btn_Mua.TabIndex = 4;
            btn_Mua.Text = "Mua hàng";
            btn_Mua.UseVisualStyleBackColor = true;
            btn_Mua.MouseClick += BtnMua_MouseClick;
            // 
            // ttx_Soluongban
            // 
            ttx_Soluongban.Location = new Point(241, 304);
            ttx_Soluongban.Name = "ttx_Soluongban";
            ttx_Soluongban.PlaceholderText = "Nhập SL";
            ttx_Soluongban.Size = new Size(200, 39);
            ttx_Soluongban.TabIndex = 5;
            // 
            // lb_giacu
            // 
            lb_giacu.AutoSize = true;
            lb_giacu.Location = new Point(306, 121);
            lb_giacu.Name = "lb_giacu";
            lb_giacu.Size = new Size(92, 32);
            lb_giacu.TabIndex = 2;
            lb_giacu.Text = product.SalePrice.ToString();

            // Form_CpnSP
            // 
            Panel pn = new Panel();
            pn.Size = new Size(500, 500);
            pn.Name = product.Id.ToString();
            pn.Controls.Add(ttx_Soluongban);
            pn.Controls.Add(btn_Mua);
            pn.Controls.Add(lb_Xuatxu);
            pn.Controls.Add(lb_Mota);
            pn.Controls.Add(lbSoluong);
            pn.Controls.Add(lbSoluongValues);
            pn.Controls.Add(lbGiaValues);
            pn.Controls.Add(lbGia);
            pn.Controls.Add(lbName);
            pn.Controls.Add(ptb_Img);
            pn.Controls.Add(lb_giacu);
            return pn;
        }

        private void Form_BanHang_Load(object sender, EventArgs e)
        {
            LoadSPToPanel(Convert.ToInt32(lb_page.Text));
            LoadBill();
        }

        private void lb_Back_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(lb_page.Text) >= 2)
            {
                lb_page.Text = Convert.ToInt32(lb_page.Text) - 1 + "";
                LoadSPToPanel(Convert.ToInt32(lb_page.Text));
            }

        }

        public void LoadSPToPanel(int page)
        {
            tlp_Product.Controls.Clear();
            _products = _productServices.GetProducts(); // Lấy ra tất cả SP
            _saleServices = new SaleServices();
            var sales = _saleServices.GetAllSale();
            // Join để lấy data
            var saleProducts =
                from product in _products
                join sale in sales
                on product.SaleID equals sale.Id
                select new SaleProduct
                {
                    Id = product.Id,
                    Name = product.Name,
                    Details = product.Details,
                    ImgURL = product.ImgURL,
                    From = product.From,
                    Price = product.Price,
                    TotalAmount = product.TotalAmount,
                    Status = product.Status,
                    SalePrice = Convert.ToInt64(product.Price - product.Price * (sale.Percent / 100))
                };
            // Khi có danh sách sản phẩm ta kiểm tra xem page có vi phạm không
            if (page * 4 - 4 < saleProducts.ToList().Count)
            {
                SaleProduct sp = saleProducts.ToList()[page * 4 - 4];
                Panel p1 = CreateSP(sp);
                tlp_Product.Controls.Add(p1, 0, 0);
            }
            if (page * 4 - 3 < saleProducts.ToList().Count)
            {
                SaleProduct sp = saleProducts.ToList()[page * 4 - 3];
                Panel p2 = CreateSP(sp);
                tlp_Product.Controls.Add(p2, 0, 1);
            }
            if (page * 4 - 2 < saleProducts.ToList().Count)
            {
                SaleProduct sp = saleProducts.ToList()[page * 4 - 2];
                Panel p3 = CreateSP(sp);
                tlp_Product.Controls.Add(p3, 1, 0);
            }
            if (page * 4 - 1 < saleProducts.ToList().Count)
            {
                SaleProduct sp = saleProducts.ToList()[page * 4 - 1];
                Panel p4 = CreateSP(sp);
                tlp_Product.Controls.Add(p4, 1, 1);
            }
        }

        private void lb_Next_Click(object sender, EventArgs e)

        {
            var products = _productServices.GetProducts();
            int count = products.Count;
            if (Convert.ToInt32(lb_page.Text) < count / 4 && count % 4 == 0
                || Convert.ToInt32(lb_page.Text) <= count / 4 && count % 4 != 0)
            {
                lb_page.Text = Convert.ToInt32(lb_page.Text) + 1 + "";
                LoadSPToPanel(Convert.ToInt32(lb_page.Text));
            }
        }



        private void BtnMua_MouseClick(object? sender, MouseEventArgs e)
        {


            long price = 0;
            int amount = 0;
            // Lấy thông tin của panel chứa SP
            System.Windows.Forms.Button btnMua = sender as System.Windows.Forms.Button;
            Panel cpnSP = btnMua.Parent as Panel;

            // Lấy danh sách Label trong Panel ra
            List<Label> labels = new List<Label>();
            List<System.Windows.Forms.TextBox> textboxs = new List<System.Windows.Forms.TextBox>();
            foreach (var item in cpnSP.Controls)
            {
                if (item is Label) labels.Add(item as Label);
                if (item is System.Windows.Forms.TextBox) textboxs.Add(item as System.Windows.Forms.TextBox);
            }
            foreach (var item in labels)
            {
                if (item.Name == "lb_giacu")
                {
                    price = Convert.ToInt64(item.Text); break;
                }
            }
            foreach (var item in textboxs)
            {
                if (item.Name == "ttx_Soluongban")
                {
                    amount = Convert.ToInt32(item.Text); break;
                }
            }


            // Lấy các thuộc tính vần thiết
            Guid productId = Guid.Parse(cpnSP.Name);
            Guid billId = Guid.Parse(lb_MaHD.Text);
            _billDetailsService = new BillDetailsServices();
            _billDetailsService.AddToBill(billId, productId, price, amount);
            LoadBillDetails(Guid.Parse(lb_MaHD.Text));

        }

        public void LoadBillDetails(Guid billId)
        {
            _billDetailsService = new BillDetailsServices();
            var billDetails = _billDetailsService.GetAllByBillId(billId);
            dgv_HDCT.DataSource = null;
            dgv_HDCT.DataSource = billDetails;
        }

        private void cbbsdt_TextChanged(object sender, EventArgs e)
        {
            int index = cbb_Phone.SelectedIndex;
            txtName.Text = _customers[index].Name + "-" + _customers[index].PhoneNumber;
        }

        private void txt_Phone_TextChanged(object sender, EventArgs e)
        {
            cbb_Phone.Items.Clear();
            _customerServices = new CustomerServives();
            string searchPhone = txt_Phone.Text;
            _customers = _customerServices.GetByPhone(searchPhone); // tìm kiếm và hiện ra khi cần
            foreach (var item in _customers)
            {
                cbb_Phone.Items.Add(item.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_CreateBill_Click(object sender, EventArgs e)
        {
            string accountId = "";
            var formMain = this.Parent.Parent as Form; // Lấy từ form Cha là form Main
            // this là formBanHang cho nên Parent của nó là Panel, Parent của panel mới là form Main
            List<Label> labels = new List<Label>();
            foreach (var item in formMain.Controls)
            {
                if (item is Label) labels.Add((Label)item);
            }
            // Lấy hết label từ form cha
            foreach (var item in labels)
            {
                if (item.Name == "lb_Account")
                {
                    accountId = item.Text; break; 
                }
            } // từ các label mình lấy ra label nào có tên là Account ID để thông qua đó lấy ID
            _billServices = new BillServices();
            _billServices.Create(accountId, cbb_Phone.Text);
            LoadBill();
        }
        public void LoadBill()
        {
            dgv_HD.DataSource = null;
            _billServices = new BillServices();
            var bills = _billServices.GetWaitBill();
            dgv_HD.DataSource = bills;
        }

        private void dgv_HD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgv_HD.Rows[e.RowIndex];
            lb_MaHD.Text = row.Cells[0].Value.ToString();
            LoadBillDetails(Guid.Parse(row.Cells[0].Value.ToString()));
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {

        }
    }
}
