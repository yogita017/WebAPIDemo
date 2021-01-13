using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIDemo.Controllers
{
    public class ValuesController : ApiController
    {
        //string []str= { "value1", "value2", "value3", "value4" };
      static List<string> str = new List<string>() { 
      "a","b","value1","value2"};
        // GET api/values
        //retriving all data
        [HttpGet]
        public IEnumerable<string> Get()
        {
            
            return str;
        }

        [HttpGet]
        // GET api/values/5
        //retrieve based on condition
        public string Get(int id)
        {
            return str[id];
        }

        [HttpPost]
        // POST api/values
        //inserting
        public void Post([FromBody]string value)
        {
            str.Add(value);
        }

        [HttpPut]
        //modifying
       // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
            str[id]=value;
        }

        [HttpDelete]
        // DELETE api/values/5
        public void Delete(int id)
        {
            str.RemoveAt(id);
        }
    }
}
