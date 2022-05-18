using AutoMapper;
using MediatR;
using Shopping.Application.Contracts.Persistence.Utilisateurs;
using Shopping.Application.DTOs.Utilisateurs;
using Shopping.Application.Exceptions;
using Shopping.Application.Features.Utilisateurs.Requests.Queries;
using Shopping.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Shopping.Application.Features.Utilisateurs.Handlers.Queries
{
    public class GetUtilisateurDetailRequestHandler : IRequestHandler<GetUtilisateurDetailRequest, UtilisateurDto>
    {
        private readonly IUtilisateurRepository _utilisateurRepository;
        private readonly IMapper _mapper;

        public GetUtilisateurDetailRequestHandler(IMapper mapper, IUtilisateurRepository utilisateurRepository)
        {
            _mapper = mapper;
            _utilisateurRepository = utilisateurRepository;
        }
        public async Task<UtilisateurDto> Handle(GetUtilisateurDetailRequest request, CancellationToken cancellationToken)
        {
            var user = await _utilisateurRepository.Get(request.Id);

            if (user == null)
               throw new NotFoundException(nameof(Utilisateur), request.Id);

            var userMapped = _mapper.Map<UtilisateurDto>(user);

            return userMapped;

        }
    }
}
