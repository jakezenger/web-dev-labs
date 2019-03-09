using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Database;
using Microsoft.AspNetCore.Authorization;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class StudentController : ControllerBase
    {
        private readonly SchoolContext dbContext;

        public StudentController(SchoolContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public ActionResult<List<Student>> Get()
        {
            return Ok(getStudents());
        }

        public List<Student> getStudents()
        {
            return dbContext.Student.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }
    }
}
