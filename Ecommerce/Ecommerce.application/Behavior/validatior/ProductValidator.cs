using Ecommerce.Domain;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.application.Behavior.validatior
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator() {
        RuleFor(x=>x.Name).NotEmpty().WithMessage("please insert product name ");
            RuleFor(x=>x.Description).NotEmpty().WithMessage("please insert product description ");
            RuleFor(x=>x.Category).NotEmpty().WithMessage("please insert Category  ");
        }
    }
}
