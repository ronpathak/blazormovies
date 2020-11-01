using BlazorMovies.Client.Helpers;
using BlazorMovies.Shared.Entities;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovies.Client.Pages
{
    public partial class Counter
    {
        [Inject] IRepository repository { get; set; }

        private List<Movie> movies1;
        protected override void OnInitialized()
        {

            movies1 = repository.GetMovies();
        }

    }
}
