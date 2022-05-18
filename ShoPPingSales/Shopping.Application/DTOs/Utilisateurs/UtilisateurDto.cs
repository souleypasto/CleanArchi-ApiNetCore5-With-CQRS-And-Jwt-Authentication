using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Application.DTOs.Utilisateurs
{
    public class UtilisateurDto: BaseDto, IUtilisateurDto
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Telephone { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
