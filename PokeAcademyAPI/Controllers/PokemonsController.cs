using Microsoft.AspNetCore.Mvc;

namespace PokeAcademyAPI.Controllers
{
    [ApiController]
    [Route("api/pokemon")]
    public class PokemonController : ControllerBase
    {
        private const string ALL_POKEMON_URL = "https://pokeapi.co/api/v2/pokemon";
        private const string EXTERNAL_BASE_URL = 
    }
}