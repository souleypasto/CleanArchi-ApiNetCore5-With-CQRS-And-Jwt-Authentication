using Shopping.Application.Contracts.Persistence.Produits;
using Shopping.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Persistence.Produits
{
    public class GenericProduitRepository : GenericRepository<GenericProduit>, IGenericProduitRepository
    {
        private readonly ApplicationDbContext _context;
        public GenericProduitRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
