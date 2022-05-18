using MediatR;
using Shopping.Application.DTOs.Utilisateurs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Application.Features.Utilisateurs.Requests.Commands
{
    public class UpdateUtilisateurCommand :IRequest<Unit>
    {
        public int Id { get; set; }
        public UpdateUtilisateurDto utilisateurDto { get; set; }
    }
}
