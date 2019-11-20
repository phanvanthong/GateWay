using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Plan
    {
        public Guid PlanID { get; set; }
        public DateTime PlanDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public string DriverName { get; set; }
        public string TeacherName { get; set; }
        public List<Student> Students { get; set; }
        

        /// <summary>
        /// Khóa ngoại
        /// </summary>
        [Key]
        public Driver driver { get; set; }
        public Guid? DriverID { get; set; }
        [Key]
        public Car car { get; set; }
        public Guid? CarID { get; set; }
        [Key]
        public Teacher teacher { get; set; }
        public Guid? TeacherID { get; set; }
    }
}
