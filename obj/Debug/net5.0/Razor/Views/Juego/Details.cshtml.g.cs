#pragma checksum "E:\JavierSanchezProyectoCore\JavierSanchezProyectoCore\Views\Juego\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a430b3ea7e476c30839d7d9101d286b425789558"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Juego_Details), @"mvc.1.0.view", @"/Views/Juego/Details.cshtml")]
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
#line 1 "E:\JavierSanchezProyectoCore\JavierSanchezProyectoCore\Views\Juego\Details.cshtml"
using JavierSanchezProyectoCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a430b3ea7e476c30839d7d9101d286b425789558", @"/Views/Juego/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca811abdbc4f5fd71c955f1d6df1554cfd914535", @"/Views/_ViewImports.cshtml")]
    public class Views_Juego_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Juego>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Venta", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddCarrito", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-block btn-light text-dark  disabled"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-block btn-light text-dark "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container w-100 row\">\r\n    <div class=\"col-md-8\">\r\n\r\n\r\n        <div class=\"embed-responsive embed-responsive-16by9\">\r\n            <iframe class=\"embed-responsive-item\"");
            BeginWriteAttribute("src", " src=\"", 236, "\"", 289, 2);
            WriteAttributeValue("", 242, "https://www.youtube.com/embed/", 242, 30, true);
#nullable restore
#line 9 "E:\JavierSanchezProyectoCore\JavierSanchezProyectoCore\Views\Juego\Details.cshtml"
WriteAttributeValue("", 272, Model.TrailerURL, 272, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"YouTube video player\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n        </div>\r\n        <h2>");
#nullable restore
#line 11 "E:\JavierSanchezProyectoCore\JavierSanchezProyectoCore\Views\Juego\Details.cshtml"
       Write(Model.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <p class=\"text-left\">");
#nullable restore
#line 12 "E:\JavierSanchezProyectoCore\JavierSanchezProyectoCore\Views\Juego\Details.cshtml"
                        Write(Model.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <div class=\"col-md-4\">\r\n");
#nullable restore
#line 15 "E:\JavierSanchezProyectoCore\JavierSanchezProyectoCore\Views\Juego\Details.cshtml"
         if (Model.Descuento != 0)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <span class=\"bg-danger  w-25 position-absolute\">- ");
#nullable restore
#line 18 "E:\JavierSanchezProyectoCore\JavierSanchezProyectoCore\Views\Juego\Details.cshtml"
                                                         Write(Model.Descuento);

#line default
#line hidden
#nullable disable
            WriteLiteral(" %</span>\r\n");
#nullable restore
#line 19 "E:\JavierSanchezProyectoCore\JavierSanchezProyectoCore\Views\Juego\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a430b3ea7e476c30839d7d9101d286b4257895588149", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 768, "~/images/", 768, 9, true);
#nullable restore
#line 20 "E:\JavierSanchezProyectoCore\JavierSanchezProyectoCore\Views\Juego\Details.cshtml"
AddHtmlAttributeValue("", 777, Model.Caratula, 777, 15, false);

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
            WriteLiteral("\r\n        \r\n            <div class=\"col-md-6\">\r\n                <h4>");
