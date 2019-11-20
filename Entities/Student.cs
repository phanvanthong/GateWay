using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Student
    {
        public Guid StudentID { get; set; }
        public string StudentName { get; set; }
        public bool StatusStudent { get; set; }

        /// <summary>
        /// Khóa ngoại
        /// </summary>
        [Key]
        public User user { get; set; }
        public Guid UserID { get; set; }
    }
}
