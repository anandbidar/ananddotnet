using System.Web;
using System.Web.Mvc;

namespace EmployeeCompetencyTrackingSystem
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}