#pragma checksum "C:\Users\46483420\Downloads\TP11\Views\Home\AgregarCurso.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7e6e15bcce1c626483c42316cc0af23c6f859ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AgregarCurso), @"mvc.1.0.view", @"/Views/Home/AgregarCurso.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7e6e15bcce1c626483c42316cc0af23c6f859ac", @"/Views/Home/AgregarCurso.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5d5cfd852d18895bf2cf5d35380edb1c85a2c70", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_AgregarCurso : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("needs-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\46483420\Downloads\TP11\Views\Home\AgregarCurso.cshtml"
Write(ViewBag.aviso);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1>AGREGAR UN NUEVO CURSO</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7e6e15bcce1c626483c42316cc0af23c6f859ac4078", async() => {
                WriteLiteral(@"
    <div class=""form-row"">
        <div class=""col-md-4 mb-3"">
            <label for=""validationCustom01"">Nombre:</label>
            <input type=""text"" class=""form-control"" id=""validationCustom01"" name=""Nombre"" required>
            <div class=""invalid-feedback"">
                Escriba el nombre del curso
            </div>
        </div>
        <div class=""col-md-4 mb-3"">
            <label for=""validationCustom02"">Descripcion</label>
            <input type=""text"" class=""form-control"" id=""validationCustom02"" name=""Descripcion"" required>
            <div class=""invalid-feedback"">
                Escriba la descripcion del curso
            </div>
        </div>
        <div class=""col-md-4 mb-3"">
            <label for=""validationCustom02"">Imagen</label>
            <input type=""text"" class=""form-control"" id=""validationCustom02"" name=""Imagen"" required>
            <div class=""invalid-feedback"">
                inserte la url de la imagen del curso
            </div>
        </div>
                WriteLiteral(@"
    </div>
    <div class=""form-row"">
        <div class=""col-md-3 mb-3"">
            <label for=""validationCustom01"">Id de la Especialidad:</label>
            <input type=""number"" class=""form-control"" id=""validationCustom01"" name=""IdEspecialidad"" required>
            <div class=""invalid-feedback"">
                inserte el id de la especialidad
            </div>
        </div>
        <div class=""col-md-3 mb-3"">
            <label for=""validationCustom02"">Url del Curso</label>
            <input type=""text"" class=""form-control"" id=""validationCustom02"" name=""UrlCurso"" required>
            <div class=""invalid-feedback"">
                inserte la url del curso
            </div>
        </div>
        <div class=""col-md-3 mb-3"">
            <label for=""validationCustom02"">Cantidad de Me Gusta</label>
            <input type=""number"" class=""form-control"" id=""validationCustom02"" name=""MeGusta"" value=0 required>
            <div class=""invalid-feedback"">
                inserte la cantid");
                WriteLiteral(@"ad de me gusta
            </div>
        </div>
        <div class=""col-md-3 mb-3"">
            <label for=""validationCustom02"">Cantidad de No Me Gusta</label>
            <input type=""number"" class=""form-control"" id=""validationCustom02"" name=""NoMeGusta"" value=0 required>
            <div class=""invalid-feedback"">
                inserte la cantidad de no me gusta
            </div>
        </div>
    </div>
    <div class=""form-row"">
        <div class=""col-md-4 mb-3"">
            <label for=""validationCustom01"">Precio</label>
            <input type=""number"" class=""form-control"" id=""validationCustom01"" name=""Precio"" required>
            <div class=""invalid-feedback"">
                inserte el Precio
            </div>
        </div>
        <div class=""col-md-4 mb-3"">
            <label for=""validationCustom02"">Link reunion de zoom</label>
            <input type=""text"" class=""form-control"" id=""validationCustom02"" name=""ReunionZoom"">
        </div>
    </div>
    <button class=""bt");
                WriteLiteral("n btn-primary\" type=\"submit\">Enviar</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#nullable restore
#line 5 "C:\Users\46483420\Downloads\TP11\Views\Home\AgregarCurso.cshtml"
AddHtmlAttributeValue("", 106, Url.Action("GuardarCurso", "Home"), 106, 35, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<script>
// Example starter JavaScript for disabling form submissions if there are invalid fields
(function() {
  'use strict';
  window.addEventListener('load', function() {
    // Fetch all the forms we want to apply custom Bootstrap validation styles to
    var forms = document.getElementsByClassName('needs-validation');
    // Loop over them and prevent submission
    var validation = Array.prototype.filter.call(forms, function(form) {
      form.addEventListener('submit', function(event) {
        if (form.checkValidity() === false) {
          event.preventDefault();
          event.stopPropagation();
        }
        form.classList.add('was-validated');
      }, false);
    });
  }, false);
})();
</script>");
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