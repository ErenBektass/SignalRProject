using Microsoft.AspNetCore.Mvc;

namespace Project.MVCUI.ViewComponents.LayoutComponents
{
    public class _LayoutNavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
