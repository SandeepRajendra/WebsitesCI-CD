using System.Web;
using System.Web.Mvc;

namespace WebsitesCI_CD
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
