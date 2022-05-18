using MediatR;
using Shopping.Application.DTOs.Produits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Application.Features.GenericProduits.Requests.Commands
{
    public class UpdateGenericProduitCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
        public UpdateGenericProduitDto GenricProduit { get; set; }
    }
}
