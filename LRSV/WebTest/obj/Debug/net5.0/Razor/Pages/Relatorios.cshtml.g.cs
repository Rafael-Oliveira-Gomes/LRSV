#pragma checksum "C:\Projetos\LRSV\LRSV\WebTest\Pages\Relatorios.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "08b4e0e21a24da67794a5afdd6839a4f5855eedc9c8b1685994338d5a1589bc9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebTest.Pages.Pages_Relatorios), @"mvc.1.0.razor-page", @"/Pages/Relatorios.cshtml")]
namespace WebTest.Pages
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Projetos\LRSV\LRSV\WebTest\Pages\_ViewImports.cshtml"
using WebTest

#nullable disable
    ;
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"08b4e0e21a24da67794a5afdd6839a4f5855eedc9c8b1685994338d5a1589bc9", @"/Pages/Relatorios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"d7f9e3ccf90dafbe6795b6daea8b928aed2f45347da169f0b9d73b113e7b19f6", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Pages_Relatorios : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Relatório de Funcionários</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>Nome</th>\r\n            <th>Cargo</th>\r\n            <th>Salário</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 16 "C:\Projetos\LRSV\LRSV\WebTest\Pages\Relatorios.cshtml"
         foreach (var funcionario in Model.Funcionarios)
        {

#line default
#line hidden
#nullable disable

            WriteLiteral("            <tr>\r\n                <td>");
            Write(
#nullable restore
#line 19 "C:\Projetos\LRSV\LRSV\WebTest\Pages\Relatorios.cshtml"
                     funcionario.Nome

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                <td>");
            Write(
#nullable restore
#line 20 "C:\Projetos\LRSV\LRSV\WebTest\Pages\Relatorios.cshtml"
                     funcionario.Cargo

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                <td>");
            Write(
#nullable restore
#line 21 "C:\Projetos\LRSV\LRSV\WebTest\Pages\Relatorios.cshtml"
                     funcionario.Salario

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 23 "C:\Projetos\LRSV\LRSV\WebTest\Pages\Relatorios.cshtml"
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
