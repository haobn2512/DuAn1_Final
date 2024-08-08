using DAL_BUS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BUS.BUS
{
    public  class SaleServices
    {
        //Cần quan tâm đến:
        //Thời gian: Ngaybatdau<NgayKetThuc. Nếu tạo mới NgayBatDau = Ngày hiện tại,..
        //percent - % giảm phải từ 0 đến 100
        AppDbContext _context;
        public SaleServices()
        {
            _context = new AppDbContext();
        }

        //Lấy dữ liệu
        public List<Sale> GetAllSale()
        {
            return _context.Sales.ToList();
        }


        //Create
        public string CreateSale(Sale sale)
        {
            //Validate
            if( sale.EndDate < DateTime.Now || sale.StartDate > sale.EndDate)
            {
                return "Kiểm tra lại thời hạn của chương trình khuyến mãi"; 
            }
            else if(sale.Percent > 100 || sale.Percent < 0)
            {
                return"Phầm  trăm giảm không thể ngoài khoảng 0 đến 100";
            }
            else
            {
                _context.Sales.Add(sale);
                _context.SaveChanges();
                return "Tạo mới khuyến mãi thành công";
            }
        }

        //Update
        
        public string UpdateSale(Sale sale)
        {
            var updatesale = _context.Sales.Find(sale.Id);
            if (updatesale == null)
            {
                return "không tìm thấy bản ghi để cập nhật.";
            }

            else
            {
                updatesale.Name = sale.Name;
                updatesale.Description = sale.Description;
                updatesale.Percent = sale.Percent;
                updatesale.StartDate = sale.StartDate;
                updatesale.StartDate = sale.StartDate;
                updatesale.StartDate = sale.StartDate;
                updatesale.Status = sale.Status;
                _context.Sales.Attach(updatesale);
                _context.SaveChanges();
                return "Sửa thành công";
            }
        }

        public string DeleteSale(Sale sale)
        {
            var updatesale = _context.Sales.Find(sale.Id);
            if (updatesale == null)
            {
                return "không tìm thấy bản ghi để Xóa.";
            }

            else
            {
                updatesale.Name = sale.Name;
                updatesale.Description = sale.Description;
                updatesale.Percent = sale.Percent;
                updatesale.StartDate = sale.StartDate;
                updatesale.StartDate = sale.StartDate;
                updatesale.StartDate = sale.StartDate;
                updatesale.Status = sale.Status;
                _context.Sales.Remove(updatesale);
                _context.SaveChanges();
                return "Xóa thành công";
            }
        }


        public List<Sale> GetActiveSale()
        {
            return _context.Sales.Where(p => p.StartDate <= DateTime.Now
            && p.EndDate >= DateTime.Now && p.Status == 0).ToList();
          
        }

    }
}
