using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text;

namespace BlazorMovies.Shared.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please enter a genre name.")]
        public string Name { get; set; }

        public List<MoviesGenres> MovieGenres { get; set; } = new List<MoviesGenres>();
    }

}
