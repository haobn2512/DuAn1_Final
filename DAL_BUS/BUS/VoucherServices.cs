using DAL_BUS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BUS.BUS
{
    public class VoucherServices
    {
        AppDbContext _context;
        public VoucherServices()
        {
            _context = new AppDbContext();
        }

        public List<Voucher> GetAllVoucher()
        {
            return _context.Vouchers.ToList();
        }
        public string CreateVoucher(Voucher voucher)
        {
            // Validate
            if (voucher.EndDate < DateTime.Now || voucher.StartDate > voucher.EndDate)
            {
                return "Kiểm tra lại thời hạn của chương trình khuyến mãi";
            }
            else if (voucher.Value < 0)
            {
                return "Không thể giảm giá âm";
            }
            else
            {
                _context.Vouchers.Add(voucher);
                _context.SaveChanges();
                return "Tạo mới khuyến mãi thành công";
            }
        }
        public List<Voucher> GetActiveVoucher() // Lấy ra danh sách các sale đang hoạt động
        {
            return _context.Vouchers.Where(p => p.StartDate <= DateTime.Now
            && p.EndDate >= DateTime.Now && p.Status == 0).ToList(); // Hoạt động = 0, ko HĐ = 1
        }
    }
}
