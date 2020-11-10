#pragma checksum "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Movies\EditMovie.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f6028c538ed8db90c2f761835dadd235d811cfe"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMovies.Client.Pages.Movies
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Shared.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client.Repositories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Shared.DTOs;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/movies/edit/{MovieId:int}")]
    public partial class EditMovie : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Edit Movie</h3>\r\n\r\n");
#nullable restore
#line 7 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Movies\EditMovie.razor"
 if (movie != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenComponent<BlazorMovies.Client.Pages.Movies.MovieForm>(2);
            __builder.AddAttribute(3, "movie", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorMovies.Shared.Entities.Movie>(
#nullable restore
#line 9 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Movies\EditMovie.razor"
                      movie

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "NotSelectedGenres", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<BlazorMovies.Shared.Entities.Genre>>(
#nullable restore
#line 9 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Movies\EditMovie.razor"
                                                NotSelectedGenresList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "SelectedGenres", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<BlazorMovies.Shared.Entities.Genre>>(
#nullable restore
#line 9 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Movies\EditMovie.razor"
                                                                                       SelectedGenresList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "SelectedActors", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<BlazorMovies.Shared.Entities.Person>>(
#nullable restore
#line 9 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Movies\EditMovie.razor"
                                                                                                                           SelectedActors

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 9 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Movies\EditMovie.razor"
                                                                                                                                                          MovieEdit

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\r\n");
#nullable restore
#line 10 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Movies\EditMovie.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Movies\EditMovie.razor"
       
    [Parameter]
    public int MovieId { get; set; }

    private Movie movie = new Movie();
    private Genre genre;
    private List<Genre> SelectedGenresList = new List<Genre>();// { new Genre() { Id = 2, Name = "Comedy" } };
    private List<Genre> NotSelectedGenresList = new List<Genre>(); //{ new Genre() { Id = 2, Name = "Action" } };
    private List<Person> SelectedActors = new List<Person>();


    //private List<Genre> NotSelectedGenres = new List<Genre>()
    //{
    //    new Genre(){Id = 2, Name = "Comedy"},
    //    new Genre(){Id = 3, Name = "Drama"}
    //};

    //private List<Genre> SelectedGenres = new List<Genre>()
    //{
    //    new Genre(){Id = 1, Name = "Action"}
    //};


    protected async override Task OnInitializedAsync()
    {
        var model = await movierepository.GetMovieToUpdate(MovieId);
        movie = model.Movie;
        SelectedGenresList = model.SelectedGenres;
        NotSelectedGenresList = model.NotSelectedGenres;
        SelectedActors = model.Actors;




        Console.WriteLine($"the movie Poster is {movie.Poster}");

        Console.WriteLine($"The id of the movie is {MovieId}");
        Console.WriteLine($"The name  of the movie is {movie.Title}");
        Console.WriteLine($"The summary of the movie is {movie.Summary}");
        Console.WriteLine($"The selected genres of the movie are:");
        for (int gen = 0; gen < SelectedGenresList.Count; gen++)
        {
            Console.WriteLine($"{SelectedGenresList[gen].Id}   {SelectedGenresList[gen].Name}");
        }
        Console.WriteLine($"The notselected genres of the movie are:");
        for (int gen = 0; gen < NotSelectedGenresList.Count; gen++)
        {
            Console.WriteLine($"{NotSelectedGenresList[gen].Id}     {NotSelectedGenresList[gen].Name}");
        }
        Console.WriteLine($"The actors of the movie are:");
        for (int act = 0; act < SelectedActors.Count; act++)
        {
            Console.WriteLine($"{SelectedActors[act].Name}");
        }
    }


    private void MovieEdit()
    {
        Console.WriteLine($"Movie saved with name: { movie.Title}");
        navigationManager.NavigateTo("movies/search");
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMoviesRepository movierepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
