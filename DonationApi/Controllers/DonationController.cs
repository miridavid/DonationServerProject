using DonationApi.BL;
using DonationApi.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DonationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonationController : ControllerBase
    {

        IDonationBL _donationBL;
        public DonationController(IDonationBL donationBL)
        {
            this._donationBL = donationBL;
        }
        // GET: api/<DonationController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<DonationController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DonationController>
        [HttpPost]
        public void AddDonation([FromBody] Donation donation)
        {
           this._donationBL.AddDonation(donation);

        }

        // PUT api/<DonationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DonationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
