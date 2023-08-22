using FluentValidation;

namespace TheWildNature.Application.Dtos.PlaceDetails.Validators
{
    public class IPlaceDetailsDtoValidator : AbstractValidator<IPlaceDetailsDto>
    {
        public IPlaceDetailsDtoValidator()
        {
            RuleFor(p => p.AddressDetails)
             .NotEmpty().WithMessage("{PropertyName} is required")
             .NotNull();

            RuleFor(p => p.Lat)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull();

            RuleFor(p => p.Lng)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull();

            RuleFor(p => p.Phone)
              .NotNull().WithMessage("{PropertyName} is not null");
        }
    }
}
