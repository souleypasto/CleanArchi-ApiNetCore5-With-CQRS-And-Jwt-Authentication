using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Application.DTOs.Utilisateurs.Validators
{
    public class IUtilisateurDtoValidator : AbstractValidator<IUtilisateurDto>
    {
        public IUtilisateurDtoValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Name must be Present ");
            RuleFor(p => p.Telephone).NotNull().WithMessage("Phone Number is Compsery ")
                .GreaterThan(599999999).WithMessage("Your Phone Number must be in the form of 6 XX XX XX XX");
            RuleFor(p => p.Email).NotEmpty().WithMessage("Email mut be present");
            RuleFor(p => p.Password).NotEmpty().WithMessage("Password must be Present");
        }
    }
}
