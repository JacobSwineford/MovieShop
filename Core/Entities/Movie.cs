using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Movie
    {
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(256)")]
        public string Title { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string Overview { get; set; }

        [Column(TypeName = "nvarchar(512)")]
        public string Tagline { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Budget { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Revenue { get; set; }

        [Column(TypeName = "nvarchar(2084)")]
        public string ImdbUrl { get; set; }

        [Column(TypeName = "nvarchar(2084)")]
        public string TmdbUrl { get; set; }

        [Column(TypeName = "nvarchar(2084)")]
        public string PosterUrL { get; set; }

        [Column(TypeName = "nvarchar(2084)")]
        public string BackdropUrl { get; set; }

        [Column(TypeName = "nvarchar(64)")]
        public string OriginalLanguage { get; set; }

        [Column(TypeName = "datetime2(7)")]
        public DateTime ReleaseDate { get; set; }
        public int RunTime { get; set; }

        [Column(TypeName = "decimal(5, 2)")]
        public decimal Price { get; set; }

        [Column(TypeName = "datetime2(7)")]
        public DateTime CreatedDate { get; set; }

        [Column(TypeName = "datetime2(7)")]
        public DateTime UpdatedDate { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string UpdatedBy { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string CreatedBy { get; set; }
    }
}
