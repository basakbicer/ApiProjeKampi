using ApiProjeKampi.WebApi.Entities;
using FluentValidation;

namespace ApiProjeKampi.WebApi.ValidationRules
{
	public class ProductValidator:AbstractValidator<Product>
	{
		public ProductValidator()
		{
			RuleFor(x => x.ProductName).NotEmpty().WithMessage("ürün adını boş geçmeyin");
			RuleFor(x => x.ProductName).MinimumLength(2).WithMessage("en az 2 karakter girişi yapın");
			RuleFor(x => x.ProductName).MaximumLength(50).WithMessage("en fazla 50 karakter");

			RuleFor(x => x.Price).NotEmpty().WithMessage("ürün fiyatı boş geçilemez").GreaterThan(0).WithMessage("ürün fiyhatı negatif olamaz").LessThan(1000).WithMessage("ürün fiyatı bu kadar yüksek olamaz.");

			RuleFor(x => x.ProductDescription).NotEmpty().WithMessage("ürün açıklaması boş geçilemez");
		}
	}
}
