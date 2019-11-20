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
    public class CarTypeBL: ICartypeRepository
    {
        public ApplicationDbContext context = new ApplicationDbContext();
        public List<CarType> GetAllCarType()
        {
            return context.CarTypes.ToList();
        }

        public object AddCarType()
        {
            return 0;
        }
        public object UpdateCarType()
        {
            return 0;
        }
        public object DeleteCarType()
        {
            return 0;
        }
    }
}
