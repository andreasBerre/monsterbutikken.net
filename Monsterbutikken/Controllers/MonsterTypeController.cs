using Monsterbutikken.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Monsterbutikken.Repos;

namespace Monsterbutikken.Controllers
{
    public class MonsterTypeController : ApiController
    {
        public ICollection<MonsterTypeJson> Get()
        {
            return MonsterTypesRepo.getMonsterTypes();   
        }
    }
}