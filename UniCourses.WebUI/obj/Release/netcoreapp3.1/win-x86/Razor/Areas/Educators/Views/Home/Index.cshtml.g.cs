#pragma checksum "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Areas\Educators\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fa35a5d86884d96ac54a52c7866cffd38579ba6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Educators_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Educators/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Areas\Educators\Views\_ViewImports.cshtml"
using UniCourses.Dal.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fa35a5d86884d96ac54a52c7866cffd38579ba6", @"/Areas/Educators/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b853c2693020103458b52d8246f923ca3fd89014", @"/Areas/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"444b4cd9ca1f2988814cb16b656851c0413ba2a0", @"/Areas/Educators/Views/_ViewImports.cshtml")]
    public class Areas_Educators_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UniCourses.WebUI.ViewModels.LessonCoursesVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Course", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Areas\Educators\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Educators/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"<!-- Content Wrapper. Contains page content -->
<div class=""content-wrapper"">
    <!-- Content Header (Page header) -->
    <div class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <h1 class=""m-0 text-dark"">Genel</h1>
                </div><!-- /.col -->

            </div><!-- /.row -->
        </div><!-- /.container-fluid -->
    </div>
    <!-- /.content-header -->
    <!-- Main content -->
    <div class=""container-fluid"">
        <!-- Small boxes (Stat box) -->
        <div class=""row"">

            <!-- ./col -->
            <div class=""col-lg-3 col-6"">
                <!-- small box -->
                <div class=""small-box bg-success"">
                    <div class=""inner"">
                        <h3>0<sup style=""font-size: 20px"">₺</sup></h3>

                        <p>Kazanç</p>
                    </div>
                    <div class=""icon"">
                       ");
            WriteLiteral(@" <i class=""ion ion-cash""></i>
                    </div>
                </div>
            </div>
            <!-- ./col -->
            <div class=""col-lg-3 col-6"">
                <!-- small box -->
                <div class=""small-box bg-warning"">
                    <div class=""inner"" style=""color:white;"">
                        <h3>");
#nullable restore
#line 62 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Areas\Educators\Views\Home\Index.cshtml"
                       Write(Model.Educator.TotalStudent);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>

                        <p>Öğrenci</p>
                    </div>
                    <div class=""icon"">
                        <i class=""ion ion-person-add""></i>
                    </div>
                </div>
            </div>

            <div class=""col-lg-3 col-6"">
                <!-- small box -->
                <div class=""small-box bg-info"">
                    <div class=""inner"">
                        <h3>0</h3>

                        <p>Sepete Eklenen</p>
                    </div>
                    <div class=""icon"">
                        <i class=""ion ion-bag""></i>
                    </div>
                </div>
            </div>
            <!-- ./col -->
            <div class=""col-lg-3 col-6"">
                <!-- small box -->
                <div class=""small-box bg-danger"">
                    <div class=""inner"">
                        <h3>0</h3>

                        <p>İstek Listesine Kurs Ekleyen</p>
                    </div>
  ");
            WriteLiteral(@"                  <div class=""icon"">
                        <i class=""ion ion-heart""></i>
                    </div>
                </div>
            </div>
            <!-- ./col -->
        </div>
        <!-- /.row -->
        <!-- Main row -->
        <div class=""row"">
            <!-- Left col -->
");
#nullable restore
#line 105 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Areas\Educators\Views\Home\Index.cshtml"
             foreach (Course course in Model.Coursess)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-md-6 col-lg-4 bg-light"">
                    <!-- Custom tabs (Charts with tabs)-->
                    <div class=""card  d-flex align-items-center justify-content-between"">
                        <div class=""card-header"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8fa35a5d86884d96ac54a52c7866cffd38579ba67536", async() => {
                WriteLiteral("\r\n                                <h3 class=\"card-title\">\r\n                                    <i class=\"fa fa-book mr-1\"></i>\r\n                                    ");
#nullable restore
#line 114 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Areas\Educators\Views\Home\Index.cshtml"
                               Write(course.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </h3> <br />\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 111 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Areas\Educators\Views\Home\Index.cshtml"
                                                     WriteLiteral(course.Id);

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
            WriteLiteral("\r\n                            <p>");
#nullable restore
#line 117 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Areas\Educators\Views\Home\Index.cshtml"
                          Write(course.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <span");
            BeginWriteAttribute("style", " style=\"", 4131, "\"", 4139, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-th-list\"></i>  ");
#nullable restore
#line 118 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Areas\Educators\Views\Home\Index.cshtml"
                                                                     Write(course.Lessons.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Ders </span>\r\n                            <span><i class=\"fa fa-user\"></i>  ");
#nullable restore
#line 119 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Areas\Educators\Views\Home\Index.cshtml"
                                                         Write(course.NumberOfStudent);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Öğrenci</span>\r\n                            <br />\r\n                            <span><i class=\"fa fa-clock-o\"></i> ");
#nullable restore
#line 121 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Areas\Educators\Views\Home\Index.cshtml"
                                                            Write(course.Duration/3600);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Saat ");
#nullable restore
#line 121 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Areas\Educators\Views\Home\Index.cshtml"
                                                                                         Write(course.Duration/60);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Dakika </span>\r\n\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 126 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Areas\Educators\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

        </div>

        <!-- /.card -->
        <!-- /.Left col -->
        <!-- right col (We are only adding the ID to make the widgets sortable)-->
        <section class=""col-lg-5 connectedSortable"">
        </section>

        <!-- right col -->
    </div>
    <!-- /.row (main row) -->
</div><!-- /.container-fluid -->
<!-- /.content -->
<!-- /.content-wrapper -->
<!-- Control Sidebar -->
<aside class=""control-sidebar control-sidebar-dark"">
    <!-- Control sidebar content goes here -->
</aside>
<!-- /.control-sidebar -->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UniCourses.WebUI.ViewModels.LessonCoursesVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
