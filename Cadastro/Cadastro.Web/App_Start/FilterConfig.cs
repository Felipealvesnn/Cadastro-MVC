using Cadastro.Web.App_Start;
using System.Web;
using System.Web.Mvc;

namespace Cadastro.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
