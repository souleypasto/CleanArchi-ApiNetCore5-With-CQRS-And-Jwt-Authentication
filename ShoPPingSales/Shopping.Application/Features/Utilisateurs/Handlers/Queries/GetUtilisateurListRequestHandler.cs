using AutoMapper;
using MediatR;
using Shopping.Application.Contracts.Persistence.Utilisateurs;
using Shopping.Application.DTOs.Utilisateurs;
using Shopping.Application.Features.Utilisateurs.Requests.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Shopping.Application.Features.Utilisateurs.Handlers.Queries
{
    public class GetUtilisateurListRequestHandler : IRequestHandler<GetUtilisateurListRequest, List<UtilisateurDto>>
    {
        private readonly IUtilisateurRepository _utilisateurRepository;
        private readonly IMapper _mapper;

        public GetUtilisateurListRequestHandler(IMapper mapper, IUtilisateurRepository utilisateurRepository)
        {
            _mapper = mapper;
            _utilisateurRepository = utilisateurRepository;
        }
        public async Task<List<UtilisateurDto>> Handle(GetUtilisateurListRequest request, CancellationToken cancellationToken)
        {
            var list = await _utilisateurRepository.Get();
            var mappedList = _mapper.Map<List<UtilisateurDto>>(list);
            return mappedList;

        }
    }
}
