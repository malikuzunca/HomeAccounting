using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAccounting.DATA.Table
{
    public class tblMoneyIncome
    {
        [Key]
        public int IncomeID { get; set; }
        public int UserID { get; set; }
        public string IncomeName { get; set; }
        public string IncomeDescription { get; set; }
        public string IncomePrice { get; set; }
        public bool IsActive { get; set; }
        public bool Deleted { get; set; }
    }
}
