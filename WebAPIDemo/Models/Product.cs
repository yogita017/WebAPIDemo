using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAPIDemo.Models
{[Table("tblproduct")]
    public class Product
    { [Key]
       
        public int ProductId { get; set; }
       
        public  string ProductName { get; set; }

        public int price { set; get; }
    
    }
}