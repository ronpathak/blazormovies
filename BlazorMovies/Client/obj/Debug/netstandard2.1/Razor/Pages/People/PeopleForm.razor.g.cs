#pragma checksum "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Pages\People\PeopleForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e9854b9dc9acb9e1d7f280c089dc1078e2b0ab9"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMovies.Client.Pages.People
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
    public partial class PeopleForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 2 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Pages\People\PeopleForm.razor"
                 person

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 2 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Pages\People\PeopleForm.razor"
                                        OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n\r\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "form-group");
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.AddMarkupContent(10, "<label> Name </label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(11);
                __builder2.AddAttribute(12, "class", "form-control");
                __builder2.AddAttribute(13, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 7 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Pages\People\PeopleForm.razor"
                                                      person.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => person.Name = __value, person.Name))));
                __builder2.AddAttribute(15, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => person.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n        ");
                __Blazor.BlazorMovies.Client.Pages.People.PeopleForm.TypeInference.CreateValidationMessage_0(__builder2, 17, 18, 
#nullable restore
#line 8 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Pages\People\PeopleForm.razor"
                                  ()=> person.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(19, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n\r\n    ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "form-group");
                __builder2.AddMarkupContent(23, "\r\n        ");
                __builder2.AddMarkupContent(24, "<label> Date Of Birth</label>\r\n        ");
                __Blazor.BlazorMovies.Client.Pages.People.PeopleForm.TypeInference.CreateInputDate_1(__builder2, 25, 26, "form-control", 27, 
#nullable restore
#line 13 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Pages\People\PeopleForm.razor"
                                                      person.DateOfBirth

#line default
#line hidden
#nullable disable
                , 28, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => person.DateOfBirth = __value, person.DateOfBirth)), 29, () => person.DateOfBirth);
                __builder2.AddMarkupContent(30, "\r\n        ");
                __Blazor.BlazorMovies.Client.Pages.People.PeopleForm.TypeInference.CreateValidationMessage_2(__builder2, 31, 32, 
#nullable restore
#line 14 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Pages\People\PeopleForm.razor"
                                  ()=> person.DateOfBirth

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(33, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n\r\n    ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "form-group");
                __builder2.AddMarkupContent(37, "\r\n        ");
                __builder2.AddMarkupContent(38, "<label> Biography</label>\r\n        ");
                __builder2.OpenElement(39, "textarea");
                __builder2.AddAttribute(40, "class", "form-control");
                __builder2.AddAttribute(41, "rows", "3");
                __builder2.AddAttribute(42, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Pages\People\PeopleForm.razor"
                                               person.Biography

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => person.Biography = __value, person.Biography));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n        ");
                __Blazor.BlazorMovies.Client.Pages.People.PeopleForm.TypeInference.CreateValidationMessage_3(__builder2, 45, 46, 
#nullable restore
#line 20 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Pages\People\PeopleForm.razor"
                                  ()=> person.Biography

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(47, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n\r\n\r\n    ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "form-group");
                __builder2.AddMarkupContent(51, "\r\n        ");
                __builder2.OpenComponent<BlazorMovies.Client.Shared.InputImage>(52);
                __builder2.AddAttribute(53, "Label", "Picture");
                __builder2.AddAttribute(54, "OnSelectedImage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 25 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Pages\People\PeopleForm.razor"
                                                     PictureSelected

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(55, "ImageURL", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Pages\People\PeopleForm.razor"
                                                                                 imageURL

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(56, "\r\n\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n\r\n\r\n    ");
                __builder2.AddMarkupContent(58, "<div class=\"form-group\">\r\n        <button class=\"btn btn-primary\" type=\"submit\">Submit</button>\r\n    </div>\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Pages\People\PeopleForm.razor"
                                                                                 
    [Parameter]
    public Person person { get; set; }

    [Parameter]
    public EventCallback OnValidSubmit { get; set; }

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Pages\People\PeopleForm.razor"
                                                                                           

    string imageURL;

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\Ron2\source\repos\BlazorMovies\BlazorMovies\Client\Pages\People\PeopleForm.razor"
                                                                                                                                                                                         
protected override void OnInitialized()
{
    
    if (!string.IsNullOrEmpty(person.Picture))
    {
        imageURL = person.Picture;
        person.Picture = null;
    }
}


private void PictureSelected(string imageBase64)
{
    person.Picture = imageBase64;
    imageURL = null;
    Console.WriteLine(imageBase64);
}




#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BlazorMovies.Client.Pages.People.PeopleForm
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
