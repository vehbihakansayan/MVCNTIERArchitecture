using FluentValidation;
using NorthwndCompany.VektorelMVCProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VektorelMVCProject.ValidationRules
{
    public class CustomerValidator:AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.CompanyName).NotEmpty().WithMessage("Şirket adı boş bırakılamaz!");
            RuleFor(c => c.ContactName).NotEmpty().WithMessage("Şirket temsilcisi boş bırakılamaz!");
        }
    }
}
