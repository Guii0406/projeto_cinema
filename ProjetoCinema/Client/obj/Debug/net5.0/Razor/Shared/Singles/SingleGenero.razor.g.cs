#pragma checksum "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\Shared\Singles\SingleGenero.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0358fb6ffd5d558f807ca4a1b15098013dbf5a1"
// <auto-generated/>
#pragma warning disable 1591
namespace ProjetoCinema.Client.Shared.Singles
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\_Imports.razor"
using ProjetoCinema;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\_Imports.razor"
using ProjetoCinema.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\_Imports.razor"
using Shared.Lists;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\_Imports.razor"
using Shared.Dialog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\_Imports.razor"
using Shared.Singles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\_Imports.razor"
using ProjetoCinema.Client.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\_Imports.razor"
using ProjetoCinema.Server.Models;

#line default
#line hidden
#nullable disable
    public partial class SingleGenero : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "tr");
            __builder.OpenElement(1, "th");
            __builder.AddAttribute(2, "scope", "row");
            __builder.AddContent(3, 
#nullable restore
#line 3 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\Shared\Singles\SingleGenero.razor"
                     genero.CodGenero

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "td");
            __builder.AddContent(6, 
#nullable restore
#line 4 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\Shared\Singles\SingleGenero.razor"
         genero.DescricaoGenero

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(7, " ");
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "style", "margin-left: 10px");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\Shared\Singles\SingleGenero.razor"
                                                                              () => Excluir.InvokeAsync(genero)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(11, "X");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\Shared\Singles\SingleGenero.razor"
       
    [Parameter] public ProjetoCinema.Server.Models.Genero genero { get; set; }
    [Parameter] public EventCallback<ProjetoCinema.Server.Models.Genero> Excluir { get; set; }

    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
