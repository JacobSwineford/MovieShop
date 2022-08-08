using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Purchase
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        [Column(TypeName = "uniqueidentifier")]
        public Guid PurchaseNumber { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal TotalPrice { get; set; }

        [Column(TypeName = "datetime2(7)")]
        public DateTime PurchaseDateTime { get; set; }
        public int MovieId { get; set; }

        public User User { get; set; }
        public Movie Movie { get; set; }
    }
}
