#pragma checksum "C:\Users\dcloc\Desktop\Daniel\Skola\Webbutvecklare inom .NET\ASP.NET MVC\Inlämningsuppgifter\Inlamningsuppgift1_ASP.NETMVCDanArv\Inlamningsuppgift1_ASP.NETMVC\Views\Classes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d330913a77dc1ef6617d85eb7d628b1b03bd313"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Classes_Details), @"mvc.1.0.view", @"/Views/Classes/Details.cshtml")]
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
#line 1 "C:\Users\dcloc\Desktop\Daniel\Skola\Webbutvecklare inom .NET\ASP.NET MVC\Inlämningsuppgifter\Inlamningsuppgift1_ASP.NETMVCDanArv\Inlamningsuppgift1_ASP.NETMVC\Views\_ViewImports.cshtml"
using Inlamningsuppgift1_ASP.NETMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dcloc\Desktop\Daniel\Skola\Webbutvecklare inom .NET\ASP.NET MVC\Inlämningsuppgifter\Inlamningsuppgift1_ASP.NETMVCDanArv\Inlamningsuppgift1_ASP.NETMVC\Views\_ViewImports.cshtml"
using Inlamningsuppgift1_ASP.NETMVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dcloc\Desktop\Daniel\Skola\Webbutvecklare inom .NET\ASP.NET MVC\Inlämningsuppgifter\Inlamningsuppgift1_ASP.NETMVCDanArv\Inlamningsuppgift1_ASP.NETMVC\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dcloc\Desktop\Daniel\Skola\Webbutvecklare inom .NET\ASP.NET MVC\Inlämningsuppgifter\Inlamningsuppgift1_ASP.NETMVCDanArv\Inlamningsuppgift1_ASP.NETMVC\Views\_ViewImports.cshtml"
using Inlamningsuppgift1_ASP.NETMVC.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dcloc\Desktop\Daniel\Skola\Webbutvecklare inom .NET\ASP.NET MVC\Inlämningsuppgifter\Inlamningsuppgift1_ASP.NETMVCDanArv\Inlamningsuppgift1_ASP.NETMVC\Views\_ViewImports.cshtml"
using Inlamningsuppgift1_ASP.NETMVC.Areas.Identity.Pages.Account.Manage;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d330913a77dc1ef6617d85eb7d628b1b03bd313", @"/Views/Classes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c130109a3dd7ab8c2f0c6286514e16bdf8d395d", @"/Views/_ViewImports.cshtml")]
    public class Views_Classes_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewClassModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\dcloc\Desktop\Daniel\Skola\Webbutvecklare inom .NET\ASP.NET MVC\Inlämningsuppgifter\Inlamningsuppgift1_ASP.NETMVCDanArv\Inlamningsuppgift1_ASP.NETMVC\Views\Classes\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Details</h1>\r\n<div>\r\n    <h5>");
#nullable restore
#line 8 "C:\Users\dcloc\Desktop\Daniel\Skola\Webbutvecklare inom .NET\ASP.NET MVC\Inlämningsuppgifter\Inlamningsuppgift1_ASP.NETMVCDanArv\Inlamningsuppgift1_ASP.NETMVC\Views\Classes\Details.cshtml"
   Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>Teacher</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 16 "C:\Users\dcloc\Desktop\Daniel\Skola\Webbutvecklare inom .NET\ASP.NET MVC\Inlämningsuppgifter\Inlamningsuppgift1_ASP.NETMVCDanArv\Inlamningsuppgift1_ASP.NETMVC\Views\Classes\Details.cshtml"
             if (Model.Teacher != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 20 "C:\Users\dcloc\Desktop\Daniel\Skola\Webbutvecklare inom .NET\ASP.NET MVC\Inlämningsuppgifter\Inlamningsuppgift1_ASP.NETMVCDanArv\Inlamningsuppgift1_ASP.NETMVC\Views\Classes\Details.cshtml"
                   Write(Model.Teacher.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 23 "C:\Users\dcloc\Desktop\Daniel\Skola\Webbutvecklare inom .NET\ASP.NET MVC\Inlämningsuppgifter\Inlamningsuppgift1_ASP.NETMVCDanArv\Inlamningsuppgift1_ASP.NETMVC\Views\Classes\Details.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        No teacher found\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 31 "C:\Users\dcloc\Desktop\Daniel\Skola\Webbutvecklare inom .NET\ASP.NET MVC\Inlämningsuppgifter\Inlamningsuppgift1_ASP.NETMVCDanArv\Inlamningsuppgift1_ASP.NETMVC\Views\Classes\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>Students</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 41 "C:\Users\dcloc\Desktop\Daniel\Skola\Webbutvecklare inom .NET\ASP.NET MVC\Inlämningsuppgifter\Inlamningsuppgift1_ASP.NETMVCDanArv\Inlamningsuppgift1_ASP.NETMVC\Views\Classes\Details.cshtml"
             if (!Model.Students.Any())
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        No students found\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 48 "C:\Users\dcloc\Desktop\Daniel\Skola\Webbutvecklare inom .NET\ASP.NET MVC\Inlämningsuppgifter\Inlamningsuppgift1_ASP.NETMVCDanArv\Inlamningsuppgift1_ASP.NETMVC\Views\Classes\Details.cshtml"
            }
            else
            {
                foreach(var student in Model.Students)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 55 "C:\Users\dcloc\Desktop\Daniel\Skola\Webbutvecklare inom .NET\ASP.NET MVC\Inlämningsuppgifter\Inlamningsuppgift1_ASP.NETMVCDanArv\Inlamningsuppgift1_ASP.NETMVC\Views\Classes\Details.cshtml"
                   Write(student.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        \r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 59 "C:\Users\dcloc\Desktop\Daniel\Skola\Webbutvecklare inom .NET\ASP.NET MVC\Inlämningsuppgifter\Inlamningsuppgift1_ASP.NETMVCDanArv\Inlamningsuppgift1_ASP.NETMVC\Views\Classes\Details.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n    <div class=\"d-flex justify-content-center text-center\">\r\n        <div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d330913a77dc1ef6617d85eb7d628b1b03bd3139677", async() => {
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
#line 70 "C:\Users\dcloc\Desktop\Daniel\Skola\Webbutvecklare inom .NET\ASP.NET MVC\Inlämningsuppgifter\Inlamningsuppgift1_ASP.NETMVCDanArv\Inlamningsuppgift1_ASP.NETMVC\Views\Classes\Details.cshtml"
                           WriteLiteral(Model.Id);

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
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d330913a77dc1ef6617d85eb7d628b1b03bd31311886", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewClassModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
