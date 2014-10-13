using System.Web.Mvc;

namespace MiniSPA.ActionFilters
{
    public class AngularModuleAttribute : ActionFilterAttribute
    {
        public string FileName { get; set; }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            filterContext.Controller.ViewBag.AngularModule = FileName;
        }
    }
}