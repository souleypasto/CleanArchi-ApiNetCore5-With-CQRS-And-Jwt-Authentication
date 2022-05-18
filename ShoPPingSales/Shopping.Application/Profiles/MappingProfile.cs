using AutoMapper;
using Shopping.Application.DTOs.Produits;
using Shopping.Application.DTOs.Utilisateurs;
using Shopping.Domain;
using Shopping.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Utilisateur, CreateUtilisateurDto>().ReverseMap();
            CreateMap<Utilisateur, UpdateUtilisateurDto>().ReverseMap();
            CreateMap<Utilisateur, UtilisateurDto>().ReverseMap();

            CreateMap<GenericProduit, GenericProduitDto>().ReverseMap();
            CreateMap<GenericProduit, UpdateGenericProduitDto>().ReverseMap();
            CreateMap<GenericProduit, CreateGenericProduitDto>().ReverseMap();
        }
    }
}
