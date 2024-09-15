using lekcjaApi.Entities;
using lekcjaApi.Repositories;
using lekcjaApi.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;

namespace lekcjaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : Controller
    {
        private readonly IPetRepository _petRepository;

        public PetController(IPetRepository petService)
        {
            _petRepository = petService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var pets = _petRepository.GetAllPosts();
            return Ok(pets);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var pet= _petRepository.GetPostById(id);
            if (pet == null)
            {
                return NotFound();
            }
            return Ok(pet);
        }
        [HttpPost]
        public IActionResult Post(Pet pet)
        {
            _petRepository.AddNewPost(pet);
            return Ok(pet);
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var pet= _petRepository.GetPostById(id);
            if (pet == null)
            {
                return NotFound();
            }
            _petRepository.DeletePost(pet);
            return NoContent();
        }

    }
}
