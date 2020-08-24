using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonDomain.Entities.DTO
{
    public class Ability
    {
        public string name { get; set; }
        public string url { get; set; }
        public bool is_hidden { get; set; }
        public int slot { get; set; }
    }
}
