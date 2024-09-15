using lekcjaApi.Entities;
using lekcjaApi.Repositories.Interface;

namespace lekcjaApi.Repositories
{
    public class PetRepository:IPetRepository
    {
        private ISet<Pet> _petsSet = new HashSet<Pet>
        {
            new Pet(1,"Fafik",5,1),
            new Pet(2, "Penelopa",1,1),
            new Pet(3, "Reksio",3,2)
        };

        public IEnumerable<Pet> GetAllPosts()
        {
            return _petsSet;
        }
        public Pet GetPostById(int id)
        {
            return _petsSet.SingleOrDefault(x=>x.Id==id);
        }
        public Pet AddNewPost(Pet pet)
        {
            pet.Id=_petsSet.Count()+1;
            _petsSet.Add(pet);
            return pet;
        }
        public void UpdatePost(Pet pet)
        {
            return;
        }
        public void DeletePost(Pet pet)
        {
            _petsSet.Remove(pet);
        }
    }
}
