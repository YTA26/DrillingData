using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YTA.DrillingData.NTier.Entities.Concrete;

namespace YTA.DrillingData.NTier.Business.ValidationRules.FluentValidation
{
    public class DrillCollarValidation:AbstractValidator<DrillCollar>
    {
        public DrillCollarValidation()
        {
            RuleFor(p => p.HoleID).NotEmpty().Length(20);
            RuleFor(p => p.Easting).NotEmpty();
            RuleFor(p => p.Northing).NotEmpty();
            RuleFor(p => p.Geologist).NotEmpty().Length(25);

        }
    }
}
