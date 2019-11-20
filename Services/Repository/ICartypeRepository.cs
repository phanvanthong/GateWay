﻿using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public interface ICartypeRepository
    {
        List<CarType> GetAllCarType();
        object AddCarType();
        object UpdateCarType();
        object DeleteCarType();
    }
}
