using lekcjaApi.Dto;

namespace lekcjaApi.Services.Interface
{
    public interface IShelterService
    {
        IEnumerable<ShelterDto> GetAllPosts();
        ShelterDto GetPostById(int id);
        ShelterDto AddNewPost(ShelterDto shelter);
        void UpdatePost(ShelterDto shelter);
        void DeletePost(int id);
    }
}
