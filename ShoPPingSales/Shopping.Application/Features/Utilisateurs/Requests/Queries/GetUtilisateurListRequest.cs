using MediatR;
using Shopping.Application.DTOs.Utilisateurs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Application.Features.Utilisateurs.Requests.Queries
{
    public class GetUtilisateurListRequest : IRequest<List<UtilisateurDto>>
    {
    }
}
