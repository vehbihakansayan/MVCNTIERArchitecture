#pragma checksum "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Views\Employee\GetAllEmployees.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb264a911ff64c566457765951032f6b87094f70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_GetAllEmployees), @"mvc.1.0.view", @"/Views/Employee/GetAllEmployees.cshtml")]
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
#line 1 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Views\_ViewImports.cshtml"
using NorthwndCompany.VektorelMVCProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Views\_ViewImports.cshtml"
using NorthwndCompany.VektorelMVCProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Views\_ViewImports.cshtml"
using NorthwndCompany.VektorelMVCProject.Models.Abstract;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Views\_ViewImports.cshtml"
using NorthwndCompany.VektorelMVCProject.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Views\_ViewImports.cshtml"
using NorthwndCompany.VektorelMVCProject.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb264a911ff64c566457765951032f6b87094f70", @"/Views/Employee/GetAllEmployees.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dcedf0f291ae6bffc2fdc4fd77416a1fcae8ca1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Employee_GetAllEmployees : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Employee>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:100px;width:100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"container\">\r\n");
#nullable restore
#line 4 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Views\Employee\GetAllEmployees.cshtml"
     foreach (var employee in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-lg-3 col-md-6 col-sm-6 col-xs-12\">\r\n            <div class=\"contact-list\">\r\n                <div class=\"contact-win\">\r\n                    <div class=\"contact-img\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bb264a911ff64c566457765951032f6b87094f705252", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 319, "~/image/employeePhoto/", 319, 22, true);
#nullable restore
#line 10 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Views\Employee\GetAllEmployees.cshtml"
AddHtmlAttributeValue("", 341, employee.PhotoPath, 341, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"conct-sc-ic\">\r\n                        <a class=\"btn waves-effect\"");
            BeginWriteAttribute("href", " href=\"", 530, "\"", 583, 2);
            WriteAttributeValue("", 537, "/Employee/GetByEmployeeId/", 537, 26, true);
#nullable restore
#line 13 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Views\Employee\GetAllEmployees.cshtml"
WriteAttributeValue("", 563, employee.EmployeeID, 563, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"notika-icon notika-next\"></i></a>Detay                        \r\n                    </div>\r\n                </div>\r\n                <div class=\"contact-ctn\">\r\n                    <div class=\"contact-ad-hd\">\r\n                        <h2>");
#nullable restore
#line 18 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Views\Employee\GetAllEmployees.cshtml"
                       Write(employee.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 18 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Views\Employee\GetAllEmployees.cshtml"
                                           Write(employee.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <p class=\"ctn-ads\">");
#nullable restore
#line 19 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Views\Employee\GetAllEmployees.cshtml"
                                      Write(employee.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <p>");
#nullable restore
#line 21 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Views\Employee\GetAllEmployees.cshtml"
                  Write(employee.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p>İşe Başlama Tarihi : ");
#nullable restore
#line 22 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Views\Employee\GetAllEmployees.cshtml"
                                       Write(employee.HireDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"social-st-list\">\r\n                    <div class=\"social-sn\">\r\n                        <h2>E-Mail:</h2>\r\n                        <p>");
#nullable restore
#line 27 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Views\Employee\GetAllEmployees.cshtml"
                      Write(employee.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 32 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Views\Employee\GetAllEmployees.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Employee>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
