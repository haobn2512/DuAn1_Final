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
        {//Validate
            if (product.Name.Trim() == "" || product.Details.Trim() == "" || product.From.Trim() == "")
            {
                return "Hãy kiểm tra lại dữ liệu không được trống";
            }
            else if (product.Price < 0 || product.TotalAmount < 0)
            {
                return "Giá hoặc số lượng không thể là giá trị âm";
            }
            else if (string.IsNullOrEmpty(product.ImgURL))
            {
                return "Đường dẫn ảnh đang trống";
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
                    return "Thêm thất bại " + e.Message;
                }
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

        public string UpDateProduct(Product product)
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
    }
}
