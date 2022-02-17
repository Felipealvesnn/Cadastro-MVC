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
    public class ClienteController : Controller
    {
        private readonly IClienteServico _clienteServico;

        public ClienteController(IClienteServico clienteServico)
        {
            _clienteServico = clienteServico;
        }

        // GET: Cliente
        public ActionResult Index()
        {

            var Clientes = _clienteServico.RetornaTodos().ToList();
            return View(Clientes);

        }

        public ActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Adicionar(Cliente cliente)
        {
            try
            {
                _clienteServico.Adicionar(cliente);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }

        }
        
        public ActionResult Editar(int id)
        {

            Cliente clientes = _clienteServico.RetornaPorId(id);

            return View(clientes);
        }

        [HttpPost]
        public ActionResult Editar(Cliente cliente)
        {
            try
            {
                _clienteServico.Alterar(cliente);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(cliente);
            }

        }

        [HttpGet]
        public ActionResult Remover(int id)
        {
            try
            {
                _clienteServico.Remover(new Cliente { Id = id });
            }
            catch
            {
            }
            return RedirectToAction("Index");
        }
    }
}