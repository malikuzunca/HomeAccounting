using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAccounting.DATA.Table
{
    public class tblVehicleExpenses
    {
        [Key]
        public int ExpenseID { get; set; }
        public string ExpenseName { get; set; }
        public string ExpensePrice { get; set; }
    }
}
