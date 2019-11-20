using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Driver
    {
        public Guid DriverID { get; set; }
        public string DriverName { get; set; }
        public string Phone { get; set; }
        public List<Notification> Notifications { get; set; }


        /// <summary>
        /// Khóa ngoại
        /// </summary>
        [Key]
        public Garage garage { get; set; }
        public Guid GarageID { get; set; }
    }
}
