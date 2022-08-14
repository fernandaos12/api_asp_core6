using Microsoft.AspNetCore.Mvc;

namespace PokeAcademyAPI.Controllers
{
    [ApiController]
    [Route("api/pokemon")]
    public class PokemonController : ControllerBase
    {
        private const string ALL_POKEMON_URL = "https://pokeapi.co/api/v2/pokemon";
        private const string EXTERNAL_BASE_URL = "https://localhost:7235";
        private const string TOKEN = "Bearer ";

        public PokemonController()
        {

        }

        [HttpGet]
        public async Task<IActionResult> GetAll(int limit)
        {
            return Ok();
        }

         [HttpGet("id")]
        public async Task<IActionResult> GetbyId(int id)
        {
            return Ok();
        }

         [HttpPost]
        public async Task<IActionResult> Post(Ping ping)
        {
            return Ok();
        }
    }

    public class Ping{
        public string Message { get; set; }
    }

     public class ExternalResponse
     {
      public List<string> Headers {get; set;}
      public Ping Data { get; set; }
    }
}