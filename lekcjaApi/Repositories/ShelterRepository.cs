using lekcjaApi.Entities;
using lekcjaApi.Repositories.Interface;

namespace lekcjaApi.Repositories
{
    public class ShelterRepository:IShelterRepository
    {
        static int count = 0;
        private ISet<Shelter> _sheltersSet = new HashSet<Shelter>
        {
            new Shelter(count++,"Zootopia","koszciuszko,5"),
            new Shelter(count ++, "Kreskówkowo","martini,69")
        };

        public IEnumerable<Shelter> GetAllPosts()
        {
            return _sheltersSet;
        }
        public Shelter GetPostById(int id)
        {
            return _sheltersSet.SingleOrDefault(x => x.Id == id);
        }
        public Shelter AddNewPost(Shelter shelter)
        {
            _sheltersSet.Add(shelter);
            return shelter;
        }
        public void UpdatePost(Shelter shelter)
        {
            throw new NotImplementedException();
        }
        public void DeletePost(Shelter shelter)
        {
            _sheltersSet.Remove(shelter);
        }
    }
}
