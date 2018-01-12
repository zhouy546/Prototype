using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleManagerLazy vehiclemanagerlazy = new VehicleManagerLazy();

            IVehicle saloon1 = vehiclemanagerlazy.CreateSaloon();
            IVehicle saloon2 = vehiclemanagerlazy.CreateSaloon();
            IVehicle pickup1 = vehiclemanagerlazy.CreatePickUp();
        }
    }
}
