#pragma checksum "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Areas\Admin\Views\AdminCustomer\GetCustomers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65da428ae794da93a6cc2ccbe1662d54d116a4be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminCustomer_GetCustomers), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminCustomer/GetCustomers.cshtml")]
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
#line 1 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Areas\Admin\Views\AdminCustomer\GetCustomers.cshtml"
using NorthwndCompany.VektorelMVCProject.Models.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65da428ae794da93a6cc2ccbe1662d54d116a4be", @"/Areas/Admin/Views/AdminCustomer/GetCustomers.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_AdminCustomer_GetCustomers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Customer>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Areas\Admin\Views\AdminCustomer\GetCustomers.cshtml"
  
    Layout = "/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div>
    <table id=""tblCustomers"" class=""table table-bordered table-hover"">
        <thead>
            <tr>
                <th>Müşteri No</th>
                <th>Şirket Adı</th>
                <th>Şirket Temsilcisi</th>
                <th>Temsilci Ünvanı</th>
                <th>Ülke</th>
                <th>Şehir</th>
                <th>Adres</th>
                <th>Sil</th>
                <th>Güncelle</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 24 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Areas\Admin\Views\AdminCustomer\GetCustomers.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td id=\"tdCustomerId\">");
#nullable restore
#line 27 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Areas\Admin\Views\AdminCustomer\GetCustomers.cshtml"
                                 Write(item.CustomerID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td id=\"tdCompanyName\">");
#nullable restore
#line 28 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Areas\Admin\Views\AdminCustomer\GetCustomers.cshtml"
                                  Write(item.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td id=\"tdContactName\">");
#nullable restore
#line 29 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Areas\Admin\Views\AdminCustomer\GetCustomers.cshtml"
                                  Write(item.ContactName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td id=\"tdContactTitle<\">");
#nullable restore
#line 30 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Areas\Admin\Views\AdminCustomer\GetCustomers.cshtml"
                                    Write(item.ContactTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td id=\"tdCountry\">");
#nullable restore
#line 31 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Areas\Admin\Views\AdminCustomer\GetCustomers.cshtml"
                              Write(item.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td id=\"tdCity\">");
#nullable restore
#line 32 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Areas\Admin\Views\AdminCustomer\GetCustomers.cshtml"
                           Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td id=\"tdAddress\">");
#nullable restore
#line 33 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Areas\Admin\Views\AdminCustomer\GetCustomers.cshtml"
                              Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                <td><button id=""btnDelete"" class=""btn btn-danger"">Sil</button></td>
                <td><button id=""btnUpdate"" class=""btn btn-primary"" data-bs-toggle=""modal"" data-bs-target=""#updateCustomer"">Güncelle</button></td>
            </tr>
