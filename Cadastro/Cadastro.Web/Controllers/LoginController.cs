using Cadastro.Dominio.Interfaces.Servicos;
using Cadastro.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cadastro.Web.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioServico _usuarioService;

        public LoginController(IUsuarioServico usuarioService)
        {
            _usuarioService = usuarioService;
        }

        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginVM login)
        {
            var usuario = _usuarioService.RetornaTodos().FirstOrDefault(x => x.Email.Equals(login.Email));

            if(usuario != null)
            {
                Session["Autorizado"] = usuario.Nome;

                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        [HttpGet]
        public ActionResult Logout()
        {
            Session["Autorizado"] = null;
            return RedirectToAction("Login");
        }
    }
}