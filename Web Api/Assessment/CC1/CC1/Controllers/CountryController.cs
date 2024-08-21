using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CC1.Models;

namespace CC1.Controllers
{
    [RoutePrefix("api/country")]
    public class CountryController : ApiController
    {
        List<Country> countries = new List<Country>()
        {
            new Country{ID=1,CountryName="India",Capital="Delhi"},
            new Country{ID=2,CountryName="USA",Capital="Washington D.C"}
        };

        [HttpGet]
        [Route("All")]
        public IEnumerable<Country> Get()
        {
            return countries;
        }

        [HttpGet]
        [Route("ById")]
        public IHttpActionResult GetCountryByName(int Id)
        {
            string Countryname = countries.Where(c => c.ID == Id).SingleOrDefault()?.CountryName;
            if (Countryname == null)
            {
                return NotFound();
            }
            return Ok(Countryname);
        }

        [HttpPost]
        [Route("Post")]
        public List<Country> Post ([FromBody] Country country)
        {
            countries.Add(country);
            return countries;
        }

        [HttpPut]
        [Route("Put")]
        public IEnumerable<Country> Put(int id, [FromBody] Country c)
        {
            countries[id - 1] = c;
            return countries;
        }

        [HttpDelete]
        [Route("Delete")]
        public IEnumerable<Country> Delete(int id)
        {
            countries.RemoveAt(id - 1);
            return countries;
        }
    }
}
