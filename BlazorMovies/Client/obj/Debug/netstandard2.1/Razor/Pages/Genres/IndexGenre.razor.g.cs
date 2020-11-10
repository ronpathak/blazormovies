#pragma checksum "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Genres\IndexGenre.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2847300e1a5aaa36244fc12fda55288ec688d952"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMovies.Client.Pages.Genres
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/genre")]
    public partial class IndexGenre : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Index Genres</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, "<div class=\"form-group\">\r\n    <a class=\"btn btn-info\" href=\"genre/create\">New Genre</a>\r\n</div>\r\n\r\n");
            __Blazor.BlazorMovies.Client.Pages.Genres.IndexGenre.TypeInference.CreateGenericList_0(__builder, 2, 3, 
#nullable restore
#line 12 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Genres\IndexGenre.razor"
                   Genres

#line default
#line hidden
#nullable disable
            , 4, (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n        ");
                __builder2.OpenElement(6, "table");
                __builder2.AddAttribute(7, "class", "table table-striped");
                __builder2.AddMarkupContent(8, "\r\n            ");
                __builder2.AddMarkupContent(9, "<thead>\r\n                <tr>\r\n                    <th></th>\r\n                    <th>Name</th>\r\n                </tr>\r\n            </thead>\r\n            ");
                __builder2.OpenElement(10, "tbody");
                __builder2.AddMarkupContent(11, "\r\n");
#nullable restore
#line 22 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Genres\IndexGenre.razor"
                 foreach (var item in Genres)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(12, "                ");
                __builder2.OpenElement(13, "tr");
                __builder2.AddMarkupContent(14, "\r\n                    ");
                __builder2.OpenElement(15, "td");
                __builder2.AddContent(16, 
#nullable restore
#line 25 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Genres\IndexGenre.razor"
                         item.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n                    ");
                __builder2.OpenElement(18, "td");
                __builder2.AddMarkupContent(19, "\r\n                        ");
                __builder2.OpenElement(20, "a");
                __builder2.AddAttribute(21, "class", "btn btn-success");
                __builder2.AddAttribute(22, "href", "/genre/edit/" + (
#nullable restore
#line 27 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Genres\IndexGenre.razor"
                                                                      item.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(23, "Edit");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n                        ");
                __builder2.OpenElement(25, "button");
                __builder2.AddAttribute(26, "class", "btn btn-danger");
                __builder2.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Genres\IndexGenre.razor"
                                                                   () => DeleteGenres(item.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(28, "Delete");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n");
#nullable restore
#line 31 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Genres\IndexGenre.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(32, "            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n    ");
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Genres\IndexGenre.razor"
       

    List<Genre> Genres;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            Genres = await genreRepository.GetGenres();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private async Task DeleteGenres(int Id)
    {
        await genreRepository.DeleteGenre(Id);
        Genres = await genreRepository.GetGenres();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGenresRepository genreRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
namespace __Blazor.BlazorMovies.Client.Pages.Genres.IndexGenre
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateGenericList_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::BlazorMovies.Client.Shared.GenericList<TItem>>(seq);
        __builder.AddAttribute(__seq0, "List", __arg0);
        __builder.AddAttribute(__seq1, "WholeListTemplate", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
