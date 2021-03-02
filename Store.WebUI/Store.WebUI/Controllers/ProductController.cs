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

        public ProductController()
        {
            using var dependency = new Dependencies();
            _productRepository = dependency.CreateProductRepository();
        }

        [HttpGet("product/all")]
        public IEnumerable<Store.Logic.Models.Product> GetProducts()
        {
            using var dependency = new Dependencies();
            _productRepository = dependency.CreateProductRepository();
            return _productRepository.GetProducts();
        }

    }
}
