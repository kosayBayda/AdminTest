#pragma checksum "C:\Users\ASUS\Desktop\Admin\AdminTestWebApp\AdminTestWebApp\Views\EmployeeAsset\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53eaafa800aa75b9f50ee7936a99e2a5b0b4959e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EmployeeAsset_Index), @"mvc.1.0.view", @"/Views/EmployeeAsset/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53eaafa800aa75b9f50ee7936a99e2a5b0b4959e", @"/Views/EmployeeAsset/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3eae561f075193ba9cbf63dc0c49c519818631c", @"/Views/_ViewImports.cshtml")]
    public class Views_EmployeeAsset_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Shared.ViewModels.EmployeeAssetViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ASUS\Desktop\Admin\AdminTestWebApp\AdminTestWebApp\Views\EmployeeAsset\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminLTE/_Layout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Employees Assets</h1>
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
#line 18 "C:\Users\ASUS\Desktop\Admin\AdminTestWebApp\AdminTestWebApp\Views\EmployeeAsset\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.employeeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                Name\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 24 "C:\Users\ASUS\Desktop\Admin\AdminTestWebApp\AdminTestWebApp\Views\EmployeeAsset\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.assetName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 27 "C:\Users\ASUS\Desktop\Admin\AdminTestWebApp\AdminTestWebApp\Views\EmployeeAsset\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.assetType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th></th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 33 "C:\Users\ASUS\Desktop\Admin\AdminTestWebApp\AdminTestWebApp\Views\EmployeeAsset\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 37 "C:\Users\ASUS\Desktop\Admin\AdminTestWebApp\AdminTestWebApp\Views\EmployeeAsset\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.employeeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 40 "C:\Users\ASUS\Desktop\Admin\AdminTestWebApp\AdminTestWebApp\Views\EmployeeAsset\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.firstName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" &nbsp; ");
#nullable restore
#line 40 "C:\Users\ASUS\Desktop\Admin\AdminTestWebApp\AdminTestWebApp\Views\EmployeeAsset\Index.cshtml"
                                                                                    Write(Html.DisplayFor(modelItem => item.lastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 43 "C:\Users\ASUS\Desktop\Admin\AdminTestWebApp\AdminTestWebApp\Views\EmployeeAsset\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.assetName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 46 "C:\Users\ASUS\Desktop\Admin\AdminTestWebApp\AdminTestWebApp\Views\EmployeeAsset\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.assetType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                \r\n                            </tr>\r\n");
#nullable restore
#line 50 "C:\Users\ASUS\Desktop\Admin\AdminTestWebApp\AdminTestWebApp\Views\EmployeeAsset\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Shared.ViewModels.EmployeeAssetViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
