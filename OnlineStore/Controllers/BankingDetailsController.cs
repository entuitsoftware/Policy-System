using DAL;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OnlineStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankingDetailsController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        public BankingDetailsController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        // GET: api/<BankingDetailsController>
        [HttpGet("GetAllForCustomer/{customerId}")]
        public IEnumerable<BankingDetail> GetAllForCustomer(Guid customerId)
        {
            return _dbContext.BankingDetails.Where(x => x.CustomerId == customerId);
        }

        // GET api/<BankingDetailsController>/5
        [HttpGet("GetDetail/{id}")]
        public string Get(Guid id)
        {
            return "value";
        }

        // POST api/<BankingDetailsController>
        [HttpPost]
        public void Post([FromBody] BankingDetail value)
        {
            _dbContext.BankingDetails.Add(value);
            _dbContext.SaveChanges();
        }

        // PUT api/<BankingDetailsController>/5
        [HttpPut("Update/{id}")]
        public void Put(Guid id, [FromBody] string value)
        {
        }

    }
}
