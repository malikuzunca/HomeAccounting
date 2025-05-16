using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HomeAccounting.DATA.Table
{
    public class tblLink
    {
        [Key]
        public int LinkID { get; set; }
        public string Link { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string GroupID { get; set; }
        public bool IsActive { get; set; }
        public bool Deleted { get; set; }
    }
}
