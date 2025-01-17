#pragma checksum "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Views\Employee\OrganizationalChart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c4d852f25440d9dd05f0f1c9ece52bc8959086e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_OrganizationalChart), @"mvc.1.0.view", @"/Views/Employee/OrganizationalChart.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c4d852f25440d9dd05f0f1c9ece52bc8959086e", @"/Views/Employee/OrganizationalChart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dcedf0f291ae6bffc2fdc4fd77416a1fcae8ca1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Employee_OrganizationalChart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("OrganizationalChart", async() => {
                WriteLiteral(@"

    <style>

        :root {
            --level-1: #8dccad;
            --level-2: #f5cc7f;
            --level-3: #7b9fe0;
            --level-4: #f27c8d;
            --black: black;
        }

        * {
            padding: 0;
            margin: 0;
            box-sizing: border-box;
        }

        ol {
            list-style: none;
        }

        body {
            margin: 50px 0 100px;
            text-align: center;
            font-family: ""Inter"", sans-serif;
        }

        .container {
            max-width: 1000px;
            padding: 0 10px;
            margin: 0 auto;
        }

        .rectangle {
            position: relative;
            padding: 20px;
            box-shadow: 0 5px 15px rgba(0, 0, 0, 0.15);
        }


        /* LEVEL-1 STYLES
        –––––––––––––––––––––––––––––––––––––––––––––––––– */
        .level-1 {
            width: 50%;
            margin: 0 auto 40px;
            background: var(--level-1);
        }");
                WriteLiteral(@"

            .level-1::before {
                content: """";
                position: absolute;
                top: 100%;
                left: 50%;
                transform: translateX(-50%);
                width: 2px;
                height: 20px;
                background: var(--black);
            }


        /* LEVEL-2 STYLES
        –––––––––––––––––––––––––––––––––––––––––––––––––– */
        .level-2-wrapper {
            position: relative;
            display: grid;
            grid-template-columns: repeat(2, 1fr);
        }

            .level-2-wrapper::before {
                content: """";
                position: absolute;
                top: -20px;
                left: 25%;
                width: 50%;
                height: 2px;
                background: var(--black);
            }

            .level-2-wrapper::after {
                display: none;
                content: """";
                position: absolute;
                left: -20px;
  ");
                WriteLiteral(@"              bottom: -20px;
                width: calc(100% + 20px);
                height: 2px;
                background: var(--black);
            }

            .level-2-wrapper li {
                position: relative;
            }

            .level-2-wrapper > li::before {
                content: """";
                position: absolute;
                bottom: 100%;
                left: 50%;
                transform: translateX(-50%);
                width: 2px;
                height: 20px;
                background: var(--black);
            }

        .level-2 {
            width: 70%;
            margin: 0 auto 40px;
            background: var(--level-2);
        }

            .level-2::before {
                content: """";
                position: absolute;
                top: 100%;
                left: 50%;
                transform: translateX(-50%);
                width: 2px;
                height: 20px;
                background: var(--black);");
                WriteLiteral(@"
            }

            .level-2::after {
                display: none;
                content: """";
                position: absolute;
                top: 50%;
                left: 0%;
                transform: translate(-100%, -50%);
                width: 20px;
                height: 2px;
                background: var(--black);
            }


        /* LEVEL-3 STYLES
        –––––––––––––––––––––––––––––––––––––––––––––––––– */
        .level-3-wrapper {
            position: relative;
            display: grid;
            grid-template-columns: repeat(2, 1fr);
            grid-column-gap: 20px;
            width: 90%;
            margin: 0 auto;
        }

            .level-3-wrapper::before {
                content: """";
                position: absolute;
                top: -20px;
                left: calc(25% - 5px);
                width: calc(50% + 10px);
                height: 2px;
                background: var(--black);
            }

     ");
                WriteLiteral(@"       .level-3-wrapper > li::before {
                content: """";
                position: absolute;
                top: 0;
                left: 50%;
                transform: translate(-50%, -100%);
                width: 2px;
                height: 20px;
                background: var(--black);
            }

        .level-3 {
            margin-bottom: 20px;
            background: var(--level-3);
        }


        /* LEVEL-4 STYLES
        –––––––––––––––––––––––––––––––––––––––––––––––––– */
        .level-4-wrapper {
            position: relative;
            width: 80%;
            margin-left: auto;
        }

            .level-4-wrapper::before {
                content: """";
                position: absolute;
                top: -20px;
                left: -20px;
                width: 2px;
                height: calc(100% + 20px);
                background: var(--black);
            }

            .level-4-wrapper li + li {
                margin");
                WriteLiteral(@"-top: 20px;
            }

        .level-4 {
            font-weight: normal;
            background: var(--level-4);
        }

            .level-4::before {
                content: """";
                position: absolute;
                top: 50%;
                left: 0%;
                transform: translate(-100%, -50%);
                width: 20px;
                height: 2px;
                background: var(--black);
            }

        /* FOOTER
        –––––––––––––––––––––––––––––––––––––––––––––––––– */
        .page-footer {
            position: fixed;
            right: 0;
            bottom: 20px;
            display: flex;
            align-items: center;
            padding: 5px;
        }

            .page-footer a {
                margin-left: 4px;
            }
    </style>
");
            }
            );
            WriteLiteral(@"
<div class=""container"">
    <h1 class=""level-1 rectangle"">Andrew Fuller</h1>
    <ol class=""level-2-wrapper"">
        <li>
            <h2 class=""level-2 rectangle"">Nancy Davolio</h2>
            <ol class=""level-3-wrapper"">
                <li>
                    <h3 class=""level-3 rectangle"">Stewart Janet</h3>
                    <ol class=""level-4-wrapper"">
                        <li>
                            <h4 class=""level-4 rectangle"">Jach Wilshere</h4>
                        </li>
                        <li>
                            <h4 class=""level-4 rectangle"">Harry Maquire</h4>
                        </li>
                        <li>
                            <h4 class=""level-4 rectangle"">Stewen Caulker</h4>
                        </li>
                        <li>
                            <h4 class=""level-4 rectangle"">Ascley Coole</h4>
                        </li>
                    </ol>
                </li>
                <li>
                    <");
            WriteLiteral(@"h3 class=""level-3 rectangle"">Maya Sophia</h3>
                    <ol class=""level-4-wrapper"">
                        <li>
                            <h4 class=""level-4 rectangle"">Henry Onyekuru</h4>
                        </li>
                        <li>
                            <h4 class=""level-4 rectangle"">Roman Sallai</h4>
                        </li>
                        <li>
                            <h4 class=""level-4 rectangle"">Andrea Cheva</h4>
                        </li>
                        <li>
                            <h4 class=""level-4 rectangle"">Fleuquen Peres</h4>
                        </li>
                    </ol>
                </li>
            </ol>
        </li>
        <li>
            <h2 class=""level-2 rectangle"">Michael Suyuma</h2>
            <ol class=""level-3-wrapper"">
                <li>
                    <h3 class=""level-3 rectangle"">Koma Babacar</h3>
                    <ol class=""level-4-wrapper"">
                        <li");
            WriteLiteral(@">
                            <h4 class=""level-4 rectangle"">Anthony Ceasar</h4>
                        </li>
                        <li>
                            <h4 class=""level-4 rectangle"">Kevin DeBruyne</h4>
                        </li>
                        <li>
                            <h4 class=""level-4 rectangle"">Henry Ford</h4>
                        </li>
                        <li>
                            <h4 class=""level-4 rectangle"">Larvin Kurzawa</h4>
                        </li>
                    </ol>
                </li>
                <li>
                    <h3 class=""level-3 rectangle"">Robert King</h3>
                    <ol class=""level-4-wrapper"">
                        <li>
                            <h4 class=""level-4 rectangle"">Jonathan Lerma</h4>
                        </li>
                        <li>
                            <h4 class=""level-4 rectangle"">Patrick Vieria</h4>
                        </li>
                        <");
            WriteLiteral(@"li>
                            <h4 class=""level-4 rectangle"">Jeferson Farfan</h4>
                        </li>
                        <li>
                            <h4 class=""level-4 rectangle"">John Snow</h4>
                        </li>
                    </ol>
                </li>
            </ol>
        </li>
    </ol>
</div>

<footer class=""page-footer"">
    <span>made by </span>
    <a href=""https://georgemartsoukos.com/"" target=""_blank"">
        <img width=""24"" height=""24"" src=""https://assets.codepen.io/162656/george-martsoukos-small-logo.svg"" alt=""George Martsoukos logo"">
    </a>
</footer>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
