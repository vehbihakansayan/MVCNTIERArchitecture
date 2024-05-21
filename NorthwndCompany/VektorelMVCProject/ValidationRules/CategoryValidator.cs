using FluentValidation;
using NorthwndCompany.VektorelMVCProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VektorelMVCProject.ValidationRules
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
                RuleFor(c => c.CategoryName)
                    .NotEmpty()
                    .WithMessage("Kategori adı boş bırakılamaz!")
                    .MinimumLength(3)
                    .WithMessage("Kategori adı iki karakterden az olamaz!");

                RuleFor(c => c.Description)
                    .NotEmpty()
                    .WithMessage("Kategori açıklaması boş bırakılamaz!")
                    .MinimumLength(3)
                    .WithMessage("Kategori açıklaması üç karakterden az olamaz");

        }
    }
}
