using BlazorMovies.Client.Helpers;
using BlazorMovies.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorMovies.Shared.DTOs;

namespace BlazorMovies.Client.Repositories
{
    public class MoviesRepository: IMoviesRepository
    {
        private readonly IHttpService httpService;
        private readonly string url = "api/movies";

        public MoviesRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<List<Movie>> GetMovies()
        {
            var response = await httpService.Get<List<Movie>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }


        public async Task<DetailsMovieDTO> GetMovie(int Id)
        {
            var response = await httpService.Get<DetailsMovieDTO>($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<MovieUpdateDTO> GetMovieToUpdate(int Id)
        {
            var response = await httpService.Get<MovieUpdateDTO>($"{url}/update/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }


        public async Task<List<Movie>> GetMovieByName(string name)
        {
            var response = await httpService.Get<List<Movie>>($"{url}/search/{name}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }


        public async Task CreateMovie(Movie movie)
        {
            var response = await httpService.Post(url, movie);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            
        }

        public async Task UpdateMovie(int Id, Movie movie)
        {

            var response = await httpService.Put($"{url}/{Id}", movie);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }


        public async Task DeleteMovie(int Id)
        {
            var response = await httpService.Delete($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }


    }
}
