using lekcjaApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace lekcjaApi.DB
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Shelter>().HasData(
                 new Shelter()
                 {
                     Id = 1,
                     Name = "zooshelter",
                     Adress = "Panki,ulica kuchenna 3",
                 },
                new Shelter()
                {
                    Id = 2,
                    Name = "kreskówkowe shronisko ",
                    Adress = "warszawa,ulica kresa 13",
                }
                );
            builder.Entity<Pet>().HasData( 
                new Pet(1,"kropka",2,1),
                new Pet(2,"budyń",5,1),
                new Pet(3,"Robberto",35,1),
                new Pet(4,"Reksio",50,2),
                new Pet(5,"Scooby",51,2),
                new Pet(6,"kudłaty",17,2)
               );
            base.OnModelCreating(builder);

            builder.Entity<Shelter>()
                .HasMany(s => s.Pets)
                .WithOne(p => p.Shelter)
                .HasForeignKey(p => p.ShelterId);
        }
        
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Shelter> Shelters { get; set; }
    }
}
