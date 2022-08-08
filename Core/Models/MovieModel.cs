using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class MovieModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Overview { get; set; }
        public string Tagline { get; set; }
        public decimal Budget { get; set; }
        public decimal Revenue { get; set; }
        public string ImdbUrl { get; set; }
        public string TmdbUrl { get; set; }
        public string PosterUrL { get; set; }
        public string BackdropUrl { get; set; }
        public string OriginalLanguage { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int RunTime { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string CreatedBy { get; set; }

        public static MovieModel From(Movie movie)
        {
            MovieModel m = new MovieModel();
            m.Id = movie.Id;
            m.Title = movie.Title;
            m.Overview = movie.Overview;
            m.Tagline = movie.Tagline;
            m.Budget = movie.Budget;
            m.Revenue = movie.Revenue;
            m.ImdbUrl = movie.ImdbUrl;
            m.TmdbUrl = movie.TmdbUrl;
            m.PosterUrL = movie.PosterUrL;
            m.BackdropUrl = movie.BackdropUrl;
            m.OriginalLanguage = movie.OriginalLanguage;
            m.ReleaseDate = movie.ReleaseDate;
            m.CreatedBy = movie.CreatedBy;
            m.UpdatedBy = movie.UpdatedBy;
            m.RunTime = movie.RunTime;
            m.Price = movie.Price;
            m.CreatedDate = movie.CreatedDate;
            m.UpdatedDate = movie.UpdatedDate;
            return m;
        }
    }
}
