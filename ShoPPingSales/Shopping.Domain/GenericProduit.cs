using Shopping.Domain.Identity;
using System;

namespace Shopping.Domain
{
    public class GenericProduit : BaseDomainEntity
    {
        public string ProduitName { get; set; }
        public string Description { get; set; }
        public Utilisateur CreatedUtilisateur { get; set; }
        public int UtilisateurId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastModifiedDate { get; set; }
        
    }
}
