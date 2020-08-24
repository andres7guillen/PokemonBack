using PokemonDomain.Entities.DTO;
using PokemonDomain.Repositories;
using PokemonDomain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PokemonInfrastructure.Services
{
    public class PokemonService : IPokemonService
    {
        private readonly IPokemonRepository _repository;
        public PokemonService(IPokemonRepository repository)
        {
            _repository = repository;
        }

        public async Task<PokemonListDTO> getAll() => await _repository.getAll();

        public async Task<PokemonDTO> getPokemonById(string url) => await _repository.getPokemonById(url);

        public async Task<PokemonDTO> getPokemonByName(string name) => await _repository.getPokemonByName(name);
    }
}
