#pragma checksum "C:\Users\owl\source\repos\UygulamaHavuzu2\UygulamaHavuzu2\Views\Weather\_weatherPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3ab0a5c13bc3a48981b1021503ca6d9f2ea5099"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Weather__weatherPartial), @"mvc.1.0.view", @"/Views/Weather/_weatherPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3ab0a5c13bc3a48981b1021503ca6d9f2ea5099", @"/Views/Weather/_weatherPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b668069497cd3b2993c6c757e7b80986defb52e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Weather__weatherPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WeatherModels>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\owl\source\repos\UygulamaHavuzu2\UygulamaHavuzu2\Views\Weather\_weatherPartial.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card p-4\">\r\n\r\n    <div class=\"d-flex\">\r\n        <h6 class=\"flex-grow-1\">");
#nullable restore
#line 9 "C:\Users\owl\source\repos\UygulamaHavuzu2\UygulamaHavuzu2\Views\Weather\_weatherPartial.cshtml"
                           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n        <h6>");
#nullable restore
#line 10 "C:\Users\owl\source\repos\UygulamaHavuzu2\UygulamaHavuzu2\Views\Weather\_weatherPartial.cshtml"
       Write(Model.Sys.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n    </div>\r\n\r\n    <div class=\"d-flex flex-column temp mt-5 mb-3\">\r\n        <h1 class=\"mb-0 font-weight-bold\" id=\"heading\"> ");
#nullable restore
#line 14 "C:\Users\owl\source\repos\UygulamaHavuzu2\UygulamaHavuzu2\Views\Weather\_weatherPartial.cshtml"
                                                   Write(Math.Round(Model.Main.Temp));

#line default
#line hidden
#nullable disable
            WriteLiteral("&deg; C</h1>\r\n        <span class=\"small grey\">");
#nullable restore
#line 15 "C:\Users\owl\source\repos\UygulamaHavuzu2\UygulamaHavuzu2\Views\Weather\_weatherPartial.cshtml"
                            Write(Model.Weather[0].Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </div>\r\n\r\n    <div class=\"d-flex\">\r\n        <div class=\"temp-details flex-grow-1\">\r\n            <p class=\"my-1\">\r\n                <img src=\"https://i.imgur.com/B9kqOzp.png\" height=\"17px\">\r\n\r\n                <span> ");
#nullable restore
#line 23 "C:\Users\owl\source\repos\UygulamaHavuzu2\UygulamaHavuzu2\Views\Weather\_weatherPartial.cshtml"
                  Write(Model.Wind.Speed);

#line default
#line hidden
#nullable disable
            WriteLiteral(" m/s</span>\r\n            </p>\r\n\r\n            <p class=\"my-1\">\r\n                <i class=\"fa fa-tint mr-2\" aria-hidden=\"true\"></i>\r\n                <span> ");
#nullable restore
#line 28 "C:\Users\owl\source\repos\UygulamaHavuzu2\UygulamaHavuzu2\Views\Weather\_weatherPartial.cshtml"
                  Write(Model.Main.Humidity);

#line default
#line hidden
#nullable disable
            WriteLiteral("% </span>\r\n            </p>\r\n\r\n            <p class=\"my-1\">\r\n                <img src=\"https://i.imgur.com/wGSJ8C5.png\" height=\"17px\">\r\n                <span>");
#nullable restore
#line 33 "C:\Users\owl\source\repos\UygulamaHavuzu2\UygulamaHavuzu2\Views\Weather\_weatherPartial.cshtml"
                 Write(Model.Sys.sunsetTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n\r\n\r\n            </p>\r\n        </div>\r\n\r\n        <div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a3ab0a5c13bc3a48981b1021503ca6d9f2ea50996591", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1101, "~/img/", 1101, 6, true);
#nullable restore
#line 40 "C:\Users\owl\source\repos\UygulamaHavuzu2\UygulamaHavuzu2\Views\Weather\_weatherPartial.cshtml"
AddHtmlAttributeValue("", 1107, Model.Weather[0].Icon, 1107, 22, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1129, "+.png", 1129, 5, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n\r\n\r\n    </div>\r\n\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WeatherModels> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
