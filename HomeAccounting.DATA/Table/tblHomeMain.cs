using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAccounting.DATA.Table
{
    public class tblHomeMain
    {
        [Key]
        public int HomeID { get; set; }
        public int ExpenseID { get; set; }
        public int Arrangement { get; set; }
        public string HomeName { get; set; }
        public string HomeDescription { get; set; }
        public bool IsActive { get; set; }
        public bool Deleted { get; set; }
    }
}
