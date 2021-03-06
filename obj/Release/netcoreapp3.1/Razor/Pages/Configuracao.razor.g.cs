#pragma checksum "D:\Projects\CasamentoBlazorServer\Casamento\Pages\Configuracao.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a424806872f265e52a486092f0a9e6e8f026324"
// <auto-generated/>
#pragma warning disable 1591
namespace Casamento.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projects\CasamentoBlazorServer\Casamento\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\CasamentoBlazorServer\Casamento\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\CasamentoBlazorServer\Casamento\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\CasamentoBlazorServer\Casamento\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\CasamentoBlazorServer\Casamento\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\CasamentoBlazorServer\Casamento\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\CasamentoBlazorServer\Casamento\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\CasamentoBlazorServer\Casamento\_Imports.razor"
using Casamento;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\CasamentoBlazorServer\Casamento\_Imports.razor"
using Casamento.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projects\CasamentoBlazorServer\Casamento\_Imports.razor"
using Casamento.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Projects\CasamentoBlazorServer\Casamento\_Imports.razor"
using Casamento.Data.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\CasamentoBlazorServer\Casamento\Pages\Configuracao.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/configuracao")]
    public partial class Configuracao : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<thead>\r\n        <tr>\r\n            <th><b>NOME</b></th>\r\n            <th><b>SOBRENOME</b></th>\r\n        </tr>\r\n    </thead>\r\n    ");
            __builder.OpenElement(4, "tbody");
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 15 "D:\Projects\CasamentoBlazorServer\Casamento\Pages\Configuracao.razor"
         foreach (Pessoa pessoa in pessoas)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "            ");
            __builder.OpenElement(7, "tr");
            __builder.AddMarkupContent(8, "\r\n                ");
            __builder.OpenElement(9, "th");
            __builder.AddContent(10, 
#nullable restore
#line 18 "D:\Projects\CasamentoBlazorServer\Casamento\Pages\Configuracao.razor"
                     pessoa.Nome

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "th");
            __builder.AddContent(13, 
#nullable restore
#line 19 "D:\Projects\CasamentoBlazorServer\Casamento\Pages\Configuracao.razor"
                     pessoa.Sobrenome

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 21 "D:\Projects\CasamentoBlazorServer\Casamento\Pages\Configuracao.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "D:\Projects\CasamentoBlazorServer\Casamento\Pages\Configuracao.razor"
       
    List<Pessoa> pessoas = new List<Pessoa>();

    protected override async Task OnInitializedAsync()
    {
        await CarregaEstudantes();
    }

    async Task CarregaEstudantes()
    {
        await GetEstudantesAsync();
    }

    async Task GetEstudantesAsync()
    {
        pessoas = await pessoaService.GetPessoasAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PessoaService pessoaService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
    }
}
#pragma warning restore 1591
