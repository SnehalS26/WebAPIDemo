using Microsoft.AspNetCore.Mvc;
using WebAPIDemo.Entites;
using WebAPIDemo.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService service;
        // GET: api/<MovieController>
        [HttpGet]
        [Route("GetAllMovie")]
        public IActionResult Get()
        {
            try
            {
                return new ObjectResult(service.GetAllMovies());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status204NoContent, ex.Message);
            }
        }

        // GET api/<MovieController>/5
        [HttpGet]
        [Route("GetMovieById/{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return new ObjectResult(service.GetMovieById(id));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status204NoContent, ex.Message);
            }
        }

        // POST api/<MovieController>
        [HttpPost]
        [Route("AddMovie")]
        public IActionResult Post([FromBody] Movie movie)
        {
            try
            {
                int result = service.AddMovie(movie);
                if (result >= 1)
                {
                    return StatusCode(StatusCodes.Status201Created);
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // PUT api/<MovieController>/5
        [HttpPut]
        [Route("UpdateMovie")]
        public IActionResult Put(int id, [FromBody] Movie movie)
        {
            try
            {
                int result = service.UpdateMovie(movie);
                if (result >= 1)
                {
                    return StatusCode(StatusCodes.Status200OK);
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // DELETE api/<MovieController>/5
        [HttpDelete]
        [Route("DeleteMovie/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                int result = service.DeleteMovie(id);
                if (result >= 1)
                {
                    return StatusCode(StatusCodes.Status200OK);
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
