using MediatR;
using Shopping.Application.DTOs.Produits;
using Shopping.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Application.Features.GenericProduits.Requests.Commands
{
    public class CreateGenericProduitCommand : IRequest<BaseCommandReponse>
    {
        public CreateGenericProduitDto GenericProduitDto { get; set; }
    }
}
