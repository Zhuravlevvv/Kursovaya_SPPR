using System.ComponentModel.DataAnnotations;

namespace Analiz_monitor
{
    public class Monitor
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } // Название монитора

        [Required]
        public int Diagonal { get; set; } // Диагональ

        [Required]
        public string Resolution { get; set; } // Разрешение

        [Required]
        public string MatrixType { get; set; } // Тип матрицы
 
        [Required]
        public int ResponseTime { get; set; } // Время отклика (МС)

        [Required]
        public int Frequency { get; set; } // Частота

        [Required]
        public bool HDTVSupport { get; set; } // поддержка hdtv

        [Required]
        public bool HDCPSupport { get; set; } // поддержка HDCP

        [Required]
        public int PowerUsage { get; set; } // энергопотребление

        [Required]
        public bool Curved { get; set; } // Изогнутость

        [Required]
        public string PowerSupply { get; set; } // тип блока питания

        [Required]
        public int Assessment { get; set; } // Оценка

        [Required]
        public int BrandId { get; set; } //Бренд

        public virtual Brand Brand { get; set; }
    }
}
