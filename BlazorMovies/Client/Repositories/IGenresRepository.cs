using BlazorMovies.Shared.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorMovies.Client.Repositories
{
    public interface IGenresRepository
    {
        Task CreateGenre(Genre genre);
        Task DeleteGenre(int Id);
        Task<Genre> GetGenre(int Id);
        Task<List<Genre>> GetGenres();
        Task UpdateGenre(Genre genre);
    }
}