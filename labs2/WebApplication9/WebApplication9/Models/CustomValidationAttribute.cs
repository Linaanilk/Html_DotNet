using System.ComponentModel.DataAnnotations;

namespace WebApplication9
{
    public class CustomValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string message = value.ToString();
                if (message.Contains("dotnet"))
                {
                    return ValidationResult.Success;
                }

            }
            ErrorMessage = ErrorMessage ?? "Field must contain dotnet keyword";
            return new ValidationResult(ErrorMessage);
        }
    }
}