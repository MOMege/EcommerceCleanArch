using Ecommerce.application.Dtos;
using FluentValidation;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.application.Behavior.validatior
{
    public class CategoryValidator : AbstractValidator<DtoCategory>
    {
        public CategoryValidator() { 
            RuleFor(x => x.Name).NotEmpty().WithMessage("please insert Name of Category")
                .Length(2,9).WithMessage("word lenght between two and nine");
        }
    }
}
