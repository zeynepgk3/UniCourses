#pragma checksum "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Views\Home\UyeGoruntule.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "230b1d0f358bf9b6ff7bea769dc03d6e6427e649"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UyeGoruntule), @"mvc.1.0.view", @"/Views/Home/UyeGoruntule.cshtml")]
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
#line 1 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Views\_ViewImports.cshtml"
using UniCourses.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Views\_ViewImports.cshtml"
using UniCourses.WebUI.ViewComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Views\_ViewImports.cshtml"
using UniCourses.Dal.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Views\_ViewImports.cshtml"
using UniCourses.WebUI.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Views\_ViewImports.cshtml"
using UniCourses.WebUI.Utility;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"230b1d0f358bf9b6ff7bea769dc03d6e6427e649", @"/Views/Home/UyeGoruntule.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"431a6833075c7f9cf5d1659ca1d972fd581d750e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UyeGoruntule : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UniCourses.Dal.Entities.Member>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100%; height: auto;max-width:256px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Views\Home\UyeGoruntule.cshtml"
  
    ViewData["Title"] = "UyeGoruntule";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<link href=""https://fonts.googleapis.com/css?family=Cardo:400,700|Oswald"" rel=""stylesheet"">

<div class=""container"">
    <div class=""row element-animate"">
        <div class="" col-md-5"">
            <div style=""text-align:right; margin-top:40px;"">
                <div class=""d-flex align-items-center justify-content-center"">
                    <figure>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "230b1d0f358bf9b6ff7bea769dc03d6e6427e6494888", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 588, "~/Picture/", 588, 10, true);
#nullable restore
#line 17 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Views\Home\UyeGoruntule.cshtml"
AddHtmlAttributeValue("", 598, Model.PictureURL, 598, 17, false);

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
            WriteLiteral(@"                        <div class=""row d-flex align-items-center justify-content-center mt-4"">


                        </div>
                        <!-- badge -->
                    </figure>

                </div>
            </div>
        </div>

        <div class=""col-md-7 text-center"" style=""margin-top:40px; margin-bottom:20px;"">
            <div class=""block-19 p-5"">

                <div class=""icon-row"">

                    <h4 style=""font-family: 'Oswald', sans-serif; text-transform: uppercase; font-size: 2em; color: #1b1b1b;"">
                        <b>");
#nullable restore
#line 36 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Views\Home\UyeGoruntule.cshtml"
                      Write(Model.NameSurName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</b>
                    </h4><br />
                    <p>
                        <i class=""fa fa-pencil m-2"" aria-hidden=""true"" style=""color:#cc2444;""></i>  Model.Class
                    </p>
                    <p>
                        <i class=""fa fa-graduation-cap m-2"" aria-hidden=""true"" style=""color:#cc2444;""></i>  Model.University
                    </p>

                </div>
            </div>
        </div>
    </div>
    <!--Tanıtım ends-->
    <!--Kurslar starts-->
    <div class=""row bg-light element-animate"">
        <div class=""col-md-12 block-25"">

            <div id=""Page2"">

                <div class=""row justify-content-between m-3 p-2"">
                    <div style=""float:left; margin:5px;"">
                        <h4>");
#nullable restore
#line 58 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Views\Home\UyeGoruntule.cshtml"
                       Write(Model.NameSurName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" 'nin İzlediği Kurslar</h4>
                    </div>

                </div>
                <div class=""row"">
                    <div class=""col-md-6"">
                        <div class="" m-2"">
                            <a href=""#"" class=""d-flex"" style=""vertical-align:middle;"">
                                <img style=""height:100px; width:auto; margin:5px 10px 10px 0px;"" src=""/images/img_2_b.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2540, "\"", 2546, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-fluid"">
                                <div class=""text m-2"">
                                    <h3 class=""heading"">Create cool websites using this template</h3>


                                </div>
                            </a>
                        </div>
                    </div>

                    <div class=""col-md-6"">
                        <div class="" m-2"">
                            <a href=""#"" class=""d-flex"" style=""vertical-align:middle;"">
                                <img style=""height:100px; width:auto; margin:5px 10px 10px 0px;"" src=""/images/img_2_b.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3165, "\"", 3171, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-fluid"">
                                <div class=""text m-2"">
                                    <h3 class=""heading"">Create cool websites using this template</h3>

                                </div>
                            </a>
                        </div>
                    </div>
                    <div class=""col-md-6"">
                        <div class="" m-2"">
                            <a href=""#"" class=""d-flex"" style=""vertical-align:middle;"">
                                <img style=""height:100px; width:auto; margin:5px 10px 10px 0px;"" src=""/images/img_2_b.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3786, "\"", 3792, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-fluid"">
                                <div class=""text m-2"">
                                    <h3 class=""heading"">Create cool websites using this template</h3>

                                </div>
                            </a>
                        </div>
                    </div>
                    <div class=""col-md-6"">
                        <div class="" m-2"">
                            <a href=""#"" class=""d-flex"" style=""vertical-align:middle;"">
                                <img style=""height:100px; width:auto; margin:5px 10px 10px 0px;"" src=""/images/img_2_b.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 4407, "\"", 4413, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-fluid"">
                                <div class=""text m-2"">
                                    <h3 class=""heading"">Create cool websites using this template</h3>


                                </div>
                            </a>
                        </div>
                    </div>
                    <div class=""col-md-6"">
                        <div class=""m-2"">
                            <a href=""#"" class=""d-flex"" style=""vertical-align:middle;"">
                                <img style=""height:100px; width:auto; margin:5px 10px 10px 0px;"" src=""/images/img_2_b.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 5029, "\"", 5035, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-fluid"">
                                <div class=""text m-2"">
                                    <h3 class=""heading"">Create cool websites using this template</h3>


                                </div>
                            </a>
                        </div>
                    </div>
                </div>

                <!--Courses ENDS-->

            </div>
        </div>
    </div>

    <!--kurslar sonu-->
    <!--faaliyetler başı-->
</div>
<script>
    function show(shown, hidden) {
        document.getElementById(shown).style.display = 'block';
        document.getElementById(hidden).style.display = 'none';
        return false;
    }
</script>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UniCourses.Dal.Entities.Member> Html { get; private set; }
    }
}
#pragma warning restore 1591
