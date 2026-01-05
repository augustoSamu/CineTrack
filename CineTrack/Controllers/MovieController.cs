using Microsoft.AspNetCore.Mvc;

namespace CineTrack.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController
    {
        [HttpGet]
        public string GetMovies()
        {
            return "List of movies";
        }

        [HttpPost]
        public string PostMovies()
        {
            return "Add a movie";
        }

        [HttpPut("{id:int}/done")]
        public string PostMovies(int id)
        {
            return "Movie x updated to watched";
        }
    }
}
