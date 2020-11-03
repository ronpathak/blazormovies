using BlazorMovies.Client.Helpers;
using BlazorMovies.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovies.Client.Repositories
{
    public class MoviesRepository: IMoviesRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/movies";

        public MoviesRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task CreateMovie(Movie movie)
        {
            Console.WriteLine("movie repository function being executed");
            var response = await httpService.Post(url, movie);
            if (!response.Success)
            {
                Console.WriteLine("Http response not success");
                throw new ApplicationException(await response.GetBody());
            }
            
        }



    }
}
