using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Analiz_monitor
{
    public class Brand
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } // Название бренда

        [ForeignKey("BrandId")]
        public virtual List<Monitor> Monitors { get; set; }
    }
}
