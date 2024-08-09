using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BUS.DAL
{
    public class Customer
    {
        [Key]
        public string PhoneNumber { get; set; }
        public string Name { get; set; }
        public int? Point { get; set; }//tích điểm
        //Navigation
        public virtual List<Bill> Bills { get; set; }
    }
}
