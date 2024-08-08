using DAL_BUS.BUS;
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
using System.Xml.Linq;

namespace PRL.Forms
{

    public partial class Form_Sale : Form
    {
        SaleServices _services;
        public Form_Sale()
        {
            InitializeComponent();
            _services = new SaleServices();
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            if (txt_Ten.Text == "" || txt_MoTa.Text == "")
            {
                MessageBox.Show("Nhập đủ thông tin");
            }
            else
            {
                Sale sale = new Sale()
                {
                    Id = Guid.NewGuid(),
                    Name = txt_Ten.Text,
                    Description = txt_MoTa.Text,
                    StartDate = dtp_Start.Value,
                    EndDate = dtp_End.Value,
                    Percent = Convert.ToDouble(txt_Percent.Text),
                    Status = cbb_Status.SelectedIndex
                };

                string saleName = txt_Ten.Text.Trim();

                // Kiểm tra trùng tên
                if (IsSaleNameDuplicate(saleName))
                {
                    MessageBox.Show("Tên khuyến mãi đã tồn tại. Vui lòng chọn tên khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Dừng lại nếu tên đã tồn tại
                }
                else
                {
                    MessageBox.Show(_services.CreateSale(sale));
                    LoadAllSale();
                    ClearData();

                }
            }
        }

        public void LoadAllSale()
        {
            dgv_Data.DataSource = null;
            var allSale = _services.GetAllSale();
            dgv_Data.DataSource = allSale;
            //dgv_Data.Columns[0].Visible = false;
        }

        private void Form_Sale_Load(object sender, EventArgs e)
        {
            LoadAllSale();

        }

        private void cbb_loc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sale = cbb_loc.SelectedItem.ToString(); // Lấy trạng thái đã chọn

            using (var context = new AppDbContext())
            {
                IQueryable<Sale> filteredProducts;

                if (sale == "Hoạt động")
                {
                    filteredProducts = context.Sales.Where(s => s.Status == 0);
                }
                else if (sale == "Không hoạt động")
                {
                    filteredProducts = context.Sales.Where(s => s.Status == 1);
                }
                else // "Tất cả"
                {
                    filteredProducts = context.Sales;
                }

                var productList = filteredProducts.ToList(); // Chuyển đổi kết quả thành danh sách

                dgv_Data.DataSource = productList; // Gán danh sách sản phẩm đã lọc cho DataGridView

                // Kiểm tra nếu không có sản phẩm nào
                if (productList.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm nào với trạng thái này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
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
                    txt_id.Text = row.Cells[0].Value?.ToString() ?? string.Empty;
                    txt_Ten.Text = row.Cells[1].Value?.ToString() ?? string.Empty;
                    txt_MoTa.Text = row.Cells[2].Value?.ToString() ?? string.Empty;
                    txt_Percent.Text = row.Cells[3].Value?.ToString() ?? string.Empty;

                    // Chuyển đổi giá trị ngày
                    dtp_Start.Value = Convert.ToDateTime(row.Cells[4].Value);
                    dtp_End.Value = Convert.ToDateTime(row.Cells[5].Value);

                    // Chuyển đổi giá trị cho ComboBox
                    cbb_Status.SelectedIndex = Convert.ToInt32(row.Cells[6].Value);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Lỗi định dạng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show("Lỗi kiểu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Guid id = Guid.Parse(txt_id.Text);
                string name = txt_Ten.Text;
                string description = txt_MoTa.Text;
                double percent = Convert.ToDouble(txt_Percent.Text);
                DateTime startdate = dtp_Start.Value;
                DateTime enddate = dtp_End.Value;
                int status = cbb_Status.SelectedIndex;
                Sale sale = new Sale()
                {
                    Id = id,
                    Name = name,
                    Description = description,
                    Percent = percent,
                    StartDate = startdate,
                    EndDate = enddate,
                    Status = status

                };
                string message = _services.UpdateSale(sale);
                MessageBox.Show(message);
                LoadAllSale();
                ClearData();

            }

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn Xóa  không", "Thông báo", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
                Guid id = Guid.Parse(txt_id.Text);
                string name = txt_Ten.Text;
                string description = txt_MoTa.Text;
                double percent = Convert.ToDouble(txt_Percent.Text);
                DateTime startdate = dtp_Start.Value;
                DateTime enddate = dtp_End.Value;
                int status = cbb_Status.SelectedIndex;
                Sale sale = new Sale()
                {
                    Id = id,
                    Name = name,
                    Description = description,
                    Percent = percent,
                    StartDate = startdate,
                    EndDate = enddate,
                    Status = status

                };
                string message = _services.DeleteSale(sale);
                MessageBox.Show(message);
                LoadAllSale();
                ClearData();

            }
        }
        public void ClearData()
        {
            txt_id.Text = "";
            txt_Ten.Text = "";
            txt_MoTa.Text = "";
            txt_Percent.Text = "";
            dtp_Start.Value = DateTime.Now;
            dtp_End.Value = DateTime.Now;
            cbb_Status.SelectedIndex = -1;

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearData();
        }


        private bool IsSaleNameDuplicate(string saleName)
        {
            foreach (DataGridViewRow row in dgv_Data.Rows)
            {
                if (!row.IsNewRow)
                {
                    if (row.Cells["Name"].Value.ToString().Equals(saleName, StringComparison.OrdinalIgnoreCase))
                    {
                        return true; // Tồn tại khuyến mãi trùng tên
                    }
                }
            }
            return false; // Không tồn tại khuyến mãi trùng tên
        }
    }
}
