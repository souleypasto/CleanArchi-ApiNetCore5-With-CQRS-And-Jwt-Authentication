using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Application.DTOs.Utilisateurs.Validators
{
    public class CreateUtilisateurDtoValidator : AbstractValidator<CreateUtilisateurDto>
    {
        public CreateUtilisateurDtoValidator()
        {
            Include(new IUtilisateurDtoValidator());
        }
    }
}
