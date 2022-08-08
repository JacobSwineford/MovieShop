using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Vendor
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string City { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Country { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Mobile { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string EmailId { get; set; }

        [Column(TypeName = "bit")]
        public bool IsActive { get; set; }
    }
}
