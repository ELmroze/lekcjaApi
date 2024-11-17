using lekcjaApi.DB;
using lekcjaApi.Entities;
using lekcjaApi.Repositories.Interface;
using Microsoft.Extensions.Caching.Memory;

namespace lekcjaApi.Repositories
{
    public class PetRepository:IPetRepository
    {
        private readonly DataContext _context;

        public PetRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Pet>> GetAllPosts()
        {
             return _context.Pets;
        }
        public Pet GetPostById(int id)
        {
            return _context.Pets.SingleOrDefault(x=>x.Id==id);
        }
        public Pet AddNewPost(Pet pet)
        {
            _context.Pets.Add(pet);
            _context.SaveChanges();
            return pet;
        }
        public void UpdatePost(Pet pet)
        {
            _context.Pets.Update(pet);
            _context.SaveChanges();
        }
        public void DeletePost(Pet pet)
        {
            _context.Pets.Remove(pet);
            _context.SaveChanges();
        }
    }
}
