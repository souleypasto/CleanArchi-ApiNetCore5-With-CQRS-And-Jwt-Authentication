using Microsoft.AspNetCore.Identity;
using Shopping.Application.Contracts.Identity;
using Shopping.Domain.Identity;
using Shopping.Identity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Identity.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UserService(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<Utilisateur> GetUtilisateur(string userId)
        {
            var utilisateur = await _userManager.FindByIdAsync(userId);
            return new Utilisateur
            {
                Email = utilisateur.Email,
                Id = Guid.Parse(utilisateur.Id),
                Name = utilisateur.Name,
                SurName = utilisateur.SurName
            };
        }

        public async Task<List<Utilisateur>> GetUtilisateurs()
        {
            var employees = await _userManager.GetUsersInRoleAsync("Employee");
            return employees.Select(q => new Utilisateur
            {
                Id = Guid.Parse(q.Id),
                Email = q.Email,
                Name = q.Name,
                SurName = q.SurName
            }).ToList();
        }
    }
}
