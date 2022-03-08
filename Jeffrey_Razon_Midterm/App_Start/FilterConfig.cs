using System.Web;
using System.Web.Mvc;

namespace Jeffrey_Razon_Midterm
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
