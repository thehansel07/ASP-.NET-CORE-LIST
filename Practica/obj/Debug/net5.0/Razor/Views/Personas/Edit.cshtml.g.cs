#pragma checksum "C:\Users\hcabrera\source\repos\Practica\Practica\Views\Personas\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2200f6552a1c98d35fcf6c04c659b560a61da4ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personas_Edit), @"mvc.1.0.view", @"/Views/Personas/Edit.cshtml")]
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
#line 1 "C:\Users\hcabrera\source\repos\Practica\Practica\Views\_ViewImports.cshtml"
using Practica;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hcabrera\source\repos\Practica\Practica\Views\_ViewImports.cshtml"
using Practica.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2200f6552a1c98d35fcf6c04c659b560a61da4ce", @"/Views/Personas/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"607bf402628c953c1bd11627d9be6122945f39c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Personas_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Practica.Repository.Model.Personas>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 9 "C:\Users\hcabrera\source\repos\Practica\Practica\Views\Personas\Edit.cshtml"
 using (Html.BeginForm("Edit", "Personas", FormMethod.Post, new { @class = "form-horizontal" }))
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        ");
#nullable restore
#line 13 "C:\Users\hcabrera\source\repos\Practica\Practica\Views\Personas\Edit.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        <div class=\"form-group\">\r\n\r\n            <div class=\"col-md-8\">\r\n                ");
#nullable restore
#line 18 "C:\Users\hcabrera\source\repos\Practica\Practica\Views\Personas\Edit.cshtml"
           Write(Html.DisplayNameFor(x => x.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 19 "C:\Users\hcabrera\source\repos\Practica\Practica\Views\Personas\Edit.cshtml"
           Write(Html.EditorFor(model => model.Nombre, new { htmlAttributes = new { @class = "form-control", @required = "required" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 20 "C:\Users\hcabrera\source\repos\Practica\Practica\Views\Personas\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.Nombre, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"col-md-8\">\r\n                ");
#nullable restore
#line 24 "C:\Users\hcabrera\source\repos\Practica\Practica\Views\Personas\Edit.cshtml"
           Write(Html.DisplayNameFor(x => x.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 25 "C:\Users\hcabrera\source\repos\Practica\Practica\Views\Personas\Edit.cshtml"
           Write(Html.EditorFor(model => model.Apellido, new { htmlAttributes = new { @class = "form-control", @required = "required" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 26 "C:\Users\hcabrera\source\repos\Practica\Practica\Views\Personas\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.Apellido, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"col-md-8\">\r\n                ");
#nullable restore
#line 30 "C:\Users\hcabrera\source\repos\Practica\Practica\Views\Personas\Edit.cshtml"
           Write(Html.DisplayNameFor(x => x.Edad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 31 "C:\Users\hcabrera\source\repos\Practica\Practica\Views\Personas\Edit.cshtml"
           Write(Html.EditorFor(model => model.Edad, new { htmlAttributes = new { @class = "form-control", @required = "required" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 32 "C:\Users\hcabrera\source\repos\Practica\Practica\Views\Personas\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.Edad, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n\r\n        </div>\r\n\r\n\r\n        <input type=\"submit\" value=\"Guardar\" class=\"btn btn-default\" />\r\n\r\n\r\n    </div>\r\n");
#nullable restore
#line 43 "C:\Users\hcabrera\source\repos\Practica\Practica\Views\Personas\Edit.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Practica.Repository.Model.Personas> Html { get; private set; }
    }
}
#pragma warning restore 1591
