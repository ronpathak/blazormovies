﻿using BlazorMovies.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovies.Client.Repositories
{
    interface IMoviesRepository
    {
        Task CreateMovie(Movie movie);
    }
}
