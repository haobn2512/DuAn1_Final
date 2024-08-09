using DAL_BUS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BUS.BUS
{
   public class CustomerServives
    {
        AppDbContext _context;
        public CustomerServives()
        {
            _context = new AppDbContext();
        }


        public List<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }
        public List<Customer> GetByPhone(string phoneNumber)
        {
            var check = _context.Customers.Where(p => p.PhoneNumber.Contains(phoneNumber)).ToList();
            return _context.Customers.Where(p => p.PhoneNumber.Contains(phoneNumber)).ToList();
        } // Danh sách chứa để add Vào combobox khi muốn tìm kiếm
        // Tạo mới
        public void Create(string phoneNumber, string name, int point = 0)
        {
            Customer customer = new Customer()
            {
                PhoneNumber = phoneNumber,
                Name = name,
                Point = point
            };
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }
    }
}
 