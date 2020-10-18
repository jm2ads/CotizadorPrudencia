#pragma checksum "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\SelectorMultiple.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb0ab9fc2c4c54cac5c7b3be11535e410a6e87d3"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class SelectorMultiple : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 20 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\SelectorMultiple.razor"
       
    private string removerTodoTexto = "<<";
    [Parameter] public List<SelectorMultipleModel> NoSeleccionados { get; set; }
        = new List<SelectorMultipleModel>();
    [Parameter] public List<SelectorMultipleModel> Seleccionados { get; set; }
        = new List<SelectorMultipleModel>();

    private void Seleccionar(SelectorMultipleModel item)
    {
        NoSeleccionados.Remove(item);
        Seleccionados.Add(item);
    }

    private void Deseleccionar(SelectorMultipleModel item)
    {
        Seleccionados.Remove(item);
        NoSeleccionados.Add(item);
    }

    private void SeleccionarTodo()
    {
        Seleccionados.AddRange(NoSeleccionados);
        NoSeleccionados.Clear();
    }

    private void DeseleccionarTodo()
    {
        NoSeleccionados.AddRange(Seleccionados);
        Seleccionados.Clear();
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
