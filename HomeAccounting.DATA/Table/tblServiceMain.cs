﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAccounting.DATA.Table
{
    public class tblServiceMain
    {
        [Key]
        public int ServiceID { get; set; }
        public string ServiceName { get; set; }
        public string ListImage { get; set; }
        public int Arrangement { get; set; }
        public bool IsActive { get; set; }
        public bool Deleted { get; set; }
    }
}
