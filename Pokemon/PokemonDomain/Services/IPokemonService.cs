using PokemonDomain.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDomain.Services
{
    public interface IPokemonService
    {
        Task<PokemonListDTO> getAll();
        Task<PokemonDTO> getPokemonById(string url);
        Task<PokemonDTO> getPokemonByName(string name);
    }
}
