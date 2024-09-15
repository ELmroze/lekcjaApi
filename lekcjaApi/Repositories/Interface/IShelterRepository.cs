using lekcjaApi.Entities;

namespace lekcjaApi.Repositories.Interface
{
    public interface IShelterRepository
    {
        IEnumerable<Shelter> GetAllPosts();
        Shelter GetPostById(int id);
        Shelter AddNewPost(Shelter shelter);
        void UpdatePost(Shelter shelter);
        void DeletePost(Shelter shelter);
    }
}
