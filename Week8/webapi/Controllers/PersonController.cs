using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Database;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly SchoolContext dbContext;

        public PersonController(SchoolContext dbContext)
        {
            this.dbContext = dbContext;
        }
        
        // GET api/values
        [HttpGet]
        public ActionResult<List<Person>> Get()
        {
            return getPersons();
        }

        public List<Person> getPersons()
        {
            return dbContext.Person.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }
    }
}
