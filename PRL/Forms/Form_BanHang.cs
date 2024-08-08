using DAL_BUS.BUS;
using DAL_BUS.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PRL.Forms
{
    public partial class Form_BanHang : Form
    {
        SaleServices _saleServices;
        ProductServices _productservices;
        public int currentBillId = -1;
        public List<Product> _products;
        public List<Sale> saleproduct;
        public Form_BanHang()
        {
            InitializeComponent();
            _productservices = new ProductServices();
            _saleServices = new SaleServices();
            _products = _productservices.GetProducts();
            saleproduct = _saleServices.GetAllSale();
        }

        public Panel CreateSP(Product product)
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
            lbGia.Location = new Point(285, 80);
            lbGia.Name = "lbGia";
            lbGia.Size = new Size(95, 32);
            lbGia.TabIndex = 2;
            lbGia.Text = "Giá bán";
            // 
            // lbSoluong
            // 
            lbSoluong.AutoSize = true;
            lbSoluong.Location = new Point(285, 173);
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
            lbGiaValues.Location = new Point(306, 153);
            lbGiaValues.Name = "lbGiaValues";
            lbGiaValues.Size = new Size(92, 32);
            lbGiaValues.TabIndex = 2;
            lbGiaValues.Text = product.Price.ToString();
            // 
            // lbSoluongValues
            // 
            lbSoluongValues.AutoSize = true;
            lbSoluongValues.Location = new Point(306, 227);
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
        }

        private void lb_Back_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(lb_page.Text) > 1)
            { // Nếu trang hiện tại vẫn nhỏ hơn tổ số trang có thể thì ta mới cho Next trang
                lb_page.Text = Convert.ToInt32(lb_page.Text) - 1 + "";
                LoadSPToPanel(Convert.ToInt32(lb_page.Text));
            }
        }

        public void LoadSPToPanel(int page)
        {
            var sales = _saleServices.GetAllSale();
            var saleProducts =
                from products in _products
                join sale in sales
                on products.SaleID equals sale.Id
                select new
                {
                    Id = products.Id,
                    Name = products.Name,
                    Details = products.Details,
                    ImgURL = products.ImgURL,
                    From = products.From,
                    Price = products.Price,
                    TotalAmount = products.TotalAmount,
                    Status = products.Status,
                    SalePrice = Convert.ToInt32(products.Price - products.Price * (sale.Percent / 100)),
                };

            tlp_Product.Controls.Clear();
            int numberOfPage = (int)Math.Ceiling((decimal)_products.Count / 4);
            if (page < 1 || page > numberOfPage) return;
            else
            {
                if (page * 4 - 4 < _products.Count)
                {
                    Panel s1 = CreateSP(_products[page * 4 - 4]);
                    tlp_Product.Controls.Add(s1, 0, 0);
                }
                if (page * 4 - 3 < _products.Count)
                {
                    Panel s2 = CreateSP(_products[page * 4 - 3]);
                    tlp_Product.Controls.Add(s2, 0, 1);
                }
                if (page * 4 - 2 < _products.Count)
                {
                    Panel s3 = CreateSP(_products[page * 4 - 2]);
                    tlp_Product.Controls.Add(s3, 1, 0);
                }
                if (page * 4 - 1 < _products.Count)
                {
                    Panel s4 = CreateSP(_products[page * 4 - 1]);
                    tlp_Product.Controls.Add(s4, 1, 1);
                }
            }
        }

        private void lb_Next_Click(object sender, EventArgs e)

        {
            if (Convert.ToInt32(lb_page.Text) < (int)Math.Ceiling((decimal)_products.Count / 4))
            { // Nếu trang hiện tại vẫn nhỏ hơn tổ số trang có thể thì ta mới cho Next trang
                lb_page.Text = Convert.ToInt32(lb_page.Text) + 1 + "";
                LoadSPToPanel(Convert.ToInt32(lb_page.Text));
            }
        }


        private void BtnMua_MouseClick(object? sender, MouseEventArgs e)
        {

            System.Windows.Forms.Button b = (System.Windows.Forms.Button)sender;
            Panel p = (Panel)b.Parent;
            System.Windows.Forms.TextBox t = p.Controls["ttx_Soluongban"] as System.Windows.Forms.TextBox;

            System.Windows.Forms.Label gia = p.Controls["lbGiaValues"] as System.Windows.Forms.Label;
            // Kiểm tra và chuyển đổi số lượng mua
            int soluongmua;

            if (string.IsNullOrWhiteSpace(t.Text) || !int.TryParse(t.Text, out soluongmua))
            {
                MessageBox.Show("Chưa nhập số lượng mà bạn muốn mua hoặc số lượng không hợp lệ.");
                return; // Ngừng thực hiện nếu không hợp lệ
            }

            System.Windows.Forms.Label soluongLabel = p.Controls["lbSoluongValues"] as System.Windows.Forms.Label;
            int soluongcon;

            // Kiểm tra và chuyển đổi số lượng còn lại
            if (!int.TryParse(soluongLabel.Text, out soluongcon))
            {
                MessageBox.Show("Số lượng còn lại không hợp lệ.");
                return; // Ngừng thực hiện nếu không hợp lệ
            }
            int giaban = Convert.ToInt32(gia.Text);
            // So sánh số lượng mua và số lượng còn lại
            if (soluongmua > soluongcon)
            {
                MessageBox.Show($"Không thể mua {soluongmua} sản phẩm, chỉ còn {soluongcon} sản phẩm.");
            }
            else if (currentBillId == -1) MessageBox.Show("Bạn chưa chọn hóa đơn để mua");
            else
            {
                MessageBox.Show($"Bạn vừa chọn mua sản phẩm có id là: {p.Name}. Với số lượng là: {t.Text} Vào hóa đơn {currentBillId}");
                int Idhd = currentBillId;
                int Idsp = Convert.ToInt32(p.Name);
                int Soluong = soluongmua;
                int Gia = giaban;
                int Trangthai = 1;


            }
        }
    }
}
