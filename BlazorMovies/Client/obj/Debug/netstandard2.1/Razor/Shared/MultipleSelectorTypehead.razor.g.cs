#pragma checksum "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\Shared\MultipleSelectorTypehead.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7fe8c4cf25d3717efe79cc81f2aa5f26ab0eb66e"
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
    public partial class MultipleSelectorTypehead<T> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.BlazorMovies.Client.Shared.MultipleSelectorTypehead.TypeInference.CreateCustomTypeahead_0(__builder, 0, 1, 
#nullable restore
#line 3 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\Shared\MultipleSelectorTypehead.razor"
                                 (string searchText) => SearchMethod(searchText)

#line default
#line hidden
#nullable disable
            , 2, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 4 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\Shared\MultipleSelectorTypehead.razor"
                                 (T item) => SelectedElement(item)

#line default
#line hidden
#nullable disable
            ), 3, (context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n        ");
                __builder2.AddContent(5, 
#nullable restore
#line 6 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\Shared\MultipleSelectorTypehead.razor"
         MyResultTemplate(context)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(6, "\r\n    ");
            }
            );
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.OpenElement(8, "ul");
            __builder.AddAttribute(9, "class", "list-group");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 11 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\Shared\MultipleSelectorTypehead.razor"
     foreach(var item in SelectedElements)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "        ");
            __builder.OpenElement(12, "li");
            __builder.AddAttribute(13, "draggable", "true");
            __builder.AddAttribute(14, "ondragstart", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\Shared\MultipleSelectorTypehead.razor"
                                             () => HandleDragStart(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "ondragend", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\Shared\MultipleSelectorTypehead.razor"
                          () => HandleDragOver(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "class", "list-group-item list-group-item-action");
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.AddContent(18, 
#nullable restore
#line 16 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\Shared\MultipleSelectorTypehead.razor"
             MyListTemplate(item)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "span");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\Shared\MultipleSelectorTypehead.razor"
                               () => SelectedElements.Remove(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(22, "X");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n");
#nullable restore
#line 19 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\Shared\MultipleSelectorTypehead.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\Shared\MultipleSelectorTypehead.razor"
       
    [Parameter]
    public List<T> SelectedElements { get; set; } = new List<T>();

    [Parameter]
    public Func<string, Task<IEnumerable<T>>> SearchMethod { get; set; }

    [Parameter]
    public RenderFragment<T> MyResultTemplate { get; set; }

    [Parameter]
    public RenderFragment<T> MyListTemplate { get; set; }

    T draggedItem;

    private void SelectedElement(T item)
    {
        if(!SelectedElements.Any(x => x.Equals(item)))
        {
            SelectedElements.Add(item);
        }
    }

    private void HandleDragStart(T item)
    {
        draggedItem = item;
    }

    private void HandleDragOver(T item)
    {
        if(!item.Equals(draggedItem))
        {
            var dragElementIndex = SelectedElements.IndexOf(draggedItem);
            var elementIndex = SelectedElements.IndexOf(item);
            SelectedElements[elementIndex] = draggedItem;
            SelectedElements[dragElementIndex] = item;
        }
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BlazorMovies.Client.Shared.MultipleSelectorTypehead
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCustomTypeahead_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Func<global::System.String, global::System.Threading.Tasks.Task<global::System.Collections.Generic.IEnumerable<TItem>>> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TItem> __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg2)
        {
        __builder.OpenComponent<global::BlazorMovies.Client.Shared.CustomTypeahead<TItem>>(seq);
        __builder.AddAttribute(__seq0, "SearchMethod", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ResultTemplate", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591