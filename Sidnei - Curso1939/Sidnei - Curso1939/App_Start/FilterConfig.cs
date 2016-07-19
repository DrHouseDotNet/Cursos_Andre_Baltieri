using System.Web;
using System.Web.Mvc;

namespace Sidnei___Curso1939
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
