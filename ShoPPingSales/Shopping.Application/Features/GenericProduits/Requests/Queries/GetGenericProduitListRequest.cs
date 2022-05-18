using MediatR;
using Shopping.Application.DTOs.Produits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Application.Features.GenericProduits.Requests.Queries
{
    public class GetGenericProduitListRequest : IRequest<List<GenericProduitDto>>
    {

    }
}
