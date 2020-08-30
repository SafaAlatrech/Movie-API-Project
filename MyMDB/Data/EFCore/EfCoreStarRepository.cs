using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyMDB.Models;
namespace MyMDB.Data.EFCore
{
    public class EfCoreStarRepository : EfCoreRepository<Star, MyMDBContext>
    {

        public EfCoreStarRepository(MyMDBContext context) : base(context)
        {

        }

    }
}
