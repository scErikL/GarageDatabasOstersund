using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GarageDatabaseOstersund.Models
{
    public class VehicleType
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }

        public virtual Fee Fee { get; set; }
    }

    public class Fee 
    {
        [Key, ForeignKey("VehicleType")]
        public int VehicleTypeId { get; set; }

        public int VehicleFee { get; set; }
        public virtual VehicleType VehicleType { get; set; }
    
    }
}