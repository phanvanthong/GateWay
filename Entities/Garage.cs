using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Garage
    {
        public Guid GarageID { get; set; }
        public string GarageName { get; set; }
        public string Address { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public string Descript { get; set; }
    }
}
