using FluentValidation;

namespace Business.Utilities
{
    public static class Utility
    {
        /// <summary>
        /// Nesneyi Validator kullanarak doğrulama yapar
        /// </summary>
        /// <param name="validator">IValidator'dan implemente edilmiş validator</param>
        /// <param name="entity">Doğrulanacak entity</param>
        public static void Validate(IValidator validator, object entity)
        {
            var context = new ValidationContext<object>(entity);
            var result = validator.Validate(context);
            if (result.Errors.Count < 0)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}