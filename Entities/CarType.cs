using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class CarType
    {
        public Guid CarTypeID { get; set; }
        public string CarTypeName { get; set; }
        public int Seats { get; set; }
        public List<Car> Cars {get;set;}
    }
}
