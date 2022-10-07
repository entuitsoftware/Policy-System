using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OnlineStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankingDetailsController : ControllerBase
    {
        // GET: api/<BankingDetailsController>
        [HttpGet("GetAllForCustomer/{customerId}")]
        public IEnumerable<string> GetAllForCustomer(Guid customerId)
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<BankingDetailsController>/5
        [HttpGet("GetDetail/{id}")]
        public string Get(Guid id)
        {
            return "value";
        }

        // POST api/<BankingDetailsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BankingDetailsController>/5
        [HttpPut("Update/{id}")]
        public void Put(Guid id, [FromBody] string value)
        {
        }

    }
}
