using FluentValidation;
using NorthwndCompany.VektorelMVCProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VektorelMVCProject.ValidationRules
{
    public class EmployeeValidator:AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(e => e.FirstName).NotEmpty().WithMessage("Personel adı boş bırakılamaz!");
            RuleFor(e => e.LastName).NotEmpty().WithMessage("Personel soyadı boş bırakılamaz!");
            RuleFor(e => e.Title).NotEmpty().WithMessage("Personel ünvanı boş bırakılamaz!");
            RuleFor(e => e.Email).NotEmpty().WithMessage("E-mail adresi boş bırakılamaz!");
            RuleFor(e => e.EmployeeImage).NotEmpty().WithMessage("Lütfen bir fotoğraf yükleyiniz!");
            RuleFor(e => e.EmployeeImage.Length).NotNull().LessThanOrEqualTo(1024000).WithMessage("Resmin boyutu 100 KB'dan büyük olamaz!");
            RuleFor(e => e.EmployeeImage.ContentType).NotNull().Must(e => e.Equals("image/jpeg") || e.Equals("image/jpg") || e.Equals("image/png")).WithMessage("Lütfen bir resim doyası seçiniz!");
            RuleFor(e => e.UserName).NotEmpty().WithMessage("Lütfen bir kullanıcı adı giriniz!");
            RuleFor(e => e.Password).NotEmpty().WithMessage("Lütfen bir şifre giriniz");
            RuleFor(e => e.Password.Length).NotEmpty().LessThanOrEqualTo(5).WithMessage("Şifreniz en fazla 5 karakterden oluşmalıdır!");
        }
    }
}
