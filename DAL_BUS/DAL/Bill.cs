using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BUS.DAL
{
    public class Bill
    {
        [Key]
        public Guid Id { get; set; }
        public string CustomerPhone { get; set; }
        public string AccountID { get; set; }
        public long? TotalMoney { get; set; }
        public DateTime CreateDate { get; set; }

        public int Status { get; set; }
        public string? VoucherID { get; set; }
        // Navigation
        public virtual List<BillDetails> Details { get; set; }
        public virtual Account Account { get; set; }
        public virtual List<PayHistory> PayHistorys { get; set; }
        public virtual Voucher Voucher { get; set; }
    }
}
