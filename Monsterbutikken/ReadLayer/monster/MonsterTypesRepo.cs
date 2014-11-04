using System;
using System.Collections.Generic;

namespace Monsterbutikken.ReadLayer.monster
{
    public class MonsterTypesRepo
    {
        private static readonly IDictionary<String, MonsterTypeJson> MonsterTypes = new Dictionary<string, MonsterTypeJson>();

        static MonsterTypesRepo()
        {            
            AddMonster("Giant squid", 100000);
            AddMonster("Bakeneko", 120000);
            AddMonster("Basilisk", 175000);
            AddMonster("Det erymanthiske villsvin", 25000);
            AddMonster("Griff", 12000);
            AddMonster("Hamloper", 8000);
            AddMonster("Hippogriff", 128000);
            AddMonster("Hydra", 38000);
            AddMonster("Kentaur", 76000);
            AddMonster("Kerberos", 31000);
            AddMonster("Kraken", 2800);
            AddMonster("Mannbjorn", 49000);
            AddMonster("Mantikora", 21000);
            AddMonster("Margyge", 73000);
            AddMonster("Marmale", 149000);
            AddMonster("Minotauros", 28000);
            AddMonster("Nekomusume", 62000);
            AddMonster("Rokk", 12000);
            AddMonster("Seljordsormen", 56000);
            AddMonster("Sfinks", 39000);
            AddMonster("Sirene", 12900);
            AddMonster("Sjoorm", 240000);
            AddMonster("Succubus", 84000);
            AddMonster("Valravn", 92300);
            AddMonster("Vampyr", 420000);
            AddMonster("Varulv", 69000);
        }

        private static void AddMonster(string name, double price)
        {
            MonsterTypes.Add(name, new MonsterTypeJson
            {
                Name = name,
                Price = price
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
        public double Price { get; set; }
    }
}