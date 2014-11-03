using System;

namespace Monsterbutikken.Models
{
    public class MonsterJson
    {
        public MonsterJson() { }

        public MonsterJson(String navn, double pris)
        {
            this.navn = navn;
            this.pris = pris;
        }

        public String navn { get; private set; }
        public double pris { get; private set; }
    }
}