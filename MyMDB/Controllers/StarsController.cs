using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

using Microsoft.AspNetCore.Mvc;
using MyMDB.Data.EFCore;
using MyMDB.Models;
using static MyMDB.Controllers.MyMDBController;



namespace MyMDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StarsController : MyMDBContext<Star, EfCoreStarRepository>
    {
        public StarsController(EfCoreStarRepository repository) : base(repository)
        {

        }
    }
}