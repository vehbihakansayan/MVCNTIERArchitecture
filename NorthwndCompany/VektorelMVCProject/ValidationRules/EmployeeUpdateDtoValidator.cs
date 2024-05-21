using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VektorelMVCProject.Models.ViewModels;

namespace VektorelMVCProject.ValidationRules
{
    public class EmployeeUpdateDtoValidator:AbstractValidator<EmployeeUpdateDto>
    {
        public EmployeeUpdateDtoValidator()
        {
            RuleFor(emp=>emp.FirstName).NotEmpty().WithMessage("Personel adı boş bırakılamaz!");
            RuleFor(emp=>emp.LastName).NotEmpty().WithMessage("Personel soyadı boş bırakılamaz!");
            RuleFor(emp=>emp.Title).NotEmpty().WithMessage("Personel ünvanı boş bırakılamaz!");
            RuleFor(emp=>emp.Email).NotEmpty().WithMessage("E-mail adresi boş bırakılamaz!");
            RuleFor(emp=>emp.UserName).NotEmpty().WithMessage("Lütfen bir kullanıcı adı giriniz!");
            RuleFor(emp=>emp.Password).NotEmpty().WithMessage("Lütfen bir şifre giriniz");
            RuleFor(emp=>emp.Password.Length).NotEmpty().LessThanOrEqualTo(5).WithMessage("Şifreniz en fazla 5 karakterden oluşmalıdır!");
        }
    }
}
