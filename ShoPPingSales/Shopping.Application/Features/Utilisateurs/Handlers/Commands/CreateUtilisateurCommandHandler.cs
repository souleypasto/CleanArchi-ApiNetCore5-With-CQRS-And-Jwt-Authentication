using AutoMapper;
using MediatR;
using Shopping.Application.Contracts.Persistence.Utilisateurs;
using Shopping.Application.DTOs.Utilisateurs.Validators;
using Shopping.Application.Features.Utilisateurs.Requests.Commands;
using Shopping.Application.Responses;
using Shopping.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Shopping.Application.Features.Utilisateurs.Handlers.Commands
{
    public class CreateUtilisateurCommandHandler : IRequestHandler<CreateUtilisateurCommand, BaseCommandReponse>
    {
        private readonly IUtilisateurRepository _utilisateurRepository;
        private readonly IMapper _mapper;

        public CreateUtilisateurCommandHandler(IMapper mapper, IUtilisateurRepository utilisateurRepository)
        {
            _mapper = mapper;
            _utilisateurRepository = utilisateurRepository;
        }
        public async Task<BaseCommandReponse> Handle(CreateUtilisateurCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateUtilisateurDtoValidator();
            var response = new BaseCommandReponse();
            var validatorResult = await validator.ValidateAsync(request.UtilisateurDto);

            if(validatorResult.IsValid == false)
            {
                response.Success = false;
                response.Message = "Utilisateur Failled Added";
                response.Errors =  validatorResult.Errors.Select(q => q.ErrorMessage).ToList();
            } else
            {
                response.Success = true;
                var utilisateur = _mapper.Map<Utilisateur>(request.UtilisateurDto);
                await _utilisateurRepository.Add(utilisateur);
                response.Success = true;
                response.Message = "Niveau Add Successfully";
            }

            return response;
        }
    }
}
