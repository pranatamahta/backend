﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Model
{
    public class Bpkb
    {
        [Key]
        public string agreement_number { get; set; }
        public string bpkb_no { get; set; }
        public string branch_id { get; set; }
        public DateTime bpkb_date { get; set; }
        public string faktur_no { get; set; }
        public DateTime faktur_date {get;set;}
        public string location_id { get; set; }
        public string police_no { get; set; }

        public DateTime bpkb_date_in { get; set; }

        [ForeignKey("location_id")]
        public virtual Location ms_storage_location { get; set; }
    }
}
