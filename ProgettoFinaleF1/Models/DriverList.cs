using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoFinaleF1.Models
{
    internal class DriverList
    {
        public List<Driver> Drivers { get; set; }

        public DriverList()
        {
            Drivers = new List<Driver>();
        }
    }
}
