using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiProductsSample_Project.Models;

namespace WebApiProductsSample_Project.Controllers
{
    public class ProductsController : ApiController
    {
        private Product[] _products = new Product[]
        {
            new Product(){Id=1,Name = "product 1", Categorie = "Categorie 1" , Price = 100}, 
            new Product(){Id=2,Name = "product 2", Categorie = "Categorie 2" , Price = 130}, 
            new Product(){Id=3,Name = "product 3", Categorie = "Categorie 2" , Price = 40}, 
            new Product(){Id=4,Name = "product 4", Categorie = "Categorie 1" , Price = 500}, 
        };

        public IEnumerable<Product> GetProducts()
        {
            return _products;
        }

        public IHttpActionResult GetProductById(int id)
        {
            var product = _products.FirstOrDefault((p) => p.Id == id);
            if (product==null)
            {
                return NotFound();
            }
            return Ok(product);

        }
    }
}
