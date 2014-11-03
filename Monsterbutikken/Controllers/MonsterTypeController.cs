using System.Collections.Generic;
using Monsterbutikken.ReadLayer.monster;

namespace Monsterbutikken.Controllers
{
    public class MonsterTypeController : MonsterShopController
    {
        public ICollection<MonsterTypeJson> Get()
        {
            return MonsterTypesRepo.GetMonsterTypes();   
        }

        public MonsterTypeJson Get(string id)
        {
            return MonsterTypesRepo.GetMonsterType(id);
        }
    }
}