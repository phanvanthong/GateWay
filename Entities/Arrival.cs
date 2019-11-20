
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Arrival
    {
        public Guid ArrivalID { get; set; }
        //kinh độ
        public float Longitude { get; set; }
        //vĩ độ
        public float Latitude { get; set; }
    }
}
