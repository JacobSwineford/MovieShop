using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class MovieCastModel
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int CastId { get; set; }
        public string Character { get; set; }
    }
}
