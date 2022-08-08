using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Models
{
    public class ShipperModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Phone { get; set; }
    }
}
