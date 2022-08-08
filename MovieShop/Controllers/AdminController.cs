using Core.Contracts.Service;
using Microsoft.AspNetCore.Mvc;

namespace MovieShop.Controllers
{
    public class AdminController : Controller
    {
        IAdminServiceAsync service;

        public AdminController(IAdminServiceAsync service)
        {
            this.service = service;
        }
    
        public async Task<IActionResult> Index()
        {
            var s = await service.GetTopPurchasesAsync();
            return View(s);
        }
    }
}
