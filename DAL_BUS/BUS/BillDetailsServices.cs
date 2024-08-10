﻿using DAL_BUS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BUS.BUS
{
    public class BillDetailsServices
    {
        AppDbContext _context;
        public BillDetailsServices()
        {
            _context = new AppDbContext();
        }

        public List<BillDetails> GetAllByBillId(Guid billId)
        {
            return _context.BillDetails.Where(p => p.BillID == billId).ToList();

        }
        public string AddToBill(Guid billID, Guid productID, int amount)
        {
            // Check xem SP đã nằm trong hóa đơn hay chưa????
            var check = _context.BillDetails.FirstOrDefault(p => p.BillID == billID && p.ProductID == productID);
            // Nếu chưa tồn tại => Tạo mới 1 HDCT
            if (check == null)// SP mới chưa có trong hóa đơn
            {
                Product sp = _context.Products.Find(productID);
                BillDetails details = new BillDetails()
                {
                    ID = Guid.NewGuid(),
                    BillID = billID,
                    ProductID = productID,
                    Price = sp.Price,
                    Amount = amount
                };
                _context.BillDetails.Add(details);
                _context.SaveChanges();
                // Update số lượng của sản phẩm trong kho
                var product = _context.Products.Find(productID);
                product.TotalAmount = product.TotalAmount - amount;
                _context.Products.Update(product);
                _context.SaveChanges();
                return "Thêm thành công vào hóa đơn";
            }
            else // SP đã có trong hóa đơn rồi => Update số lượng
            {
                check.Amount = check.Amount + amount; // update số lượng trong bill Details
                _context.BillDetails.Update(check); _context.SaveChanges();
                // Update số lượng của sản phẩm trong kho
                var product = _context.Products.Find(productID);
                product.TotalAmount = product.TotalAmount - amount;
                _context.Products.Update(product);
                _context.SaveChanges();
                return "Thêm mới và cộng dồn thành công";
            }
        }
        

        public long CalculateBill(Guid id)
        {
            List<BillDetails> billDetails =GetAllByBillId(id); // Lấy tất cả HDCT theo ID
            long sum = 0;
            foreach (var item in billDetails)
            {
                sum += item.Price * (long)item.Amount;
            }
            return sum;
        }
        
    }
}