﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorMovies.Shared.Entities
{
    public class MoviesPersons
    {

        public int MovieId { get; set; }
        public int PersonId { get; set; }

        public Movie Movie { get; set; }
        public Person Person { get; set; }
        public string Character { get; set; }
        public int Order{ get; set; }

    }
}
