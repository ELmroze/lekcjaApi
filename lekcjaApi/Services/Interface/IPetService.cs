using lekcjaApi.Dto;

namespace lekcjaApi.Services.Interface
{
    public interface IPetService
    {
        Task<IEnumerable<PetDto>> GetAllPosts();
        PetDto GetPostById(int id);
        PetDto AddNewPost(PetDto pet);
        void UpdatePost(PetDto Pet);
        void DeletePost(int id);
    }
}
