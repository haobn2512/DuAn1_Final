using DAL_BUS.BUS;
using DAL_BUS.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL.Forms
{

    public partial class Form_QLSPham : Form
    {
        SaleServices _saleServices;
        ProductServices _services;
        List<Sale> activeSales;
       
        public Form_QLSPham()
        {
            InitializeComponent();
            ptb_Image.SizeMode = PictureBoxSizeMode.StretchImage;
            _services = new ProductServices();
            _saleServices = new SaleServices();
            activeSales = _saleServices.GetActiveSale();
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {


            // Kiểm tra các TextBox có giá trị không
            if (string.IsNullOrWhiteSpace(txt_Ten.Text) ||
                string.IsNullOrWhiteSpace(txt_XuatXu.Text) ||
                string.IsNullOrWhiteSpace(txt_MoTa.Text) ||
                string.IsNullOrWhiteSpace(txt_Price.Text) ||
                string.IsNullOrWhiteSpace(txt_SoLuongCon.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            // Kiểm tra activeSales có null không
            if (activeSales == null || activeSales.Count == 0)
            {
                MessageBox.Show("Danh sách sale không hợp lệ.");
                return;
            }

            // Kiểm tra SelectedIndex
            if (cbb_Sale.SelectedIndex < 0 || cbb_Sale.SelectedIndex >= activeSales.Count)
            {
                MessageBox.Show("Vui lòng chọn một sale hợp lệ.");
                return;
            }


            Product product = new Product()
            {
                Id = Guid.NewGuid(),
                Name = txt_Ten.Text,
                From = txt_XuatXu.Text,
                Details = txt_MoTa.Text,
                Price = Convert.ToInt32(txt_Price.Text),
                TotalAmount = Convert.ToInt32(txt_SoLuongCon.Text),
                Status = cbb_Status.SelectedIndex,
                ImgURL = ptb_Image.ImageLocation,
                SaleID = activeSales[cbb_Sale.SelectedIndex].Id 
            };

            string newProductName = txt_Ten.Text; // Lấy tên sản phẩm từ TextBox

            if (IsProductNameDuplicate(newProductName))
            {
                MessageBox.Show("Tên sản phẩm đã tồn tại. Vui lòng nhập tên khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Ngừng thêm sản phẩm
            }
            else
            {
                try
                {
                    // Mã lưu dữ liệu vào cơ sở dữ liệu
                    _services.CreateProduct(product);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}\n{ex.InnerException?.Message}");
                }
                LoadDataToGridView();
                ClearData();
            }

        }

        public void LoadDataToGridView()
        {
            dgv_Data.DataSource = null;
            var products = _services.GetProducts();
            dgv_Data.DataSource = products;
        }

        private void Form_QLSPham_Load(object sender, EventArgs e)
        {
            var activesales = _saleServices.GetActiveSale(); // Lấy danh sách các sale đang hoạt động

            if (activesales == null || !activesales.Any())
            {
                MessageBox.Show("Không có sale nào đang hoạt động.");
                return;
            }

            foreach (var item in activesales)
            {
                cbb_Sale.Items.Add(item.Name);
            }

            LoadDataToGridView();
        }

        private void ptb_Image_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            ptb_Image.ImageLocation = openFileDialog.FileName;
            //ptb_Image.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void dgv_Data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Kiểm tra xem chỉ số hàng có hợp lệ không
                if (e.RowIndex >= 0 && e.RowIndex < dgv_Data.Rows.Count)
                {
                    DataGridViewRow row = dgv_Data.Rows[e.RowIndex];

                    // Cập nhật các điều khiển
                    txt_Id.Text = row.Cells[0].Value?.ToString() ?? string.Empty;
                    txt_Ten.Text = row.Cells[1].Value?.ToString() ?? string.Empty;
                    txt_MoTa.Text = row.Cells[2].Value?.ToString() ?? string.Empty;
                    ptb_Image.ImageLocation = row.Cells[3].Value?.ToString() ?? string.Empty;
                    txt_XuatXu.Text = row.Cells[4].Value?.ToString() ?? string.Empty;
                    txt_Price.Text = row.Cells[5].Value?.ToString() ?? string.Empty;
                    txt_SoLuongCon.Text = row.Cells[6].Value?.ToString() ?? string.Empty;

                    // Chuyển đổi giá trị cho ComboBox
                    cbb_Status.SelectedIndex = Convert.ToInt32(row.Cells[7].Value);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Lỗi định dạng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn sửa  không", "Thông báo", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
                Guid id;
                if (!Guid.TryParse(txt_Id.Text, out id))
                {
                    MessageBox.Show("Định dạng GUID không hợp lệ.");
                    return; // Dừng thực hiện nếu định dạng không hợp lệ
                }
                id = Guid.Parse(txt_Id.Text);
                string name = txt_Ten.Text;
                string details = txt_MoTa.Text;
                string imgUrl = ptb_Image.ImageLocation;
                string from = txt_XuatXu.Text;
                long price = long.Parse(txt_Price.Text);
                int totalamount = Convert.ToInt32(txt_SoLuongCon.Text);
                int status = cbb_Status.SelectedIndex;
                //Guid saleId = ;
                Product product = new Product()
                {
                    Id = id,
                    Name = name,
                    Details = details,
                    ImgURL = imgUrl,
                    From = from,
                    Price = price,
                    TotalAmount = totalamount,
                    Status = status,
                    //SaleID = saleId

                };
                string message = _services.UpDateProduct(product);
                MessageBox.Show(message);
                LoadDataToGridView();
                ClearData();
            }

        }

        public void ClearData()
        {
            txt_Id.Text = "";
            txt_Ten.Text = "";
            txt_MoTa.Text = "";
            txt_XuatXu.Text = "";
            txt_Price.Text = "";
            txt_SoLuongCon.Text = "";
            cbb_Status.SelectedIndex = -1;
            ptb_Image.Image = null;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn Xóa  không", "Thông báo", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
                Guid id;
                if (!Guid.TryParse(txt_Id.Text, out id))
                {
                    MessageBox.Show("Định dạng GUID không hợp lệ.");
                    return; // Dừng thực hiện nếu định dạng không hợp lệ
                }
                id = Guid.Parse(txt_Id.Text);
                string name = txt_Ten.Text;
                string details = txt_MoTa.Text;
                string imgUrl = ptb_Image.ImageLocation;
                string from = txt_XuatXu.Text;
                long price = long.Parse(txt_Price.Text);
                int totalamount = Convert.ToInt32(txt_SoLuongCon.Text);
                int status = cbb_Status.SelectedIndex;
                Product product = new Product()
                {
                    Id = id,
                    Name = name,
                    Details = details,
                    ImgURL = imgUrl,
                    From = from,
                    Price = price,
                    TotalAmount = totalamount,
                    Status = status,

                };
                string message = _services.DeleteProduct(product);
                MessageBox.Show(message);
                LoadDataToGridView();
                ClearData();
            }
        }


        private bool IsProductNameDuplicate(string product)
        {
            foreach (DataGridViewRow row in dgv_Data.Rows)
            {
                // Kiểm tra nếu hàng không phải là hàng mới (new row)
                if (!row.IsNewRow)
                {
                    if (row.Cells["Name"].Value.ToString().Equals(product, StringComparison.OrdinalIgnoreCase))
                    {
                        return true; // Tồn tại sản phẩm trùng tên
                    }
                }
            }
            return false; // Không tồn tại sản phẩm trùng tên
        }
    }
}
