using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRL.ViewModels
{
    //Tạo 1 viewmodels để chứa sản phẩm sau khi đã sale, giá bán thực tế lưu hóa đơn là SalePrice
    public class SaleProduct
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; } //Mô tả
        public string ImgURL { get; set; } //link ảnh
        public string From { get; set; }   //xuất xứ
        public long Price { get; set; }
        public int TotalAmount { get; set; }//số lượng còn or số lượng tồn
        public int Status { get; set; }
        public Guid? SalePrice { get; set; }
    }
}
