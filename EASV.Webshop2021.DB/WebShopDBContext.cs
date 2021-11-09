using EASV.Webshop2021.DB.Entities;
using Microsoft.EntityFrameworkCore;

namespace EASV.Webshop2021.DB
{
    public class WebShopDbContext : DbContext
    {
        public WebShopDbContext(DbContextOptions<WebShopDbContext> options) : base(options)
        {
            
        }

        public DbSet<ProductEntity> Products { get; set; }
    }
}