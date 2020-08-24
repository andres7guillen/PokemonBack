using Newtonsoft.Json;
using PokemonDomain.Entities.DTO;
using PokemonDomain.Repositories;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PokemonInfrastructure.Repositories
{
    public class PokemonRepository : IPokemonRepository
    {
        public async Task<PokemonListDTO> getAll()
        {
            try
            {
                var client = new RestClient("https://pokeapi.co/api/v2/pokemon?offset=0&limit=1048");
                var request = new RestRequest(Method.GET);
                var response = await client.ExecuteAsync(request);
                PokemonListDTO result = JsonConvert.DeserializeObject<PokemonListDTO>(response.Content);
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }           
        }

        public async Task<PokemonDTO> getPokemonById(string url)
        {
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest(Method.GET);
                var response = await client.ExecuteAsync(request);
                PokemonDTO result = JsonConvert.DeserializeObject<PokemonDTO>(response.Content);
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<PokemonDTO> getPokemonByName(string name)
        {
            try
            {
                var client = new RestClient("https://pokeapi.co/api/v2/pokemon/" + name);
                var request = new RestRequest(Method.GET);
                var response = await client.ExecuteAsync(request);
                PokemonDTO result = JsonConvert.DeserializeObject<PokemonDTO>(response.Content);
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }            
        }
    }
}
