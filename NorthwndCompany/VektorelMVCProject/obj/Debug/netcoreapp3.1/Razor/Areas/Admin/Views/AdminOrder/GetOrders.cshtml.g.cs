#pragma checksum "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Areas\Admin\Views\AdminOrder\GetOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee2e3790cdd7c1f199a6cfba338e577af593cc5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminOrder_GetOrders), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminOrder/GetOrders.cshtml")]
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
#line 1 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Areas\Admin\Views\AdminOrder\GetOrders.cshtml"
using NorthwndCompany.VektorelMVCProject.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee2e3790cdd7c1f199a6cfba338e577af593cc5c", @"/Areas/Admin/Views/AdminOrder/GetOrders.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_AdminOrder_GetOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AddOrderDto>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Areas\Admin\Views\AdminOrder\GetOrders.cshtml"
  
    Layout = "/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div>
    <table id=""tblOrders"" class=""table table-bordered table-hover"">
        <thead>
            <tr>
                <th>Sipariş No</th>
                <th>Sipariş Tarihi</th>
                <th>Kargo Firması</th>
                <th>Kargo Ücreti</th>
                <th>Şehir</th>
                <th>Ülke</th>
                <th>Sil</th>
                <th>Güncelle</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 23 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Areas\Admin\Views\AdminOrder\GetOrders.cshtml"
             foreach (var item in Model.Orders)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td id=\"tdOrderId\">");
#nullable restore
#line 26 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Areas\Admin\Views\AdminOrder\GetOrders.cshtml"
                                  Write(item.OrderID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td id=\"tdOrderDate\">");
#nullable restore
#line 27 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Areas\Admin\Views\AdminOrder\GetOrders.cshtml"
                                    Write(item.OrderDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td id=\"tdShipName\">");
#nullable restore
#line 28 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Areas\Admin\Views\AdminOrder\GetOrders.cshtml"
                                   Write(item.ShipName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td id=\"tdFreight\">");
#nullable restore
#line 29 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Areas\Admin\Views\AdminOrder\GetOrders.cshtml"
                                  Write(item.Freight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td id=\"tdShipCity\">");
#nullable restore
#line 30 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Areas\Admin\Views\AdminOrder\GetOrders.cshtml"
                                   Write(item.ShipCity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td id=\"tdShipCountry\">");
#nullable restore
#line 31 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Areas\Admin\Views\AdminOrder\GetOrders.cshtml"
                                      Write(item.ShipCountry);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                    <td><button id=""btnDelete"" class=""btn btn-danger"">Sil</button></td>
                    <td><button id=""btnUpdate"" class=""btn btn-primary"" data-bs-toggle=""modal"" data-bs-target=""#updateOrder"">Güncelle</button></td>
                </tr>
");
#nullable restore
#line 35 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Areas\Admin\Views\AdminOrder\GetOrders.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>
</div>
<button type=""button"" class=""btn btn-info"" data-bs-toggle=""modal"" data-bs-target=""#addOrder"">Yeni Sipariş Ekle</button>
<div class=""modal fade"" id=""addOrder"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Yeni Sipariş Ekleme Formu</h5>
                <button id=""btnx"" type=""button"" class=""btn-close Close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
                <form id=""formOrder"" class=""row g-3 needs-validation"" novalidate>
                    <div class=""mb-3"">
                        <label for=""addOrder01"" class=""form-label"">Müşteri Bilgileri</label>
                        <select name=""CustomerID"" class=""form-select"" id=""addOrder01"" required>
                            <option selected disable");
            WriteLiteral("d");
            BeginWriteAttribute("value", " value=\"", 2382, "\"", 2390, 0);
            EndWriteAttribute();
            WriteLiteral(">Müşteri Seçiniz</option>\r\n");
#nullable restore
#line 53 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Areas\Admin\Views\AdminOrder\GetOrders.cshtml"
                             foreach (var item in Model.Customers)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 2556, "\"", 2580, 1);
