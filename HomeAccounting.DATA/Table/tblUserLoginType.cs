using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAccounting.DATA.Table
{
    public class tblUserLoginType
    {
        [Key]
        public int ElementID { get; set; }
        public string? UserID { get; set; }
        public int LoginType { get; set; }
    }
}
