using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class Offer
    {
        public String OfferName;
        public List<Product> Products;

        public Offer(string _offername, List<Product> _products)
        {
            OfferName = _offername;
            Products = _products;
        }
    }
}