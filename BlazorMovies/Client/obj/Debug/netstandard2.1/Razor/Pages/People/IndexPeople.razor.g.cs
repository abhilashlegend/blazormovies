#pragma checksum "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\Pages\People\IndexPeople.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00f682512f2c71bb8865193bae1a6d5718fcfe9f"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/people")]
    public partial class IndexPeople : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Index People</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, "<div class=\"form-group\">\r\n    <a class=\"btn btn-info\" href=\"person/create\">New Person</a>\r\n</div>\r\n\r\n");
            __Blazor.BlazorMovies.Client.Pages.People.IndexPeople.TypeInference.CreateGenericList_0(__builder, 2, 3, 
#nullable restore
#line 9 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\Pages\People\IndexPeople.razor"
                   People

#line default
#line hidden
#nullable disable
            , 4, (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n        ");
                __builder2.OpenElement(6, "table");
                __builder2.AddAttribute(7, "class", "table table-striped");
                __builder2.AddMarkupContent(8, "\r\n            ");
                __builder2.AddMarkupContent(9, "<thead>\r\n                <tr>\r\n                    <th>Name</th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            ");
                __builder2.OpenElement(10, "tbody");
                __builder2.AddMarkupContent(11, "\r\n");
#nullable restore
#line 19 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\Pages\People\IndexPeople.razor"
                 foreach(var item in People)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(12, "                    ");
                __builder2.OpenElement(13, "tr");
                __builder2.AddMarkupContent(14, "\r\n                        ");
                __builder2.OpenElement(15, "td");
                __builder2.AddContent(16, 
#nullable restore
#line 22 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\Pages\People\IndexPeople.razor"
                             item.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n                        ");
                __builder2.AddMarkupContent(18, "<td>\r\n                            <a class=\"btn btn-primary\">Edit</a>\r\n                            <button class=\"btn btn-danger\">Delete</button>\r\n                        </td>\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n");
#nullable restore
#line 28 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\Pages\People\IndexPeople.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(20, "            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n    ");
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\Pages\People\IndexPeople.razor"
       
    List<Person> People;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            People = await personRepository.GetPeople();
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPersonRepository personRepository { get; set; }
    }
}
namespace __Blazor.BlazorMovies.Client.Pages.People.IndexPeople
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
