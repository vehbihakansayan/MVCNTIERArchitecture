using FluentValidation;
using NorthwndCompany.VektorelMVCProject.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VektorelMVCProject.ValidationRules
{
    public class UserInformationValidator : AbstractValidator<UserInformation>
    {
        public UserInformationValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı adı boş bırakılamaz!");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Parola boş bırakılamaz!");
        }
    }
}
