#pragma checksum "D:\Projects\CasamentoBlazorServer\Casamento\Pages\ConfirmaPresenca.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ddba26b3114e5b9338c91454c9144c6bcca3439"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/confirmapresenca")]
    public partial class ConfirmaPresenca : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "D:\Projects\CasamentoBlazorServer\Casamento\Pages\ConfirmaPresenca.razor"
      
    Pessoa pessoa = new Pessoa();
    bool ShowPopUp = false;



    protected override void OnInitialized()
    {
        ShowPopUp = false;
    }

    async Task AdicionaConvidado()
    {
        await pessoaService.PostPessoaAsync(pessoa);
        ShowPopUp = true;
    }

    void ClosePopup()
    {
        ShowPopUp = false;
        navigation.NavigateTo("");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PessoaService pessoaService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
    }
}
#pragma warning restore 1591
