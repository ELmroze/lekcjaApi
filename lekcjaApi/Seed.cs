/*using lekcjaApi.DB;
using lekcjaApi.Entities;
using System.Diagnostics.Metrics;

namespace lekcjaApi
{
    public class Seed
    {
        private readonly DataContext dataContext;
        public Seed(DataContext context)
        {
            this.dataContext = context;
        }
        public void SeedDataContext()
        {
            if (dataContext.Database.CanConnect())
            {
                if (!dataContext.Shelters.Any())
                {
                    var shelter = GetShelters();
                    dataContext.Shelters.AddRange(shelter);
                    dataContext.SaveChanges();
                }
            }
        }
        private IEnumerable<Shelter> GetShelters()
        {
            var shelters = new List<Shelter>()
            {
                new Shelter()
                {
                    Name="zooshelter",
                    Adress="Panki,ulica kuchenna 3",
                    Pets=new List<Pet>()
                    {
                        new Pet("kropka",2,1),
                        new Pet("budyń",5,1),
                        new Pet("Robberto",35,1)
                    }
                },
                new Shelter()
                {
                    Name="kreskówkowe shronisko ",
                    Adress="warszawa,ulica kresa 13",
                    Pets=new List<Pet>()
                    {
                        new Pet("Reksio",50,1),
                        new Pet("Scooby",51,1),
                        new Pet("kudłaty",17,1)
                    }
                }
            };
            return shelters;
        }
    }
}
*/
