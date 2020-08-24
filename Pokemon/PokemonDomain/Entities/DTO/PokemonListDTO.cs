using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonDomain.Entities.DTO
{
    public class PokemonListDTO
    {
        public int count { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public List<PokemonList> results { get; set; }
    }
}
