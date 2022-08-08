using Core.Contracts.Service;
using Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MovieShopAPI.Controllers
{
    public class MovieController : ControllerBase
    {
        private readonly IMovieServiceAsync service;
        public MovieController(IMovieServiceAsync serv)
        {
            service = serv;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            // throw new Exception("custom exception");
            return Ok(await service.GetAllMoviesAsync());
        }

        [Authorize]
        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await service.GetByIdAsync(id);
            if (result == null)
                return NotFound($"Movie with Id = {id} is not available");
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(MovieModel model)
        {
            var result = await service.AddMovieAsync(model);
            if (result > 0)
                return Ok(model);
            return BadRequest();
        }

        [HttpPut]
        public async Task<IActionResult> Put(MovieModel model)
        {
            var result = await service.UpdateMovieAsync(model);
            if (result > 0)
                return Ok(model);
            return BadRequest();
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await service.DeleteMovieAsync(id);
            if (result > 0)
            {
                var response = new { Message = "Movie Deleted Successfully" };
                return Ok(response);
            }
            return BadRequest();
        }
    }
}
