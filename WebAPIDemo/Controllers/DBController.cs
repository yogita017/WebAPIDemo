using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIDemo.Models;

namespace WebAPIDemo.Controllers
{
    public class DBController : ApiController
    {
        ProjectContextCls P = new ProjectContextCls();
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return P.Products.ToList(); 
        }

        [HttpGet]

        public Product Get(int Id)
        {
            return P.Products.FirstOrDefault(x => x.ProductId == Id);

        }
        [HttpPost]
        public string Post([FromBody]Product product)
        {
            P.Products.Add(product);
            P.SaveChanges();
            return "1 row inserted";
        }

        [HttpPut]
        public string put(int id, [FromBody] Product product)
        {

            var Prod=P.Products.FirstOrDefault(x => x.ProductId == id);//this is for retriving data as select command
            Prod.ProductName = product.ProductName;
            Prod.price = product.price;
            P.SaveChanges();
            return "1 row updated";

        }
        [HttpDelete]

        public string Delete(int id)
        {
            var Prod = P.Products.FirstOrDefault(x => x.ProductId == id);//this is for retriving data as select command
            P.Products.Remove(Prod);
            P.SaveChanges();

            return "! row deleted";

        }
    }
}
