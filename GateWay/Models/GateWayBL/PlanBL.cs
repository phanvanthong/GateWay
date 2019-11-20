using Entities;
using GateWay.Models;
using Services.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GateWay.BL
{
    public class PlanBL : IPlanRepository
    {
        public ApplicationDbContext context = new ApplicationDbContext();
        public string ConfirmReport()
        {
            return null;
        }

        public bool SendNotification()
        {
            return true;
        }
        public List<Plan> GetSchedule()
        {
            return null;
        }
    }
}
