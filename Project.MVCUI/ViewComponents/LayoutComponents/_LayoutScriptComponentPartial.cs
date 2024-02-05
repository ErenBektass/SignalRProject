using Microsoft.AspNetCore.Mvc;

namespace Project.MVCUI.ViewComponents.LayoutComponents
{
    public class _LayoutScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
