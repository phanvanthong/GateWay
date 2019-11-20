using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public interface IUserRepository
    {
        List<User> GetAllUser();
        User GetUserByID(Guid ID);
        string ReportProblem();
        List<Plan> GetSchedule();
        IEnumerable<Arrival> TrackMove();
        bool CheckPlaceSent();
        bool CheckPlaceTake();
    }
}
