using System.Web;
using System.Web.Mvc;

namespace CRIS_3_Nav_Material
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
