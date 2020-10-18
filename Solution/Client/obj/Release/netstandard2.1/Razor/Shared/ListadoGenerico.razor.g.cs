#pragma checksum "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\ListadoGenerico.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f8f28aaa3941889a78d6a5ec1837c002796cb04"
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
    public partial class ListadoGenerico<Titem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 3 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\ListadoGenerico.razor"
 if (Listado == null)
{
    

#line default
#line hidden
#line 5 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\ListadoGenerico.razor"
     if (Cargando == null)
    {
        

#line default
#line hidden
            __builder.AddContent(0, "Cargando...");
#line 7 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\ListadoGenerico.razor"
                                
    }
    else
    {
        

#line default
#line hidden
            __builder.AddContent(1, 
#line 11 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\ListadoGenerico.razor"
         Cargando

#line default
#line hidden
            );
#line 11 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\ListadoGenerico.razor"
                 
    }

#line default
#line hidden
#line 12 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\ListadoGenerico.razor"
     
}
else if (Listado.Count == 0)
{
    

#line default
#line hidden
#line 16 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\ListadoGenerico.razor"
     if (NoHayRegistros == null)
    {
        

#line default
#line hidden
            __builder.AddContent(2, "No hay registros para mostrar");
#line 18 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\ListadoGenerico.razor"
                                                  
    }
    else
    {
        

#line default
#line hidden
            __builder.AddContent(3, 
#line 22 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\ListadoGenerico.razor"
         NoHayRegistros

#line default
#line hidden
            );
#line 22 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\ListadoGenerico.razor"
                       
    }

#line default
#line hidden
#line 23 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\ListadoGenerico.razor"
     
}
else
{
    if (HayRegistros != null)
    {
        foreach (var elemento in Listado)
        {
            

#line default
#line hidden
            __builder.AddContent(4, 
#line 31 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\ListadoGenerico.razor"
             HayRegistros(elemento)

#line default
#line hidden
            );
#line 31 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\ListadoGenerico.razor"
                                   
        }
    }
    else
    {
        

#line default
#line hidden
            __builder.AddContent(5, 
#line 36 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\ListadoGenerico.razor"
         HayRegistrosCompleto

#line default
#line hidden
            );
#line 36 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\ListadoGenerico.razor"
                             
    }
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 40 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\ListadoGenerico.razor"
       
    [Parameter] public RenderFragment Cargando { get; set; }
    [Parameter] public RenderFragment NoHayRegistros { get; set; }
    [Parameter] public RenderFragment<Titem> HayRegistros { get; set; }
    [Parameter] public RenderFragment HayRegistrosCompleto { get; set; }
    [Parameter] public List<Titem> Listado { get; set; }

#line default
#line hidden
    }
}
#pragma warning restore 1591
