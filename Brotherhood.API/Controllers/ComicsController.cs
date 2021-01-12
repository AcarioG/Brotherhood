using Brotherhood.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Brotherhood.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComicsController : ControllerBase
    {
        // GET: api/<ComicsController>
        [HttpGet]
        //public IEnumerable<Comics> Get()
        //{
        //    return Get();
        //}

        // GET api/<ComicsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ComicsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ComicsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ComicsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
