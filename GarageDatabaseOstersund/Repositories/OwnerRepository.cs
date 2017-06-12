using GarageDatabaseOstersund.DataAccess;
using GarageDatabaseOstersund.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GarageDatabaseOstersund.Repositories
{
    public class OwnerRepository
    {
        GarageContext context = new GarageContext();

        public IEnumerable<Owner> getAllOwners()
        {
            return context.Owners.ToList();
        }    

        public Owner getOwner(string SSN)
        {
            Owner owner = context.Owners.FirstOrDefault(o=>o.SSN.Equals(SSN));
            //owner.Vehicles = context.Vehicles.Where(v => v.OwnerSSN.Equals(SSN)).ToList();
            return owner;
        }
    }
}