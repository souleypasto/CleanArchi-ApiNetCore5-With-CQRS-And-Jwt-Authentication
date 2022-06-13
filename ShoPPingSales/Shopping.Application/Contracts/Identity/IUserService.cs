using Shopping.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Application.Contracts.Identity
{
    public interface IUserService
    {
        Task<List<Utilisateur>> GetUtilisateurs();
        Task<Utilisateur> GetUtilisateur(string userId);
    }
}
