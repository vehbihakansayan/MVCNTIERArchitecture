#pragma checksum "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Views\Employee\AddEmployee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbd9d98393b1ee00b18c8f8118be3e31fa17fc1e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_AddEmployee), @"mvc.1.0.view", @"/Views/Employee/AddEmployee.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbd9d98393b1ee00b18c8f8118be3e31fa17fc1e", @"/Views/Employee/AddEmployee.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dcedf0f291ae6bffc2fdc4fd77416a1fcae8ca1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Employee_AddEmployee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CountriesForEmployee>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("signup-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row g-3 needs-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"col-lg-12 col-md-12 col-sm-12 col-xs-12\">\r\n    <div class=\"form-element-list\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbd9d98393b1ee00b18c8f8118be3e31fa17fc1e5377", async() => {
                WriteLiteral(@"
            <div class=""row"">
                <div class=""col-md-6"">
                    <label for=""validationCustom01"" class=""form-label"">Adı</label>
                    <input type=""text"" class=""form-control"" id=""validationCustom01"" placeholder=""Ad"" required>
                    <div class=""invalid-feedback"">
                        Lütfen adınızı yazınız.
                    </div>
                </div>
                <div class=""col-md-6"">
                    <label for=""validationCustom02"" class=""form-label"">Soyadı</label>
                    <input type=""text"" class=""form-control"" id=""validationCustom02"" placeholder=""Soyad"" required>
                    <div class=""invalid-feedback"">
                        Lütfen soyadınızı yazınız.
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-6"">
                    <label for=""validationCustom03"" class=""form-label"">İş Tanımı</label>
                    <in");
                WriteLiteral(@"put type=""text"" class=""form-control"" id=""validationCustom03"" placeholder=""Ünvan"" required>
                    <div class=""invalid-feedback"">
                        Lütfen bir iş tanımı seçiniz.
                    </div>
                </div>
                <div class=""col-md-6"">
                    <label for=""validationCustom04"" class=""form-label"">E-Mail</label>
                    <input type=""email"" class=""form-control"" id=""validationCustom04"" placeholder=""email"" required />
                    <div class=""invalid-feedback"">
                        Lütfen bir e-mail adresi seçiniz.
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-6"">
                    <label for=""validationCustom05"" class=""form-label"">Doğum Tarihi</label>
                    <input type=""date"" class=""form-control"" id=""validationCustom05"" required />
                    <div class=""invalid-feedback"">
                        Lütfen b");
                WriteLiteral(@"ir tarih seçiniz.
                    </div>
                </div>
                <div class=""col-md-6"">
                    <label for=""validationCustom06"" class=""form-label"">İşe Giriş Tarihi</label>
                    <input type=""date"" class=""form-control"" id=""validationCustom06"" required />
                    <div class=""invalid-feedback"">
                        Lütfen bir tarih seçiniz.
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-6"">
                    <label for=""validationCustom07"" class=""form-label"">Yönetici</label>
                    <select class=""form-control"" id=""validationCustom07"" required>
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbd9d98393b1ee00b18c8f8118be3e31fa17fc1e8610", async() => {
                    WriteLiteral("Yönetici Seçiniz");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 59 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Views\Employee\AddEmployee.cshtml"
                         foreach (var item in Model.Employees)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbd9d98393b1ee00b18c8f8118be3e31fa17fc1e10830", async() => {
#nullable restore
#line 61 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Views\Employee\AddEmployee.cshtml"
                                                        Write(item.FirstName);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" ");
#nullable restore
#line 61 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Views\Employee\AddEmployee.cshtml"
                                                                        Write(item.LastName);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 61 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Views\Employee\AddEmployee.cshtml"
                               WriteLiteral(item.EmployeeID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 62 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Views\Employee\AddEmployee.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </select>
                    <div class=""invalid-feedback"">
                        Lütfen bir yönetici seçiniz.
                    </div>
                </div>
                <div class=""col-md-6"">
                    <label for=""validationCustom08"" class=""form-label"">Ülke</label>
                    <select class=""form-control"" id=""validationCustom08"" required>
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbd9d98393b1ee00b18c8f8118be3e31fa17fc1e13781", async() => {
                    WriteLiteral("Ülke Seçiniz");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 72 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Views\Employee\AddEmployee.cshtml"
                         foreach (var item in Model.Countries)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbd9d98393b1ee00b18c8f8118be3e31fa17fc1e15675", async() => {
#nullable restore
#line 74 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Views\Employee\AddEmployee.cshtml"
                                                       Write(item.CountryName);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 74 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Views\Employee\AddEmployee.cshtml"
                               WriteLiteral(item.CountryId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 75 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Views\Employee\AddEmployee.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </select>
                    <div class=""invalid-feedback"">
                        Lütfen bir ülke seçiniz.
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-6"">
                    <label for=""validationCustom09"" class=""form-label"">Şehir</label>
                    <select class=""form-control"" id=""validationCustom09"" required disabled>
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbd9d98393b1ee00b18c8f8118be3e31fa17fc1e18363", async() => {
                    WriteLiteral("Önce Ülke Seçiniz");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </select>
                    <div class=""invalid-feedback"">
                        Lütfen bir şehir seçiniz.
                    </div>
                </div>
                <div class=""col-md-6"">
                    <label for=""validationCustom10"" class=""form-label"">Fotoğraf</label>
                    <input type=""file"" class=""form-control"" id=""validationCustom10"" aria-label=""file example"" required>
                    <div class=""invalid-feedback"">Lütfen bir resim dosyası seçiniz</div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-6"">
                    <label for=""validationCustomUsername"" class=""form-label"">Kullanıcı Adı</label>
                    <div class=""input-group has-validation"">
                        <input type=""text"" class=""form-control"" id=""validationCustomUsername"" placeholder=""Kullanıcı Adı"" aria-describedby=""inputGroupPrepend"" required>
                        <div class=""invalid-feedb");
                WriteLiteral(@"ack"">
                            Lütfen bir kullanıcı adı seçiniz.
                        </div>
                    </div>
                </div>
                <div class=""col-md-6"">
                    <label class=""control-label"">Şifre</label>
                    <input type=""password"" class=""form-control"" id=""validationCustom11"" placeholder=""Şifre"" required />
                    <div class=""invalid-feedback"">
                        Lütfen bir şifre belirleyiniz.
                    </div>
                </div>
            </div>
            <div class=""col-12"">
                <div class=""form-check"">
                    <input class=""form-check-input"" type=""checkbox""");
                BeginWriteAttribute("value", " value=\"", 6219, "\"", 6227, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""invalidCheck"" required>
                    <label class=""form-check-label"" for=""invalidCheck"">
                        Koşulları okudum ve kabul ediyorum.
                    </label>
                    <div class=""invalid-feedback"">
                        Onaylamadan önce koşulları kabul etmeniz gerekir.
                    </div>
                </div>
            </div>
            <div class=""col-12"">
                    <button id=""submitButton"" class=""btn btn-primary"" type=""button"">Kaydet</button>
                </div>

        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n");
            DefineSection("AddEmployee", async() => {
                WriteLiteral(@"

    <script>
        $(document).ready(function () {

            $(""#submitButton"").click(function () {

                    var fname = $(""#validationCustom01"").val();
                    var lname = $(""#validationCustom02"").val();
                    var title = $(""#validationCustom03"").val();
                    var email = $(""#validationCustom04"").val();
                    var birthdate = $(""#validationCustom05"").val();
                    var hiredate = $(""#validationCustom06"").val();
                    var manager = $(""#validationCustom07"").val();
                    var country = $(""#validationCustom08"").val();
                    var city = $(""#validationCustom09"").val();
                    var photo = $(""#validationCustom10"").get(0).files[0];
                    var uname = $(""#validationCustomUsername"").val();
                    var password = $(""#validationCustom11"").val();

                    var formData = new FormData();
                    formData.append(""FirstName");
                WriteLiteral(@""", fname);
                    formData.append(""LastName"", lname);
                    formData.append(""Title"", title);
                    formData.append(""BirthDate"", birthdate);
                    formData.append(""HireDate"", hiredate);
                    formData.append(""ReportsTo"", manager);
                    formData.append(""CountryId"", country);
                    formData.append(""CityId"", city);
                    formData.append(""EmployeeImage"", photo);
                    formData.append(""UserName"", uname);
                    formData.append(""Email"", email);
                    formData.append(""Password"", password);

                    $.ajax({
                        url: ""/Employee/AddEmployee"",
                        method: ""post"",
                        contentType: false,
                        processData: false,
                        data: formData,
                        success: function (response) {
                            if (response.result) {
     ");
                WriteLiteral(@"                           Command: toastr[""success""](response.message)

                                toastr.options = {
                                    ""closeButton"": true,
                                    ""debug"": false,
                                    ""newestOnTop"": false,
                                    ""progressBar"": false,
                                    ""positionClass"": ""toast-top-right"",
                                    ""preventDuplicates"": false,
                                    ""onclick"": null,
                                    ""showDuration"": ""300"",
                                    ""hideDuration"": ""1000"",
                                    ""timeOut"": ""5000"",
                                    ""extendedTimeOut"": ""1000"",
                                    ""showEasing"": ""swing"",
                                    ""hideEasing"": ""linear"",
                                    ""showMethod"": ""fadeIn"",
                                    ""hideMethod"": ""fa");
                WriteLiteral(@"deOut""
                                }

                                window.location.href=""/Employee/GetAllEmployees""

                            } else {

                                var rp = response.message.errors
                                for (var i = 0; i < rp.length; i++) {
                                    Command: toastr[""error""](rp[i].message);

                                    toastr.options = {
                                        ""closeButton"": true,
                                        ""debug"": false,
                                        ""newestOnTop"": false,
                                        ""progressBar"": false,
                                        ""positionClass"": ""toast-top-right"",
                                        ""preventDuplicates"": false,
                                        ""onclick"": null,
                                        ""showDuration"": ""300"",
                                        ""hideDuration"": ""1000"",
    ");
                WriteLiteral(@"                                    ""timeOut"": ""5000"",
                                        ""extendedTimeOut"": ""1000"",
                                        ""showEasing"": ""swing"",
                                        ""hideEasing"": ""linear"",
                                        ""showMethod"": ""fadeIn"",
                                        ""hideMethod"": ""fadeOut""
                                    }
                                }
                            }
                        }
                    });
            });


            $(""#validationCustom08"").change(function () {
                var countryId = $(""#validationCustom08"").val();
                if (countryId != """") {
                    $.ajax({

                        url: ""/Employee/GetCitiesByCountry"",
                        method: ""get"",
                        dataType: ""json"",
                        data: { countryId: countryId },
                        success: function (response) {
         ");
                WriteLiteral(@"                   if (response.result) {
                                $(""#validationCustom09"").empty();
                                $(""#validationCustom09"").append(""<option value=''>Bir şehir seçiniz</option>"")

                                for (var i = 0; i < response.cities.length; i++) {
                                    $(""#validationCustom09"").append(""<option value='"" + response.cities[i].cityId + ""'>"" + response.cities[i].cityName + ""</option>"");
                                }
                                $(""#validationCustom09"").removeAttr(""disabled"");
                            }
                        }
                    });

                } else {
                    $(""#validationCustom09"").empty();
                    $(""#validationCustom09"").append(""<option value=''>Önce Ülke Seçiniz</option>"");
                    $(""#validationCustom09"").prop(""disabled"", true);
                }
            });
        });
    </script>


");
            }
            );
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CountriesForEmployee> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
