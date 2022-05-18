using FluentValidation;
using Shopping.Application.Contracts.Persistence.Utilisateurs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Application.DTOs.Produits.Validators
{
    public class UpdateGenericProduitDtoValidator : AbstractValidator<UpdateGenericProduitDto>
    {
        private readonly IUtilisateurRepository _utilisateurRepository;
        public UpdateGenericProduitDtoValidator(IUtilisateurRepository utilisateurRepository)
        {
            _utilisateurRepository = utilisateurRepository;
            RuleFor(p => p.Id).NotNull().WithMessage("{PropertyName} must be present");
            Include(new IGenericProduitDtoValidator(_utilisateurRepository));
        }
    }
}
