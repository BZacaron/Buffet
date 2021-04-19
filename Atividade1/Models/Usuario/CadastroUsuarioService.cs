using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buffet.Models.Usuario
{
    public class CadastroUsuarioService
    {
        private readonly UserManager<Usuario> _userManager;
        private readonly SignInManager<Usuario> _signInManager;

        public CadastroUsuarioService()
        {
        }

        public CadastroUsuarioService(UserManager<Usuario> userManager, SignInManager<Usuario> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task AutenticarUsuario(string user, string senha)
        {
            var resultado = await _signInManager.PasswordSignInAsync(user, senha, false, false);

            if (!resultado.Succeeded)
            {
                throw new Exception("Login ou senha incorretos");
            }
        }

        public async Task RegistrarUsuario(string user, string senha)
        {
            var novoUsuario = new Usuario()
            {
                Login = user
            };

            var resultado = await _userManager.CreateAsync(novoUsuario, senha);

            if (!resultado.Succeeded)
            {
                var listaErros = "";
                foreach (var identityError in resultado.Errors)
                {
                    listaErros += identityError.Description + " / ";
                }
                throw new Exception(listaErros);
            }
                
        }
    }
}
