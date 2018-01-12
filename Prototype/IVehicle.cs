﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public interface IVehicle :ICloneable
    {
        IEngine Engine { get; }
        VehicleColour Colour{get;}
        void Paint(VehicleColour colour);
    }
}
