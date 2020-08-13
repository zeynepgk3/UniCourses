#pragma checksum "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Views\Home\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89973b5c343668a963a01b34e566fbfaa3c22f27"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Register), @"mvc.1.0.view", @"/Views/Home/Register.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89973b5c343668a963a01b34e566fbfaa3c22f27", @"/Views/Home/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9610a0b4e08ff27db021206b3e1634715074c956", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UniCourses.Dal.Entities.Member>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("already"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Uye", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Views\Home\Register.cshtml"
  
    ViewData["Title"] = "Register";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
            .register-photo {
  background: #f1f7fc;
  padding: 80px 0;
}

.register-photo .image-holder {
  display: table-cell;
  width: auto;
  background: url(/images/graduating.png);
  background-size: cover;
}

.register-photo .form-container {
  display: table;
  max-width: 900px;
  width: 90%;
  margin: 0 auto;
  box-shadow: 1px 1px 5px rgba(0,0,0,0.1);
}

.register-photo form {
  display: table-cell;
  width: 400px;
  background-color: #ffffff;
  padding: 40px 60px;
  color: #505e6c;
}

media (max-width:991px) {
  .register-photo form {
    padding: 40px;
  }
}

.register-photo form h2 {
  font-size: 24px;
  line-height: 1.5;
  margin-bottom: 30px;
}

.register-photo form .form-control {
  background: #f7f9fc;
  border: none;
  border-bottom: 1px solid #dfe7f1;
  border-radius: 0;
  box-shadow: none;
  outline: none;
  color: inherit;
  text-indent: 6px;
  height: 40px;
}

