using AutoMapper;
using MediatR;
using Shopping.Application.Contracts.Persistence.Produits;
using Shopping.Application.DTOs.Produits;
using Shopping.Application.Features.GenericProduits.Requests.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Shopping.Application.Features.GenericProduits.Handlers.Queries
{
    public class GetGenericProduitListRequestHandler : IRequestHandler<GetGenericProduitListRequest, List<GenericProduitDto>>
    {
        private readonly IGenericProduitRepository _genericProduitRepository;
        private readonly IMapper _mapper;

        public GetGenericProduitListRequestHandler(IMapper mapper, IGenericProduitRepository genericProduitRepository)
        {
            _mapper = mapper;
            _genericProduitRepository = genericProduitRepository;
        }
        public async Task<List<GenericProduitDto>> Handle(GetGenericProduitListRequest request, CancellationToken cancellationToken)
        {
            var list = await _genericProduitRepository.Get();
            var mappedList = _mapper.Map<List<GenericProduitDto>>(list);
            return mappedList;

        }
    }
}
