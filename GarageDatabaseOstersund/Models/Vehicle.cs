using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GarageDatabaseOstersund.Models
{
    public class Vehicle
    {
        [Key]
        public string RegNr { get; set; }
        public string  Brand { get; set; }

        [ForeignKey("Owner")]
        public string OwnerSSN { get; set; }

        public virtual Owner Owner { get; set; }

        [ForeignKey("VehicleType")]
        public int VehicleTypeId { get; set; }

        public virtual VehicleType VehicleType { get; set; }

    }
}