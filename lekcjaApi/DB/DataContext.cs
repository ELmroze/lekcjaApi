using lekcjaApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace lekcjaApi.DB
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        /*protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Shelter>().HasData(
                 new Shelter()
                 {
                     Name = "zooshelter",
                     Adress = "Panki,ulica kuchenna 3",
                     Pets = new List<Pet>()
                    {
                        new Pet("kropka",2,1),
                        new Pet("budyń",5,1),
                        new Pet("Robberto",35,1)
                    }
                 },
                new Shelter()
                {
                    Name = "kreskówkowe shronisko ",
                    Adress = "warszawa,ulica kresa 13",
                    Pets = new List<Pet>()
                    {
                        new Pet("Reksio",50,1),
                        new Pet("Scooby",51,1),
                        new Pet("kudłaty",17,1)
                    }
                }
                );
        }
        */
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Shelter> Shelters { get; set; }
    }
}
