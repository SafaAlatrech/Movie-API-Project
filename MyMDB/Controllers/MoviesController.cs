using Microsoft.AspNetCore.Mvc;
using MyMDB.Data.EFCore;
using MyMDB.Models;
using static MyMDB.Controllers.MyMDBController;

namespace MyMDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : MyMDBContext<Movie, EfCoreMovieRepository>
    {
        public MoviesController(EfCoreMovieRepository repository) : base(repository)
        {

        }
    }
}