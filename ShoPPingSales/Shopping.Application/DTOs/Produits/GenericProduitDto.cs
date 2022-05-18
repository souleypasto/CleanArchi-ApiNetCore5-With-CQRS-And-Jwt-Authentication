using Shopping.Application.DTOs.Utilisateurs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Application.DTOs.Produits
{
    public class GenericProduitDto : BaseDto
    {
        public string ProduitName { get; set; }
        public string Description { get; set; }
        public Guid UtilisateurId { get; set; }
        public UtilisateurDto CreatedUtilisateur { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}
