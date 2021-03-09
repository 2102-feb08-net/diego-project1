using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Store.Logic.Interfaces;

namespace Store.WebUI.Controllers
{
    [ApiController]
    public class LocationController : ControllerBase
    {
        private ILocationRepository _locationRepository;

        public LocationController(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }

        [HttpGet("api/store/products")]
        public IEnumerable<Store.Logic.Models.Product> GetStoreProducts(int storeId)
        {
            return _locationRepository.GetInventory(storeId);
        }
    }
}
