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

        public bool AddCarType(CarType carType)
        {
            context.CarTypes.Add(carType);
            context.SaveChanges();
            return true;
        }
        public bool UpdateCarType(CarType carType)
        {
            CarType carType1 = context.CarTypes.SingleOrDefault(n => n.CarTypeID == carType.CarTypeID);
            if (carType1 !=null)
            {
                carType1.CarTypeName = carType.CarTypeName;
                carType1.Seats = carType.Seats;
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool DeleteCarType(Guid ID)
        {
            CarType carType = context.CarTypes.SingleOrDefault(n => n.CarTypeID == ID);
            if (carType != null)
            {
                context.CarTypes.Remove(carType);
                context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
