using System;
using System.Collections.Generic;

namespace Monsterbutikken.ReadLayer.monster
{
    public class MonsterTypesRepo
    {
        private static readonly IDictionary<String, MonsterTypeJson> MonsterTypes = new Dictionary<string, MonsterTypeJson>();

        static MonsterTypesRepo()
        {
            MonsterTypes.Add("Ao (skilpadde)", new MonsterTypeJson{
                Name = "Ao (skilpadde)", 
                Price = 100000
            });

            MonsterTypes.Add("Bakeneko", new MonsterTypeJson
            {
                Name = "Bakeneko",
                Price = 100000
            });
        }

        public static ICollection<MonsterTypeJson> GetMonsterTypes()
        {
            return MonsterTypes.Values;
        }

        public static MonsterTypeJson GetMonsterType(string monsterType)
        {
            return MonsterTypes[monsterType];
        }
    }

    public class MonsterTypeJson
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
}