#pragma checksum "C:\Users\ASUS\Desktop\Admin\AdminTestWebApp\AdminTestWebApp\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1907cc1a6a815292d857978c3fe8a626a0b72a0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
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
#line 1 "C:\Users\ASUS\Desktop\Admin\AdminTestWebApp\AdminTestWebApp\Views\_ViewImports.cshtml"
using AdminTestWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\Admin\AdminTestWebApp\AdminTestWebApp\Views\_ViewImports.cshtml"
using AdminTestWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1907cc1a6a815292d857978c3fe8a626a0b72a0d", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3eae561f075193ba9cbf63dc0c49c519818631c", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Shared.ViewModels.EmployeeViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ASUS\Desktop\Admin\AdminTestWebApp\AdminTestWebApp\Views\Employee\Index.cshtml"
  
    ViewData["Title"] = "Departments";
    Layout = "~/Views/Shared/AdminLTE/_Layout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Employees</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1907cc1a6a815292d857978c3fe8a626a0b72a0d3789", async() => {
                WriteLiteral("Create New");
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
            WriteLiteral(@"
</p>
<!-- /.row -->
<div class=""row"">
    <div class=""col-12"">
        <div class=""card"">
            <div class=""table table-hover text-nowrap"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th>
                                ");
#nullable restore
#line 22 "C:\Users\ASUS\Desktop\Admin\AdminTestWebApp\AdminTestWebApp\Views\Employee\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 25 "C:\Users\ASUS\Desktop\Admin\AdminTestWebApp\AdminTestWebApp\Views\Employee\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.firstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 28 "C:\Users\ASUS\Desktop\Admin\AdminTestWebApp\AdminTestWebApp\Views\Employee\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.lastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            \r\n                            <th>\r\n                                ");
#nullable restore
#line 32 "C:\Users\ASUS\Desktop\Admin\AdminTestWebApp\AdminTestWebApp\Views\Employee\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.departmentName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 35 "C:\Users\ASUS\Desktop\Admin\AdminTestWebApp\AdminTestWebApp\Views\Employee\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.createdAt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th></th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 41 "C:\Users\ASUS\Desktop\Admin\AdminTestWebApp\AdminTestWebApp\Views\Employee\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 45 "C:\Users\ASUS\Desktop\Admin\AdminTestWebApp\AdminTestWebApp\Views\Employee\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 48 "C:\Users\ASUS\Desktop\Admin\AdminTestWebApp\AdminTestWebApp\Views\Employee\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.firstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 51 "C:\Users\ASUS\Desktop\Admin\AdminTestWebApp\AdminTestWebApp\Views\Employee\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.lastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 54 "C:\Users\ASUS\Desktop\Admin\AdminTestWebApp\AdminTestWebApp\Views\Employee\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.departmentName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                               \r\n                                <td>\r\n                                    ");
#nullable restore
#line 58 "C:\Users\ASUS\Desktop\Admin\AdminTestWebApp\AdminTestWebApp\Views\Employee\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.createdAt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                \r\n                            </tr>\r\n");
#nullable restore
#line 62 "C:\Users\ASUS\Desktop\Admin\AdminTestWebApp\AdminTestWebApp\Views\Employee\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n            <!-- /.card-body -->\r\n        </div>\r\n        <!-- /.card -->\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Shared.ViewModels.EmployeeViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591