using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRL.ViewModels
{
    internal class BillDetaisJoin
    {
        public Guid ID { get; set; }
        public Guid BillID { get; set; }
        public Guid ProductID { get; set; }
        public long Price { get; set; }
        public int Amount { get; set; } //số lượng

        public string Name { get; set; }
    }
}
