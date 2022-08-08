using Core.Contracts.Service;
using Core.Entities;
using Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace MovieShop.Controllers
{
    public class MovieController : Controller
    {

        IMovieServiceAsync service;

        public MovieController(IMovieServiceAsync _service)
        {
            service = _service;
        }

        public IActionResult Index(string name)
        {
            Console.WriteLine("name index: " + name); // test to see if I can detect name, can be used to navigate through details
            return View();
        }

        public async Task<IActionResult> List(string name)
        {
            int perRow = 4;
            IEnumerable<MovieModel> results = await service.GetAllMoviesAsync();
            List<List<MovieModel>> rowed = RowedResults((List<MovieModel>)results, perRow);
            foreach (var a in rowed)
            {
                Console.WriteLine($"Row length: {a.Count}");
                foreach (var b in a)
                {
                    Console.WriteLine($"\tRow Item: {b}");
                }
            }
            return View(rowed);
        }

        [Route("Movie/Details/{movieId}")]
        public async Task<IActionResult> Details(int movieId)
        {
            Console.WriteLine($"movieId: {movieId}");
            MovieModel result = await service.GetByIdAsync(movieId);
            return View(result);
        }

        private List<List<MovieModel>> RowedResults(List<MovieModel> dataSet, int perRow)
        {
            List<List<MovieModel>> models = new List<List<MovieModel>>();

            int count = 0;
            int numRows = dataSet.Count / perRow + 1;
            Console.WriteLine($"number of rows: {numRows}, count: {dataSet.Count}");
            while (numRows-- != 0)
            {
                List<MovieModel> row = new List<MovieModel>();
                for (var i = 0; i < perRow; i++)
                {
                    if (count == dataSet.Count())
                    {
                        models.Add(row);
                        return models;
                    }
                    row.Add(dataSet.ElementAt(i));
                    count++;
                }
                models.Add(row);
            }
            return models;

            //foreach (MovieModel model in dataSet)
            //{
            //    if (r == null) r = new List<MovieModel>();
            //    if (r.Count == perRow)
            //    {
            //        models.Add(r);
            //        r = null;
            //    }

            //    if (r != null) r.Add(model);
            //    count++;
            //}
            //if (r != null && r.Count != 0)
            //    models.Add(r);

            //return models;
        }
    }
}
