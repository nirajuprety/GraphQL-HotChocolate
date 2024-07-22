using GraphQLHotChocolate.Entities;
using Microsoft.EntityFrameworkCore;

namespace GraphQLHotChocolate.Data
{
    public class DbContextClass : DbContext
    {

        public DbContextClass(DbContextOptions<DbContextClass> options) : base(options)
        {

        }

        public DbSet<ProductDetails> Products { get; set; }
    }
}
