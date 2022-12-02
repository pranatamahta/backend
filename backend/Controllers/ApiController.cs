using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.DataModel;
using backend.Model;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiController : ControllerBase
    {


        [HttpGet]
        public IEnumerable<Location> Get()
        {
            try
            {
                var context = new DataContext();
                var studentsWithSameName = context.ms_storage_location.ToArray();
                return studentsWithSameName;
            }
            catch (Exception ex)
            {
                var rng = new Random();
                return Enumerable.Range(1, 5).Select(index => new Location
                {

                    location_name = ex.Message.ToString()
                })
                .ToArray();
            }
        }
        [HttpPost("save")]

        public String Save([FromBody] Bpkb bp)
        {
            using (var context = new DataContext())
            {
                var std = new Bpkb()
                {
                    agreement_number = bp.agreement_number,
                    bpkb_no = bp.bpkb_no,
                    branch_id = bp.branch_id,
                    bpkb_date = bp.bpkb_date,
                    faktur_no = bp.faktur_no,
                    faktur_date = bp.faktur_date,
                    location_id = bp.location_id,
                    police_no = bp.police_no,
                    bpkb_date_in = bp.bpkb_date_in
                };
                context.tr_bpkb.Add(std);

                // or
                // context.Add<Student>(std);

                context.SaveChanges();
            }
            return "sukses";
        }
    }
}