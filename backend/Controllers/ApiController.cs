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
        Response r = new Response();
        [HttpGet]
        public Response Get()
        {
            try
            {
                var context = new DataContext();
                var studentsWithSameName = context.ms_storage_location.ToList();
                
                r.message = "sukses";
                r.data = studentsWithSameName.ToList<Object>();
                return r;
                
            }
            catch (Exception ex)
            {
                r.message = ex.Message;
                
                return r;
            }
        }
        [HttpPost("save")]

        public Response Save([FromBody] Bpkb bp)
        {
            
            try
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
                    r.message = "sukses";
                    r.data = new List<Object>() { std };
                    return r;
                }
            }catch(Exception ex)
            {
                r.message = "Error: "+ex.Message;
                return r;
            }
           
        }
    }
}