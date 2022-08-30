using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class OfferService
    {
        private List<Product> Inventory;

        private void addProducts()
        {
            Inventory.Add(new Product("P1", 1000, "P1 desc"));
            Inventory.Add(new Product("P2", 200, "P2 desc"));
            Inventory.Add(new Product("P3", 400, "P3 desc"));
            Inventory.Add(new Product("P4", 700, "P4 desc"));
            Inventory.Add(new Product("P5", 600, "P5 desc"));
            Inventory.Add(new Product("P6", 800, "P6 desc"));
        }

        public OfferService()
        {
            addProducts();
        }

        public List<Product> GetAllProducts()
        {
            return Inventory;
        }

        public List<Offer> GetTodaysOffers()
        {
            List<Offer> offerList = new List<Offer>();

            List<Product> combo1 = new List<Product>();
            combo1.Add(new Product("P1", 700, "combo1"));
            combo1.Add(new Product("P2", 100, "combo1"));
            combo1.Add(new Product("P3", 200, "combo1"));

            List<Product> combo2 = new List<Product>();
            combo2.Add(new Product("P4", 500, "combo2"));
            combo2.Add(new Product("P5", 300, "combo2"));
            combo2.Add(new Product("P6", 400, "combo2"));

            List<Product> combo3 = new List<Product>();
            combo3.Add(new Product("P1", 500, "combo3"));
            combo3.Add(new Product("P3", 300, "combo3"));
            combo3.Add(new Product("P6", 400, "combo3"));

            List<Product> combo4 = new List<Product>();
            combo4.Add(new Product("P2", 500, "combo4"));
            combo4.Add(new Product("P4", 300, "combo4"));
            combo4.Add(new Product("P3", 400, "combo4"));

            offerList.Add(new Offer("ComboPackage1", combo1));
            offerList.Add(new Offer("ComboPackage2", combo2));
            offerList.Add(new Offer("ComboPackage3", combo3));
            offerList.Add(new Offer("ComboPackage4", combo4));

            return offerList;
        }
    }
}