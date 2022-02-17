using System.Web;
using System.Web.Mvc;

namespace Cadastro.Web.App_Start
{
    public class AutorizacaoCustomizada : ActionFilterAttribute, IActionFilter
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (string.IsNullOrEmpty(HttpContext.Current.Session["Autorizado"]?.ToString()))
                filterContext.Result = new RedirectResult("/Login/Login");
        }
    }
}