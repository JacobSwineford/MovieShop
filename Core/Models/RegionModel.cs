using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Core.Models
{
    public class RegionModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "region name is required")]
        [MaxLength(50, ErrorMessage = "region name maximum of ? characters")]
        public string Name { get; set; }
    }
}
