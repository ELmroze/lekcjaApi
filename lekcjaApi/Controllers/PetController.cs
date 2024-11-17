using lekcjaApi.Dto;
using lekcjaApi.Entities;
using lekcjaApi.Repositories;
using lekcjaApi.Repositories.Interface;
using lekcjaApi.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace lekcjaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : Controller
    {
        private readonly IPetService _petService;

        public PetController(IPetService petService)
        {
            _petService = petService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var pets = _petService.GetAllPosts();
            return Ok(pets);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var pet= _petService.GetPostById(id);
            if (pet == null)
            {
                return NotFound();
            }
            return Ok(pet);
        }
        [HttpPost]
        public async Task<IActionResult> Post(PetDto pet)
        {
            _petService.AddNewPost(pet);
            return Created($"api/pet/{pet.Id}",pet);
        }
        [HttpPut]
        public async Task<IActionResult> Update(PetDto pet)
        {
            _petService.UpdatePost(pet);
            return NoContent();
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            _petService.DeletePost(id);
            return NoContent();
        }

    }
}
