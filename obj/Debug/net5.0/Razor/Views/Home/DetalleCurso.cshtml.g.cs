#pragma checksum "C:\Users\46483420\Downloads\TP11\Views\Home\DetalleCurso.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce3935e2fce65b8f2e07fff6880a82797e414714"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DetalleCurso), @"mvc.1.0.view", @"/Views/Home/DetalleCurso.cshtml")]
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
#line 1 "C:\Users\46483420\Downloads\TP11\Views\_ViewImports.cshtml"
using TP11;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\46483420\Downloads\TP11\Views\_ViewImports.cshtml"
using TP11.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce3935e2fce65b8f2e07fff6880a82797e414714", @"/Views/Home/DetalleCurso.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5d5cfd852d18895bf2cf5d35380edb1c85a2c70", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_DetalleCurso : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\46483420\Downloads\TP11\Views\Home\DetalleCurso.cshtml"
Write(ViewBag.aviso);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<br><br>\r\n<img");
            BeginWriteAttribute("src", " src=\"", 32, "\"", 59, 1);
#nullable restore
#line 4 "C:\Users\46483420\Downloads\TP11\Views\Home\DetalleCurso.cshtml"
WriteAttributeValue("", 38, ViewBag.curso.Imagen, 38, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=100>\r\nIdCurso: ");
#nullable restore
#line 5 "C:\Users\46483420\Downloads\TP11\Views\Home\DetalleCurso.cshtml"
    Write(ViewBag.curso.IdCurso);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br>\r\nNombre: ");
#nullable restore
#line 6 "C:\Users\46483420\Downloads\TP11\Views\Home\DetalleCurso.cshtml"
   Write(ViewBag.curso.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br>\r\nPrecio: ");
#nullable restore
#line 7 "C:\Users\46483420\Downloads\TP11\Views\Home\DetalleCurso.cshtml"
   Write(ViewBag.curso.Precio);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br>\r\n");
#nullable restore
#line 8 "C:\Users\46483420\Downloads\TP11\Views\Home\DetalleCurso.cshtml"
  
    if(@ViewBag.curso.ReunionZoom != null){

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Reunion zoom: ");
#nullable restore
#line 10 "C:\Users\46483420\Downloads\TP11\Views\Home\DetalleCurso.cshtml"
                    Write(ViewBag.curso.ReunionZoom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 11 "C:\Users\46483420\Downloads\TP11\Views\Home\DetalleCurso.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("IdEspecialidad: ");
#nullable restore
#line 13 "C:\Users\46483420\Downloads\TP11\Views\Home\DetalleCurso.cshtml"
           Write(ViewBag.curso.IdEspecialidad);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br>\r\nDescripcion: ");
#nullable restore
#line 14 "C:\Users\46483420\Downloads\TP11\Views\Home\DetalleCurso.cshtml"
        Write(ViewBag.curso.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br>\r\n");
#nullable restore
#line 15 "C:\Users\46483420\Downloads\TP11\Views\Home\DetalleCurso.cshtml"
Write(Html.Raw(ViewBag.curso.UrlCurso));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br><br><br><br>\r\n\r\n<a");
            BeginWriteAttribute("href", " href=\'", 454, "\'", 546, 1);
#nullable restore
#line 17 "C:\Users\46483420\Downloads\TP11\Views\Home\DetalleCurso.cshtml"
WriteAttributeValue("", 461, Url.Action("Calificar", "Home", new{idCurso = @ViewBag.curso.IdCurso, gusta = true}), 461, 85, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <img src=\"/img/like.png\" height=50>\r\n</a>\r\n");
#nullable restore
#line 20 "C:\Users\46483420\Downloads\TP11\Views\Home\DetalleCurso.cshtml"
Write(ViewBag.curso.MeGusta);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<a");
            BeginWriteAttribute("href", " href=\'", 623, "\'", 716, 1);
#nullable restore
#line 21 "C:\Users\46483420\Downloads\TP11\Views\Home\DetalleCurso.cshtml"
WriteAttributeValue("", 630, Url.Action("Calificar", "Home", new{idCurso = @ViewBag.curso.IdCurso, gusta = false}), 630, 86, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <img src=\"/img/dislike.png\" height=50>\r\n</a>\r\n");
#nullable restore
#line 24 "C:\Users\46483420\Downloads\TP11\Views\Home\DetalleCurso.cshtml"
Write(ViewBag.curso.NoMeGusta);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br><br><br>\r\n");
#nullable restore
#line 26 "C:\Users\46483420\Downloads\TP11\Views\Home\DetalleCurso.cshtml"
  
    if(@ViewBag.coinciden == true){

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\'", 861, "\'", 935, 1);
#nullable restore
#line 28 "C:\Users\46483420\Downloads\TP11\Views\Home\DetalleCurso.cshtml"
WriteAttributeValue("", 868, Url.Action("SacarDelCarrito", "Home", new{curso = @ViewBag.curso}), 868, 67, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Eliminar del carrito</a><br><br>\r\n");
#nullable restore
#line 29 "C:\Users\46483420\Downloads\TP11\Views\Home\DetalleCurso.cshtml"
    }
    else{

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\'", 999, "\'", 1074, 1);
#nullable restore
#line 31 "C:\Users\46483420\Downloads\TP11\Views\Home\DetalleCurso.cshtml"
WriteAttributeValue("", 1006, Url.Action("AgregarAlCarrito", "Home", new{curso = @ViewBag.curso}), 1006, 68, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Agregar al carrito</a><br><br>\r\n");
#nullable restore
#line 32 "C:\Users\46483420\Downloads\TP11\Views\Home\DetalleCurso.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br><br><br>\r\n");
#nullable restore
#line 35 "C:\Users\46483420\Downloads\TP11\Views\Home\DetalleCurso.cshtml"
  
    if(@ViewBag.esAdministrador == true){

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\'", 1189, "\'", 1269, 1);
#nullable restore
#line 37 "C:\Users\46483420\Downloads\TP11\Views\Home\DetalleCurso.cshtml"
WriteAttributeValue("", 1196, Url.Action("BorrarLikes", "Home", new{idCurso = @ViewBag.curso.IdCurso}), 1196, 73, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Borrar Likes y Dislikes</a><br><br>\r\n        <a");
            BeginWriteAttribute("href", " href=\'", 1318, "\'", 1400, 1);
#nullable restore
#line 38 "C:\Users\46483420\Downloads\TP11\Views\Home\DetalleCurso.cshtml"
WriteAttributeValue("", 1325, Url.Action("EliminarCurso", "Home", new{idCurso = @ViewBag.curso.IdCurso}), 1325, 75, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Borrar Curso</a><br><br>\r\n        <p>Agregar Reunion de zoom:</p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce3935e2fce65b8f2e07fff6880a82797e41471410222", async() => {
                WriteLiteral("\r\n            <input type=\"text\" name=\"link\">\r\n            <button type=\"submit\">Enviar</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#nullable restore
#line 40 "C:\Users\46483420\Downloads\TP11\Views\Home\DetalleCurso.cshtml"
AddHtmlAttributeValue("", 1505, Url.Action("AgregarReunionZoom", "Home", new{idCurso = @ViewBag.curso.IdCurso}), 1505, 80, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 44 "C:\Users\46483420\Downloads\TP11\Views\Home\DetalleCurso.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
