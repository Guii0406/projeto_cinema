#pragma checksum "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\Shared\Lists\ListDiretor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fd2357e6f97c98da0ff0634ef67774e1637433b"
// <auto-generated/>
#pragma warning disable 1591
namespace ProjetoCinema.Client.Shared.Lists
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
    public partial class ListDiretor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.ProjetoCinema.Client.Shared.Lists.ListDiretor.TypeInference.CreateGenericList_0(__builder, 0, 1, 
#nullable restore
#line 2 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\Shared\Lists\ListDiretor.razor"
                    listaDiretores

#line default
#line hidden
#nullable disable
            , 2, (__builder2) => {
                __builder2.AddMarkupContent(3, "<p>Loading...</p>");
            }
            , 4, (__builder2) => {
                __builder2.AddMarkupContent(5, "<p>Nada encontrado...</p>");
            }
            , 6, (ctxDiretor) => (__builder2) => {
                __builder2.OpenComponent<ProjetoCinema.Client.Shared.Singles.SingleDiretor>(7);
                __builder2.AddAttribute(8, "diretor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ProjetoCinema.Server.Models.Diretor>(
#nullable restore
#line 9 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\Shared\Lists\ListDiretor.razor"
                                                                    ctxDiretor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "Excluir", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<ProjetoCinema.Server.Models.Diretor>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<ProjetoCinema.Server.Models.Diretor>(this, 
#nullable restore
#line 9 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\Shared\Lists\ListDiretor.razor"
                                                                                         Excluir

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
            }
            );
            __builder.AddMarkupContent(10, "\r\n\r\n");
            __builder.OpenComponent<ProjetoCinema.Client.Shared.Dialog.ConfirmationDialog>(11);
            __builder.AddAttribute(12, "Titulo", "Atenção!");
            __builder.AddAttribute(13, "onCancel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 15 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\Shared\Lists\ListDiretor.razor"
                                                                                                       onCancel

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(14, "onConfirm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 15 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\Shared\Lists\ListDiretor.razor"
                                                                                                                            onConfirm

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(16, "<div>Deseja apagar este item?</div>");
            }
            ));
            __builder.AddComponentReferenceCapture(17, (__value) => {
#nullable restore
#line 15 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\Shared\Lists\ListDiretor.razor"
                                                                               confirmation = (ProjetoCinema.Client.Shared.Dialog.ConfirmationDialog)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\Shared\Lists\ListDiretor.razor"
       
    ConfirmationDialog confirmation;
    [Parameter] public List<ProjetoCinema.Server.Models.Diretor> listaDiretores { get; set; }
    ProjetoCinema.Server.Models.Diretor diretorToDelete;

    private async Task onConfirm()
    {
        await diretorRepository.DeleteDiretor(diretorToDelete.CodDiretor);
        listaDiretores = await diretorRepository.GetDiretores();
        confirmation.Hide();
        diretorToDelete = null;
    }

    void onCancel()
    {
        confirmation.Hide();
        diretorToDelete = null;
    }

    public void Excluir(ProjetoCinema.Server.Models.Diretor diretor)
    {
        diretorToDelete = diretor;
        confirmation.Show();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDiretorRepository diretorRepository { get; set; }
    }
}
namespace __Blazor.ProjetoCinema.Client.Shared.Lists.ListDiretor
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateGenericList_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg3)
        {
        __builder.OpenComponent<global::ProjetoCinema.Client.Shared.Lists.GenericList<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Lista", __arg0);
        __builder.AddAttribute(__seq1, "NullTemplate", __arg1);
        __builder.AddAttribute(__seq2, "EmptyTemplate", __arg2);
        __builder.AddAttribute(__seq3, "ElementTemplate", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591