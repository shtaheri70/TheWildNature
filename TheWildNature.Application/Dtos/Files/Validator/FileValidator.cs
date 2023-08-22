using FluentValidation;
using Microsoft.AspNetCore.Http;

namespace TheWildNature.Application.Dtos.Files.Validator
{
    public class FileValidator: AbstractValidator<IFormFile>
    {
        public FileValidator()
        {
            RuleFor(x => x.Length).NotNull().LessThanOrEqualTo(1024*1024)
                    .WithMessage("File size is larger than allowed");

            RuleFor(x => x.ContentType).NotNull().Must(x => x.Equals("image/jpeg")
            || x.Equals("image/jpg") || x.Equals("image/png") || x.Equals("pdf"))
                .WithMessage("File type is larger than allowed");
        }
        }
}
