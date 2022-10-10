using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OnlineStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BanksController : ControllerBase
    {
        // GET: api/<BanksController>
        [HttpGet(Name = nameof(GetAll))]
        public IEnumerable<string> GetAll()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<BanksController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BanksController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BanksController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BanksController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
