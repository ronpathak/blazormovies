#pragma checksum "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Shared\IndividualMovie.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72d1d7446de917fb3cfdcbdebf2a17db02060f65"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMovies.Client.Shared
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
    public partial class IndividualMovie : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "individual-movie-container");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "a");
            __builder.AddAttribute(4, "href", 
#nullable restore
#line 3 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Shared\IndividualMovie.razor"
              movieURL

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "img");
            __builder.AddAttribute(7, "src", 
#nullable restore
#line 4 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Shared\IndividualMovie.razor"
                   movie.Poster

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(8, "alt", "Poster");
            __builder.AddAttribute(9, "class", "movie-poster");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n\r\n    ");
            __builder.OpenElement(12, "p");
            __builder.OpenElement(13, "a");
            __builder.AddAttribute(14, "href", 
#nullable restore
#line 7 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Shared\IndividualMovie.razor"
                 movieURL

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(15, 
#nullable restore
#line 7 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Shared\IndividualMovie.razor"
                            movie.TitleBrief

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.OpenElement(17, "p");
            __builder.AddContent(18, 
#nullable restore
#line 8 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Shared\IndividualMovie.razor"
        movie.Genre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\r\n    ");
            __builder.OpenElement(20, "div");
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.OpenElement(22, "a");
            __builder.AddAttribute(23, "class", "btn btn-info");
            __builder.AddAttribute(24, "href", "movies/edit/" + (
#nullable restore
#line 11 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Shared\IndividualMovie.razor"
                                                   movie.Id

#line default
#line hidden
#nullable disable
            ) + "/");
            __builder.AddContent(25, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "type", "button");
            __builder.AddAttribute(29, "class", "btn btn-danger");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Shared\IndividualMovie.razor"
                                                                 ()=>Delete.InvokeAsync(movie)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(31, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n\r\n\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Shared\IndividualMovie.razor"
       
    [Parameter]
    public Movie movie { get; set; }

    [Parameter]
    public bool ButtonDisplay { get; set; } = false;


    [Parameter(CaptureUnmatchedValues = true)]
    public IDictionary<string, object> AdditionalParameters { get; set; }

    [Parameter]
    public EventCallback<Movie> Delete { get; set; }


    private string movieURL = string.Empty;
    private string movieEditURL = string.Empty;

    protected override void OnInitialized()
    {
        movieURL =$"movie/{movie.Id}/{movie.Title.Replace(" ","-")}";
        movieEditURL = $"movies/edit/{movie.Id}/{movie.Title.Replace(" ", "-")}";

    }





#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