.register-photo form .form-check {
  font-size: 13px;
  line-heigh");
            WriteLiteral(@"t: 20px;
}

.register-photo form .btn-primary {
  background: #f4476b;
  border: none;
  border-radius: 4px;
  padding: 11px;
  box-shadow: none;
  margin-top: 35px;
  text-shadow: none;
  outline: none !important;
}

.register-photo form .btn-primary:hover, .register-photo form .btn-primary:active {
  background: #eb3b60;
}

.register-photo form .btn-primary:active {
  transform: translateY(1px);
}

.register-photo form .already {
  display: block;
  text-align: center;
  font-size: 12px;
  color: #6f7a85;
  opacity: 0.9;
  text-decoration: none;
}

    body {
        margin: 0;
        font-family: -apple-system,BlinkMacSystemFont,""Segoe UI"",Roboto,""Helvetica Neue"",Arial,""Noto Sans"",sans-serif,""Apple Color Emoji"",""Segoe UI Emoji"",""Segoe UI Symbol"",""Noto Color Emoji"";
        font-size: 1rem;
        font-weight: 400;
        line-height: 1.5;
        color: #212529;
        text-align: left;
        background-color: #fff;
    }
</style>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89973b5c343668a963a01b34e566fbfaa3c22f277819", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0, shrink-to-fit=no"">
    <title>Untitled</title>
    <link rel=""stylesheet"" href=""/css/bootstrap.min.css"">
    <link rel=""stylesheet"" href=""/css/Registration-Form-with-Photo.css"">
    <link rel=""stylesheet"" href=""/css/styles.css"">
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
            WriteLiteral(@"

<section class=""site-hero site-sm-hero overlay"" data-stellar-background-ratio=""0.5"" style=""background-image: url(/images/big_image_2.jpg);"">
    <div class=""container"">
        <div class=""row align-items-center justify-content-center site-hero-sm-inner"">
            <div class=""col-md-7 text-center"">

                <div class=""mb-5 element-animate"">
                    <h1 class=""mb-2"">Kayıt Ol</h1>
                    <p class=""bcrumb"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89973b5c343668a963a01b34e566fbfaa3c22f279608", async() => {
                WriteLiteral("Anasayfa");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" <span class=\"sep ion-android-arrow-dropright px-2\"></span>  <span class=\"current\">Kayıt Ol</span></p>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n<!-- END section -->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89973b5c343668a963a01b34e566fbfaa3c22f2710997", async() => {
                WriteLiteral("\r\n    <div class=\"register-photo\" >\r\n        <div class=\"form-container\">\r\n            <div class=\"image-holder\"></div>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89973b5c343668a963a01b34e566fbfaa3c22f2711399", async() => {
                    WriteLiteral(@"
                <h2 class=""text-center""><strong>Yeni</strong>Hesap Oluştur.</h2>
                <div class=""form-group""><input class=""form-control"" type=""email"" name=""Mail"" placeholder=""Email"" required></div>
                <div class=""form-group""><input class=""form-control"" type=""password"" name=""Password"" placeholder=""Şifre"" required></div>
                <div class=""form-group""><input class=""form-control"" type=""text"" name=""NameSurName"" placeholder=""İsim Soyisim"" required></div>
                <div class=""form-group"">
                    <div class=""col-md-12 form-group"">
                        <input type=""hidden"" id=""RegisteryDate"" name=""RegisteryDate""");
                    BeginWriteAttribute("value", " value=", 4039, "", 4059, 1);
#nullable restore
#line 139 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Views\Home\Register.cshtml"
WriteAttributeValue("", 4046, DateTime.Now, 4046, 13, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" class=\"form-control py-2\">\r\n                        <input type=\"hidden\" id=\"BirthDate\" name=\"BirthDate\"");
                    BeginWriteAttribute("value", " value=", 4164, "", 4184, 1);
#nullable restore
#line 140 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Views\Home\Register.cshtml"
WriteAttributeValue("", 4171, DateTime.Now, 4171, 13, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" class=""form-control py-2"">
                        <input type=""hidden"" id=""Gender"" name=""Gender"" value=""Diğer"" class=""form-control py-2"">
                        <input type=""hidden"" id=""Phone"" name=""Phone"" value=""1234567890"" class=""form-control py-2"">
                        <input type=""hidden"" id=""RoleNumber"" name=""RoleNumber"" value=""1"" class=""form-control py-2"">
                        <input type=""hidden"" id=""LogDate"" name=""LogDate""");
                    BeginWriteAttribute("value", " value=", 4631, "", 4651, 1);
#nullable restore
#line 144 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Views\Home\Register.cshtml"
WriteAttributeValue("", 4638, DateTime.Now, 4638, 13, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" class=""form-control py-2"">
                    </div>
                    <div class=""form-check""><label class=""form-check-label""><input class=""form-check-input"" type=""checkbox"" required>Koşul ve Şartları Kabul Ediyorum.</label></div>
                </div>
                <div class=""form-group""><input type=""submit"" class=""btn btn-primary px-5 py-2"" value=""Kayıt Ol""></div>");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89973b5c343668a963a01b34e566fbfaa3c22f2714573", async() => {
                        WriteLiteral("Zaten Hesabın Var Mı? Buradan Giriş Yap.");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <script src=\"/js/jquery.min.js\"></script >\r\n    <script src=\"/bootstrap/js/bootstrap.min.js\"></script>\r\n");
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
            WriteLiteral(@"
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />

<section class=""site-section"">
    <div class=""container"">
        <div class=""row justify-content-center"">
            <div class=""col-md-7"">
                <div class=""form-wrap"">
                    <h2 class=""mb-5"">Yeni Hesap Aç</h2>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89973b5c343668a963a01b34e566fbfaa3c22f2718429", async() => {
                WriteLiteral(@"
                        <div>
                            <div class=""row"">
                                <div class=""col-md-12 form-group"">
                                    <label for=""Mail"">Email Adresi</label>
                                    <input type=""email"" name=""Mail"" class=""form-control py-2"">
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-md-12 form-group"">
                                    <label for=""NameSurName""> İsim Soyisim </label>
                                    <input type=""text"" name=""NameSurName"" class=""form-control py-2"">
                                </div>
                            </div>

");
                WriteLiteral(@"
                            <div class=""row"">
                                <div class=""col-md-12 form-group"">
                                    <label for=""Password"">Parola</label>
                                    <input type=""password"" name=""Password"" class=""form-control py-2 "">
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-md-12 form-group"">
                                    <input type=""hidden"" id=""RegisteryDate"" name=""RegisteryDate""");
                BeginWriteAttribute("value", " value=", 9514, "", 9534, 1);
#nullable restore
#line 226 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Views\Home\Register.cshtml"
WriteAttributeValue("", 9521, DateTime.Now, 9521, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control py-2\">\r\n                                    <input type=\"hidden\" id=\"BirthDate\" name=\"BirthDate\"");
                BeginWriteAttribute("value", " value=", 9651, "", 9671, 1);
#nullable restore
#line 227 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Views\Home\Register.cshtml"
WriteAttributeValue("", 9658, DateTime.Now, 9658, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control py-2"">
                                    <input type=""hidden"" id=""Gender"" name=""Gender"" value=""Diğer"" class=""form-control py-2"">
                                    <input type=""hidden"" id=""Phone"" name=""Phone"" value=""1234567890"" class=""form-control py-2"">
                                    <input type=""hidden"" id=""RoleNumber"" name=""RoleNumber"" value=""1"" class=""form-control py-2"">
                                    <input type=""hidden"" id=""LogDate"" name=""LogDate""");
                BeginWriteAttribute("value", " value=", 10166, "", 10186, 1);
#nullable restore
#line 231 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Views\Home\Register.cshtml"
WriteAttributeValue("", 10173, DateTime.Now, 10173, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control py-2"">
                                </div>
                            </div>

                        </div>
                        <div class=""row"">
                            <div class=""col-md-6 form-group"">
                                <input type=""submit"" value=""Kaydol"" class=""btn btn-primary px-5 py-2"">
                            </div>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
            WriteLiteral("\r\n");
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
