#pragma checksum "C:\Users\rafael.gomes\Desktop\rafa\Faculdade\Pim\LRSV\WebTest\Pages\PontoList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "861bd34f7d181aca2dcd0328edc8f193c7f984bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebTest.Pages.Pages_PontoList), @"mvc.1.0.razor-page", @"/Pages/PontoList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"861bd34f7d181aca2dcd0328edc8f193c7f984bb", @"/Pages/PontoList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c88b295d316cec874966132c0b8ea65b9f96da12", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_PontoList : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h1>Pontos</h1>

<table class=""table"">
    <thead>
        <tr>
            <th>Id</th>
            <th>Nome</th>
            <th>Dia</th>
            <th>Horário de entrada</th>
            <th>Horário de saída</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 19 "C:\Users\rafael.gomes\Desktop\rafa\Faculdade\Pim\LRSV\WebTest\Pages\PontoList.cshtml"
         foreach (var ponto in Model.Pontos)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\rafael.gomes\Desktop\rafa\Faculdade\Pim\LRSV\WebTest\Pages\PontoList.cshtml"
               Write(ponto.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\rafael.gomes\Desktop\rafa\Faculdade\Pim\LRSV\WebTest\Pages\PontoList.cshtml"
               Write(ponto.NomeUsuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\rafael.gomes\Desktop\rafa\Faculdade\Pim\LRSV\WebTest\Pages\PontoList.cshtml"
               Write(ponto.Dia.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\rafael.gomes\Desktop\rafa\Faculdade\Pim\LRSV\WebTest\Pages\PontoList.cshtml"
               Write(DateTime.Today.Add(ponto.HorarioEntrada).ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\rafael.gomes\Desktop\rafa\Faculdade\Pim\LRSV\WebTest\Pages\PontoList.cshtml"
                Write(ponto.HorarioSaida != null ? DateTime.Today.Add(ponto.HorarioSaida.Value).ToString("HH:mm") : "");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 28 "C:\Users\rafael.gomes\Desktop\rafa\Faculdade\Pim\LRSV\WebTest\Pages\PontoList.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebTest.Pages.PontoListModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebTest.Pages.PontoListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebTest.Pages.PontoListModel>)PageContext?.ViewData;
        public WebTest.Pages.PontoListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
