#pragma checksum "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Areas\panel\Views\Comment\CommentList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "133261033b8f2fa3c1740f511475be030cccc388"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_panel_Views_Comment_CommentList), @"mvc.1.0.view", @"/Areas/panel/Views/Comment/CommentList.cshtml")]
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
#line 1 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Areas\panel\Views\_ViewImports.cshtml"
using UniCourses.Dal.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"133261033b8f2fa3c1740f511475be030cccc388", @"/Areas/panel/Views/Comment/CommentList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b853c2693020103458b52d8246f923ca3fd89014", @"/Areas/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53b90faa6661773057164976a6feb5bf5a8ebb06", @"/Areas/panel/Views/_ViewImports.cshtml")]
    public class Areas_panel_Views_Comment_CommentList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ConfirmationCancel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Confirmation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Areas\panel\Views\Comment\CommentList.cshtml"
Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(" List<Comment> \r\n");
#nullable restore
#line 2 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Areas\panel\Views\Comment\CommentList.cshtml"
  
    ViewData["Title"] = "CommentList";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
               <div class=""content-wrapper"">
                   <!-- Content Header (Page header) -->
                   <section class=""content-header"">
                       <div class=""container-fluid"">
                           <div class=""row mb-2"">
                               <div class=""col-sm-6"">
                                   <h1>Yorumlar</h1>
                               </div>
                               <div class=""col-sm-6"">
                                   <ol class=""breadcrumb float-sm-right"">
                                       <li class=""breadcrumb-item"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "133261033b8f2fa3c1740f511475be030cccc3885634", async() => {
                WriteLiteral("Ana Sayfa");
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
            WriteLiteral(@"</li>
                                       <li class=""breadcrumb-item active"">Yorumlar</li>
                                   </ol>
                               </div>
                           </div>
                       </div><!-- /.container-fluid -->
                   </section>

                   <!-- Main content -->
                   <section class=""content"">
                       <div class=""container-fluid"">

                           <!-- /.row -->
                           <div class=""row"">
                               <div class=""col-12"">
                                   <div class=""card"">
                                       <div class=""card-header"">
                                           <h3 class=""card-title"">Onaylanan Yorumlar</h3>

                                           <div class=""card-tools"">
                                               <div class=""input-group input-group-sm"" style=""width: 150px;"">
                                          ");
            WriteLiteral(@"         <input type=""text"" name=""table_search"" class=""form-control float-right"" placeholder=""Search"">

                                                   <div class=""input-group-append"">
                                                       <button type=""submit"" class=""btn btn-default""><i class=""fa fa-search""></i></button>
                                                   </div>
                                               </div>
                                           </div>
                                       </div>
                                       <!-- /.card-header -->
                                       <div class=""card-body table-responsive p-0"">

                                           <table class=""table table-striped projects"">
                                               <thead>
                                                   <tr>
                                                       <th style=""width: 1%"">
                                                  ");
            WriteLiteral(@"         UYE ID
                                                       </th>
                                                       <th style=""width: 39%"">
                                                           UYE ADI
                                                       </th>
                                                       <th style=""width: 20%"">
                                                           KURS ID
                                                       </th>
                                                       <th>
                                                           YORUM
                                                       </th>
                                                       <th style=""width: 20%"" class=""text-center"">
                                                           DURUM
                                                       </th>
                                                       <th style=""width: 20%"">
                            ");
            WriteLiteral("                           </th>\r\n                                                   </tr>\r\n                                               </thead>\r\n                                               <tbody>\r\n");
#nullable restore
#line 72 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Areas\panel\Views\Comment\CommentList.cshtml"
                                                    foreach (Comment comment in Model)
                                                   {
                                                       if (comment.State == true)
                                                       {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                   <tr>\r\n                                                       <td>\r\n                                                           ");
#nullable restore
#line 78 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Areas\panel\Views\Comment\CommentList.cshtml"
                                                      Write(comment.MemberID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                       </td>\r\n\r\n                                                       <td>\r\n                                                           <a>\r\n                                                               ");
#nullable restore
#line 83 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Areas\panel\Views\Comment\CommentList.cshtml"
                                                          Write(comment.MemberName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                           </a>
                                                           <br />
                                                           <small>

                                                           </small>
                                                       </td>



                                                       <td class=""project_progress"">

                                                           <small>
                                                               ");
#nullable restore
#line 96 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Areas\panel\Views\Comment\CommentList.cshtml"
                                                          Write(comment.CourseID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                           </small>\r\n                                                       </td>\r\n\r\n                                                       <td>\r\n                                                           ");
#nullable restore
#line 101 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Areas\panel\Views\Comment\CommentList.cshtml"
                                                      Write(comment.UserComment);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                       </td>

                                                       <td class=""project-state"">
                                                           <span class=""badge badge-success"">Onaylandır</span>
                                                       </td>
                                                       <td class=""project-actions text-right"">
");
            WriteLiteral("                                                           ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "133261033b8f2fa3c1740f511475be030cccc38813729", async() => {
                WriteLiteral(@"
                                                               <i class=""fa fa-blackberry"">
                                                               </i>
                                                               Onay Kaldır
                                                           ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 114 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Areas\panel\Views\Comment\CommentList.cshtml"
                                                                WriteLiteral(comment.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral(@"                                                           <a class=""btn btn-danger btn-sm"" href=""#"">
                                                               <i class=""fa fa-trash"">
                                                               </i>
                                                           </a>
                                                       </td>
                                                   </tr>");
#nullable restore
#line 129 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Areas\panel\Views\Comment\CommentList.cshtml"
                                                        }

                                                   }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                               </tbody>
                                           </table>
                                       </div>
                                       <!-- /.card-body -->
                                   </div>
                                   <!-- /.card -->
                               </div>
                           </div>
                           <!-- /.row -->
                           <div class=""row"">
                               <div class=""col-12"">
                                   <div class=""card"">
                                       <div class=""card-header"">
                                           <h3 class=""card-title"">Onay Bekleyen Yorumlar</h3>

                                           <div class=""card-tools"">
                                               <div class=""input-group input-group-sm"" style=""width: 150px;"">
                                                   <input type=""text"" name=""table_search"" class=""");
            WriteLiteral(@"form-control float-right"" placeholder=""Search"">

                                                   <div class=""input-group-append"">
                                                       <button type=""submit"" class=""btn btn-default""><i class=""fa fa-search""></i></button>
                                                   </div>
                                               </div>
                                           </div>
                                       </div>
                                       <!-- /.card-header -->
                                       <div class=""card-body table-responsive p-0"">

                                           <table class=""table table-striped projects"">
                                               <thead>

                                                   <tr>
                                                       <th style=""width: 1%"">
                                                           UYE ID
                                    ");
            WriteLiteral(@"                   </th>
                                                       <th style=""width: 39%"">
                                                           UYE ADI
                                                       </th>
                                                       <th style=""width: 20%"">
                                                           KURS ID
                                                       </th>
                                                       <th>
                                                           YORUM
                                                       </th>
                                                       <th style=""width: 20%"" class=""text-center"">
                                                           DURUM
                                                       </th>
                                                       <th style=""width: 20%"">
                                                       </th>
                   ");
            WriteLiteral("                                </tr>\r\n                                               </thead>\r\n                                               <tbody>\r\n");
#nullable restore
#line 184 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Areas\panel\Views\Comment\CommentList.cshtml"
                                                    foreach (Comment comment in Model)
                                                   {
                                                       if (comment.State == false)
                                                       {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                   <tr>\r\n                                                       <td>\r\n                                                           ");
#nullable restore
#line 190 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Areas\panel\Views\Comment\CommentList.cshtml"
                                                      Write(comment.MemberID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                       </td>\r\n\r\n                                                       <td>\r\n                                                           <a>\r\n                                                               ");
#nullable restore
#line 195 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Areas\panel\Views\Comment\CommentList.cshtml"
                                                          Write(comment.MemberName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                           </a>
                                                           <br />
                                                           <small>

                                                           </small>
                                                       </td>



                                                       <td class=""project_progress"">

                                                           <small>
                                                               ");
#nullable restore
#line 208 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Areas\panel\Views\Comment\CommentList.cshtml"
                                                          Write(comment.CourseID);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                           </small>
                                                       </td>
                                                       
                                                       <td>
                                                           ");
#nullable restore
#line 213 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Areas\panel\Views\Comment\CommentList.cshtml"
                                                      Write(comment.UserComment);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                       </td>

                                                       <td class=""project-state"">
                                                           <span class=""badge badge-success"">Onay Bekliyor</span>
                                                       </td>
                                                       <td class=""project-actions text-right"">
");
            WriteLiteral("                                                           ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "133261033b8f2fa3c1740f511475be030cccc38824066", async() => {
                WriteLiteral(@"
                                                               <i class=""fa fa-blackberry"">
                                                               </i>
                                                               Onayla
                                                           ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 226 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Areas\panel\Views\Comment\CommentList.cshtml"
                                                                WriteLiteral(comment.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral(@"                                                           <a class=""btn btn-danger btn-sm"" href=""#"">
                                                               <i class=""fa fa-trash"">
                                                               </i>
                                                           </a>
                                                       </td>
                                                   </tr>
");
#nullable restore
#line 242 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Areas\panel\Views\Comment\CommentList.cshtml"
}

                                                   }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                               </tbody>
                                           </table>


                                       </div>
                                       <!-- /.card-body -->
                                   </div>
                                   <!-- /.card -->
                               </div>
                           </div>
                           <!-- /.row -->
                       </div><!-- /.container-fluid -->
                   </section>
                   <!-- /.content -->
               </div>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
