using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Model
{
    public class Location
    {
        [Key]
        public string location_id { get; set; }
        public string location_name { get; set; }
    }
}
