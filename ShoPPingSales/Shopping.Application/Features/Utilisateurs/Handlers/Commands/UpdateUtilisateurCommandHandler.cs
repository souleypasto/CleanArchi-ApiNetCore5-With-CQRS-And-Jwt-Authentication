using AutoMapper;
using MediatR;
using Shopping.Application.Contracts.Persistence.Utilisateurs;
using Shopping.Application.DTOs.Utilisateurs.Validators;
using Shopping.Application.Exceptions;
using Shopping.Application.Features.Utilisateurs.Requests.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ValidationException = Shopping.Application.Exceptions.ValidationException;

namespace Shopping.Application.Features.Utilisateurs.Handlers.Commands
{
    public class UpdateUtilisateurCommandHandler : IRequestHandler<UpdateUtilisateurCommand, Unit>
    {
        private readonly IUtilisateurRepository _utilisateurRepository;
        private readonly IMapper _mapper;

        public UpdateUtilisateurCommandHandler(IMapper mapper, IUtilisateurRepository utilisateurRepository)
        {
            _mapper = mapper;
            _utilisateurRepository = utilisateurRepository;
        }

        public async Task<Unit> Handle(UpdateUtilisateurCommand request, CancellationToken cancellationToken)
        {
            var validator = new UpdateUtilisateurDtoValidator();
            var validationResult = await validator.ValidateAsync(request.utilisateurDto);

            if (validationResult.IsValid == false)
            {
                throw new ValidationException(validationResult);
            }

            var utilisateur = await _utilisateurRepository.Get(request.Id);

            if (utilisateur == null)
                throw new NotFoundException(nameof(utilisateur), request.utilisateurDto.Id);

            _mapper.Map(request.utilisateurDto, utilisateur);

            await _utilisateurRepository.Update(utilisateur);

            return Unit.Value;
        }
    }
}
