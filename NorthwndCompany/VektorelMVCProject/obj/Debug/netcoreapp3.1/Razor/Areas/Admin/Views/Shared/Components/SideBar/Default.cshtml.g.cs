#pragma checksum "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3f5da3fb14dae6c48da0cd094e3e9a9ca154246"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_Components_SideBar_Default), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/Components/SideBar/Default.cshtml")]
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
#line 1 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"
using NorthwndCompany.VektorelMVCProject.Models.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3f5da3fb14dae6c48da0cd094e3e9a9ca154246", @"/Areas/Admin/Views/Shared/Components/SideBar/Default.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Shared_Components_SideBar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Employee>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<nav id=\"sidebar\">\r\n    <div class=\"p-4 pt-5\">\r\n");
            WriteLiteral("        <img class=\"img logo rounded-circle mb-5\"");
            BeginWriteAttribute("src", " src=\"", 309, "\"", 362, 1);
#nullable restore
#line 7 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"
WriteAttributeValue("", 315, "data:image/png;base64," + Model.Base64Photo, 315, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <h3 style=\"color:white;font-family:\'Times New Roman\', Times, serif;text-align:center\">");
#nullable restore
#line 8 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"
                                                                                         Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 8 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"
                                                                                                          Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
        <ul class=""list-unstyled components mb-5"">
            <li>
                <a href=""#"">Hakkımızda</a>
            </li>
            <li>
                <a href=""/Admin/AdminEmployee/GetEmployees"">Personel</a>
            </li>
            <li>
                <a href=""/Admin/AdminProduct/GetProducts"">Ürünler</a>
            </li>
            <li>
                <a href=""/Admin/AdminOrder/GetOrders"">Siparişler</a>
            </li>
");
            WriteLiteral(@"            <li>
                <a href=""/Admin/AdminCustomer/GetCustomers"">Müşteriler</a>
            </li>
            <li>
                <a href=""/Admin/AdminCategory/CategoryList"">Kategoriler</a>
            </li>
        </ul>

        <div class=""footer"">
            <p>
                <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
                Copyright &copy;
                <script>document.write(new Date().getFullYear());</script> Vektörel Bilişim | Bu sayfa Vektörel Bilişim .Net Core Yazılım Uzmanlığı bitirme projesi olarak <i class=""icon-heart"" aria-hidden=""true""></i> Okan Kantar tarafından yapılmıştır.
                <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
            </p>
        </div>

    </div>
</nav>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Employee> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591