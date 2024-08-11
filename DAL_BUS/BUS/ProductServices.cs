using DAL_BUS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BUS.BUS
{
    public class ProductServices
    {
        AppDbContext _context;
        public ProductServices()
        {
            _context = new AppDbContext();
        }

        // lấy dữ liệu
        public List<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        //Create

        public string CreateProduct(Product product)
        {
            while (true) // Vòng lặp cho phép nhập lại dữ liệu
            {
                // Validate
                if (string.IsNullOrWhiteSpace(product.Name) ||
                    string.IsNullOrWhiteSpace(product.Details) ||
                    string.IsNullOrWhiteSpace(product.From))
                {
                    Console.WriteLine("Hãy kiểm tra lại dữ liệu không được trống");
                    return "Dữ liệu không hợp lệ, vui lòng nhập lại.";
                }
                else if (!long.TryParse(product.Price.ToString(), out long price) || price < 0 ||
                         !int.TryParse(product.TotalAmount.ToString(), out int totalAmount) || totalAmount < 0)
                {
                    return "Giá hoặc số lượng không thể là giá trị âm hoặc không phải là số.";
                }
                else if (string.IsNullOrEmpty(product.ImgURL))
                {
                    return "Đường dẫn ảnh đang trống.";
                }
                else
                {
                    try
                    {
                        _context.Products.Add(product);
                        _context.SaveChanges();
                        return "Thêm mới sản phẩm thành công";
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Thêm thất bại: " + e.Message);
                        return "Có lỗi xảy ra, vui lòng nhập lại dữ liệu.";
                    }
                }

                // Nếu không có lỗi, thoát vòng lặp
                break;
            }
        }




        //Search 
        public List<Product> SearchByName(string name)
        {
            return _context.Products.Where(p => p.Name.ToLower().Contains(name.ToLower())).ToList();
        }

        public string LockProduct(Guid id)
        {
            var product = _context.Products.Find(id);
            if (product.Status == 0) { return "Sản phẩm đã bị khóa, không  thể khóa tiếp"; }
            else
            {
                product.Status = 1;
                _context.Products.Update(product);
                _context.SaveChanges();
                return "Khóa thành công"; ;
            }
        }

        public string UnLockProduct(Guid id)
        {
            var product = _context.Products.Find(id);
            if (product.Status != 0) { return "Sản phẩm không bị khóa, không  thể mở khóa "; }
            else
            {
                product.Status = 1;
                _context.SaveChanges();
                return "Mở khóa hóa thành công"; ;
            }
        }

        public string UpDateProduct(ProductViewModel product)
        {
            var UpDateProduct = _context.Products.Find(product.Id);
            if (UpDateProduct == null)
            {
                return "Không tìm thấy bản ghi để cập nhật";
            }
            else
            {
                UpDateProduct.Name = product.Name;
                UpDateProduct.Details = product.Details;
                UpDateProduct.ImgURL = product.ImgURL;
                UpDateProduct.From = product.From;
                UpDateProduct.Price = product.Price;
                UpDateProduct.TotalAmount = product.TotalAmount;
                UpDateProduct.Status = product.Status;
               
                _context.Products.Update(UpDateProduct);
                _context.SaveChanges();
                return "Sửa thành công";
            }

        }

        public string DeleteProduct(Product product)
        {
            var UpDateProduct = _context.Products.Find(product.Id);
            if (UpDateProduct == null)
            {
                return "Không tìm thấy bản ghi để Xóa";
            }
            else
            {
                UpDateProduct.Name = product.Name;
                UpDateProduct.Details = product.Details;
                UpDateProduct.ImgURL = product.ImgURL;
                UpDateProduct.From = product.From;
                UpDateProduct.Price = product.Price;
                UpDateProduct.TotalAmount = product.TotalAmount;
                UpDateProduct.Status = product.Status;

                _context.Products.Remove(UpDateProduct);
                _context.SaveChanges();
                return "Xóa thành công";



            }

        }


        public List<ProductViewModel> GetFullProdutc()
        {
            var sales = _context.Sales.ToList();
            var product = _context.Products.ToList();
            var spVM = from c in sales
                       join p in product
                       on c.Id equals p.SaleID
                       select
                       new ProductViewModel
                       {
                           Id = p.Id,
                           Name = p.Name,
                           Details = p.Details,
                           ImgURL = p.ImgURL,
                           From = p.From,
                           Price = p.Price,
                           TotalAmount = p.TotalAmount,
                           Status = p.Status,
                           SaleID = p.SaleID,
                           NameID = c.Name,
                       };
            return spVM.ToList();
        }
    }



    public class ProductViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; } //Mô tả
        public string ImgURL { get; set; } //link ảnh
        public string From { get; set; }   //xuất xứ
        public long Price { get; set; }
        public int TotalAmount { get; set; }//số lượng còn or số lượng tồn
        public int Status { get; set; }
        public Guid? SaleID { get; set; }

        public string NameID { get; set; }


    }
}
