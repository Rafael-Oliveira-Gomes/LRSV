#pragma checksum "C:\Users\rafael.gomes\Desktop\rafa\Faculdade\Pim\LRSV\WebTest\Pages\Relatorios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bc8055cd8d60ee053c0ab72dd12daac4020e0c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebTest.Pages.Pages_Relatorios), @"mvc.1.0.razor-page", @"/Pages/Relatorios.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bc8055cd8d60ee053c0ab72dd12daac4020e0c8", @"/Pages/Relatorios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c88b295d316cec874966132c0b8ea65b9f96da12", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Relatorios : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Relatório de Funcionários</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>Nome</th>\r\n            <th>Cargo</th>\r\n            <th>Salário</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 16 "C:\Users\rafael.gomes\Desktop\rafa\Faculdade\Pim\LRSV\WebTest\Pages\Relatorios.cshtml"
         foreach (var funcionario in Model.Funcionarios)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 19 "C:\Users\rafael.gomes\Desktop\rafa\Faculdade\Pim\LRSV\WebTest\Pages\Relatorios.cshtml"
               Write(funcionario.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\rafael.gomes\Desktop\rafa\Faculdade\Pim\LRSV\WebTest\Pages\Relatorios.cshtml"
               Write(funcionario.Cargo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\rafael.gomes\Desktop\rafa\Faculdade\Pim\LRSV\WebTest\Pages\Relatorios.cshtml"
               Write(funcionario.Salario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 23 "C:\Users\rafael.gomes\Desktop\rafa\Faculdade\Pim\LRSV\WebTest\Pages\Relatorios.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebTest.Pages.RelatoriosModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebTest.Pages.RelatoriosModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebTest.Pages.RelatoriosModel>)PageContext?.ViewData;
        public WebTest.Pages.RelatoriosModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
