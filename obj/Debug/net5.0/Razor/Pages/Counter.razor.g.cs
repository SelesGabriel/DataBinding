#pragma checksum "C:\Users\gadasilvas\Downloads\Projects\BlazorExamples\DataBinding\DataBinding\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3538e809e40a333ca7ab9296242544cf81501858"
// <auto-generated/>
#pragma warning disable 1591
namespace DataBinding.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\gadasilvas\Downloads\Projects\BlazorExamples\DataBinding\DataBinding\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gadasilvas\Downloads\Projects\BlazorExamples\DataBinding\DataBinding\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gadasilvas\Downloads\Projects\BlazorExamples\DataBinding\DataBinding\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gadasilvas\Downloads\Projects\BlazorExamples\DataBinding\DataBinding\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\gadasilvas\Downloads\Projects\BlazorExamples\DataBinding\DataBinding\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\gadasilvas\Downloads\Projects\BlazorExamples\DataBinding\DataBinding\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\gadasilvas\Downloads\Projects\BlazorExamples\DataBinding\DataBinding\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\gadasilvas\Downloads\Projects\BlazorExamples\DataBinding\DataBinding\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\gadasilvas\Downloads\Projects\BlazorExamples\DataBinding\DataBinding\_Imports.razor"
using DataBinding;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\gadasilvas\Downloads\Projects\BlazorExamples\DataBinding\DataBinding\_Imports.razor"
using DataBinding.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddContent(1, 
#nullable restore
#line 3 "C:\Users\gadasilvas\Downloads\Projects\BlazorExamples\DataBinding\DataBinding\Pages\Counter.razor"
     Mensagem

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(2, "\r\n\r\n");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "text");
            __builder.AddAttribute(5, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 5 "C:\Users\gadasilvas\Downloads\Projects\BlazorExamples\DataBinding\DataBinding\Pages\Counter.razor"
                           Mensagem

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Mensagem = __value, Mensagem));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.OpenElement(8, "p");
            __builder.AddContent(9, "Current count: ");
            __builder.AddContent(10, 
#nullable restore
#line 7 "C:\Users\gadasilvas\Downloads\Projects\BlazorExamples\DataBinding\DataBinding\Pages\Counter.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n\r\n");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "class", "btn btn-primary");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\gadasilvas\Downloads\Projects\BlazorExamples\DataBinding\DataBinding\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(15, "Click me");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\Users\gadasilvas\Downloads\Projects\BlazorExamples\DataBinding\DataBinding\Pages\Counter.razor"
       
    public string Mensagem { get; set; }
    private int currentCount = 0;


    private void IncrementCount()
    {
        currentCount++;
    }

    public void AtualizaMensagem()
    {
        Mensagem = "Olá";
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
