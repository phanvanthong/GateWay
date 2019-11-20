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
     public class UserBL: IUserRepository
    {
        public ApplicationDbContext context = new ApplicationDbContext();

        public List<User> GetAllUser()
        {
            return context.Users.ToList();
        }

        public User GetUserByID(Guid ID)
        {
            return context.Users.SingleOrDefault(n => n.UserID == ID);
        }

        public string ReportProblem()
        {
            return null;
        }
        public List<Plan> GetSchedule()
        {
            return context.Plans.ToList();
        }
        public IEnumerable<Arrival> TrackMove()
        {
            return context.Arrivals.ToList();
        }
        public bool CheckPlaceSent()
        {
            return true;
        }
        public bool CheckPlaceTake()
        {
            return true;
        }
    }
}
