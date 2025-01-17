#pragma checksum "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d72a8bec3bbc515e3077294f626d71c147aa97a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d72a8bec3bbc515e3077294f626d71c147aa97a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dcedf0f291ae6bffc2fdc4fd77416a1fcae8ca1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModelCategoryProduct>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            DefineSection("HomeIndexCSS", async() => {
                WriteLiteral("\r\n\r\n    <link rel=\"stylesheet\" href=\"https://cdn.datatables.net/1.12.1/css/jquery.dataTables.min.css\" />\r\n    <link rel=\"stylesheet\" href=\"https://cdn.datatables.net/buttons/2.2.3/css/buttons.dataTables.min.css\" />\r\n\r\n");
            }
            );
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <div class=""col-lg-4 col-md-6 col-sm-6 col-xs-12"">
            <div class=""search-engine-int"">
                <div class=""contact-hd search-hd-eg"">
                    <h2>Kategori Listesi</h2>
                    <p>Kategoriler, açıklamaları ve kategorilere ait ürün sayıları</p>
                </div>
                <div class=""search-eg-table"">
                    <table class=""table"">
                        <thead>
                          <tr>
                              <th>Kategori Adı</th>
                              <th>Ürün Sayısı</th>
                          </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 27 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Views\Home\Index.cshtml"
                             foreach (var item in Model.Categories)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 30 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Views\Home\Index.cshtml"
                                   Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br /><span><i>");
#nullable restore
#line 30 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Views\Home\Index.cshtml"
                                                                    Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></span></td>\r\n                                    <td class=\"text-right\"><b>");
#nullable restore
#line 31 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Views\Home\Index.cshtml"
                                                         Write(item.Products.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n                                </tr>\r\n");
#nullable restore
#line 33 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>
            </div>
        </div>
        <div class=""col-lg-8 col-md-6 col-sm-6 col-xs-12"">
            <div class=""search-engine-int sm-res-mg-t-30 tb-res-mg-t-30 tb-res-mg-t-0"">
                <div class=""contact-hd search-hd-eg"">
                    <h2>Ürünler</h2>
                    <p>Ürünlere ilişkin kategori, fiyat ve stok bilgileri</p>
                </div>
                <div class=""search-eg-table"">
                    <table id=""tblProducts"" class=""table"">
                        <thead>
                            <tr>
                                <th>Ürün No</th>
                                <th>Ürün Adı</th>
                                <th>Kategorisi</th>
                                <th>Fiyat</th>
                                <th>Stok</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 57 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Views\Home\Index.cshtml"
                             foreach (var item in Model.Products)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 60 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Views\Home\Index.cshtml"
                                   Write(item.ProductID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 61 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Views\Home\Index.cshtml"
                                   Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 62 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Views\Home\Index.cshtml"
                                   Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 63 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Views\Home\Index.cshtml"
                                   Write(item.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 64 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Views\Home\Index.cshtml"
                                   Write(item.UnitsInStock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 66 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("HomeIndexScript", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $('#tblProducts').DataTable({
                ""language"": {
                    ""url"": ""//cdn.datatables.net/plug-ins/1.12.1/i18n/tr.json""
                }
            });

        });

    </script>

    <script type=""text/javascript"" src=""https://cdn.datatables.net/1.12.1/js/jquery.dataTables.min.js""></script>
    <script type=""text/javascript"" src=""https://cdn.datatables.net/buttons/2.2.3/js/dataTables.buttons.min.js""></script>
    <script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/jszip/3.1.3/jszip.min.js""></script>
    <script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/pdfmake/0.1.53/pdfmake.min.js""></script>
    <script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/pdfmake/0.1.53/vfs_fonts.js""></script>
    <script type=""text/javascript"" src=""https://cdn.datatables.net/buttons/2.2.3/js/buttons.html5.min.js""></script>
    <script type=""text/javascript""");
                WriteLiteral(" src=\"https://cdn.datatables.net/buttons/2.2.3/js/buttons.print.min.js\"></script>\r\n    ");
            }
            );
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewModelCategoryProduct> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
