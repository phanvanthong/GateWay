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
    public class GarageBL: IGarageRepository
    {
        public ApplicationDbContext context = new ApplicationDbContext();
        public List<Garage> GetListGarage() {
            return context.Garages.ToList();
        }
        public List<Plan> GetSchedule()
        {
            return context.Plans.ToList();
        }
        public List<Arrival> TrackMove()
        {
            return context.Arrivals.ToList();
        }

        public string ReportProblem()
        {
            return null;
        }
    }
}
