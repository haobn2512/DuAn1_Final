using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BUS.DAL
{
    public class BillDetails
    {
        [Key]
        public Guid ID { get; set; }
        public Guid BillID { get; set; }
        public Guid ProductID { get; set; }
        public long Price { get; set; }
        public int Amount { get; set; } //số lượng
        //Navigation
        public virtual Bill Bill { get; set; }
        public virtual Product Product { get; set; }
    }
}
