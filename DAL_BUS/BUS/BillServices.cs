using DAL_BUS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BUS.BUS
{
     public class BillServices
    {

        AppDbContext _context;
        public BillServices()
        {
            _context = new AppDbContext();
        }

        public List<Bill> GetAllBills() // Tất cả các HD
        {
            return _context.Bills.ToList();
        }
        public List<Bill> GetWaitBill() // Hóa đơn chờ
        {
            return _context.Bills.Where(p => p.Status == 0).ToList();
        }
        public string Create(string accountID, string customerPhone)
        {
            Bill bill = new Bill()
            {
                Id = Guid.NewGuid(),
                Status = 0,
                TotalMoney = 0,
                AccountID = accountID,
                CustomerPhone = customerPhone,
                CreateDate = DateTime.Now
            };
            _context.Bills.Add(bill);
            _context.SaveChanges();
            return "Tạo thành công";
        }
    }
}
