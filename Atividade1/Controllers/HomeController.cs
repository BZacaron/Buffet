using Atividade1.Models;
using Buffet.Acesso;
using Buffet.Database;
using Buffet.Models.Usuario;
using Buffet.RequestModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Linq;

namespace Atividade1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DatabaseContext _databaseContext;

        private readonly Usuario _usuario;
        private readonly CadastroUsuarioService _cadastroUsuarioService;

        public HomeController(CadastroUsuarioService cadastroUsuarioService)
        {
            _cadastroUsuarioService = cadastroUsuarioService;
        }

        public IActionResult Index()
        {
            //var listaClientes = _databaseContext.Cliente.ToList();

            //_databaseContext.[TABELA].Add([OBJETO]);  -> adicionar no banco
            //_databaseContext.SaveChanges();  -> salva as alterações no banco


            return View();
        }

        public IActionResult Privacidade()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Cadastro()
        {
            var viewmodel = new MsgAcessoViewModel();

            viewmodel.Mensagem = (string)TempData["msg-cadastro"];

            return View(viewmodel);
        }
        [HttpPost]
        public async System.Threading.Tasks.Task<RedirectResult> Cadastro(CadastroRequest request)
        {
            var redirectUrl = "/Home/Cadastro";
            var user = request.User;
            var senha = request.Senha;

            if(user==null)
            {
                TempData["msg-cadastro"] = "O campo de Usuário não pode ficar vazio.";
                return Redirect(redirectUrl);
            }
            if (senha == null)
            {
                TempData["msg-cadastro"] = "O campo de Senha não pode ficar vazio.";
                return Redirect(redirectUrl);
            }

            try
            {
                await _cadastroUsuarioService.RegistrarUsuario(user, senha);
                TempData["msg-cadastro"] = "Cadastro realizado com sucesso!";
                return Redirect("/Home/Login");
            }catch(Exception exception){
                TempData["msg-cadastro"] = exception.Message;
                return Redirect("/Home/Cadastro");
            }


            return Redirect(redirectUrl);
        }

        public RedirectResult Login(LoginRequest request)
        {
            //var usuarios = _usuario.ObterUsuarios();
            var listaUsuarios = _databaseContext.Usuario.ToList();
            bool usuarioValidado = false;
            var user = request.User;
            var senha = request.Senha;

            foreach (var usuario in listaUsuarios)
            {
                if (usuario.Login == user && usuario.Senha == senha)
                    usuarioValidado = true;
            }

            if(usuarioValidado == true)
                return Redirect("/Home/Principal");
            else
            {
                TempData["msg-cadastro"] = "Usuário ou senha incorretos";
                return Redirect("/Home/Login");
            }             
        }

        public IActionResult Recuperar()
        {
            return View();
        }

        public IActionResult Termos()
        {
            return View();
        }

        public IActionResult Ajuda()
        {
            return View();
        }

        public IActionResult Painel()
        {
            return View();
        }

        public IActionResult Principal()
        {
            return View();
        }

        public IActionResult TermosInterno()
        {
            return View();
        }

        public IActionResult PrivacidadeInterno()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
