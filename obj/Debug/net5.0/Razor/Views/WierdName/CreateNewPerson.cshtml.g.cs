#pragma checksum "D:\Documents\Coding\Codeboxx\Codeboxx_Stack\Codeboxx_Stack_Demo\Views\WierdName\CreateNewPerson.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abb181e92ebde68db1e234b3d83a471d5aac505a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WierdName_CreateNewPerson), @"mvc.1.0.view", @"/Views/WierdName/CreateNewPerson.cshtml")]
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
#line 1 "D:\Documents\Coding\Codeboxx\Codeboxx_Stack\Codeboxx_Stack_Demo\Views\_ViewImports.cshtml"
using Codeboxx_Stack_Demo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Documents\Coding\Codeboxx\Codeboxx_Stack\Codeboxx_Stack_Demo\Views\_ViewImports.cshtml"
using Codeboxx_Stack_Demo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abb181e92ebde68db1e234b3d83a471d5aac505a", @"/Views/WierdName/CreateNewPerson.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfef5f579dfae313cd65c232b0fbe58861b09734", @"/Views/_ViewImports.cshtml")]
    public class Views_WierdName_CreateNewPerson : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Codeboxx_Stack_Demo.Models.Person>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Documents\Coding\Codeboxx\Codeboxx_Stack\Codeboxx_Stack_Demo\Views\WierdName\CreateNewPerson.cshtml"
  
    ViewBag.Title = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Create</h2>\r\n\r\n\r\n");
#nullable restore
#line 12 "D:\Documents\Coding\Codeboxx\Codeboxx_Stack\Codeboxx_Stack_Demo\Views\WierdName\CreateNewPerson.cshtml"
 using (Html.BeginForm())
{



    //this it for our '[ValidateAntiForgeryToken]' on top of our method. name is self explanatory
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Documents\Coding\Codeboxx\Codeboxx_Stack\Codeboxx_Stack_Demo\Views\WierdName\CreateNewPerson.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <h4>Person</h4>\r\n        <hr />\r\n\r\n");
            WriteLiteral("        ");
#nullable restore
#line 25 "D:\Documents\Coding\Codeboxx\Codeboxx_Stack\Codeboxx_Stack_Demo\Views\WierdName\CreateNewPerson.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n        <div class=\"form-group\">\r\n\r\n\r\n");
            WriteLiteral("            ");
#nullable restore
#line 32 "D:\Documents\Coding\Codeboxx\Codeboxx_Stack\Codeboxx_Stack_Demo\Views\WierdName\CreateNewPerson.cshtml"
       Write(Html.LabelFor(model => model.Name, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n            <div class=\"col-md-10\">\r\n");
            WriteLiteral("                ");
#nullable restore
#line 38 "D:\Documents\Coding\Codeboxx\Codeboxx_Stack\Codeboxx_Stack_Demo\Views\WierdName\CreateNewPerson.cshtml"
           Write(Html.EditorFor(model => model.Name, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
            WriteLiteral("                ");
#nullable restore
#line 43 "D:\Documents\Coding\Codeboxx\Codeboxx_Stack\Codeboxx_Stack_Demo\Views\WierdName\CreateNewPerson.cshtml"
           Write(Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n            </div>\r\n        </div>\r\n\r\n\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 53 "D:\Documents\Coding\Codeboxx\Codeboxx_Stack\Codeboxx_Stack_Demo\Views\WierdName\CreateNewPerson.cshtml"
       Write(Html.LabelFor(model => model.Email, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 55 "D:\Documents\Coding\Codeboxx\Codeboxx_Stack\Codeboxx_Stack_Demo\Views\WierdName\CreateNewPerson.cshtml"
           Write(Html.EditorFor(model => model.Email, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 56 "D:\Documents\Coding\Codeboxx\Codeboxx_Stack\Codeboxx_Stack_Demo\Views\WierdName\CreateNewPerson.cshtml"
           Write(Html.ValidationMessageFor(model => model.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 61 "D:\Documents\Coding\Codeboxx\Codeboxx_Stack\Codeboxx_Stack_Demo\Views\WierdName\CreateNewPerson.cshtml"
       Write(Html.LabelFor(model => model.Age, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 63 "D:\Documents\Coding\Codeboxx\Codeboxx_Stack\Codeboxx_Stack_Demo\Views\WierdName\CreateNewPerson.cshtml"
           Write(Html.EditorFor(model => model.Age, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 64 "D:\Documents\Coding\Codeboxx\Codeboxx_Stack\Codeboxx_Stack_Demo\Views\WierdName\CreateNewPerson.cshtml"
           Write(Html.ValidationMessageFor(model => model.Age, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-offset-2 col-md-10\">\r\n                <input type=\"submit\" value=\"Create\" class=\"btn btn-primary\" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 74 "D:\Documents\Coding\Codeboxx\Codeboxx_Stack\Codeboxx_Stack_Demo\Views\WierdName\CreateNewPerson.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    ");
#nullable restore
#line 77 "D:\Documents\Coding\Codeboxx\Codeboxx_Stack\Codeboxx_Stack_Demo\Views\WierdName\CreateNewPerson.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Codeboxx_Stack_Demo.Models.Person> Html { get; private set; }
    }
}
#pragma warning restore 1591
