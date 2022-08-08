using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    public class Shipper
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string Phone { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
