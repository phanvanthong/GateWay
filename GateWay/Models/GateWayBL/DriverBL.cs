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

    public class DriverBL: IDriverRepository
    {
        public ApplicationDbContext context = new ApplicationDbContext();
        public List<Driver> GetListDriver()
        {
            var lstDriver = context.Drivers.ToList();
            return lstDriver;
        }
        public Driver FindDriver()
        {
            Driver diver = new Driver();
            return diver;
        }
    }
}
