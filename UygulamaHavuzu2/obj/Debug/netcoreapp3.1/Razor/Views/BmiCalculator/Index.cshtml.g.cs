#pragma checksum "C:\Users\owl\source\repos\UygulamaHavuzu2\UygulamaHavuzu2\Views\BmiCalculator\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a7a2f7da0fe5d0c869f8b2afecf1cc922e3e42a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BmiCalculator_Index), @"mvc.1.0.view", @"/Views/BmiCalculator/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a7a2f7da0fe5d0c869f8b2afecf1cc922e3e42a", @"/Views/BmiCalculator/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b668069497cd3b2993c6c757e7b80986defb52e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_BmiCalculator_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UygulamaHavuzu2.Models.CalculateViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-success", new global::Microsoft.AspNetCore.Html.HtmlString("myf"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "BmiCalculator", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/jquery-ajax-unobtrusive/jquery.unobtrusive-ajax.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bmiCalculator.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\owl\source\repos\UygulamaHavuzu2\UygulamaHavuzu2\Views\BmiCalculator\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewData["title"] = "Bmi Calculator";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container mt-5  d-flex justify-content-center"">
    <div class=""card p-sm-3 shadow p-3 mb-5 bg-body rounded"">
        <div class=""card-body text-center"">
            <div class=""m-auto"">
                <h5 class=""card-title text-center"">BMI Calculator</h5>

                <div class=""d-inline-block"">

                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a7a2f7da0fe5d0c869f8b2afecf1cc922e3e42a7212", async() => {
                WriteLiteral("\r\n                        <label class=\"m-2 \" for=\"height\">Height(cm): </label>\r\n                        ");
#nullable restore
#line 17 "C:\Users\owl\source\repos\UygulamaHavuzu2\UygulamaHavuzu2\Views\BmiCalculator\Index.cshtml"
                   Write(Html.TextBoxFor(m => m.Height));

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n                        <label class=\"m-2 \" for=\"weight\">Weight(Kg): </label>\r\n                        ");
#nullable restore
#line 19 "C:\Users\owl\source\repos\UygulamaHavuzu2\UygulamaHavuzu2\Views\BmiCalculator\Index.cshtml"
                   Write(Html.TextBoxFor(m => m.Weight));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        <div class=""d-flex justify-content-end"">
                            <a href=""#"" onclick=""resetFunc()"" class=""btn btn-sm  btn-warning"">Reset</a>
                            <input type=""submit"" class=""btn btn-sm btn-info"" value=""Gonder"">
                        </div>

                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


                    <div id=""results"">
                        <p class=""m-0"">Your BMI:<span id=""your_bmi""></span></p>
                        <p>BMI result:<span id=""bmi_result""></span></p>
                    </div>


                </div>



                <div class=""row"">
                    <div class=""col-lg-3 col-md-6"">
                        <div class=""card size"" id=""under_weight"">
                            <div class=""card-body"">
                                <h6 class=""  card-title p-md-3""> <18.5 under weight </h6>

                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-3  col-md-6"">
                        <div class=""card size"" id=""normal"">
                            <div class=""card-body"">
                                <h6 class="" card-title p-md-3"">18.5-25 Normal</h6>

                            </div>
                        </div>
                    </div>
               ");
            WriteLiteral(@"     <div class=""col-lg-3 col-md-6"">
                        <div class=""card size"" id=""over_weight"">
                            <div class=""card-body"">
                                <h6 class="" card-title p-md-3"">25-30 Over weight</h6>

                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-3 col-md-6"">
                        <div class=""card size"" id=""obese"">
                            <div class=""card-body"">
                                <h6 class="" card-title p-md-4"">>30 Obese</h6>

                            </div>
                        </div>
                    </div>
                </div>


            </div>
        </div>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>

        function myf(data) {

            var obj = JSON.parse(data);

            document.getElementById(""your_bmi"").textContent = obj.Result.toFixed(2);
            document.getElementById(""bmi_result"").textContent = obj.YourResult;
            if (obj.YourResult === ""Under Weight"") {

                document.getElementById(""under_weight"").classList.add(""shadow"");
                document.getElementById(""normal"").classList.remove(""shadow"");
                document.getElementById(""over_weight"").classList.remove(""shadow"");
                document.getElementById(""obese"").classList.remove(""shadow"");
            } else if (obj.YourResult === ""Normal"") {
                document.getElementById(""normal"").classList.add(""shadow"");
                document.getElementById(""under_weight"").classList.remove(""shadow"");
                document.getElementById(""over_weight"").classList.remove(""shadow"");
                document.getElementById(""obese"").classList.remove(""shadow"");
       ");
                WriteLiteral(@"     } else if (obj.YourResult === ""Over weight"") {
                document.getElementById(""over_weight"").classList.add(""shadow"");
                document.getElementById(""normal"").classList.remove(""shadow"");
                document.getElementById(""under_weight"").classList.remove(""shadow"");
                document.getElementById(""obese"").classList.remove(""shadow"");
            } else if (obj.YourResult === ""Obese"") {
                document.getElementById(""obese"").classList.add(""shadow"");
                document.getElementById(""under_weight"").classList.remove(""shadow"");
                document.getElementById(""normal"").classList.remove(""shadow"");
                document.getElementById(""over_weight"").classList.remove(""shadow"");

            }

        }

    </script>


    <script>
        function resetFunc() {
            document.getElementById(""Height"").value = """";
            document.getElementById(""Weight"").value = """";
            document.getElementById(""your_bmi"").innerHTM");
                WriteLiteral(@"L = """";
            document.getElementById(""bmi_result"").innerHTML = """";
            document.getElementById(""under_weight"").classList.remove(""shadow"");
            document.getElementById(""normal"").classList.remove(""shadow"");
            document.getElementById(""over_weight"").classList.remove(""shadow"");
            document.getElementById(""obese"").classList.remove(""shadow"");

        }
    </script>





    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a7a2f7da0fe5d0c869f8b2afecf1cc922e3e42a14930", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a7a2f7da0fe5d0c869f8b2afecf1cc922e3e42a16030", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <script src=\"https://cdn.jsdelivr.net/npm/bootstrap@5.2.0/dist/js/bootstrap.bundle.min.js\"></script>\r\n\r\n");
            }
            );
            WriteLiteral("\r\n\r\n\r\n");
            DefineSection("cssdefination", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9a7a2f7da0fe5d0c869f8b2afecf1cc922e3e42a17414", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UygulamaHavuzu2.Models.CalculateViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
