using System.Collections.Generic;
using EASV.Webshop2021.Core.Models;
using EASV.Webshop2021.Domain.IRepositories;

namespace EASV.Webshop2021.DB
{
    public class ProductRepository : IProductRepository
    {
        private readonly WebShopDbContext _ctx;

        public ProductRepository(WebShopDbContext context)
        {
            _ctx = context;
        }
        
        public List<Product> ReadAll()
        {
            throw new System.NotImplementedException();
        }

        public Product CreateProduct(Product product)
        {
            throw new System.NotImplementedException();
        }
    }
}