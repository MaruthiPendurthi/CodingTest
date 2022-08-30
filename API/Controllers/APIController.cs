using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace API.Controllers
{

    public class APIController : ApiController
    {
        OfferService offerService;
        public APIController(OfferService _offerservice)
        {
            offerService = _offerservice;
        }
        [HttpGet]
        private async Task<List<Offer>> GetTodaysOffersAsync()
        {
            return offerService.GetTodaysOffers();
        }

        [HttpGet]
        private async Task<List<Product>> GetAllProductsAsync()
        {
            return offerService.GetAllProducts();
        }
    }
}
