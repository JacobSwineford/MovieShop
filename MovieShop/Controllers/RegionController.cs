using Core.Models;
using Microsoft.AspNetCore.Mvc;
using Core.Contracts.Service;

namespace MovieShop.Controllers
{
    public class RegionController : Controller
    {
        IRegionServiceAsync regionServiceAsync;
        public RegionController(IRegionServiceAsync _service)
        {
            regionServiceAsync = _service;
        }
        public async Task<IActionResult> Index()
        {
            var result = await regionServiceAsync.GetAllRegionsAsync();
            return View(result);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(RegionModel model)
        {
            if (ModelState.IsValid)
            {
                await regionServiceAsync.InsertRegionAsync(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public async Task<IActionResult> Delete(int regionId)
        {
            await regionServiceAsync.DeleteRegionAsync(regionId);
            return RedirectToAction("Index");
        }

    }
}
