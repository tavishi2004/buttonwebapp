using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using detailwebapp.Models;
using detailwebapp.RequestModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace detailwebapp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly detailsContext _detailscontext;

        public ValuesController(detailsContext detailss)
        {
            _detailscontext = detailss;
        }

        // GET: api/info
        [HttpGet]
        public IActionResult Get1()
        {
            var getinfo = _detailscontext.Info.ToList();
            return Ok(getinfo);
        }

        // GET api/values/5
        [HttpGet("{id:int}")]

        public IActionResult Get(int id)
        {
            try
            {
                var x = _detailscontext.Info.First(obj => obj.StudId == id);
                //if (x == null)
                //    return NotFound();
                return Ok(x);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error!");
            }
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] infoRequest value)
        {
            Info obj1 = new Info();
            //obj1.studID = value.StudId;
            obj1.Firstname = value.Firstname;
            obj1.Lastname = value.Lastname;
            obj1.Age = value.Age;
            obj1.Subject = value.Subject;
            obj1.Number = value.Number;
            obj1.CreatedBy = value.CreatedBy;
            obj1.CreatedAt = value.CreatedAt;
            obj1.UpdatedBy = value.UpdatedBy;
            obj1.UpdatedAt = value.UpdatedAt;
            _detailscontext.Info.Add(obj1);
            _detailscontext.SaveChanges();

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
