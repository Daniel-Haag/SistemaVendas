#pragma checksum "C:\Users\danni\Desktop\Cursos\Curso ASP.NET CORE MVC\SistemaVendas\SistemaVendas\Views\Produto\ExcluirProduto.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2ac558971fdcc7eb3853b4abc2e0686a2cab5a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_ExcluirProduto), @"mvc.1.0.view", @"/Views/Produto/ExcluirProduto.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produto/ExcluirProduto.cshtml", typeof(AspNetCore.Views_Produto_ExcluirProduto))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\danni\Desktop\Cursos\Curso ASP.NET CORE MVC\SistemaVendas\SistemaVendas\Views\_ViewImports.cshtml"
using SistemaVendas;

#line default
#line hidden
#line 2 "C:\Users\danni\Desktop\Cursos\Curso ASP.NET CORE MVC\SistemaVendas\SistemaVendas\Views\_ViewImports.cshtml"
using SistemaVendas.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2ac558971fdcc7eb3853b4abc2e0686a2cab5a6", @"/Views/Produto/ExcluirProduto.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92b8143e28e2ecf99681febd0458bd3a62631f08", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_ExcluirProduto : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProdutoModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(21, 229, true);
            WriteLiteral("\r\n<h3>Produto excluído com sucesso!</h3>\r\n\r\n<button type=\"button\" class=\"btn btn-success\" onclick=\"OK()\">OK</button>\r\n\r\n<script>\r\n\r\n    function OK() {\r\n        window.location.href = \'../../Produto/Index\'\r\n    }\r\n\r\n</script>\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProdutoModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
