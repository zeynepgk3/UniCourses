#pragma checksum "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Views\Shared\Components\Categori\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e76810d539f94661f7adf002a418794b5286fe9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Categori_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Categori/Default.cshtml")]
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
#nullable restore
#line 1 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Views\Shared\Components\Categori\Default.cshtml"
using UniCourses.WebUI.ViewComponents;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e76810d539f94661f7adf002a418794b5286fe9a", @"/Views/Shared/Components/Categori/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"431a6833075c7f9cf5d1659ca1d972fd581d750e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Categori_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<UniCourses.Dal.Entities.Category>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "uye", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Courses", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    </UniCourses.WebUI.ViewComponents.Categori>\r\n    <div class=\"courses\">\r\n        <div class=\"tab\">\r\n            <ul class=\"mainmenu\">\r\n                <li>\r\n                    <div class=\"tab\">\r\n");
#nullable restore
#line 9 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Views\Shared\Components\Categori\Default.cshtml"
                         foreach (Category category in Model)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Views\Shared\Components\Categori\Default.cshtml"
                             if (@category.ParentID == null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <button class=\"tablinks bg-warning\" onmouseover=\"openCity(event, \'submenu\')\">");
#nullable restore
#line 13 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Views\Shared\Components\Categori\Default.cshtml"
                                                                                                        Write(category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n");
#nullable restore
#line 14 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Views\Shared\Components\Categori\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <!--  <a asp-area=\"uye\" asp-controller=\"Home\" asp-action=\"Courses\" asp-route-id=\"");
#nullable restore
#line 15 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Views\Shared\Components\Categori\Default.cshtml"
                                                                                                        Write(category.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 15 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Views\Shared\Components\Categori\Default.cshtml"
                                                                                                                      Write(category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> -->\r\n                            <ul class=\"submenu\">\r\n                                <li>\r\n                                    <div id=\"submenu\" class=\"tabcontent\">\r\n");
#nullable restore
#line 19 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Views\Shared\Components\Categori\Default.cshtml"
                                         foreach (Category subcategory in Model)
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Views\Shared\Components\Categori\Default.cshtml"
                                             if (category.Id == subcategory.ParentID)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e76810d539f94661f7adf002a418794b5286fe9a8176", async() => {
#nullable restore
#line 23 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Views\Shared\Components\Categori\Default.cshtml"
                                                                                                                                       Write(subcategory.CategoryName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Views\Shared\Components\Categori\Default.cshtml"
                                                                                                               WriteLiteral(subcategory.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 24 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Views\Shared\Components\Categori\Default.cshtml"
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Views\Shared\Components\Categori\Default.cshtml"
                                             
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </div>
                                    <!--  <a asp-area=""uye"" asp-controller=""Home"" asp-action=""Courses"" asp-route-id=""subcategory.Id"">subcategory.CategoryName</a>-->
                                </li>
                            </ul>
");
#nullable restore
#line 30 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Views\Shared\Components\Categori\Default.cshtml"
                         }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </li>\r\n            </ul>\r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UniCourses.Dal.Entities.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
