using BlazorMovies.Shared.DTOs;
using BlazorMovies.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovies.Client.Repositories
{
    interface IMoviesRepository
    {
        //Task<Movie> CreateMovie(Movie movie);
        Task<int> CreateMovie(Movie movie);
        Task DeleteMovie(int Id);
        Task<DetailsMovieDTO> GetMovie(int Id);
        Task<List<Movie>> GetMovieByName(string name);
        Task<List<Movie>> GetMovies();
        Task<MovieUpdateDTO> GetMovieToUpdate(int Id);
        Task UpdateMovie(int Id, Movie movie);
    }
}