#nullable restore
#line 23 "E:\JavierSanchezProyectoCore\JavierSanchezProyectoCore\Views\Juego\Details.cshtml"
               Write(Model.Desarrolladora.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            </div>\r\n            <div class=\"col-md-6  text-center\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a430b3ea7e476c30839d7d9101d286b42578955810131", async() => {
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a430b3ea7e476c30839d7d9101d286b42578955810348", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1088, "~/images/", 1088, 9, true);
#nullable restore
#line 26 "E:\JavierSanchezProyectoCore\JavierSanchezProyectoCore\Views\Juego\Details.cshtml"
AddHtmlAttributeValue("", 1097, Model.Desarrolladora.Logo, 1097, 26, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 26 "E:\JavierSanchezProyectoCore\JavierSanchezProyectoCore\Views\Juego\Details.cshtml"
                  WriteLiteral(Model.Desarrolladora.Pagina);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Host = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-host", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Host, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        \r\n\r\n\r\n        <p>\r\n            Generos:\r\n");
#nullable restore
#line 33 "E:\JavierSanchezProyectoCore\JavierSanchezProyectoCore\Views\Juego\Details.cshtml"
             foreach (GeneroJuego item in Model.GenerosJuego)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "E:\JavierSanchezProyectoCore\JavierSanchezProyectoCore\Views\Juego\Details.cshtml"
                 if (item != Model.GenerosJuego.Last())
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "E:\JavierSanchezProyectoCore\JavierSanchezProyectoCore\Views\Juego\Details.cshtml"
               Write(item.Genero.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            WriteLiteral(",\r\n");
#nullable restore
#line 38 "E:\JavierSanchezProyectoCore\JavierSanchezProyectoCore\Views\Juego\Details.cshtml"
                }
                else
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "E:\JavierSanchezProyectoCore\JavierSanchezProyectoCore\Views\Juego\Details.cshtml"
               Write(item.Genero.Nombre);

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "E:\JavierSanchezProyectoCore\JavierSanchezProyectoCore\Views\Juego\Details.cshtml"
                                       
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "E:\JavierSanchezProyectoCore\JavierSanchezProyectoCore\Views\Juego\Details.cshtml"
                 

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </p>\r\n        <p>");
#nullable restore
#line 46 "E:\JavierSanchezProyectoCore\JavierSanchezProyectoCore\Views\Juego\Details.cshtml"
      Write(Model.Salida.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 47 "E:\JavierSanchezProyectoCore\JavierSanchezProyectoCore\Views\Juego\Details.cshtml"
         if (Model.Descuento != 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p> Descuento : ");
#nullable restore
#line 49 "E:\JavierSanchezProyectoCore\JavierSanchezProyectoCore\Views\Juego\Details.cshtml"
                       Write(Model.Descuento);

#line default
#line hidden
#nullable disable
            WriteLiteral(" %</p>\r\n            <p> Precio : ");
#nullable restore
#line 50 "E:\JavierSanchezProyectoCore\JavierSanchezProyectoCore\Views\Juego\Details.cshtml"
                    Write(Model.Precio);

#line default
#line hidden
#nullable disable
            WriteLiteral(" €</p>\r\n            <p>\r\n                Precio Final:\r\n");
#nullable restore
#line 53 "E:\JavierSanchezProyectoCore\JavierSanchezProyectoCore\Views\Juego\Details.cshtml"
                  
                    decimal? preciofinal = Model.Precio - (Model.Precio * Model.Descuento / 100);

                

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
#nullable restore
#line 57 "E:\JavierSanchezProyectoCore\JavierSanchezProyectoCore\Views\Juego\Details.cshtml"
           Write(preciofinal.Value.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" €\r\n            </p>\r\n");
#nullable restore
#line 59 "E:\JavierSanchezProyectoCore\JavierSanchezProyectoCore\Views\Juego\Details.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p> Precio : ");
#nullable restore
#line 62 "E:\JavierSanchezProyectoCore\JavierSanchezProyectoCore\Views\Juego\Details.cshtml"
                    Write(Model.Precio);

#line default
#line hidden
#nullable disable
            WriteLiteral(" €</p>\r\n");
#nullable restore
#line 63 "E:\JavierSanchezProyectoCore\JavierSanchezProyectoCore\Views\Juego\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 65 "E:\JavierSanchezProyectoCore\JavierSanchezProyectoCore\Views\Juego\Details.cshtml"
         if (ViewBag.Disabled)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a430b3ea7e476c30839d7d9101d286b42578955818212", async() => {
                WriteLiteral("Añadir al carrito");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 67 "E:\JavierSanchezProyectoCore\JavierSanchezProyectoCore\Views\Juego\Details.cshtml"
                                                                WriteLiteral(Model.JuegoId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 68 "E:\JavierSanchezProyectoCore\JavierSanchezProyectoCore\Views\Juego\Details.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a430b3ea7e476c30839d7d9101d286b42578955820937", async() => {
                WriteLiteral("Añadir al carrito");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 71 "E:\JavierSanchezProyectoCore\JavierSanchezProyectoCore\Views\Juego\Details.cshtml"
                                                                WriteLiteral(Model.JuegoId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("   \r\n");
#nullable restore
#line 72 "E:\JavierSanchezProyectoCore\JavierSanchezProyectoCore\Views\Juego\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Juego> Html { get; private set; }
    }
}
#pragma warning restore 1591