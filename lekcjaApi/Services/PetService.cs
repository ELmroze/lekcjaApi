using AutoMapper;
using lekcjaApi.Dto;
using lekcjaApi.Entities;
using lekcjaApi.Repositories.Interface;
using lekcjaApi.Services.Interface;
using Microsoft.Extensions.Hosting;

namespace lekcjaApi.Services
{
    public class PetService : IPetService
    {
        private readonly IPetRepository _petRepository;
        private readonly IMapper _mapper;

        public PetService(IPetRepository petRepository, IMapper mapper)
        {
            _petRepository = petRepository;
            _mapper = mapper;
        }

        public IEnumerable<PetDto> GetAllPosts()
        {
            var posts = _petRepository.GetAllPosts();
            return _mapper.Map<IEnumerable<PetDto>>(posts);
        }
        public PetDto GetPostById(int id)
        {
            var post=_petRepository.GetPostById(id);
            return _mapper.Map<PetDto>(post);
        }
        public PetDto AddNewPost(PetDto npet)
        {
            if (string.IsNullOrEmpty(npet.Name))
            {
                throw new Exception("Post can not have an empty Name.");
            }

            var pet = _mapper.Map<Pet>(npet);
            _petRepository.AddNewPost(pet);
            return _mapper.Map<PetDto>(pet);
        }
        public void UpdatePost(PetDto uPet)
        {
            var existingPet = _petRepository.GetPostById(uPet.Id);
            var pet = _mapper.Map(uPet, existingPet);
            _petRepository.UpdatePost(pet);
        }
        public void DeletePost(int id)
        {
            var pet = _petRepository.GetPostById(id);
            _petRepository.DeletePost(pet);
        }
    }
}
