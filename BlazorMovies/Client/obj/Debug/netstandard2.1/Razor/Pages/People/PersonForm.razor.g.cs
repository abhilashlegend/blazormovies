#pragma checksum "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\Pages\People\PersonForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6420813be682bce6681abc15d2f329b9acb2d56e"
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
    public partial class PersonForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 1 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\Pages\People\PersonForm.razor"
                 Person

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 1 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\Pages\People\PersonForm.razor"
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
                __builder2.AddMarkupContent(10, "<label for=\"name\">Name</label>\r\n        ");
                __builder2.OpenElement(11, "div");
                __builder2.AddMarkupContent(12, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(13);
                __builder2.AddAttribute(14, "class", "form-control");
                __builder2.AddAttribute(15, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 7 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\Pages\People\PersonForm.razor"
                                                         Person.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Person.Name = __value, Person.Name))));
                __builder2.AddAttribute(17, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Person.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n            ");
                __Blazor.BlazorMovies.Client.Pages.People.PersonForm.TypeInference.CreateValidationMessage_0(__builder2, 19, 20, 
#nullable restore
#line 8 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\Pages\People\PersonForm.razor"
                                      () => Person.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(21, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n\r\n    ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "form-group");
                __builder2.AddMarkupContent(26, "\r\n        ");
                __builder2.AddMarkupContent(27, "<label for=\"dateofbirth\">Date of Birth</label>\r\n        ");
                __builder2.OpenElement(28, "div");
                __builder2.AddMarkupContent(29, "\r\n            ");
                __Blazor.BlazorMovies.Client.Pages.People.PersonForm.TypeInference.CreateInputDate_1(__builder2, 30, 31, "form-control", 32, 
#nullable restore
#line 15 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\Pages\People\PersonForm.razor"
                                                          Person.DateOfBirth

#line default
#line hidden
#nullable disable
                , 33, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Person.DateOfBirth = __value, Person.DateOfBirth)), 34, () => Person.DateOfBirth);
                __builder2.AddMarkupContent(35, "\r\n            ");
                __Blazor.BlazorMovies.Client.Pages.People.PersonForm.TypeInference.CreateValidationMessage_2(__builder2, 36, 37, 
#nullable restore
#line 16 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\Pages\People\PersonForm.razor"
                                       () => Person.DateOfBirth

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(38, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n\r\n    ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "form-group");
                __builder2.AddMarkupContent(43, "\r\n        ");
                __builder2.OpenComponent<BlazorMovies.Client.Shared.InputImg>(44);
                __builder2.AddAttribute(45, "Label", "Picture");
                __builder2.AddAttribute(46, "OnSelectedImage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 21 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\Pages\People\PersonForm.razor"
                                                   pictureSelected

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(47, "ImageUrl", 
#nullable restore
#line 21 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\Pages\People\PersonForm.razor"
                                                                               imageUrl

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(48, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n\r\n    ");
                __builder2.OpenElement(50, "div");
                __builder2.AddAttribute(51, "class", "form-group form-markdown");
                __builder2.AddMarkupContent(52, "\r\n        ");
                __Blazor.BlazorMovies.Client.Pages.People.PersonForm.TypeInference.CreateInputMarkdown_3(__builder2, 53, 54, "Biography", 55, 
#nullable restore
#line 26 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\Pages\People\PersonForm.razor"
                                                 () => Person.Biography

#line default
#line hidden
#nullable disable
                , 56, 
#nullable restore
#line 25 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\Pages\People\PersonForm.razor"
                                    Person.Biography

#line default
#line hidden
#nullable disable
                , 57, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Person.Biography = __value, Person.Biography)), 58, () => Person.Biography);
                __builder2.AddMarkupContent(59, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n\r\n    ");
                __builder2.AddMarkupContent(61, "<button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\Acer\source\repos\BlazorMovies\BlazorMovies\Client\Pages\People\PersonForm.razor"
       
    [Parameter]
    public Person Person { get; set; }

    [Parameter]
    public EventCallback OnValidSubmit { get; set; }

    string imageUrl;

    protected override void OnInitialized()
    {
        if(!string.IsNullOrEmpty(Person.Picture))
        {
            imageUrl = Person.Picture;
            Person.Picture = null;
        }
    }

    private void pictureSelected(string imageBase64)
    {
        Person.Picture = imageBase64;
        imageUrl = null;
        Console.WriteLine(imageBase64);
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BlazorMovies.Client.Pages.People.PersonForm
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
        public static void CreateInputMarkdown_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg1, int __seq2, global::System.String __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<global::System.String> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<global::System.String>> __arg4)
        {
        __builder.OpenComponent<global::BlazorMovies.Client.Shared.InputMarkdown<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "For", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
