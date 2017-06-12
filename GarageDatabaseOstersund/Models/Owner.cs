using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GarageDatabaseOstersund.Models
{
    public class Owner
    {
        [Key]
        public string SSN { get; set; }
        public string Name { get; set; }

        public virtual List<Vehicle> Vehicles { get; set; }
    }
}