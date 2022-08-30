using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class Product
    {
        public String ProductName;
        public decimal Price;
        public String Description;

        public Product(string _productname, decimal _price, String _description)
        {
            ProductName = _productname;
            Price = _price;
            Description = _description;
        }
    }
}