using lekcjaApi.Entities;

namespace lekcjaApi.Repositories.Interface
{
    public interface IPetRepository
    {
        IEnumerable<Pet> GetAllPosts();
        Pet GetPostById(int id);
        Pet AddNewPost(Pet pet);
        void UpdatePost(Pet pet);
        void DeletePost(Pet pet);
    }
}
