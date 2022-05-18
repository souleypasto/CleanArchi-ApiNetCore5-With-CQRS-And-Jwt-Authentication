using AutoMapper;
using MediatR;
using Shopping.Application.Contracts.Persistence.Produits;
using Shopping.Application.Contracts.Persistence.Utilisateurs;
using Shopping.Application.DTOs.Produits.Validators;
using Shopping.Application.Exceptions;
using Shopping.Application.Features.GenericProduits.Requests.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Shopping.Application.Features.GenericProduits.Handlers.Commands
{
    public class UpdateGenericProduitCommandHandler : IRequestHandler<UpdateGenericProduitCommand, Unit>
    {
        private readonly IGenericProduitRepository _genericProduitRepository;
        private readonly IUtilisateurRepository _utilisateurRepository;
        private readonly IMapper _mapper;

        public UpdateGenericProduitCommandHandler(IUtilisateurRepository utilisateurRepository, IMapper mapper, IGenericProduitRepository genericProduitRepository)
        {
            _mapper = mapper;
            _genericProduitRepository = genericProduitRepository;
            _utilisateurRepository = utilisateurRepository;
        }

        public async Task<Unit> Handle(UpdateGenericProduitCommand request, CancellationToken cancellationToken)
        {
            var validator = new UpdateGenericProduitDtoValidator(_utilisateurRepository);
            var validationResult = await validator.ValidateAsync(request.GenricProduit);

            if (validationResult.IsValid == false)
            {
                throw new ValidationException(validationResult);
            }

            var genericProduit = await _genericProduitRepository.Get(request.Id);

            if (genericProduit == null)
                throw new NotFoundException(nameof(genericProduit), request.GenricProduit.Id);

            _mapper.Map(request.GenricProduit, genericProduit);

            await _genericProduitRepository.Update(genericProduit);

            return Unit.Value;
        }
    }
}
