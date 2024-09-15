using AutoMapper;
using lekcjaApi.Dto;
using lekcjaApi.Entities;
using lekcjaApi.Repositories;
using lekcjaApi.Repositories.Interface;

namespace lekcjaApi.Services
{
    public class ShelterService
    {
        private readonly IShelterRepository _shelterRepository;
        private readonly IMapper _mapper;

        public ShelterService(IShelterRepository ShelterRepository, IMapper mapper)
        {
            _shelterRepository = ShelterRepository;
            _mapper = mapper;
        }

        public IEnumerable<ShelterDto> GetAllPosts()
        {
            var posts = _shelterRepository.GetAllPosts();
            return _mapper.Map<IEnumerable<ShelterDto>>(posts);
        }
        public ShelterDto GetPostById(int id)
        {
            var post = _shelterRepository.GetPostById(id);
            return _mapper.Map<ShelterDto>(post);
        }
        public ShelterDto AddNewPost(ShelterDto nshelter)
        {
            if (string.IsNullOrEmpty(nshelter.Name))
            {
                throw new Exception("Post can not have an empty Name.");
            }

            var shelter = _mapper.Map<Shelter>(nshelter);
            _shelterRepository.AddNewPost(shelter);
            return _mapper.Map<ShelterDto>(shelter);
        }
        public void UpdatePost(ShelterDto uShelter)
        {
            var existingShelter = _shelterRepository.GetPostById(uShelter.Id);
            var shelter = _mapper.Map(uShelter, existingShelter);
            _shelterRepository.UpdatePost(shelter);
        }
        public void DeletePost(int id)
        {
            var shelter = _shelterRepository.GetPostById(id);
            _shelterRepository.DeletePost(shelter);
        }
    }
}
