#pragma checksum "E:\JavierSanchezProyectoCore\JavierSanchezProyectoCore\Views\Venta\Carrito.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5cd1c827b8ec7f374664579b29da6f76e2f95ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Venta_Carrito), @"mvc.1.0.view", @"/Views/Venta/Carrito.cshtml")]
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
#nullable restore
#line 1 "E:\JavierSanchezProyectoCore\JavierSanchezProyectoCore\Views\_ViewImports.cshtml"
using JavierSanchezProyectoCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\JavierSanchezProyectoCore\JavierSanchezProyectoCore\Views\_ViewImports.cshtml"
using JavierSanchezProyectoCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5cd1c827b8ec7f374664579b29da6f76e2f95ee", @"/Views/Venta/Carrito.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca811abdbc4f5fd71c955f1d6df1554cfd914535", @"/Views/_ViewImports.cshtml")]
    public class Views_Venta_Carrito : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Juego>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Carrito", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\JavierSanchezProyectoCore\JavierSanchezProyectoCore\Views\Venta\Carrito.cshtml"
  
    if (Model==null)
    {

    }else
    if (Model.Count() < 1)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>No hay Juegos </p>\r\n");
#nullable restore
#line 11 "E:\JavierSanchezProyectoCore\JavierSanchezProyectoCore\Views\Venta\Carrito.cshtml"
    }
    else
    {
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table table-striped table-dark"">
            <thead>
                <tr>
                    <th>Caratula</th>
                    <th>Titulo</th>
                    <th>Precio</th>
                    <th></th>

                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 26 "E:\JavierSanchezProyectoCore\JavierSanchezProyectoCore\Views\Venta\Carrito.cshtml"
                 foreach (Juego juego in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f5cd1c827b8ec7f374664579b29da6f76e2f95ee5739", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 629, "~/images/", 629, 9, true);
#nullable restore
#line 30 "E:\JavierSanchezProyectoCore\JavierSanchezProyectoCore\Views\Venta\Carrito.cshtml"
AddHtmlAttributeValue("", 638, juego.Caratula, 638, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                    <td>");
#nullable restore
#line 32 "E:\JavierSanchezProyectoCore\JavierSanchezProyectoCore\Views\Venta\Carrito.cshtml"
                   Write(juego.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    \r\n\r\n");
#nullable restore
#line 36 "E:\JavierSanchezProyectoCore\JavierSanchezProyectoCore\Views\Venta\Carrito.cshtml"
                     if (juego.Descuento != 0)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td >\r\n                            \r\n");
#nullable restore
#line 41 "E:\JavierSanchezProyectoCore\JavierSanchezProyectoCore\Views\Venta\Carrito.cshtml"
                              
                                decimal? preciofinal = juego.Precio - (juego.Precio * juego.Descuento / 100);

                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
#nullable restore
#line 45 "E:\JavierSanchezProyectoCore\JavierSanchezProyectoCore\Views\Venta\Carrito.cshtml"
                       Write(preciofinal.Value.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ???\r\n                        </td>\r\n");
#nullable restore
#line 47 "E:\JavierSanchezProyectoCore\JavierSanchezProyectoCore\Views\Venta\Carrito.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>  ");
#nullable restore
#line 50 "E:\JavierSanchezProyectoCore\JavierSanchezProyectoCore\Views\Venta\Carrito.cshtml"
                         Write(juego.Precio);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ???</td>\r\n");
#nullable restore
#line 51 "E:\JavierSanchezProyectoCore\JavierSanchezProyectoCore\Views\Venta\Carrito.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5cd1c827b8ec7f374664579b29da6f76e2f95ee9482", async() => {
                WriteLiteral("Quitar del Carrito");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "E:\JavierSanchezProyectoCore\JavierSanchezProyectoCore\Views\Venta\Carrito.cshtml"
                                                                         WriteLiteral(juego.JuegoId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n\r\n\r\n                </tr>\r\n");
#nullable restore
#line 59 "E:\JavierSanchezProyectoCore\JavierSanchezProyectoCore\Views\Venta\Carrito.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5cd1c827b8ec7f374664579b29da6f76e2f95ee12099", async() => {
                WriteLiteral("\r\n            <button type=\"submit\" class=\" btn btn-success btn-block\">Realizar Compra</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 66 "E:\JavierSanchezProyectoCore\JavierSanchezProyectoCore\Views\Venta\Carrito.cshtml"
       
    }


#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Juego>> Html { get; private set; }
    }
}
#pragma warning restore 1591
