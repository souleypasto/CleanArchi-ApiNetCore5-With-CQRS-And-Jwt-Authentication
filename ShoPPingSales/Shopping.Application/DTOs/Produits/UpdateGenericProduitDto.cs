using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Application.DTOs.Produits
{
    public class UpdateGenericProduitDto : BaseDto, IGenericProduitDto
    {
        public string ProduitName { get; set; }
        public string Description { get; set; }
        public Guid UtilisateurId { get; set; }
    }
}
