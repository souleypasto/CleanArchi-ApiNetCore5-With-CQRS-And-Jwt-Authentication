using AutoMapper;
using MediatR;
using Shopping.Application.Contracts.Persistence.Produits;
using Shopping.Application.Contracts.Persistence.Utilisateurs;
using Shopping.Application.DTOs.Produits.Validators;
using Shopping.Application.Features.GenericProduits.Requests.Commands;
using Shopping.Application.Responses;
using Shopping.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Shopping.Application.Features.GenericProduits.Handlers.Commands
{
    public class CreateGenericProduitCommandHandler : IRequestHandler<CreateGenericProduitCommand, BaseCommandReponse>
    {
        private readonly IGenericProduitRepository _genericProduitRepository;
        private readonly IUtilisateurRepository _utilisateurRepository;
        private readonly IMapper _mapper;

        public CreateGenericProduitCommandHandler(IUtilisateurRepository utilisateurRepository, IMapper mapper, IGenericProduitRepository genericProduitRepository)
        {
            _mapper = mapper;
            _genericProduitRepository = genericProduitRepository;
            _utilisateurRepository = utilisateurRepository;
        }
        public async Task<BaseCommandReponse> Handle(CreateGenericProduitCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateGenericProduitDtoValidator(_utilisateurRepository);
            var response = new BaseCommandReponse();
            var validatorResult = await validator.ValidateAsync(request.GenericProduitDto);

            if (validatorResult.IsValid == false)
            {
                response.Success = false;
                response.Message = "GenericProduit Failled Added";
                response.Errors = validatorResult.Errors.Select(q => q.ErrorMessage).ToList();
            }
            else
            {
                response.Success = true;
                var genericProduit = _mapper.Map<GenericProduit>(request.GenericProduitDto);
                await _genericProduitRepository.Add(genericProduit);
                response.Success = true;
                response.Message = "GenericProduit Add Successfully";
            }

            return response;
        }
    }
}
