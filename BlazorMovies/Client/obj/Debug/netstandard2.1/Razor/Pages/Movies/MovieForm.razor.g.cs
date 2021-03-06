#pragma checksum "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43991593e7c69c34c3d2eb9e362bdc322afcd3db"
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
#line 1 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Shared.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client.Repository;

#line default
#line hidden
#nullable disable
    public partial class MovieForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 3 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieForm.razor"
                 Movie

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 3 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieForm.razor"
                                       OnDataAnnotationsValidated

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "form-group");
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.AddMarkupContent(10, "<label>Title: </label>\r\n        ");
                __builder2.OpenElement(11, "div");
                __builder2.AddMarkupContent(12, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(13);
                __builder2.AddAttribute(14, "class", "form-control");
                __builder2.AddAttribute(15, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 8 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieForm.razor"
                                                          Movie.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Movie.Title = __value, Movie.Title))));
                __builder2.AddAttribute(17, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Movie.Title));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n            ");
                __Blazor.BlazorMovies.Client.Pages.Movies.MovieForm.TypeInference.CreateValidationMessage_0(__builder2, 19, 20, 
#nullable restore
#line 9 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieForm.razor"
                                       () => Movie.Title 

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(21, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n    ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "form-group");
                __builder2.AddMarkupContent(26, "\r\n        ");
                __builder2.AddMarkupContent(27, "<label>In Theaters</label>\r\n        ");
                __builder2.OpenElement(28, "div");
                __builder2.AddMarkupContent(29, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(30);
                __builder2.AddAttribute(31, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieForm.razor"
                                        Movie.InTheaters

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Movie.InTheaters = __value, Movie.InTheaters))));
                __builder2.AddAttribute(33, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => Movie.InTheaters));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\r\n            ");
                __Blazor.BlazorMovies.Client.Pages.Movies.MovieForm.TypeInference.CreateValidationMessage_1(__builder2, 35, 36, 
#nullable restore
#line 16 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieForm.razor"
                                      () => Movie.InTheaters

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(37, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n    ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "form-group");
                __builder2.AddMarkupContent(42, "\r\n        ");
                __builder2.AddMarkupContent(43, "<label>Trailer:</label>\r\n        ");
                __builder2.OpenElement(44, "div");
                __builder2.AddMarkupContent(45, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(46);
                __builder2.AddAttribute(47, "class", "form-control");
                __builder2.AddAttribute(48, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieForm.razor"
                                                          Movie.Trailer

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Movie.Trailer = __value, Movie.Trailer))));
                __builder2.AddAttribute(50, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Movie.Trailer));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\r\n            ");
                __Blazor.BlazorMovies.Client.Pages.Movies.MovieForm.TypeInference.CreateValidationMessage_2(__builder2, 52, 53, 
#nullable restore
#line 23 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieForm.razor"
                                      () => Movie.Trailer

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(54, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n    ");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "form-group");
                __builder2.AddMarkupContent(59, "\r\n        ");
                __builder2.AddMarkupContent(60, "<label>Release Date:</label>\r\n        ");
                __builder2.OpenElement(61, "div");
                __builder2.AddMarkupContent(62, "\r\n            ");
                __Blazor.BlazorMovies.Client.Pages.Movies.MovieForm.TypeInference.CreateInputDate_3(__builder2, 63, 64, "form-control", 65, 
#nullable restore
#line 29 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieForm.razor"
                                                          Movie.ReleaseDate

#line default
#line hidden
#nullable disable
                , 66, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Movie.ReleaseDate = __value, Movie.ReleaseDate)), 67, () => Movie.ReleaseDate);
                __builder2.AddMarkupContent(68, "\r\n            ");
                __Blazor.BlazorMovies.Client.Pages.Movies.MovieForm.TypeInference.CreateValidationMessage_4(__builder2, 69, 70, 
#nullable restore
#line 30 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieForm.razor"
                                      () => Movie.ReleaseDate

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(71, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n    ");
                __builder2.OpenElement(74, "div");
                __builder2.AddAttribute(75, "class", "form-group");
                __builder2.AddMarkupContent(76, "\r\n        ");
                __builder2.OpenComponent<BlazorMovies.Client.Shared.InputImg>(77);
                __builder2.AddAttribute(78, "Label", "Picture");
                __builder2.AddAttribute(79, "OnSelectedImage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 34 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieForm.razor"
                                                   PosterSelected

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(80, "ImageUrl", 
#nullable restore
#line 34 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieForm.razor"
                                                                              imageURL

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(81, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n\r\n    ");
                __builder2.OpenElement(83, "div");
                __builder2.AddAttribute(84, "class", "form-group form-markdown");
                __builder2.AddMarkupContent(85, "\r\n        ");
                __Blazor.BlazorMovies.Client.Pages.Movies.MovieForm.TypeInference.CreateInputMarkdown_5(__builder2, 86, 87, "Biography", 88, 
#nullable restore
#line 38 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieForm.razor"
                                                                             () => Movie.Summary

#line default
#line hidden
#nullable disable
                , 89, 
#nullable restore
#line 38 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieForm.razor"
                                    Movie.Summary

#line default
#line hidden
#nullable disable
                , 90, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Movie.Summary = __value, Movie.Summary)), 91, () => Movie.Summary);
                __builder2.AddMarkupContent(92, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n\r\n    ");
                __builder2.OpenElement(94, "div");
                __builder2.AddAttribute(95, "class", "form-group");
                __builder2.AddMarkupContent(96, "\r\n        ");
                __builder2.AddMarkupContent(97, "<label>Genres: </label>\r\n        ");
                __builder2.OpenElement(98, "div");
                __builder2.AddMarkupContent(99, "\r\n            ");
                __builder2.OpenComponent<BlazorMovies.Client.Shared.MultipleSelector>(100);
                __builder2.AddAttribute(101, "Selected", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<BlazorMovies.Client.Helpers.MultipleSelectorModel>>(
#nullable restore
#line 44 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieForm.razor"
                                        Selected

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(102, "NotSelected", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<BlazorMovies.Client.Helpers.MultipleSelectorModel>>(
#nullable restore
#line 44 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieForm.razor"
                                                               NotSelected

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(103, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(104, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(105, "\r\n\r\n    ");
                __builder2.OpenElement(106, "div");
                __builder2.AddAttribute(107, "class", "form-group");
                __builder2.AddMarkupContent(108, "\r\n        ");
                __builder2.AddMarkupContent(109, "<label>Actors:</label>\r\n        ");
                __builder2.OpenElement(110, "div");
                __builder2.AddMarkupContent(111, "\r\n            ");
                __Blazor.BlazorMovies.Client.Pages.Movies.MovieForm.TypeInference.CreateMultipleSelectorTypehead_6(__builder2, 112, 113, 
#nullable restore
#line 51 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieForm.razor"
                                                                     SearchMethod

#line default
#line hidden
#nullable disable
                , 114, 
#nullable restore
#line 52 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieForm.razor"
                                                        SelectedActors

#line default
#line hidden
#nullable disable
                , 115, (person) => (__builder3) => {
                    __builder3.AddMarkupContent(116, "\r\n                    ");
                    __builder3.OpenElement(117, "img");
                    __builder3.AddAttribute(118, "style", "width: 50px;");
                    __builder3.AddAttribute(119, "src", 
#nullable restore
#line 54 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieForm.razor"
                                                    person.Picture

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(120, "\r\n                    ");
                    __builder3.AddContent(121, 
#nullable restore
#line 55 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieForm.razor"
                     person.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(122, "\r\n                ");
                }
                , 123, (person) => (__builder3) => {
                    __builder3.AddMarkupContent(124, "\r\n                    ");
                    __builder3.AddContent(125, 
#nullable restore
#line 58 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieForm.razor"
                     person.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(126, " / ");
                    __builder3.OpenElement(127, "input");
                    __builder3.AddAttribute(128, "type", "text");
                    __builder3.AddAttribute(129, "placeholder", "Character");
                    __builder3.AddAttribute(130, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 58 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieForm.razor"
                                                                                     person.Character

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(131, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => person.Character = __value, person.Character));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(132, "\r\n                ");
                }
                );
                __builder2.AddMarkupContent(133, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(134, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(135, "\r\n\r\n    ");
                __builder2.AddMarkupContent(136, "<button class=\"btn btn-primary\" type=\"submit\">Save Changes</button>\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieForm.razor"
       
    [Parameter] public Movie Movie { get; set; }
    [Parameter] public EventCallback OnValidSubmit { get; set; }
    [Parameter] public List<Genre> SelectedGenres { get; set; } = new List<Genre>();
    [Parameter] public List<Genre> NotSelectedGenres { get; set; } = new List<Genre>();
    [Parameter] public List<Person> SelectedActors { get; set; } = new List<Person>();

    private List<MultipleSelectorModel> Selected = new List<MultipleSelectorModel>();
    private List<MultipleSelectorModel> NotSelected = new List<MultipleSelectorModel>();

    private string imageURL;

    protected override void OnInitialized()
    {
        Selected = SelectedGenres.Select(x => new MultipleSelectorModel(x.Id.ToString(), x.Name)).ToList();
        NotSelected = NotSelectedGenres.Select(x => new MultipleSelectorModel(x.Id.ToString(), x.Name)).ToList();

        if (!string.IsNullOrEmpty(Movie.Poster))
        {
            imageURL = Movie.Poster;
            Movie.Poster = null;
        }
    }

    private void PosterSelected(string imageBase64)
    {
        Movie.Poster = imageBase64;
        imageURL = null;
        Console.WriteLine(imageBase64);
    }

    private async Task<IEnumerable<Person>> SearchMethod(string searchText)
    {
        return await personRepository.GetPeopleByName(searchText);
    }

    private async Task OnDataAnnotationsValidated()
    {
        Movie.MoviesGenres = Selected
            .Select(x => new MoviesGenres { GenreId = int.Parse(x.Key) }).ToList();

        Movie.MoviesActors = SelectedActors
            .Select(x => new MoviesActors { PersonId = x.Id, Character = x.Character }).ToList();

        if (!string.IsNullOrWhiteSpace(Movie.Poster)) { imageURL = null; }

        await OnValidSubmit.InvokeAsync(null);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPersonRepository personRepository { get; set; }
    }
}
namespace __Blazor.BlazorMovies.Client.Pages.Movies.MovieForm
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
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputMarkdown_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg1, int __seq2, global::System.String __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<global::System.String> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<global::System.String>> __arg4)
        {
        __builder.OpenComponent<global::BlazorMovies.Client.Shared.InputMarkdown<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "For", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMultipleSelectorTypehead_6<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Func<global::System.String, global::System.Threading.Tasks.Task<global::System.Collections.Generic.IEnumerable<T>>> __arg0, int __seq1, global::System.Collections.Generic.List<T> __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg3)
        {
        __builder.OpenComponent<global::BlazorMovies.Client.Shared.MultipleSelectorTypehead<T>>(seq);
        __builder.AddAttribute(__seq0, "SearchMethod", __arg0);
        __builder.AddAttribute(__seq1, "SelectedElements", __arg1);
        __builder.AddAttribute(__seq2, "MyResultTemplate", __arg2);
        __builder.AddAttribute(__seq3, "MyListTemplate", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
