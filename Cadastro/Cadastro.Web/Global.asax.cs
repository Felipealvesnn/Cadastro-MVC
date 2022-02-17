using Cadastro.Application.Servico;
using Cadastro.Data.Contexto;
using Cadastro.Data.Repositorios;
using Cadastro.Dominio.Interfaces.Repositorios;
using Cadastro.Dominio.Interfaces.Servicos;
using SimpleInjector;
using SimpleInjector.Extensions;
using SimpleInjector.Integration.Web;
using SimpleInjector.Lifestyles;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Cadastro.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            DependencyResolver.SetResolver(RegisterServices());
            Database.SetInitializer<CadastroContexto>(new DropCreateDatabaseIfModelChanges<CadastroContexto>());
        }

        private Container RegisterServices()
        {
            var container = new Container();
            container.Register<DbContext, CadastroContexto>();
            container.RegisterOpenGeneric(typeof(IRepositorioBase<>), typeof(RepositorioBase<>));
            container.Register<IClienteRepositorio, ClienteRepositorio>();
            container.Register<IClienteServico, ClienteServico>();
            container.Register<IUsuarioRepositorio, UsuarioRepositorio>();
            container.Register<IUsuarioServico, UsuarioServico>();
            //Adiciona aqui inicio

            //fim

            container.Verify();
            return container;
        }
    }
}