#nullable restore
#line 55 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Areas\Admin\Views\AdminOrder\GetOrders.cshtml"
WriteAttributeValue("", 2564, item.CustomerID, 2564, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 55 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Areas\Admin\Views\AdminOrder\GetOrders.cshtml"
                                                            Write(item.ContactName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 56 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Areas\Admin\Views\AdminOrder\GetOrders.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </select>
                        <div class=""invalid-feedback"">
                            Lütfen bir müşteri seçiniz.
                        </div>
                    </div>
                    <div class=""mb-3"">
                        <label for=""addOrder02"" class=""form-label"">Satış Danışmanı</label>
                        <select name=""EmployeeID"" class=""form-select"" id=""addOrder02"" required>
                            <option selected disabled");
            BeginWriteAttribute("value", " value=\"", 3131, "\"", 3139, 0);
            EndWriteAttribute();
            WriteLiteral(">Satış Danışmanı Seçiniz</option>\r\n");
#nullable restore
#line 66 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Areas\Admin\Views\AdminOrder\GetOrders.cshtml"
                             foreach (var item in Model.Employees)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 3313, "\"", 3337, 1);
#nullable restore
#line 68 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Areas\Admin\Views\AdminOrder\GetOrders.cshtml"
WriteAttributeValue("", 3321, item.EmployeeID, 3321, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 68 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Areas\Admin\Views\AdminOrder\GetOrders.cshtml"
                                                            Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 68 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Areas\Admin\Views\AdminOrder\GetOrders.cshtml"
                                                                            Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 69 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Areas\Admin\Views\AdminOrder\GetOrders.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </select>
                        <div class=""invalid-feedback"">
                            Lütfen bir satış danışmanı seçiniz.
                        </div>
                    </div>
                    <div class=""col-md-6"">
                        <label for=""addOrder03"" class=""form-label"">Kargo Firması</label>
                        <input name=""ShipName"" type=""text"" class=""form-control"" id=""addOrder03"" placeholder=""Kargo Firması"" required>
                        <div class=""invalid-feedback"">
                            Lütfen kargo firması seçiniz.
                        </div>
                    </div>
                    <div class=""col-md-6"">
                        <label for=""addOrder04"" class=""form-label"">Soyadı</label>
                        <input name=""Freight"" type=""number"" step="".01"" class=""form-control"" id=""addOrder04"" placeholder=""Kargo Ücreti"" required>
                        <div class=""invalid-feedback"">
                            Lütfen ");
            WriteLiteral(@"kargo ücretini yazınız.
                        </div>
                    </div>
                    <div class=""col-md-6"">
                        <label for=""addOrder05"" class=""form-label"">Ülke</label>
                        <input name=""ShipCountry"" type=""text"" class=""form-control"" id=""addOrder05"" placeholder=""Ülke"" required />
                        <div class=""invalid-feedback"">
                            Lütfen bir ülke seçiniz.
                        </div>
                    </div>
                    <div class=""col-md-6"">
                        <label for=""addOrder06"" class=""form-label"">Şehir</label>
                        <input name=""ShipCity"" type=""text"" class=""form-control"" id=""addOrder06"" placeholder=""Şehir"" required>
                        <div class=""invalid-feedback"">
                            Lütfen bir şehir seçiniz.
                        </div>
                    </div>
                    <div class=""col-md-6"">
                        <label for=""addOrder0");
            WriteLiteral(@"7"" class=""form-label"">Sipariş Tarihi</label>
                        <input name=""OrderDate"" type=""date"" class=""form-control"" id=""addOrder07"" placeholder=""Sipariş Tarihi"" required>
                        <div class=""invalid-feedback"">
                            Lütfen sipariş tarihini seçiniz.
                        </div>
                    </div>
                    <div class=""col-12"">
                        <div class=""form-check"">
                            <input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 5987, "\"", 5995, 0);
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


<div class=""modal fade"" id=""updateOrder"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-h");
            WriteLiteral(@"idden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Sipariş Güncelleme Formu</h5>
                <button id=""btnx"" type=""button"" class=""btn-close CloseUpdate"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
                <form id=""formUpdateOrder"" class=""row g-3 needs-validation updateForm"" novalidate>
                    <div class=""mb-3"">
                        <label for=""updateOrder01"" class=""form-label"">Müşteri Bilgileri</label>
                        <select name=""CustomerID"" class=""form-select"" id=""updateOrder01"" required>
                            <option selected disabled");
            BeginWriteAttribute("value", " value=\"", 7818, "\"", 7826, 0);
            EndWriteAttribute();
            WriteLiteral(">Müşteri Seçiniz</option>\r\n");
#nullable restore
#line 147 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Areas\Admin\Views\AdminOrder\GetOrders.cshtml"
                             foreach (var item in Model.Customers)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 7992, "\"", 8016, 1);
#nullable restore
#line 149 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Areas\Admin\Views\AdminOrder\GetOrders.cshtml"
WriteAttributeValue("", 8000, item.CustomerID, 8000, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 149 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Areas\Admin\Views\AdminOrder\GetOrders.cshtml"
                                                            Write(item.ContactName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 150 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Areas\Admin\Views\AdminOrder\GetOrders.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </select>
                        <div class=""invalid-feedback"">
                            Lütfen bir müşteri seçiniz.
                        </div>
                    </div>
                    <input name=""OrderID"" type=""hidden"" class=""form-control"" id=""updateForOrderID"" />
                    <div class=""mb-3"">
                        <label for=""updateOrder02"" class=""form-label"">Satış Danışmanı</label>
                        <select name=""EmployeeID"" class=""form-select"" id=""updateOrder02"" required>
                            <option selected disabled");
            BeginWriteAttribute("value", " value=\"", 8676, "\"", 8684, 0);
            EndWriteAttribute();
            WriteLiteral(">Satış Danışmanı Seçiniz</option>\r\n");
#nullable restore
#line 161 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Areas\Admin\Views\AdminOrder\GetOrders.cshtml"
                             foreach (var item in Model.Employees)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 8858, "\"", 8882, 1);
#nullable restore
#line 163 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Areas\Admin\Views\AdminOrder\GetOrders.cshtml"
WriteAttributeValue("", 8866, item.EmployeeID, 8866, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 163 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Areas\Admin\Views\AdminOrder\GetOrders.cshtml"
                                                            Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 163 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Areas\Admin\Views\AdminOrder\GetOrders.cshtml"
                                                                            Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 164 "D:\Yazılım\Projeler\Vektorel\APİ&MVC\NorthwndCompany\VektorelMVCProject\Areas\Admin\Views\AdminOrder\GetOrders.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </select>
                        <div class=""invalid-feedback"">
                            Lütfen bir satış danışmanı seçiniz.
                        </div>
                    </div>
                    <div class=""col-md-6"">
                        <label for=""updateOrder03"" class=""form-label"">Kargo Firması</label>
                        <input name=""ShipName"" type=""text"" class=""form-control"" id=""updateOrder03"" placeholder=""Kargo Firması"" required>
                        <div class=""invalid-feedback"">
                            Lütfen kargo firması seçiniz.
                        </div>
                    </div>
                    <div class=""col-md-6"">
                        <label for=""updateOrder04"" class=""form-label"">Kargo Ücreti</label>
                        <input name=""Freight"" type=""number"" step="".01"" class=""form-control"" id=""updateOrder04"" placeholder=""Kargo Ücreti"" required>
                        <div class=""invalid-feedback"">
                 ");
            WriteLiteral(@"           Lütfen kargo ücretini yazınız.
                        </div>
                    </div>
                    <div class=""col-md-6"">
                        <label for=""updateOrder05"" class=""form-label"">Ülke</label>
                        <input name=""ShipCountry"" type=""text"" class=""form-control"" id=""updateOrder05"" placeholder=""Ülke"" required />
                        <div class=""invalid-feedback"">
                            Lütfen bir ülke seçiniz.
                        </div>
                    </div>
                    <div class=""col-md-6"">
                        <label for=""updateOrder06"" class=""form-label"">Şehir</label>
                        <input name=""ShipCity"" type=""text"" class=""form-control"" id=""updateOrder06"" placeholder=""Şehir"" required>
                        <div class=""invalid-feedback"">
                            Lütfen bir şehir seçiniz.
                        </div>
                    </div>
                    <div class=""col-md-6"">
               ");
            WriteLiteral(@"         <label for=""updateOrder07"" class=""form-label"">Sipariş Tarihi</label>
                        <input name=""OrderDate"" type=""date"" class=""form-control"" id=""updateOrder07"" placeholder=""Sipariş Tarihi"" required>
                        <div class=""invalid-feedback"">
                            Lütfen sipariş tarihini seçiniz.
                        </div>
                    </div>
                    <div class=""col-12"">
                        <div class=""form-check"">
                            <input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 11568, "\"", 11576, 0);
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
                            <button id=""updateOrderButton"" class=""btn btn-primary"" type=""submit"">Kaydet</button>
                        </div>
                    </div>
                </form>
            </div>
        </div>
    </div>
</div>


");
            DefineSection("OrderScript", async() => {
                WriteLiteral(@"

    <script>
        $(document).ready(function () {

            $(""#tblOrders"").DataTable({
                ""language"": {
                    ""url"": ""//cdn.datatables.net/plug-ins/1.12.1/i18n/tr.json""
                },
            });

            $(""#submitButton"").click(function () {

                //Fetch form to apply custom Bootstrap validation
                var form = $(""#formOrder"")
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
                $('#addOrder').on('hidden.bs.modal', function () {
                    $(this).find('form').trigger('reset');
                    $(""#formOrder"").removeClass('was-va");
                WriteLiteral(@"lidated');
                });
            }

            $('#formOrder').submit(function (e) {

                var formData = new FormData(this);

                $.ajax({
                    url: '/Admin/AdminOrder/AddOrder',
                    type: ""post"",
                    dataType: ""json"",
                    contentType: ""application/json; charset=utf-8"",
                    data: formData,
                    contentType: false,
                    processData: false,
                    success: function (response) {
                        if (response.result) {

                            var table = $(""#tblOrders"").DataTable();
                            table.row.add([response.neworder.orderID, response.neworder.orderDate, response.neworder.shipName, response.neworder.freight, response.neworder.shipCity, response.neworder.shipCountry, '<button id=""btnDelete"" class=""btn btn-danger"">Sil</button>', '<button id=""btnUpdate"" class=""btn btn-primary"" data-bs-toggle=""modal"" data-");
                WriteLiteral(@"bs-target=""#divUpdateEmployee"">Güncelle</button>']).draw(false);

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
                                ""showMethod"": ""fadeIn"",
                                ""hideMethod"": ");
                WriteLiteral(@"""fadeOut""

                            }

                            $('#addOrder').modal(""hide"");
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
                                ""showEasing"": ""swing"",
                                ""hideEasing"": ");
                WriteLiteral(@"""linear"",
                                ""showMethod"": ""fadeIn"",
                                ""hideMethod"": ""fadeOut""
                            }
                            $('#addOrder').modal(""hide"");
                            clear();
                        }
                    },
                });
                e.preventDefault();
            });

            $(""#updateOrderButton"").click(function () {

                //Fetch form to apply custom Bootstrap validation
                var form = $(""#formUpdateOrder"")
                if (form[0].checkValidity() === false) {
                    event.preventDefault()
                    event.stopPropagation()
                }
                form.addClass('was-validated');
            });

            $(""#tblOrders"").on(""click"", ""#btnUpdate"", function () {

                var row = $(this).closest('tr');
                var orderId = row.find(""#tdOrderId"").text();

                $.ajax({
                    ur");
                WriteLiteral(@"l: ""/Admin/AdminOrder/GetOrderById"",
                    method: ""get"",
                    dataType: ""json"",
                    data: { id: orderId },
                    success: function (response) {
                        $(""#updateOrder01"").val(response.updateorder.customerID);
                        $(""#updateOrder02"").val(response.updateorder.employeeID);
                        $(""#updateOrder03"").val(response.updateorder.shipName);
                        $(""#updateOrder04"").val(response.updateorder.freight);
                        $(""#updateOrder05"").val(response.updateorder.shipCountry);
                        $(""#updateOrder06"").val(response.updateorder.shipCity);
                        $(""#updateOrder07"").val(response.orderdate);
                    }
                });

                $(""#formUpdateOrder"").submit(function () {

                    $(""#updateForOrderID"").val(orderId)
                    var formDataUpdate = new FormData(this);

                    $.aj");
                WriteLiteral(@"ax({
                        url: ""/Admin/AdminOrder/UpdateOrder"",
                        method: ""post"",
                        dataType: ""json"",
                        contentType: ""application/json; charset=utf-8"",
                        data: formDataUpdate,
                        contentType: false,
                        processData: false,
                        success: function (response) {
                            if (response.result) {                                
                                row.find(""#tdOrderDate"").text(response.odt);
                                row.find(""#tdShipName"").text(response.updateOrder.shipName);
                                row.find(""#tdFreight"").text(response.updateOrder.freight);
                                row.find(""#tdShipCity"").text(response.updateOrder.shipCity);
                                row.find(""#tdShipCountry"").text(response.updateOrder.shipCountry);

                                Command: toastr[""success""](re");
                WriteLiteral(@"sponse.message)
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
                                    ""hideMethod"": ""fadeOut""
                                }

             ");
                WriteLiteral(@"                   $('#updateOrder').modal(""hide"");
                                
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
                                    ""hideEasin");
                WriteLiteral(@"g"": ""linear"",
                                    ""showMethod"": ""fadeIn"",
                                    ""hideMethod"": ""fadeOut""
                                }
                            }
                        }


                    })

                });

            });

            $("".CloseUpdate"").click(function () {
                $('#updateOrder').on('hidden.bs.modal', function () {
                    $(""#formUpdateOrder"").removeClass('was-validated');
                });
            });

            $(""#tblOrders"").on(""click"", ""#btnDelete"", function () {
                Swal.fire({
                    title: 'Siparişi silmek istediğinize emin misiniz?',
                    showDenyButton: true,
                    showCancelButton: false,
                    confirmButtonText: 'Sil',
                    denyButtonText: `İptal`,
                }).then((result) => {
                    /* Read more about isConfirmed, isDenied below */
                    if ");
                WriteLiteral(@"(result.isConfirmed) {
                        var row = $(this).closest(""tr"");
                        var orderId = row.find(""#tdOrderId"").text();
                        $.ajax({
                            url: ""/Admin/AdminOrder/DeleteOrder"",
                            method: ""delete"",
                            dataType: ""json"",
                            data: { id: orderId },
                            success: function (response) {
                                if (response.result) {
                                    row.remove();
                                    Command: toastr[""success""](response.message)

                                    toastr.options = {
                                        ""closeButton"": true,
                                        ""debug"": false,
                                        ""newestOnTop"": false,
                                        ""progressBar"": false,
                                        ""positionClass"": ""toast-top-right");
                WriteLiteral(@""",
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
                                    }
                                } else {
                                    Command: toastr[""error""](response.message);

                                    toastr.options = {
                                        ""closeButton"": true,
                                        ""debug"": false,
                                      ");
                WriteLiteral(@"  ""newestOnTop"": false,
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
                                    }
                                }
                            }
                        });
                    };
                });
            });



        });
");
                WriteLiteral("\n\r\n\r\n    </script>\r\n\r\n");
            }
            );
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AddOrderDto> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
