﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public abstract class AbstractCar:AbstractVehicle
    {
        public AbstractCar(IEngine engine) : this(engine, VehicleColour.Unpainted) { }
        public AbstractCar(IEngine engine, VehicleColour colour) : base(engine, colour) {

        }
    }
}
