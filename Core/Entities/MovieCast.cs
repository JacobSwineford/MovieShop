using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class MovieCast
    {
        public int Id { get; set; }
        public int MovieId { get; set; }

        public int CastId { get; set; }

        [Column(TypeName = "nvarchar(450)")]
        public string Character { get; set; }

        public Movie Movie { get; set; }
        public Cast Cast { get; set; }
    }
}
