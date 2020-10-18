#pragma checksum "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\CustomTypeahead.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ff3ac5a7de9fb7b4a72592d069566468a81e565"
// <auto-generated/>
#pragma warning disable 1591
namespace Project.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#line 3 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 4 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 6 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 7 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Project.Client;

#line default
#line hidden
#line 8 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Project.Client.Shared;

#line default
#line hidden
#line 9 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Project.Client.Helpers;

#line default
#line hidden
#line 10 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Project.Shared.Entidades;

#line default
#line hidden
#line 11 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Project.Client.Repositorios;

#line default
#line hidden
#line 12 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Project.Shared.DTOs;

#line default
#line hidden
#line 13 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Project.Shared.PrudenciaDTOs;

#line default
#line hidden
    public partial class CustomTypeahead<TItem> : CustomTypeaheadBase<TItem>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "blazored-typeahead");
            __builder.AddElementReferenceCapture(2, (__value) => {
#line 6 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\CustomTypeahead.razor"
                                      typeahead = __value;

#line default
#line hidden
            }
            );
            __builder.AddMarkupContent(3, "\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "blazored-typeahead__controls");
            __builder.AddMarkupContent(6, "\n        ");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "class", "blazored-typeahead__input");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 12 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\CustomTypeahead.razor"
                          ShowSuggestions

#line default
#line hidden
            ));
            __builder.AddAttribute(10, "type", "text");
            __builder.AddAttribute(11, "autocomplete", "off");
            __builder.AddAttribute(12, "placeholder", 
#line 15 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\CustomTypeahead.razor"
                             Placeholder

#line default
#line hidden
            );
            __builder.AddAttribute(13, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 10 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\CustomTypeahead.razor"
                             SearchText

#line default
#line hidden
            ));
            __builder.AddAttribute(14, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SearchText = __value, SearchText));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddElementReferenceCapture(15, (__value) => {
#line 8 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\CustomTypeahead.razor"
                     searchInput = __value;

#line default
#line hidden
            }
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n");
#line 17 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\CustomTypeahead.razor"
     if (ShouldShowSuggestions())
    {

#line default
#line hidden
            __builder.AddContent(18, "        ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "blazored-typeahead__results");
            __builder.AddMarkupContent(21, "\n");
#line 20 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\CustomTypeahead.razor"
             foreach (var item in Suggestions)
            {

#line default
#line hidden
            __builder.AddContent(22, "                ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "blazored-typeahead__result" + " " + (
#line 22 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\CustomTypeahead.razor"
                                                                    GetSelectedSuggestionClass(item)

#line default
#line hidden
            ));
            __builder.AddAttribute(25, "tabindex", "0");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 22 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\CustomTypeahead.razor"
                                                                                                                               () => SelectResult(item)

#line default
#line hidden
            ));
            __builder.AddAttribute(27, "onkeyup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#line 22 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\CustomTypeahead.razor"
                                                                                                                                                                    ((e) => HandleKeyUpOnSuggestion(e,item))

#line default
#line hidden
            ));
            __builder.SetKey(
#line 22 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\CustomTypeahead.razor"
                           item

#line default
#line hidden
            );
            __builder.AddMarkupContent(28, "\n");
#line 23 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\CustomTypeahead.razor"
                     if (ResultTemplate != null)
                    {
                        

#line default
#line hidden
            __builder.AddContent(29, 
#line 25 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\CustomTypeahead.razor"
                         ResultTemplate(item)

#line default
#line hidden
            );
#line 25 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\CustomTypeahead.razor"
                                             
                    }

#line default
#line hidden
            __builder.AddContent(30, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n");
#line 28 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\CustomTypeahead.razor"
            }

#line default
#line hidden
            __builder.AddContent(32, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n");
#line 30 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\CustomTypeahead.razor"
    }
    else if (ShowNotFound())
    {

#line default
#line hidden
            __builder.AddContent(34, "        ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "blazored-typeahead__results");
            __builder.AddMarkupContent(37, "\n");
#line 34 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\CustomTypeahead.razor"
             if (NotFoundTemplate != null)
            {

#line default
#line hidden
            __builder.AddContent(38, "                ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "blazored-typeahead__notfound");
            __builder.AddMarkupContent(41, "\n                    ");
            __builder.AddContent(42, 
#line 37 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\CustomTypeahead.razor"
                     NotFoundTemplate

#line default
#line hidden
            );
            __builder.AddMarkupContent(43, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\n");
#line 39 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\CustomTypeahead.razor"
            }
            else
            {

#line default
#line hidden
            __builder.AddContent(45, "                ");
            __builder.AddMarkupContent(46, "<div class=\"blazored-typeahead__notfound\">\n                    No Results Found\n                </div>\n");
#line 45 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\CustomTypeahead.razor"
            }

#line default
#line hidden
            __builder.AddContent(47, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\n");
#line 47 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\CustomTypeahead.razor"
    }

#line default
#line hidden
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
