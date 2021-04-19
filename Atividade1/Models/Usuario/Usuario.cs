using Buffet.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buffet.Models.Usuario
{
    public class Usuario
    {
        private readonly DatabaseContext _databaseContext;

        public Usuario(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

        public Usuario(string login, string senha)
        {
            Login = login;
            Senha = senha;
        }
        public Usuario()
        { }

        public List<Usuario> ObterUsuarios()
        {
            List<Usuario> usuarios = _databaseContext.Usuario.ToList();

            return usuarios;
        }
    }
}
