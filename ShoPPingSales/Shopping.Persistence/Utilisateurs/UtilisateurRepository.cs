using Shopping.Application.Contracts.Persistence.Utilisateurs;
using Shopping.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Persistence.Utilisateurs
{
    public class UtilisateurRepository : GenericRepository<Utilisateur>, IUtilisateurRepository
    {
        private readonly ApplicationDbContext _context;
        public UtilisateurRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
