#pragma checksum "C:\Users\danni\Desktop\Cursos\Curso ASP.NET CORE MVC\SistemaVendas\SistemaVendas\Views\Produto\Excluir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5eb779a62f86e272fcdaae5a23a329ca9bb164c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Excluir), @"mvc.1.0.view", @"/Views/Produto/Excluir.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produto/Excluir.cshtml", typeof(AspNetCore.Views_Produto_Excluir))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5eb779a62f86e272fcdaae5a23a329ca9bb164c", @"/Views/Produto/Excluir.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92b8143e28e2ecf99681febd0458bd3a62631f08", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Excluir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProdutoModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(21, 343, true);
            WriteLiteral(@"
<h2>Excluir Produto</h2>

<h3>Deseja realmente excluir o produto selecionado?</h3>

<button type=""button"" class=""btn btn-success"" onclick=""Sim()"">Sim</button>
<button type=""button"" class=""btn btn-danger"" onclick=""Não()"">Não</button>

<script>

    function Sim() {
        window.location.href = '../../Produto/ExcluirProduto/' + '");
            EndContext();
            BeginContext(365, 17, false);
#line 13 "C:\Users\danni\Desktop\Cursos\Curso ASP.NET CORE MVC\SistemaVendas\SistemaVendas\Views\Produto\Excluir.cshtml"
                                                             Write(ViewBag.ProdutoID);

#line default
#line hidden
            EndContext();
            BeginContext(382, 107, true);
            WriteLiteral("\';\r\n    }\r\n\r\n    function Não() {\r\n        window.location.href = \'../../Produto/Index\'\r\n    }\r\n\r\n</script>");
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