");
#nullable restore
#line 37 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Areas\Admin\Views\AdminCustomer\GetCustomers.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>
</div>
<button type=""button"" class=""btn btn-info"" data-bs-toggle=""modal"" data-bs-target=""#addCustomer"">Yeni Müşteri Ekle</button>
<div class=""modal fade"" id=""addCustomer"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Yeni Müşteri Ekleme Formu</h5>
                <button id=""btnx"" type=""button"" class=""btn-close Close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
                <form id=""formCustomer"" class=""row g-3 needs-validation"" novalidate>
                    <div class=""col-md-6"">
                        <label for=""addCustomer00"" class=""form-label"">Müşteri No</label>
                        <input name=""CustomerID"" type=""text"" class=""form-control"" id=""addCustomer00"" placeholder=""Müşteri No"" required>
   ");
            WriteLiteral(@"                     <div class=""invalid-feedback"">
                            Lütfen bir müşteri no giriniz.
                        </div>
                    </div>
                    <div class=""col-md-6"">
                        <label for=""addCustomer01"" class=""form-label"">Şirket Adı</label>
                        <input name=""CompanyName"" type=""text"" class=""form-control"" id=""addCustomer01"" placeholder=""Şirket Adı"" required>
                        <div class=""invalid-feedback"">
                            Lütfen bir şirket adı giriniz.
                        </div>
                    </div>
                    <div class=""col-md-6"">
                        <label for=""addCustomer02"" class=""form-label"">Temsilci Adı</label>
                        <input name=""ContactName"" type=""text"" class=""form-control"" id=""addCustomer02"" placeholder=""Temsilci Adı"" required>
                        <div class=""invalid-feedback"">
                            Lütfen bir temsilci ismi giriniz.
        ");
            WriteLiteral(@"                </div>
                    </div>
                    <div class=""col-md-6"">
                        <label for=""addCustomer03"" class=""form-label"">Temsilci Ünvanı</label>
                        <input name=""ContactTitle"" type=""text"" class=""form-control"" id=""addCustomer03"" placeholder=""Temsilci Ünvanı"" required>
                        <div class=""invalid-feedback"">
                            Lütfen bir ünvan seçiniz.
                        </div>
                    </div>
                    <div class=""col-md-6"">
                        <label for=""addCustomer04"" class=""form-label"">Ülke</label>
                        <input name=""Country"" type=""text"" class=""form-control"" id=""addCustomer04"" placeholder=""Ülke"" required />
                        <div class=""invalid-feedback"">
                            Lütfen bir ülke seçiniz.
                        </div>
                    </div>
                    <div class=""col-md-6"">
                        <label for=""addCustome");
            WriteLiteral(@"r05"" class=""form-label"">Şehir</label>
                        <input name=""City"" type=""text"" class=""form-control"" id=""addCustomer05"" placeholder=""Şehir"" required>
                        <div class=""invalid-feedback"">
                            Lütfen bir şehir seçiniz.
                        </div>
                    </div>
                    <div class=""col-md-6"">
                        <label for=""addCustomer06"" class=""form-label"">Adres</label>
                        <input name=""Address"" type=""text"" class=""form-control"" id=""addCustomer06"" placeholder=""Adres"" required>
                        <div class=""invalid-feedback"">
                            Lütfen bir adres giriniz.
                        </div>
                    </div>
                    <div class=""col-12"">
                        <div class=""form-check"">
                            <input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 5401, "\"", 5409, 0);
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
                        <div class=""modal-footer"">
                            <button type=""button"" class=""btn btn-secondary Close"" data-bs-dismiss=""modal"">Kapat</button>
                            <button id=""submitButton"" class=""btn btn-primary"" type=""submit"">Kaydet</button>
                        </div>
                    </div>
                </form>
            </div>
        </div>
    </div>
</div>


<div class=""modal fade"" id=""updateCustomer"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" ari");
            WriteLiteral(@"a-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Müşteri Güncelleme Formu</h5>
                <button id=""btnx"" type=""button"" class=""btn-close CloseUpdate"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
                <form id=""formUpdateCustomer"" class=""row g-3 needs-validation updateForm"" novalidate>
                    <div class=""col-md-6"">
                        <label for=""updateForCustomerID"" class=""form-label"">Müşteri No</label>
                        <input name=""CustomerID"" type=""text"" class=""form-control"" id=""updateForCustomerID"" placeholder=""Müşteri No"" required/>
                        <div class=""invalid-feedback"">
                            Lütfen bir müşteri no giriniz.
                        </div>
                    </div>
                    
                    <div cla");
            WriteLiteral(@"ss=""col-md-6"">
                        <label for=""updateCustomer01"" class=""form-label"">Şirket Adı</label>
                        <input name=""CompanyName"" type=""text"" class=""form-control"" id=""updateCustomer01"" placeholder=""Şirket Adı"" required>
                        <div class=""invalid-feedback"">
                            Lütfen bir şirket adı giriniz.
                        </div>
                    </div>
                    <div class=""col-md-6"">
                        <label for=""updateCustomer02"" class=""form-label"">Temsilci Adı</label>
                        <input name=""ContactName"" type=""text"" class=""form-control"" id=""updateCustomer02"" placeholder=""Temsilci Adı"" required>
                        <div class=""invalid-feedback"">
                            Lütfen bir temsilci ismi giriniz.
                        </div>
                    </div>
                    <div class=""col-md-6"">
                        <label for=""updateCustomer03"" class=""form-label"">Temsilci Ünvanı</lab");
            WriteLiteral(@"el>
                        <input name=""ContactTitle"" type=""text"" class=""form-control"" id=""updateCustomer03"" placeholder=""Temsilci Ünvanı"" required>
                        <div class=""invalid-feedback"">
                            Lütfen bir ünvan seçiniz.
                        </div>
                    </div>
                    <div class=""col-md-6"">
                        <label for=""updateCustomer04"" class=""form-label"">Ülke</label>
                        <input name=""Country"" type=""text"" class=""form-control"" id=""updateCustomer04"" placeholder=""Ülke"" required />
                        <div class=""invalid-feedback"">
                            Lütfen bir ülke seçiniz.
                        </div>
                    </div>
                    <div class=""col-md-6"">
                        <label for=""updateCustomer05"" class=""form-label"">Şehir</label>
                        <input name=""City"" type=""text"" class=""form-control"" id=""updateCustomer05"" placeholder=""Şehir"" required>
      ");
            WriteLiteral(@"                  <div class=""invalid-feedback"">
                            Lütfen bir şehir seçiniz.
                        </div>
                    </div>
                    <div class=""col-md-6"">
                        <label for=""updateCustomer06"" class=""form-label"">Adres</label>
                        <input name=""Address"" type=""text"" class=""form-control"" id=""updateCustomer06"" placeholder=""Adres"" required>
                        <div class=""invalid-feedback"">
                            Lütfen bir adres giriniz.
                        </div>
                    </div>
                    <div class=""col-12"">
                        <div class=""form-check"">
                            <input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 10273, "\"", 10281, 0);
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
                        <div class=""modal-footer"">
                            <button type=""button"" class=""btn btn-secondary CloseUpdate"" data-bs-dismiss=""modal"">Kapat</button>
                            <button id=""updateCustomerButton"" class=""btn btn-primary"" type=""submit"">Kaydet</button>
                        </div>
                    </div>
                </form>
            </div>
        </div>
    </div>
</div>


");
            DefineSection("CustomerScript", async() => {
                WriteLiteral(@"

    <script>
        $(document).ready(function () {

            $(""#tblCustomers"").DataTable({
                ""language"": {
                    ""url"": ""//cdn.datatables.net/plug-ins/1.12.1/i18n/tr.json""
                },
            });

            $(""#submitButton"").click(function () {

                //Fetch form to apply custom Bootstrap validation
                var form = $(""#formCustomer"")
                if (form[0].checkValidity() === false) {
                    event.preventDefault()
                    event.stopPropagation()
                }
                form.addClass('was-validated');
            });

            $("".Close"").each(function () {
                $(this).click(function () {
                    clear();
                });
            })

            function clear() {
                $('#addCustomer').on('hidden.bs.modal', function () {
                    $(this).find('form').trigger('reset');
                    $(""#formCustomer"").removeC");
                WriteLiteral(@"lass('was-validated');
                });
            }

            $('#formCustomer').submit(function (e) {

                var formData = new FormData(this);

                $.ajax({
                    url: '/Admin/AdminCustomer/AddCustomer',
                    type: ""post"",
                    dataType: ""json"",
                    contentType: ""application/json; charset=utf-8"",
                    data: formData,
                    contentType: false,
                    processData: false,
                    success: function (response) {
                        if (response.result) {

                            var table = $(""#tblCustomers"").DataTable();
                            table.row.add([response.newcustomer.customerID, response.newcustomer.companyName, response.newcustomer.contactName, response.newcustomer.contactTitle, response.newcustomer.country, response.newcustomer.city, response.newcustomer.address, '<button id=""btnDelete"" class=""btn btn-danger"">Sil</button>',");
                WriteLiteral(@" '<button id=""btnUpdate"" class=""btn btn-primary"" data-bs-toggle=""modal"" data-bs-target=""#updateCustomer"">Güncelle</button>']).draw(false);

                            Command: toastr[""success""](response.message)
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
                             ");
                WriteLiteral(@"   ""showMethod"": ""fadeIn"",
                                ""hideMethod"": ""fadeOut""

                            }

                            $('#addCustomer').modal(""hide"");
                            clear();

                        } else {

                            Command: toastr[""error""](response.message);

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
                         ");
                WriteLiteral(@"       ""showEasing"": ""swing"",
                                ""hideEasing"": ""linear"",
                                ""showMethod"": ""fadeIn"",
                                ""hideMethod"": ""fadeOut""
                            }
                            $('#addCustomer').modal(""hide"");
                            clear();
                        }
                    },
                });
                e.preventDefault();
            });

            $(""#updateCustomerButton"").click(function () {

                //Fetch form to apply custom Bootstrap validation
                var form = $(""#formUpdateCustomer"")
                if (form[0].checkValidity() === false) {
                    event.preventDefault()
                    event.stopPropagation()
                }
                form.addClass('was-validated');
            });

            $(""#tblCustomers"").on(""click"", ""#btnUpdate"", function () {

                var row = $(this).closest('tr');
                var cus");
                WriteLiteral(@"tomerId = row.find(""#tdCustomerId"").text();

                $.ajax({
                    url: ""/Admin/AdminCustomer/GetCustomerById"",
                    method: ""get"",
                    dataType: ""json"",
                    data: { id: customerId },
                    success: function (response) {
                        $(""#updateForCustomerID"").val(response.updatecustomer.customerID);
                        $(""#updateCustomer01"").val(response.updatecustomer.companyName);
                        $(""#updateCustomer02"").val(response.updatecustomer.contactName);
                        $(""#updateCustomer03"").val(response.updatecustomer.contactTitle);
                        $(""#updateCustomer04"").val(response.updatecustomer.country);
                        $(""#updateCustomer05"").val(response.updatecustomer.city);
                        $(""#updateCustomer06"").val(response.updatecustomer.address);
                    }
                });

                $(""#formUpdateCustomer"").submit");
                WriteLiteral(@"(function () {

                    var formDataUpdate = new FormData(this);

                    $.ajax({
                        url: ""/Admin/AdminCustomer/UpdateCustomer"",
                        method: ""post"",
                        dataType: ""json"",
                        contentType: ""application/json; charset=utf-8"",
                        data: formDataUpdate,
                        contentType: false,
                        processData: false,
                        success: function (response) {
                            if (response.result) {

                                row.find(""#tdCustomerId"").text(response.updateCustomer.customerID);
                                row.find(""#tdCompanyName"").text(response.updateCustomer.companyName);
                                row.find(""#tdContactName"").text(response.updateCustomer.contactName);
                                row.find(""#tdContactTitle"").text(response.updateCustomer.contactTitle);
                           ");
                WriteLiteral(@"     row.find(""#tdCountry"").text(response.updateCustomer.country);
                                row.find(""#tdCity"").text(response.updateCustomer.city);
                                row.find(""#tdAddress"").text(response.updateCustomer.address);

                                Command: toastr[""success""](response.message)
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
                                    ""exten");
                WriteLiteral(@"dedTimeOut"": ""1000"",
                                    ""showEasing"": ""swing"",
                                    ""hideEasing"": ""linear"",
                                    ""showMethod"": ""fadeIn"",
                                    ""hideMethod"": ""fadeOut""
                                }
                                $('#updateCustomer').modal(""hide"");
                                


                            } else {
                                Command: toastr[""error""](response.message);

                                toastr.options = {
                                    ""closeButton"": true,
                                    ""debug"": false,
                                    ""newestOnTop"": false,
                                    ""progressBar"": false,
                                    ""positionClass"": ""toast-top-right"",
                                    ""preventDuplicates"": false,
                                    ""onclick"": null,
                           ");
                WriteLiteral(@"         ""showDuration"": ""300"",
                                    ""hideDuration"": ""1000"",
                                    ""timeOut"": ""5000"",
                                    ""extendedTimeOut"": ""1000"",
                                    ""showEasing"": ""swing"",
                                    ""hideEasing"": ""linear"",
                                    ""showMethod"": ""fadeIn"",
                                    ""hideMethod"": ""fadeOut""
                                }
                            }
                        }


                    })

                });

            });

            $("".CloseUpdate"").click(function () {
                $('#updateCustomer').on('hidden.bs.modal', function () {
                    $(""#formUpdateCustomer"").removeClass('was-validated');
                });
            });



            $(""#tblCustomers"").on(""click"", ""#btnDelete"", function () {
                Swal.fire({
                    title: 'Siparişi silmek istediğinize");
                WriteLiteral(@" emin misiniz?',
                    showDenyButton: true,
                    showCancelButton: false,
                    confirmButtonText: 'Sil',
                    denyButtonText: `İptal`,
                }).then((result) => {
                    /* Read more about isConfirmed, isDenied below */
                    if (result.isConfirmed) {
                        var row = $(this).closest(""tr"");
                        var customerId = row.find(""#tdCustomerId"").text();
                        $.ajax({
                            url: ""/Admin/AdminCustomer/DeleteCustomer"",
                            method: ""delete"",
                            dataType: ""json"",
                            data: { id: customerId },
                            success: function (response) {
                                if (response.result) {
                                    row.remove();
                                    Command: toastr[""success""](response.message)

                          ");
                WriteLiteral(@"          toastr.options = {
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
                                        ""hideMethod"": ""fadeOut""
                             ");
                WriteLiteral(@"       }
                                } else {
                                    Command: toastr[""error""](response.message);

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
                                        ""hideEasing"": ""linear"",");
                WriteLiteral(@"
                                        ""showMethod"": ""fadeIn"",
                                        ""hideMethod"": ""fadeOut""
                                    }
                                }
                            }
                        });
                    };
                });
            });



        });



    </script>

");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Customer>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
