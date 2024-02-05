using Microsoft.AspNetCore.Mvc;

namespace Project.MVCUI.ViewComponents.LayoutComponents
{
    public class _LayoutFooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
