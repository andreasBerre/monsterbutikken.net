using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Monsterbutikken.Models;

namespace Monsterbutikken.Repos
{
    public class MonsterTypesRepo
    {
        private static IDictionary<String, MonsterTypeJson> _monsterTypes = new Dictionary<string, MonsterTypeJson>();

        static MonsterTypesRepo()
        {
            _monsterTypes.Add("Ao (skilpadde)", new MonsterTypeJson{
                name = "Ao (skilpadde)", 
                price = 100000
            });

            _monsterTypes.Add("Bakeneko", new MonsterTypeJson
            {
                name = "Bakeneko",
                price = 100000
            });
        }

        public static ICollection<MonsterTypeJson> getMonsterTypes()
        {
            return _monsterTypes.Values;
        }
    }

    public class MonsterTypeJson
    {
        public string name { get; set; }
        public int price { get; set; }
    }
}