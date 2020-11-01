using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorMovies.Shared.Entities
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Oops - you forgot to mention the name of the movie") ]
        public string Title { get; set; }
        

        public string Summary { get; set; }

        public bool InTheatres { get; set; }

        public string Trailer { get; set; }

        public string Genre { get; set; }

        public List<MoviesGenres> MovieGenres { get; set; } = new List<MoviesGenres>();
        public List<MoviesPersons> MovieActors { get; set; } = new List<MoviesPersons>();

        //[Required(ErrorMessage = "Oops - a picture says a thousand words")]
        public string Poster { get; set; }
        
        public string TitleBrief 
        { 
            get 
            {
                if (string.IsNullOrEmpty(Title)){
                    return null;
                }
                if (Title.Length > 60)
                {
                    return Title.Substring(0, 60) + "...";
                }
                else
                {
                    return Title;
                }
            
            }
            set 
            {
                


            }
        }
    }
}
