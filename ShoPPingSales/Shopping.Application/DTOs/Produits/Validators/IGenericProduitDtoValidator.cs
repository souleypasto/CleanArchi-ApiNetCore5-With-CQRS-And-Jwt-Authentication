using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Shopping.Application.Contracts.Persistence.Utilisateurs;

namespace Shopping.Application.DTOs.Produits.Validators
{
    public class IGenericProduitDtoValidator : AbstractValidator<IGenericProduitDto>
    {
        private readonly IUtilisateurRepository _utilisateurRepository;

        public IGenericProduitDtoValidator(IUtilisateurRepository utilisateurRepository)
        {
            _utilisateurRepository = utilisateurRepository;

           
        }

    }
}
