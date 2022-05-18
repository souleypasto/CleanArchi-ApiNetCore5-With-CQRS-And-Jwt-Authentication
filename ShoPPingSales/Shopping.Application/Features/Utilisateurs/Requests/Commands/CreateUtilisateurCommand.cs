using MediatR;
using Shopping.Application.DTOs.Utilisateurs;
using Shopping.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Application.Features.Utilisateurs.Requests.Commands
{
    public class CreateUtilisateurCommand : IRequest<BaseCommandReponse>
    {
        public CreateUtilisateurDto UtilisateurDto { get; set; }
    }
}
