using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonDomain.Entities.DTO
{
    public class PokemonDTO
    {
        public int base_experience { get; set; }
        public int height { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int weight { get; set; }
        public List<Ability> abilities { get; set; }        
        public Sprites sprites { get; set; }
        public List<Types> types { get; set; }
        public List<Moves> moves { get; set; }

    }
}
