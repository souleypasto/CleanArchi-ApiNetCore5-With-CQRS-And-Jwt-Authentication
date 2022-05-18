using AutoMapper;
using MediatR;
using Shopping.Application.Contracts.Persistence.Produits;
using Shopping.Application.DTOs.Produits;
using Shopping.Application.Exceptions;
using Shopping.Application.Features.GenericProduits.Requests.Queries;
using Shopping.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Shopping.Application.Features.GenericProduits.Handlers.Queries
{
    public class GetGenericProduitDetailRequestHandler : IRequestHandler<GetGenericProduitDetailRequest, GenericProduitDto>
    {
        private readonly IGenericProduitRepository _genericProduitRepository;
        private readonly IMapper _mapper;

        public GetGenericProduitDetailRequestHandler(IMapper mapper, IGenericProduitRepository genericProduitRepository)
        {
            _mapper = mapper;
            _genericProduitRepository = genericProduitRepository;
        }
        public async Task<GenericProduitDto> Handle(GetGenericProduitDetailRequest request, CancellationToken cancellationToken)
        {
            var user = await _genericProduitRepository.Get(request.Id);

            if (user == null)
                throw new NotFoundException(nameof(GenericProduit), request.Id);

            var userMapped = _mapper.Map<GenericProduitDto>(user);

            return userMapped;

        }
    }
}
