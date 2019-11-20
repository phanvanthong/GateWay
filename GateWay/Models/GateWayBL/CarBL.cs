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
    
    public class CarBL:ICarRepository
    {
        public ApplicationDbContext context = new ApplicationDbContext();
        public List<Car> GetAllCar()
        {
            return context.Cars.ToList();
        }

        public Car GetCarByID(Guid ID)
        {
            return context.Cars.SingleOrDefault(n => n.CarID == ID);
        }

        public object CheckInCar()
        {
            return 0;
        }
        public object CheckOutCar()
        {
            return 0;
        }
    }
}
