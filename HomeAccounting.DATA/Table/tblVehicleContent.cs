using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAccounting.DATA.Table
{
    public class tblVehicleContent
    {
        [Key]
        public int VehicleSubID { get; set; }
        public int VehicleID { get; set; }
        public string VehicleSubName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }

    }
}
