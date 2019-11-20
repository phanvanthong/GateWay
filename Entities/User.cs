using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User
    {
        public Guid UserID { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public bool FirstLogin { get; set; }
        public DateTime FinalLogin { get; set; }
        public string UserPhone { get; set; }
        public string UserAddress { get; set; }
        public string UserRole { get; set; }
        public string UserStatus { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public bool IsActive { get; set; }
        public bool Waiting { get; set; }
    }
}
