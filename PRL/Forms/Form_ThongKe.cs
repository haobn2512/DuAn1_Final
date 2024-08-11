using DAL_BUS.DAL;
using Microsoft.EntityFrameworkCore;
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
    public partial class Form_ThongKe : Form
    {
        public Form_ThongKe()
        {
            InitializeComponent();
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;

            var topSellingProducts = GetTopSellingProducts(startDate, endDate);
            var totalRevenue = GetTotalRevenue(startDate, endDate);

            
            textBoxTotalRevenue.Text = totalRevenue.ToString();

            lstTopSellingProducts.Items.Clear(); // Xóa các mục cũ
            foreach (var product in topSellingProducts)
            {
                lstTopSellingProducts.Items.Add($"Sản phẩm: {product.ProductName}, Số lượng bán: {product.QuantitySold}");
            }
        }

        public static decimal GetTotalRevenue(DateTime startDate, DateTime endDate)
        {
            using (var context = new AppDbContext())
            {
                var totalRevenue = from bill in context.Bills
                                   where bill.CreateDate >= startDate && bill.CreateDate <= endDate
                                   select (decimal?)bill.TotalMoney; // Chuyển đổi sang decimal?

                return totalRevenue.Sum(x => x.GetValueOrDefault()); // Sử dụng GetValueOrDefault để xử lý null
            }
        }


        public class TopSellingProduct
        {
            public string ProductName { get; set; }
            public int QuantitySold { get; set; }
        }

        public static List<TopSellingProduct> GetTopSellingProducts(DateTime startDate, DateTime endDate)
        {
            using (var context = new AppDbContext())
            {
                var result = from billDetail in context.BillDetails
                             join product in context.Products on billDetail.ProductID equals product.Id
                             join bill in context.Bills on billDetail.BillID equals bill.Id
                             where bill.CreateDate >= startDate && bill.CreateDate <= endDate
                             group new { product, billDetail } by product.Name into g
                             orderby g.Sum(x => x.billDetail.Amount) descending
                             select new TopSellingProduct
                             {
                                 ProductName = g.Key,
                                 QuantitySold = g.Sum(x => x.billDetail.Amount)
                             };

                return result.Take(10).ToList();
            }
        }
    }
}
