#pragma checksum "C:\Users\owl\source\repos\UygulamaHavuzu2\UygulamaHavuzu2\Views\Todo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fdfd5470c2b44cc52c3fc0ddaa4fea9de611025f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Todo_Index), @"mvc.1.0.view", @"/Views/Todo/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdfd5470c2b44cc52c3fc0ddaa4fea9de611025f", @"/Views/Todo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b668069497cd3b2993c6c757e7b80986defb52e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Todo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TodoModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("todoForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex justify-content-center align-items-center mb-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\owl\source\repos\UygulamaHavuzu2\UygulamaHavuzu2\Views\Todo\Index.cshtml"
  
    ViewData["Title"] = "Todo App";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"

<section class=""vh-100"">
    <div class=""container py-5 h-100"">
        <div class=""row d-flex justify-content-center align-items-center h-100"">
            <div class=""col col-xl-10"">

                <div class=""card"" style=""border-radius: 15px;"">
                    <div id=""alertBox"" class=""alert alert-success"" role=""alert"" style=""display:none;"">

                    </div>
                    <div class=""card-body p-5"">

                        <h6 class=""mb-3"">Todo List App</h6>

                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fdfd5470c2b44cc52c3fc0ddaa4fea9de611025f4860", async() => {
                WriteLiteral(@"
                            <div class=""form-outline flex-fill"">
                                <input type=""text"" id=""todoText"" asp class=""form-control form-control-lg"" placeholder=""Ne yapmak istersiniz ?"" required />

                            </div>
                            <button type=""submit"" onclick=""addFunc()"" class=""btn btn-primary btn-lg ms-2"">Ekle</button>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <div id=\"TodoList\">\r\n");
#nullable restore
#line 31 "C:\Users\owl\source\repos\UygulamaHavuzu2\UygulamaHavuzu2\Views\Todo\Index.cshtml"
                              Html.RenderPartial("TodoList");

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n\r\n\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
            DefineSection("cssdefination", async() => {
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.2.0/css/all.min.css"" integrity=""sha512-xh6O/CkQoPOWDdYTDqeRdPCVd1SpvCA9XXcUnZS2FmJNp1coAFzvtCN9BmamE+4aHK8yyUHUSCcJHgXloTyT2A=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />
");
            }
            );
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        function editFunc(id) {

            $.ajax({
                method: ""POST"",
                url: ""/Todo/EditAndAdd"",
                data: { ""id"":id }
            })
                .done(function (responseHtml) {


                    document.getElementById('TodoList').innerHTML = responseHtml;

                });
        }
        function deleteFunc(id) {
            $.ajax({
                method: ""POST"",
                url: ""/Todo/Remove"",
                data: { ""id"": id }
            })
                .done(function () {

                    document.getElementById(id).parentElement.remove();


                });
        }

        function addFunc() {

            var todoContent = document.getElementById(""todoText"").value;
            $.ajax({
                method: ""POST"",
                url: ""/Todo/AddTodo"",
                data: { ""Content"":todoContent }
            })
                .done(function (msg) {
                    ");
                WriteLiteral(@"if (msg.length !== 0) {

                        document.getElementById(""alertBox"").innerHTML = todoContent + "" basarili bir sekilde kayit edildi."";
                        $(""#alertBox"").fadeIn();
                        setTimeout(function () { $(""#alertBox"").fadeOut(); }, 3000);
                        $(""#TodoULTag"").append(msg);
                        document.getElementById(""todoText"").value = """";
                    } else {

                    }


                });
        }
        document.getElementById(""todoForm"").addEventListener('submit', (e) => { e.preventDefault();});

    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TodoModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
