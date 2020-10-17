#pragma checksum "C:\Users\danni\Desktop\Cursos\Curso ASP.NET CORE MVC\SistemaVendas\SistemaVendas\Views\Venda\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ec9aedc949f7a39beeaa201fc9766b319010b39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Venda_Index), @"mvc.1.0.view", @"/Views/Venda/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Venda/Index.cshtml", typeof(AspNetCore.Views_Venda_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ec9aedc949f7a39beeaa201fc9766b319010b39", @"/Views/Venda/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92b8143e28e2ecf99681febd0458bd3a62631f08", @"/Views/_ViewImports.cshtml")]
    public class Views_Venda_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VendaModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(19, 281, true);
            WriteLiteral(@"
<h2>Listagem de vendas</h2>

<table class=""table table-bordered"">
    <thead>
        <tr>
            <th>ID</th>
            <th>Data</th>
            <th>Total</th>
            <th>Vendedor</th>
            <th>Cliente</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 16 "C:\Users\danni\Desktop\Cursos\Curso ASP.NET CORE MVC\SistemaVendas\SistemaVendas\Views\Venda\Index.cshtml"
          
            foreach (var item in (List<VendaModel>)ViewBag.listaVendas)
            {

#line default
#line hidden
            BeginContext(400, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(447, 7, false);
#line 20 "C:\Users\danni\Desktop\Cursos\Curso ASP.NET CORE MVC\SistemaVendas\SistemaVendas\Views\Venda\Index.cshtml"
                   Write(item.ID);

#line default
#line hidden
            EndContext();
            BeginContext(454, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(486, 9, false);
#line 21 "C:\Users\danni\Desktop\Cursos\Curso ASP.NET CORE MVC\SistemaVendas\SistemaVendas\Views\Venda\Index.cshtml"
                   Write(item.data);

#line default
#line hidden
            EndContext();
            BeginContext(495, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(527, 10, false);
#line 22 "C:\Users\danni\Desktop\Cursos\Curso ASP.NET CORE MVC\SistemaVendas\SistemaVendas\Views\Venda\Index.cshtml"
                   Write(item.total);

#line default
#line hidden
            EndContext();
            BeginContext(537, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(569, 13, false);
#line 23 "C:\Users\danni\Desktop\Cursos\Curso ASP.NET CORE MVC\SistemaVendas\SistemaVendas\Views\Venda\Index.cshtml"
                   Write(item.vendedor);

#line default
#line hidden
            EndContext();
            BeginContext(582, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(614, 12, false);
#line 24 "C:\Users\danni\Desktop\Cursos\Curso ASP.NET CORE MVC\SistemaVendas\SistemaVendas\Views\Venda\Index.cshtml"
                   Write(item.cliente);

#line default
#line hidden
            EndContext();
            BeginContext(626, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 26 "C:\Users\danni\Desktop\Cursos\Curso ASP.NET CORE MVC\SistemaVendas\SistemaVendas\Views\Venda\Index.cshtml"
            }
        

#line default
#line hidden
            BeginContext(682, 244, true);
            WriteLiteral("    </tbody>\r\n\r\n</table>\r\n<br />\r\n\r\n<button class=\"btn btn-block btn-primary\" type=\"button\" onclick=\"Registrar()\">Registrar</button>\r\n\r\n<script>\r\n    function Registrar() {\r\n        window.location.href = \'../Venda/Registrar\';\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VendaModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
