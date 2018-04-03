using microCommerce.Mvc.UI;
using Microsoft.AspNetCore.Mvc;

namespace microCommerce.Web.ViewComponents
{
    [ViewComponent(Name = "Header")]
    public class TopMenuComponent : BaseComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}