using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YTA.DrillingData.NTier.Business.ValidationRules.FluentValidation
{
    public class ValidatorTool
    {
        public static void FluentValidator(IValidator validator, object entity)
        {
            var result = validator.Validate((IValidationContext)entity);

            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
        }

    }
}
