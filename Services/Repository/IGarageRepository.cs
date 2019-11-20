using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public interface IGarageRepository
    {
        List<Garage> GetListGarage();
        List<Plan> GetSchedule();
        List<Arrival> TrackMove();
        string ReportPorblem();
    }
}
