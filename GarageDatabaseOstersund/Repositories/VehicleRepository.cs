using GarageDatabaseOstersund.DataAccess;
using GarageDatabaseOstersund.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GarageDatabaseOstersund.Repositories
{
    public class VehicleRepository
    {
        GarageContext context = new GarageContext();

        public IEnumerable<Vehicle> GetAllVehicles() 
        {
            return context.Vehicles.ToList();
        }

        public Vehicle GetVehicle(string RegNr)
        {
            return context.Vehicles.FirstOrDefault(v=>v.RegNr.Equals(RegNr));
        }

        public IEnumerable<VehicleType> GetAllVehicleTypes()
        {
            return context.VehicleTypes.ToList();
        }




        public void AddVehicle(Vehicle vehicle)
        {
            context.Vehicles.Add(vehicle);
            context.SaveChanges();
        }
    }
}