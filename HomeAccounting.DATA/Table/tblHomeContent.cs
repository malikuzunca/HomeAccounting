using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAccounting.DATA.Table
{
    public class tblHomeContent
    {
        [Key]
        public int HomeSubID { get; set; }
        public int HomeID { get; set; }
        public string HomeSubName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
    }
}
