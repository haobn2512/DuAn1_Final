using DAL_BUS.BUS;
using DAL_BUS.DAL;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
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
    public partial class Form_Account : Form
    {
        AccountServices _services;
        AppDbContext _dbContext;
        public Form_Account()
        {
            InitializeComponent();
            _services = new AccountServices();
            _dbContext = new AppDbContext();
        }

        private void Form_Account_Load(object sender, EventArgs e)
        {
            LoadDataToDridView();
        }
        public void LoadDataToDridView()
        {
            dgv_Account.DataSource = null;
            var data = _services.GetAccounts();
            dgv_Account.DataSource = data;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;
            int role = cbb_role.SelectedIndex; //mặc định = -1


            string saleName = txt_username.Text.Trim();

            // Kiểm tra trùng tên
            if (IsSaleNameDuplicate(saleName))
            {
                MessageBox.Show("Tên account đã tồn tại. Vui lòng chọn tên khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng lại nếu tên đã tồn tại
            }
            else
            {
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || role == -1)
                {
                    MessageBox.Show("Dữ liệu sai, kiểm tra lại");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Thêm tài khoản", "Thông báo", MessageBoxButtons.YesNo);
                    string message = _services.CreateAccount(username, password, role);
                    MessageBox.Show(message);
                    //MessageBox.Show("Thêm thành công");
                    LoadDataToDridView();
                    _dbContext.SaveChanges();
                    ClearData();
                }

            }
        }

        private void dgv_Account_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Kiểm tra xem chỉ số hàng có hợp lệ không
                if (e.RowIndex >= 0 && e.RowIndex < dgv_Account.Rows.Count)
                {
                    DataGridViewRow row = dgv_Account.Rows[e.RowIndex];

                    // Cập nhật các điều khiển
                    txt_username.Text = row.Cells[0].Value?.ToString() ?? string.Empty;
                    txt_password.Text = row.Cells[1].Value?.ToString() ?? string.Empty;

                    // Chuyển đổi giá trị cho ComboBox
                    cbb_role.SelectedIndex = Convert.ToInt32(row.Cells[2].Value);
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

        private void btn_khoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Khóa tài khoản", "Thông báo", MessageBoxButtons.YesNo);
            string username = txt_username.Text;
            string message = _services.LockAccount(username);
            MessageBox.Show(message);
            LoadDataToDridView();
            ClearData();
        }

        private void btn_mokhoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Mở khóa tài khoản", "Thông báo", MessageBoxButtons.YesNo);
            string username = txt_username.Text;
            string message = _services.UnLockAccount(username);
            MessageBox.Show(message);
            LoadDataToDridView();
            ClearData();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sửa tài khoản", "Thông báo", MessageBoxButtons.YesNo);
            string username = txt_username.Text;
            string password = txt_password.Text;
            int role = cbb_role.SelectedIndex; //mặc định = -1
            string message = _services.UpdateAccount(username, password, role);
            MessageBox.Show(message);
            LoadDataToDridView();
            ClearData();

        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string search = txt_search.Text.Trim();
            using (var context = new AppDbContext())
            {

                var results = context.Accounts
                    .Where(nv => nv.UserName.Contains(search))
                    .ToList();

                dgv_Account.DataSource = results;

                if (results.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy nhân viên nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ClearData()
        {
            txt_username.Clear();
            txt_password.Clear();
            cbb_role.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private bool IsSaleNameDuplicate(string saleName)
        {
            foreach (DataGridViewRow row in dgv_Account.Rows)
            {
                if (!row.IsNewRow)
                {
                    if (row.Cells["UserName"].Value.ToString().Equals(saleName, StringComparison.OrdinalIgnoreCase))
                    {
                        return true; // Tồn tại khuyến mãi trùng tên
                    }
                }
            }
            return false; // Không tồn tại khuyến mãi trùng tên
        }
    }
}
