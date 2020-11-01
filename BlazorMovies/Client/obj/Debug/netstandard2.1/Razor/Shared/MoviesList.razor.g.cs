#pragma checksum "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Shared\MoviesList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99b49c28ba5dc7108b930ad5529db4cd5ac3696d"
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
    public partial class MoviesList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "\r\n\r\n    ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "movies-container");
            __builder.AddMarkupContent(4, "\r\n\r\n\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Shared\MoviesList.razor"
         if (Movies == null)
        {
            

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, " Loading...");
#nullable restore
#line 11 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Shared\MoviesList.razor"
                                    
        }
        else if (Movies.Count == 0)
        {
            

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "There are no movies listed");
#nullable restore
#line 15 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Shared\MoviesList.razor"
                                                   
        }
        else
        {


            

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Shared\MoviesList.razor"
             foreach (var movie in Movies)
            {




#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "                ");
            __builder.OpenComponent<BlazorMovies.Client.Shared.IndividualMovie>(8);
            __builder.AddAttribute(9, "movie", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorMovies.Shared.Entities.Movie>(
#nullable restore
#line 26 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Shared\MoviesList.razor"
                                        movie

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "Delete", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorMovies.Shared.Entities.Movie>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorMovies.Shared.Entities.Movie>(this, 
#nullable restore
#line 27 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Shared\MoviesList.razor"
                                         DeleteMovie

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n");
#nullable restore
#line 28 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Shared\MoviesList.razor"



            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Shared\MoviesList.razor"
             ;
     }

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n\r\n\r\n");
            __builder.OpenComponent<BlazorMovies.Client.Shared.ConfirmationModalt>(15);
            __builder.AddAttribute(16, "onConfirm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 37 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Shared\MoviesList.razor"
                                                   onConfirm

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(17, "onCancel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 37 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Shared\MoviesList.razor"
                                                                        onCancel

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(18, "RF1", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(19, " Are you sure you want to delete ");
                __builder2.AddContent(20, 
#nullable restore
#line 38 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Shared\MoviesList.razor"
                                           movieToBeDeleted.Title

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.AddComponentReferenceCapture(21, (__value) => {
#nullable restore
#line 37 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Shared\MoviesList.razor"
                          confirmation = (BlazorMovies.Client.Shared.ConfirmationModalt)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(22, "\r\n\r\n");
            __builder.OpenComponent<BlazorMovies.Client.Shared.ConfirmationModalt>(23);
            __builder.AddAttribute(24, "onConfirm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 41 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Shared\MoviesList.razor"
                                                           onConfirm2

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(25, "onCancel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 41 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Shared\MoviesList.razor"
                                                                                 onCancel2

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(26, (__value) => {
#nullable restore
#line 41 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Shared\MoviesList.razor"
                          confirmationOfCancel = (BlazorMovies.Client.Shared.ConfirmationModalt)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Shared\MoviesList.razor"
       


    ConfirmationModalt confirmation;
    ConfirmationModalt confirmationOfCancel;

    [Parameter]
    public List<Movie> Movies {get;set;}



    Movie movieToBeDeleted;
    private void DeleteMovie(Movie movie)
    {
        confirmation.Show();
        movieToBeDeleted = movie;
    }

    void onConfirm()
    {
        confirmation.Hide();
        confirmationOfCancel.Show();
    }

    void onConfirm2()
    {
        Movies.Remove(movieToBeDeleted);
        confirmationOfCancel.Hide();
        movieToBeDeleted = null;
    }

    void onCancel()
    {
        confirmation.Hide();
        movieToBeDeleted = null;

    }
    void onCancel2()
    {
        confirmationOfCancel.Hide();
        movieToBeDeleted = null;

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
