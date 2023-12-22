using FluentValidation;
using ProniaApi.Application.DTOs.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProniaApi.Application.Validators
{
    internal class CreateProductDtoValidator : AbstractValidator<CreateProductDto>
    {
        public CreateProductDtoValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Boş ola bilməz").MaximumLength(100).MinimumLength(3);

            RuleFor(p => p.SKU).NotEmpty().MaximumLength(10);

            RuleFor(p => p.Price).NotEmpty().LessThanOrEqualTo(999999.99m).GreaterThanOrEqualTo(10);

            RuleFor(p => p.Description).MaximumLength(1000);

        }
    }
}
