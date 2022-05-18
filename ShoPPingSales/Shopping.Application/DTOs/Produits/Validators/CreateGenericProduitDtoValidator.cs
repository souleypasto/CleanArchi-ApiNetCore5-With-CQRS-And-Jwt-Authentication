using FluentValidation;
using Shopping.Application.Contracts.Persistence.Utilisateurs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Application.DTOs.Produits.Validators
{
    public class CreateGenericProduitDtoValidator : AbstractValidator<CreateGenericProduitDto>
    {
        private readonly IUtilisateurRepository _utilisateurRepository;

        public CreateGenericProduitDtoValidator(IUtilisateurRepository utilisateurRepository)
        {
            _utilisateurRepository = utilisateurRepository;
            RuleFor(p => p.UtilisateurId)
               .MustAsync(async (id, token) =>
               {
                   var UtilisateurExists = await _utilisateurRepository.Exists(id);
                   return UtilisateurExists;
               })
               .WithMessage("{PropertyName} does not exist.");

            Include(new IGenericProduitDtoValidator(_utilisateurRepository));
        }
    }
}
