using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HomeAccounting.DATA.Table
{
    public class tblVehicleMain
    {
        [Key]
        public int VehicleID { get; set; }
        public int ExpenseID { get; set; }
        public int Arrangement { get; set; }
        public string VehicleName { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Kilometers { get; set; }
        public bool IsActive { get; set; }
        public bool Deleted { get; set; }
    }
}
