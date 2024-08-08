using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BUS.DAL
{
    public class Payment
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        //Navigation
        public virtual List<PayHistory> PayHistorys { get; set; }
    }
}
