using GarageDatabaseOstersund.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GarageDatabaseOstersund.DataAccess
{
    public class GarageContext : DbContext
    {
        public GarageContext() :base("DefaultConnection"){}

        public DbSet<Owner> Owners { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }

        public DbSet<VehicleType> VehicleTypes { get; set; }
        public DbSet<Fee> Fees { get; set;  }
    }
}