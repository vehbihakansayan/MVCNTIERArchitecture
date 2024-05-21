using FluentValidation;
using NorthwndCompany.VektorelMVCProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwndCompany.VektorelMVCProject.ValidationRules
{
    public class OrderValidator:AbstractValidator<Order>
    {
        public OrderValidator()
        {
            RuleFor(o => o.CustomerID).NotEmpty().WithMessage("Müşteri bilgisi boş bırakılamaz!");
            RuleFor(o => o.EmployeeID).NotEmpty().WithMessage("Satış danışmanı bilgisi boş bırakılamaz!");
            RuleFor(o => o.Freight).GreaterThanOrEqualTo(0).WithMessage("Kargo Ücreti en az sıfır TL olarak seçilebilir!");
            RuleFor(o => o.OrderDate).NotEmpty().WithMessage("Kargo tarihi boş bırakılamaz!");
            RuleFor(o => o.ShipCity).NotEmpty().WithMessage("Şehir adı boş bırakılamaz!");
            RuleFor(o => o.ShipCountry).NotEmpty().WithMessage("Ülke adı boş bırakılamaz!");
        }
    }
}
