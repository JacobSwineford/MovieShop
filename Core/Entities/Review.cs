using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Review
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int UserId { get; set; }

        [Column(TypeName = "decimal(3, 2)")]
        public decimal Rating { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string ReviewText { get; set; }

        public Movie Movie { get; set; }
        public User User { get; set; }
    }
}
