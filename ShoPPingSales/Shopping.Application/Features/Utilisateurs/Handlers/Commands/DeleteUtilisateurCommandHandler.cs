using AutoMapper;
using MediatR;
using Shopping.Application.Contracts.Persistence.Utilisateurs;
using Shopping.Application.Exceptions;
using Shopping.Application.Features.Utilisateurs.Requests.Commands;
using Shopping.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Shopping.Application.Features.Utilisateurs.Handlers.Commands
{
    public class DeleteUtilisateurCommandHandler : IRequestHandler<DeleteUtilisateurCommand, Unit>
    {
        private readonly IUtilisateurRepository _utilisateurRepository;
        private readonly IMapper _mapper;

        public DeleteUtilisateurCommandHandler(IMapper mapper, IUtilisateurRepository utilisateurRepository)
        {
            _mapper = mapper;
            _utilisateurRepository = utilisateurRepository;
        }
        public async Task<Unit> Handle(DeleteUtilisateurCommand request, CancellationToken cancellationToken)
        {
            var utilisateur = await _utilisateurRepository.Get(request.Id);

            if (utilisateur == null)
                throw new NotFoundException(nameof(Utilisateur), request.Id);

            await _utilisateurRepository.Delete(utilisateur);

            return Unit.Value;
        }
    }
}
