using ProjetoCinema.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCinema.Client.Repository
{
    public interface IGeneroRepository
    {
        Task CreateGenero(Genero genero);
        Task DeleteGenre(int Id);
        Task<Genero> GetGenre(int Id);
        Task<List<Genero>> GetGenres();
        Task UpdateGenre(Genero genre);
    }
}
