using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Application.Features.GenericProduits.Requests.Commands
{
    public class DeleteGenericProduitCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
    }
}
