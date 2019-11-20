using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Car
    {
        public Guid CarID { get; set; }
        public string LicensePlate { get; set; }
        

        /// <summary>
        /// Khóa ngoại
        /// </summary>
        [Key]
        public Garage garage { get; set; }
        public Guid GarageID { get; set; }
        [Key]
        public CarType carType { get; set; }
        public Guid CarTypeID { get; set; }
    }
}
