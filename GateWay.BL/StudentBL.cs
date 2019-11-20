using GateWay.Models;
using Services.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GateWay.BL
{
    public class StudentBL: IStudentRepository
    {
        public ApplicationDbContext context = new ApplicationDbContext();
        public bool ChangeStatusUser()
        {
            return true;
        }
    }
}
