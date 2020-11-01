﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Text;

namespace BlazorMovies.Shared.Entities
{
    public class Person
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Please enter a genre name.")]
        public string Name { get; set; }
        public string Biography { get; set; }
        public string Picture { get; set; }
        [Required]
        public DateTime? DateOfBirth { get; set; }
        public List<MoviesPersons> MoviePerson { get; set; } = new List<MoviesPersons>();
        
        [NotMapped]
        public string Character { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Person p2)
            {
                 return Id == p2.Id;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
