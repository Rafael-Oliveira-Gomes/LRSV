#pragma checksum "C:\Users\rafael.gomes\Desktop\rafa\Faculdade\Pim\LRSV\WebTest\Pages\ChamadoAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05a35e2f6407dc659007855ddc9ac8b3b496a032"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebTest.Pages.Pages_ChamadoAdmin), @"mvc.1.0.razor-page", @"/Pages/ChamadoAdmin.cshtml")]
namespace WebTest.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\rafael.gomes\Desktop\rafa\Faculdade\Pim\LRSV\WebTest\Pages\_ViewImports.cshtml"
using WebTest;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05a35e2f6407dc659007855ddc9ac8b3b496a032", @"/Pages/ChamadoAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c88b295d316cec874966132c0b8ea65b9f96da12", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_ChamadoAdmin : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\rafael.gomes\Desktop\rafa\Faculdade\Pim\LRSV\WebTest\Pages\ChamadoAdmin.cshtml"
  
    var chamados = Model.GetChamados();

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Chamados</h1>

<table class=""table"">
    <thead>
        <tr>
            <th>Código</th>
            <th>Resumo</th>
            <th>Categoria</th>
            <th>Prioridade</th>
            <th>Status</th>
            <th>Data de Abertura</th>
            <th>Nome do Usuário</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 22 "C:\Users\rafael.gomes\Desktop\rafa\Faculdade\Pim\LRSV\WebTest\Pages\ChamadoAdmin.cshtml"
         foreach (var chamado in chamados)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\rafael.gomes\Desktop\rafa\Faculdade\Pim\LRSV\WebTest\Pages\ChamadoAdmin.cshtml"
               Write(chamado.Codigo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\rafael.gomes\Desktop\rafa\Faculdade\Pim\LRSV\WebTest\Pages\ChamadoAdmin.cshtml"
               Write(chamado.Resumo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\rafael.gomes\Desktop\rafa\Faculdade\Pim\LRSV\WebTest\Pages\ChamadoAdmin.cshtml"
               Write(chamado.Categoria);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\rafael.gomes\Desktop\rafa\Faculdade\Pim\LRSV\WebTest\Pages\ChamadoAdmin.cshtml"
               Write(chamado.Prioridade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\rafael.gomes\Desktop\rafa\Faculdade\Pim\LRSV\WebTest\Pages\ChamadoAdmin.cshtml"
               Write(chamado.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\rafael.gomes\Desktop\rafa\Faculdade\Pim\LRSV\WebTest\Pages\ChamadoAdmin.cshtml"
               Write(chamado.DataAbertura.ToString("dd/MM/yyyy HH:mm:ss"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\rafael.gomes\Desktop\rafa\Faculdade\Pim\LRSV\WebTest\Pages\ChamadoAdmin.cshtml"
               Write(chamado.NomeUsuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 33 "C:\Users\rafael.gomes\Desktop\rafa\Faculdade\Pim\LRSV\WebTest\Pages\ChamadoAdmin.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebTest.Pages.ChamadoAdminModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebTest.Pages.ChamadoAdminModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebTest.Pages.ChamadoAdminModel>)PageContext?.ViewData;
        public WebTest.Pages.ChamadoAdminModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
