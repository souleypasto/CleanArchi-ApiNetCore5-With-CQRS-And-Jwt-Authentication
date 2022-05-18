using AutoMapper;
using MediatR;
using Shopping.Application.Contracts.Persistence.Produits;
using Shopping.Application.Exceptions;
using Shopping.Application.Features.GenericProduits.Requests.Commands;
using Shopping.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Shopping.Application.Features.GenericProduits.Handlers.Commands
{
    public class DeleteGenericProduitCommandHandler : IRequestHandler<DeleteGenericProduitCommand, Unit>
    {
        private readonly IGenericProduitRepository _genericProduitRepository;
        private readonly IMapper _mapper;

        public DeleteGenericProduitCommandHandler(IMapper mapper, IGenericProduitRepository genericProduitRepository)
        {
            _mapper = mapper;
            _genericProduitRepository = genericProduitRepository;
        }
        public async Task<Unit> Handle(DeleteGenericProduitCommand request, CancellationToken cancellationToken)
        {
            var genericProduit = await _genericProduitRepository.Get(request.Id);

            if (genericProduit == null)
                throw new NotFoundException(nameof(GenericProduit), request.Id);

            await _genericProduitRepository.Delete(genericProduit);

            return Unit.Value;
        }
    }
}
