#pragma checksum "C:\Users\rafael.gomes\Desktop\rafa\Faculdade\Pim\LRSV\WebTest\Pages\Pagamento.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a9b3c7fa05fba822e25ea4d574596d5ca9c587f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebTest.Pages.Pages_Pagamento), @"mvc.1.0.razor-page", @"/Pages/Pagamento.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a9b3c7fa05fba822e25ea4d574596d5ca9c587f", @"/Pages/Pagamento.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c88b295d316cec874966132c0b8ea65b9f96da12", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Pagamento : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h1>Pagamentos</h1>

<table class=""table"">
    <thead>
        <tr>
            <th>Nome</th>
            <th>Salário Bruto</th>
            <th>Salário Líquido</th>
            <th>INSS</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>");
#nullable restore
#line 17 "C:\Users\rafael.gomes\Desktop\rafa\Faculdade\Pim\LRSV\WebTest\Pages\Pagamento.cshtml"
           Write(Model.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 18 "C:\Users\rafael.gomes\Desktop\rafa\Faculdade\Pim\LRSV\WebTest\Pages\Pagamento.cshtml"
           Write(Model.SalarioBruto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 19 "C:\Users\rafael.gomes\Desktop\rafa\Faculdade\Pim\LRSV\WebTest\Pages\Pagamento.cshtml"
           Write(Model.SalarioLiquido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\rafael.gomes\Desktop\rafa\Faculdade\Pim\LRSV\WebTest\Pages\Pagamento.cshtml"
           Write(Model.inss);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebTest.Pages.PagamentoModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebTest.Pages.PagamentoModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebTest.Pages.PagamentoModel>)PageContext?.ViewData;
        public WebTest.Pages.PagamentoModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
