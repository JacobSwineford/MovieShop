using Core.Contracts.Service;
using Core.Entities;
using Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace MovieShop.Controllers
{
    public class CastController : Controller
    {
        ICastServiceAsync service;
        public CastController(ICastServiceAsync _service)
        {
            service = _service;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            Task<IEnumerable<Cast>> cast = service.GetCastDetails();
            List<CastModel> models = new List<CastModel>();
            foreach (var c in cast.Result)
            {
                CastModel m = new CastModel();
                m.Id = c.Id;
                m.Name = c.Name;
                m.Gender = c.Gender;
            }
            return View(models);
        }
    }
}