using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlazorMovies.Server;
using BlazorMovies.Shared.Entities;
using BlazorMovies.Server.Helpers;
using BlazorMovies.Shared.DTOs;
using System.Security.Cryptography.X509Certificates;
using AutoMapper;

namespace BlazorMovies.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IFileStorageService fileStorageService;
        private readonly IMapper mapper;

        public MoviesController(ApplicationDbContext context, IFileStorageService fileStorageService, IMapper mapper)
        {
            _context = context;
            this.fileStorageService = fileStorageService;
            this.mapper = mapper;
        }

        // GET: api/Movies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movie>>> GetMovies()
        {
            return await _context.Movies.ToListAsync();
        }

        // GET: api/Movies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DetailsMovieDTO>> GetMovie(int id)
        {
            var movie = await _context.Movies
                .Where(x=>x.Id == id)
                .Include(x => x.MovieGenres).ThenInclude(x => x.Genre)
                .Include(x => x.MovieActors).ThenInclude(x => x.Person)
                .FirstOrDefaultAsync();

            if (movie == null)
            {
                return NotFound();
            }

            movie.MovieActors = movie.MovieActors.OrderBy(x => x.Order).ToList();


            var movieDTO = new DetailsMovieDTO();
            movieDTO.Movie = movie;
            movieDTO.Genres = movie.MovieGenres.Select(x => x.Genre).ToList();
            movieDTO.Actors = movie.MovieActors.Select(x => new Person
            {
                Name = x.Person.Name,
                Picture= x.Person.Picture,
                Character = x.Character,
                Id = x.PersonId
            }).ToList();

            return movieDTO;
        }

        [HttpGet("update/{id}")]
        public async Task<ActionResult<MovieUpdateDTO>> GetMovieToUpdate(int id)
        {
            var getmovieResult = await GetMovie(id);
            if (getmovieResult.Result is NotFoundResult) 
            {
                return NotFound(); 
            }

            var movieDTO = getmovieResult.Value;
            var selectedGenresIds = movieDTO.Genres.Select(x => x.Id).ToList();
            var notSelectedGenres = await _context.Genres
                .Where(x => !selectedGenresIds.Contains(x.Id))
                .ToListAsync();

            var movieupdateDTO = new MovieUpdateDTO();
            movieupdateDTO.Movie = movieDTO.Movie;
            movieupdateDTO.SelectedGenres = movieDTO.Genres;
            movieupdateDTO.NotSelectedGenres = notSelectedGenres;
            movieupdateDTO.Actors = movieDTO.Actors;
            return movieupdateDTO;
        }

        // PUT: api/Movies/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut]
        public async Task<ActionResult> Put(Movie movie)
        {
            var movieDB = await _context.Movies.FirstOrDefaultAsync(x => x.Id == movie.Id);

            if (movieDB == null) { return NotFound(); }

            movieDB = mapper.Map(movie, movieDB);

            if (!string.IsNullOrWhiteSpace(movie.Poster))
            {
                var moviePoster = Convert.FromBase64String(movie.Poster);
                movieDB.Poster = await fileStorageService.EditFile(moviePoster,
                    "jpg", "movies", movieDB.Poster);
            }

            await _context.Database.ExecuteSqlInterpolatedAsync($"delete from MoviesActors where MovieId = {movie.Id}; delete from MoviesGenres where MovieId = {movie.Id}");

            if (movie.MovieActors != null)
            {
                for (int i = 0; i < movie.MovieActors.Count; i++)
                {
                    movie.MovieActors[i].Order = i + 1;
                }
            }
            movieDB.MovieActors = movie.MovieActors;
            movieDB.MovieGenres = movie.MovieGenres;

            await _context.SaveChangesAsync();
            return NoContent();

        }

        // POST: api/Movies
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Movie>> PostMovie(Movie movie)
        {

            if (!string.IsNullOrWhiteSpace(movie.Poster))
            {
                var moviePoster = Convert.FromBase64String(movie.Poster);
                movie.Poster= await fileStorageService.SaveFile(moviePoster, "jpg", "movies");
            }

            if (movie.MovieActors != null)
            {
                for (int i = 0; i < movie.MovieActors.Count; i++)
                {
                    movie.MovieActors[i].Order = i + 1;
                }
            }

            _context.Movies.Add(movie);
            await _context.SaveChangesAsync();

            // return movie; 
            return CreatedAtAction("GetMovie", new { id = movie.Id }, movie);
        }

        // DELETE: api/Movies/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Movie>> DeleteMovie(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }

            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();

            return movie;
        }

        private bool MovieExists(int id)
        {
            return _context.Movies.Any(e => e.Id == id);
        }
    }
}
