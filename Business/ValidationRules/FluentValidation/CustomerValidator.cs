using Entity.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.FirstName).NotEmpty().When(c => c.IdentityNumber == "123").WithMessage("İsim boş olamaz");
            RuleFor(c => c.LastName).NotEmpty().WithMessage("Soyisim boş olamaz");
            RuleFor(c => c.IdentityNumber).NotEmpty().WithMessage("Tc kimlik boş olamaz");
            RuleFor(c => c.IdentityNumber).MinimumLength(11).MaximumLength(11).WithMessage("Tc kimlik numarasını doğru giriniz");
            RuleFor(c => c.IdentityNumber).Must(BeEven);
        }

        private bool BeEven(string arg)
        {
            return true;
        }
    }
    public class CustomerValidator1 : AbstractValidator<Customer>
    {
        public CustomerValidator1()
        {
            RuleFor(c => c.FirstName).NotEmpty().When(c => c.IdentityNumber == "123").WithMessage("İsim boş olamaz");
            RuleFor(c => c.LastName).NotEmpty().WithMessage("Soyisim boş olamaz");
            RuleFor(c => c.IdentityNumber).NotEmpty().WithMessage("Tc kimlik boş olamaz");
            RuleFor(c => c.IdentityNumber).MinimumLength(11).MaximumLength(11).WithMessage("Tc kimlik numarasını doğru giriniz");
            RuleFor(c => c.IdentityNumber).Must(BeEven);
        }

        private bool BeEven(string arg)
        {
            return true;
        }
    }
}