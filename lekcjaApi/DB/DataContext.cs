using lekcjaApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace lekcjaApi.DB
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Shelter> Shelters { get; set; }
    }
}
