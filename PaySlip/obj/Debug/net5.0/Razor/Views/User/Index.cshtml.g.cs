#pragma checksum "C:\Users\Admin\docs\.NET Core\Payslip\PaySlip\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9556f34b58a6554475d9ca968b9c67d7510f2693"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
#line 1 "C:\Users\Admin\docs\.NET Core\Payslip\PaySlip\Views\_ViewImports.cshtml"
using PaySlip;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\docs\.NET Core\Payslip\PaySlip\Views\_ViewImports.cshtml"
using PaySlip.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9556f34b58a6554475d9ca968b9c67d7510f2693", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3d32c2785e93088fd2263eeef68634e615cfeb5", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BusinessLayer.User>>
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
#line 3 "C:\Users\Admin\docs\.NET Core\Payslip\PaySlip\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_ListLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9556f34b58a6554475d9ca968b9c67d7510f26933663", async() => {
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
            WriteLiteral("\r\n</p>\r\n<style>\r\n    .trash {\r\n        color: red;\r\n    }\r\n</style>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\Admin\docs\.NET Core\Payslip\PaySlip\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\Admin\docs\.NET Core\Payslip\PaySlip\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\Admin\docs\.NET Core\Payslip\PaySlip\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Designation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\Admin\docs\.NET Core\Payslip\PaySlip\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "C:\Users\Admin\docs\.NET Core\Payslip\PaySlip\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "C:\Users\Admin\docs\.NET Core\Payslip\PaySlip\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DOB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 41 "C:\Users\Admin\docs\.NET Core\Payslip\PaySlip\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DOJ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 44 "C:\Users\Admin\docs\.NET Core\Payslip\PaySlip\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 50 "C:\Users\Admin\docs\.NET Core\Payslip\PaySlip\Views\User\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 54 "C:\Users\Admin\docs\.NET Core\Payslip\PaySlip\Views\User\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 57 "C:\Users\Admin\docs\.NET Core\Payslip\PaySlip\Views\User\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 60 "C:\Users\Admin\docs\.NET Core\Payslip\PaySlip\Views\User\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Designation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 63 "C:\Users\Admin\docs\.NET Core\Payslip\PaySlip\Views\User\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 66 "C:\Users\Admin\docs\.NET Core\Payslip\PaySlip\Views\User\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 69 "C:\Users\Admin\docs\.NET Core\Payslip\PaySlip\Views\User\Index.cshtml"
               Write(item.DOB.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 73 "C:\Users\Admin\docs\.NET Core\Payslip\PaySlip\Views\User\Index.cshtml"
               Write(item.DOJ.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 77 "C:\Users\Admin\docs\.NET Core\Payslip\PaySlip\Views\User\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    <span>\r\n                        ");
#nullable restore
#line 82 "C:\Users\Admin\docs\.NET Core\Payslip\PaySlip\Views\User\Index.cshtml"
                   Write(Html.ActionLink("", "Edit", new { id = item.ID }, new { @class = "fa fa-edit" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 83 "C:\Users\Admin\docs\.NET Core\Payslip\PaySlip\Views\User\Index.cshtml"
                   Write(Html.ActionLink("", "Details", new { id = item.ID }, new { @class = "fa fa-eye" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 84 "C:\Users\Admin\docs\.NET Core\Payslip\PaySlip\Views\User\Index.cshtml"
                   Write(Html.ActionLink("", "Delete", new { id = item.ID }, new { @class = "fa fa-trash trash" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </span>\r\n\r\n                </td>\r\n                <td>\r\n                    <span>\r\n                        ");
#nullable restore
#line 90 "C:\Users\Admin\docs\.NET Core\Payslip\PaySlip\Views\User\Index.cshtml"
                   Write(Html.ActionLink("Add", "AddSalary", new { id = item.ID, userType = item.UserType }, new {@class ="fas fa-dollar-sign"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </span>\r\n                </td>\r\n                <td>\r\n                    <span>\r\n                        ");
#nullable restore
#line 95 "C:\Users\Admin\docs\.NET Core\Payslip\PaySlip\Views\User\Index.cshtml"
                   Write(Html.ActionLink("Edit", "EditSalary", new { id = item.ID, userType = item.UserType }, new { @class = "fas fa-dollar-sign" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </span>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 99 "C:\Users\Admin\docs\.NET Core\Payslip\PaySlip\Views\User\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BusinessLayer.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
