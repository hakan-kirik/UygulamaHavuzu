#pragma checksum "C:\Users\owl\source\repos\UygulamaHavuzu2\UygulamaHavuzu2\Views\Todo\TodoLi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "247c5f5f08b53732de6c0f72f9817e42b5f17fad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Todo_TodoLi), @"mvc.1.0.view", @"/Views/Todo/TodoLi.cshtml")]
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
#line 1 "C:\Users\owl\source\repos\UygulamaHavuzu2\UygulamaHavuzu2\Views\_ViewImports.cshtml"
using UygulamaHavuzu2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\owl\source\repos\UygulamaHavuzu2\UygulamaHavuzu2\Views\_ViewImports.cshtml"
using UygulamaHavuzu2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"247c5f5f08b53732de6c0f72f9817e42b5f17fad", @"/Views/Todo/TodoLi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b668069497cd3b2993c6c757e7b80986defb52e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Todo_TodoLi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TodoModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<li class=\"list-group-item d-flex justify-content-between align-items-center border-start-0 border-top-0 border-end-0 border-bottom rounded-0 mb-2\">\r\n    <div class=\"d-flex align-items-center\">\r\n        <input");
            BeginWriteAttribute("onclick", " onclick=\"", 229, "\"", 258, 3);
            WriteAttributeValue("", 239, "editFunc(", 239, 9, true);
#nullable restore
#line 5 "C:\Users\owl\source\repos\UygulamaHavuzu2\UygulamaHavuzu2\Views\Todo\TodoLi.cshtml"
WriteAttributeValue("", 248, Model.Id, 248, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 257, ")", 257, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"form-check-input me-2\" type=\"checkbox\"");
            BeginWriteAttribute("value", " value=\"", 305, "\"", 313, 0);
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"...\" />\r\n        ");
#nullable restore
#line 6 "C:\Users\owl\source\repos\UygulamaHavuzu2\UygulamaHavuzu2\Views\Todo\TodoLi.cshtml"
   Write(Model.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <a href=\"#!\"");
            BeginWriteAttribute("onclick", " onclick=\"", 388, "\"", 419, 3);
            WriteAttributeValue("", 398, "deleteFunc(", 398, 11, true);
#nullable restore
#line 8 "C:\Users\owl\source\repos\UygulamaHavuzu2\UygulamaHavuzu2\Views\Todo\TodoLi.cshtml"
WriteAttributeValue("", 409, Model.Id, 409, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 418, ")", 418, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=", 420, "", 433, 1);
#nullable restore
#line 8 "C:\Users\owl\source\repos\UygulamaHavuzu2\UygulamaHavuzu2\Views\Todo\TodoLi.cshtml"
WriteAttributeValue("", 424, Model.Id, 424, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-mdb-toggle=\"tooltip\" title=\"Remove item\">\r\n        <i class=\"fas fa-times text-primary\"></i>\r\n    </a>\r\n</li>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TodoModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
