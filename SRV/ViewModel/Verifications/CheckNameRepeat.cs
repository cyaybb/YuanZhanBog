using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel.Verifications
{
    class CheckNameRepeat:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value.ToString()=="陈百万")
            {
                var errorMessage = FormatErrorMessage(validationContext.DisplayName);
                return new ValidationResult(ErrorMessage);
            }
            return ValidationResult.Success;
        }
    }
}
