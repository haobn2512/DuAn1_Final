using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BUS.DAL
{
    public class Account
    {
        [Key]
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
        //Navigation
        public virtual List<Bill> Bills { get; set; } //Quan hệ với bảng Bill
    }
}
