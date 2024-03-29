#pragma checksum "C:\Users\43442346851\Documents\Exercicio\MVC\McBonaldsMVC\Views\Administrador\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff4e9e9fe29a47eb599ddad35537ddf84b9edf98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrador_Dashboard), @"mvc.1.0.view", @"/Views/Administrador/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administrador/Dashboard.cshtml", typeof(AspNetCore.Views_Administrador_Dashboard))]
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
#line 1 "C:\Users\43442346851\Documents\Exercicio\MVC\McBonaldsMVC\Views\_ViewImports.cshtml"
using McBonaldsMVC;

#line default
#line hidden
#line 2 "C:\Users\43442346851\Documents\Exercicio\MVC\McBonaldsMVC\Views\_ViewImports.cshtml"
using McBonaldsMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff4e9e9fe29a47eb599ddad35537ddf84b9edf98", @"/Views/Administrador/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57177a2332d7bbd6b3532411ed5e910c130f158a", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrador_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<McBonaldsMVC.ViewModels.DashboardViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 267, true);
            WriteLiteral(@"    <main>
        <h2>Dashboard</h2>
        <section id=""status-pedidos"">
            <h3>Status dos pedidos</h3>
            <div id=""painel"">
                <div class=""box-status-pedidos aprovados"">
                    <h4>Aprovados</h4>
                    <p>");
            EndContext();
            BeginContext(318, 22, false);
#line 9 "C:\Users\43442346851\Documents\Exercicio\MVC\McBonaldsMVC\Views\Administrador\Dashboard.cshtml"
                  Write(Model.PedidosAprovados);

#line default
#line hidden
            EndContext();
            BeginContext(340, 149, true);
            WriteLiteral("</p>\n                </div>\n                <div class=\"box-status-pedidos pendentes\">\n                    <h4>Pendentes</h4>\n                    <p>");
            EndContext();
            BeginContext(490, 22, false);
#line 13 "C:\Users\43442346851\Documents\Exercicio\MVC\McBonaldsMVC\Views\Administrador\Dashboard.cshtml"
                  Write(Model.PedidosPendentes);

#line default
#line hidden
            EndContext();
            BeginContext(512, 151, true);
            WriteLiteral("</p>\n                </div>\n                <div class=\"box-status-pedidos reprovados\">\n                    <h4>Reprovados</h4>\n                    <p>");
            EndContext();
            BeginContext(664, 23, false);
#line 17 "C:\Users\43442346851\Documents\Exercicio\MVC\McBonaldsMVC\Views\Administrador\Dashboard.cshtml"
                  Write(Model.PedidosReprovados);

#line default
#line hidden
            EndContext();
            BeginContext(687, 876, true);
            WriteLiteral(@"</p>
                </div>
            </div>
        </section>

        <section id=""lista-pedidos"">
            <h3>Lista de pedidos</h3>
            <table>
                <thead>
                    <tr>
                        <th rowspan=""2"">Nome</th>
                        <th rowspan=""2"">Endereço</th>
                        <th colspan=""2"">Pedido</th>
                        <th colspan=""2"" rowspan=""2"">Aprovar</th>
                    </tr>
                    <tr>
                        <th><i class=""fas fa-hamburger""></i></th>
                        <th><i class=""fas fa-mug-hot""></i></th>
                        <th></th>
                        <th></th>
                    </tr>
                </thead>
                <tfoot>
                    <tr>
                        <td colspan=""6"">
                            <p>Pedidos atualizados em ");
            EndContext();
            BeginContext(1564, 12, false);
#line 42 "C:\Users\43442346851\Documents\Exercicio\MVC\McBonaldsMVC\Views\Administrador\Dashboard.cshtml"
                                                 Write(DateTime.Now);

#line default
#line hidden
            EndContext();
            BeginContext(1576, 110, true);
            WriteLiteral("</p>\n                        </td>\n                    </tr>\n                </tfoot>\n                <tbody>\n");
            EndContext();
#line 47 "C:\Users\43442346851\Documents\Exercicio\MVC\McBonaldsMVC\Views\Administrador\Dashboard.cshtml"
                     foreach(var pedido in Model.Pedidos )
                    {

#line default
#line hidden
            BeginContext(1767, 61, true);
            WriteLiteral("                        <tr>\n                            <td>");
            EndContext();
            BeginContext(1829, 19, false);
#line 50 "C:\Users\43442346851\Documents\Exercicio\MVC\McBonaldsMVC\Views\Administrador\Dashboard.cshtml"
                           Write(pedido.Cliente.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1848, 38, true);
            WriteLiteral("</td>\n                            <td>");
            EndContext();
            BeginContext(1887, 23, false);
#line 51 "C:\Users\43442346851\Documents\Exercicio\MVC\McBonaldsMVC\Views\Administrador\Dashboard.cshtml"
                           Write(pedido.Cliente.Endereco);

#line default
#line hidden
            EndContext();
            BeginContext(1910, 38, true);
            WriteLiteral("</td>\n                            <td>");
            EndContext();
            BeginContext(1949, 22, false);
#line 52 "C:\Users\43442346851\Documents\Exercicio\MVC\McBonaldsMVC\Views\Administrador\Dashboard.cshtml"
                           Write(pedido.Hamburguer.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1971, 38, true);
            WriteLiteral("</td>\n                            <td>");
            EndContext();
            BeginContext(2010, 17, false);
#line 53 "C:\Users\43442346851\Documents\Exercicio\MVC\McBonaldsMVC\Views\Administrador\Dashboard.cshtml"
                           Write(pedido.Shake.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(2027, 40, true);
            WriteLiteral("</td>\n                            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 2067, "\'", 2129, 1);
#line 54 "C:\Users\43442346851\Documents\Exercicio\MVC\McBonaldsMVC\Views\Administrador\Dashboard.cshtml"
WriteAttributeValue("", 2074, Url.Action("Aprovar", "Pedido", new {id = @pedido.Id}), 2074, 55, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2130, 73, true);
            WriteLiteral("><i class=\"fas fa-check\"></i></a></td>\n                            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 2203, "\'", 2266, 1);
#line 55 "C:\Users\43442346851\Documents\Exercicio\MVC\McBonaldsMVC\Views\Administrador\Dashboard.cshtml"
WriteAttributeValue("", 2210, Url.Action("Reprovar", "Pedido", new {id = @pedido.Id}), 2210, 56, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2267, 69, true);
            WriteLiteral("><i class=\"fas fa-times\"></i></a></td>\n                        </tr>\n");
            EndContext();
#line 57 "C:\Users\43442346851\Documents\Exercicio\MVC\McBonaldsMVC\Views\Administrador\Dashboard.cshtml"
                    }

#line default
#line hidden
            BeginContext(2358, 77, true);
            WriteLiteral("                </tbody>\n            </table>\n        </section>\n\n    </main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<McBonaldsMVC.ViewModels.DashboardViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
