using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspDotNEtCore.models;
using AspDotNEtCore.Repositories;

namespace AspDotNEtCore.Controllers
{

    [Route("api/[controller]")]
    public class ValuesController : Controller
    {

        private AddressRepository addressRepository;

        public ValuesController(AddressRepository address) {
            this.addressRepository = address;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            
            return new string[] { "Rara", "Steven" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Person Get(int id)
        {
            Person person = new Person();
            person.ID = id;
            person.FirstName = "Steven";
            person.LastName = "Ham";
            person.PayRate = 125;
            person.StartDate = DateTime.Parse("5/5/1995");
            person.EndDate = DateTime.Parse("1/1/1996");

            return person;
         }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Person value)
        {
            Console.WriteLine("Void");
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        [HttpGet]
        [Route("addresses/{id}")]
        public IActionResult GetAddress([FromRoute]int id) {
            return new JsonResult(addressRepository.GetAddress(id));
        }




        public class AddressModel
        {
            public string ID { get; set; }
            public string AddressLine1 { get; set; }
        }
    }

}
