using AutoMapper;
using MediatR;
using Shopping.Application.Contracts.Identity;
using Shopping.Application.Contracts.Persistence.Utilisateurs;
using Shopping.Application.DTOs.Utilisateurs;
using Shopping.Application.DTOs.Utilisateurs.Validators;
using Shopping.Application.Features.Utilisateurs.Requests.Commands;
using Shopping.Application.Models.Identity;
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
        private readonly IAuthService _authService;
        private readonly IMapper _mapper;

        public CreateUtilisateurCommandHandler(IAuthService authService, IMapper mapper, IUtilisateurRepository utilisateurRepository)
        {
            _mapper = mapper;
            _utilisateurRepository = utilisateurRepository;
            _authService = authService;
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
                await AddNetUser(request.UtilisateurDto);
                response.Success = true;
                var utilisateur = _mapper.Map<Utilisateur>(request.UtilisateurDto);
                await _utilisateurRepository.Add(utilisateur);
                response.Success = true;
                response.Message = "Utilisateur Add Successfully";
               
            }

            return response;
        }

        public async Task AddNetUser(CreateUtilisateurDto utilisateurDto)
        {
            RegistrationRequest registerRequest = new RegistrationRequest
            {
                Email = utilisateurDto.Email,
                Name = utilisateurDto.Name,
                Password = utilisateurDto.Password,
                SurName = utilisateurDto.SurName,
                Telephone = utilisateurDto.Telephone,
                UserName = utilisateurDto.UserName,
            };
            var response = await _authService.Register(registerRequest, utilisateurDto.Role);
        }
    }
}
