using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Store.DataAccess.Repositories;
using Store.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.WebUI.Controllers
{
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet("api/product/all")]
        public IEnumerable<Store.Logic.Models.Product> GetProducts()
        {
            return _productRepository.GetProducts();
        }

    }
}
