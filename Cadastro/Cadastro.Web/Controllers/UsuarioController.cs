using Cadastro.Dominio.Interfaces.Servicos;
using Cadastro.Dominio.Models;
using Cadastro.Web.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cadastro.Web.Controllers
{
    [AutorizacaoCustomizada]
    public class UsuarioController : Controller
    {

        private readonly IUsuarioServico _usuarioServico;

        public UsuarioController(IUsuarioServico usuarioServico)
        {
            _usuarioServico = usuarioServico;
        }
        // GET: Usuario
        public ActionResult Index()
        {
            var Usuario = _usuarioServico.RetornaTodos().ToList();

            return View(Usuario);

        }
        public ActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Adicionar(Usuario usuarios)
        {
            try
            {
                _usuarioServico.Adicionar(usuarios);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }

        }

        public ActionResult Editar(int id)
        {

            Usuario usuarios = _usuarioServico.RetornaPorId(id);

            return View(usuarios);
        }

        [HttpPost]
        public ActionResult Editar(Usuario usuarios)
        {
            try
            {
                _usuarioServico.Alterar(usuarios);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }

        }
        //public ActionResult Remover(int id)
        //{
        //    return View(usuarios);
        //}

        [HttpPost, ActionName("Deletar")]
        public ActionResult Remover(Usuario usuarios)
        {
            try
            {
                _usuarioServico.Remover(usuarios);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}