#pragma checksum "C:\Users\Win 10\Desktop\HCILab\HCILab\HCILab.Interface\Views\Home\ListArticleInsert.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cd56d693d959b4b93e7425def74bdd3ea3eab3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ListArticleInsert), @"mvc.1.0.view", @"/Views/Home/ListArticleInsert.cshtml")]
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
#line 1 "C:\Users\Win 10\Desktop\HCILab\HCILab\HCILab.Interface\Views\_ViewImports.cshtml"
using HCILab.Interface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Win 10\Desktop\HCILab\HCILab\HCILab.Interface\Views\_ViewImports.cshtml"
using HCILab.Interface.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cd56d693d959b4b93e7425def74bdd3ea3eab3b", @"/Views/Home/ListArticleInsert.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87f441f042de37f98e71af3ce4dde8035c1f6fc9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ListArticleInsert : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ArticleInsert", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Win 10\Desktop\HCILab\HCILab\HCILab.Interface\Views\Home\ListArticleInsert.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5cd56d693d959b4b93e7425def74bdd3ea3eab3b4388", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""generator"" content=""Mobirise v4.12.4, mobirise.com"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, minimum-scale=1"">
    <link rel=""shortcut icon"" href=""assets/images/logo2.png"" type=""image/x-icon"">
    <meta name=""description""");
                BeginWriteAttribute("content", " content=\"", 419, "\"", 429, 0);
                EndWriteAttribute();
                WriteLiteral(@">
    <title>Lista de Afiliações</title>
    <link rel=""stylesheet"" href=""../../assets/web/assets/mobirise-icons/mobirise-icons.css"">
    <link rel=""stylesheet"" href=""../../assets/bootstrap/css/bootstrap.min.css"">
    <link rel=""stylesheet"" href=""../../assets/bootstrap/css/bootstrap-grid.min.css"">
    <link rel=""stylesheet"" href=""../../assets/bootstrap/css/bootstrap-reboot.min.css"">
    <link rel=""stylesheet"" href=""../../assets/tether/tether.min.css"">
    <link rel=""stylesheet"" href=""../../assets/dropdown/css/style.css"">
    <link rel=""stylesheet"" href=""../../assets/theme/css/style.css"">
    <link rel=""preload"" as=""style"" href=""../../assets/mobirise/css/mbr-additional.css"">
    <link rel=""stylesheet"" href=""../../assets/mobirise/css/mbr-additional.css"" type=""text/css"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5cd56d693d959b4b93e7425def74bdd3ea3eab3b6721", async() => {
                WriteLiteral(@"
    <section class=""menu cid-s3850fUtFu"" once=""menu"" id=""menu1-13"">
        <nav class=""navbar navbar-expand beta-menu navbar-dropdown align-items-center navbar-fixed-top navbar-toggleable-sm"">
            <button class=""navbar-toggler navbar-toggler-right"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <div class=""hamburger"">
                    <span></span>
                    <span></span>
                    <span></span>
                    <span></span>
                </div>
            </button>
            <div class=""menu-logo"">
                <div class=""navbar-brand"">
                    <span class=""navbar-caption-wrap"">
                        <a class=""navbar-caption text-white display-4""");
                BeginWriteAttribute("href", " href=\'", 2101, "\'", 2136, 1);
#nullable restore
#line 38 "C:\Users\Win 10\Desktop\HCILab\HCILab\HCILab.Interface\Views\Home\ListArticleInsert.cshtml"
WriteAttributeValue("", 2108, Url.Action("Index", "Home"), 2108, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">HCI LAB</a>
                    </span>
                </div>
            </div>
            <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
                <ul class=""navbar-nav nav-dropdown nav-right"" data-app-modern-menu=""true"">
                    <li class=""nav-item""><a class=""nav-link link text-white display-4""");
                BeginWriteAttribute("href", " href=\'", 2482, "\'", 2523, 1);
#nullable restore
#line 44 "C:\Users\Win 10\Desktop\HCILab\HCILab\HCILab.Interface\Views\Home\ListArticleInsert.cshtml"
WriteAttributeValue("", 2489, Url.Action("ArticleMenu", "Home"), 2489, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Artigos</a></li>\r\n                    <li class=\"nav-item\"><a class=\"nav-link link text-white display-4\"");
                BeginWriteAttribute("href", " href=\"", 2629, "\"", 2636, 0);
                EndWriteAttribute();
                WriteLiteral(">Projetos</a></li>\r\n                    <li class=\"nav-item\"><a class=\"nav-link link text-white display-4\"");
                BeginWriteAttribute("href", " href=\"", 2743, "\"", 2750, 0);
                EndWriteAttribute();
                WriteLiteral(@">Investigadores</a>
                </ul>

            </div>
        </nav>
    </section>

    <section class=""engine""></section><section class=""mbr-fullscreen form3 cid-s3850gMsDv"" id=""form3-14"">
        <div class=""container"">
            <p class=""mbr-white"">");
#nullable restore
#line 55 "C:\Users\Win 10\Desktop\HCILab\HCILab\HCILab.Interface\Views\Home\ListArticleInsert.cshtml"
                            Write(ViewBag.r);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5cd56d693d959b4b93e7425def74bdd3ea3eab3b10127", async() => {
                    WriteLiteral("\r\n                <span class=\" align-left\">\r\n                    <button type=\"submit\" value=\"Voltar\" class=\"btn btn-primary display-4\">Voltar</button>\r\n                </span>\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        </div>

    </section>
    <section once=""footers"" class=""cid-s3850hIzF6 mbr-reveal"" id=""footer6-15"">
        <div class=""container"">
            <div class=""media-container-row align-center mbr-white"">
                <div class=""col-12"">
                    <p class=""mbr-text mb-0 mbr-fonts-style display-7"">Laboratório de Projeto em Engenharia Informática<br><br></p>
                </div>
            </div>
        </div>
    </section>

    <script src=""../../assets/web/assets/jquery/jquery.min.js""></script>
    <script src=""../../assets/popper/popper.min.js""></script>
    <script src=""../../assets/bootstrap/js/bootstrap.min.js""></script>
    <script src=""../../assets/tether/tether.min.js""></script>
    <script src=""../../assets/smoothscroll/smooth-scroll.js""></script>
    <script src=""../../assets/dropdown/js/nav-dropdown.js""></script>
    <script src=""../../assets/dropdown/js/navbar-dropdown.js""></script>
    <script src=""../../assets/touchswipe/jquery.touch-swipe.min.js""><");
                WriteLiteral("/script>\r\n    <script src=\"../../assets/theme/js/script.js\"></script>\r\n    <script src=\"../../assets/formoid/formoid.min.js\"></script>\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
