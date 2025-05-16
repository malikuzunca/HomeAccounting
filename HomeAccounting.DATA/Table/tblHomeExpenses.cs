using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAccounting.DATA.Table
{
    public class tblHomeExpenses
    {
        [Key]
        public int ExpenseID { get; set; }
        public int UserID { get; set; }
        public string ExpenseName { get; set; }
        public string ExpensePrice { get; set; }
        public bool IsFixed { get; set; }
    }
}
