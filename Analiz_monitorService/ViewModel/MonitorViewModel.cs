using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace Analiz_monitorService.ViewModel
{
    public class MonitorViewModel
    {
        public int Id { get; set; }

        [DisplayName("Название")]
        public string Name { get; set; }

        [DisplayName("Диагональ")]
        public int Diagonal { get; set; }

        [DisplayName("Разрешение")]
        public string Resolution { get; set; }

        [DisplayName("Тип матрицы")]
        public string MatrixType { get; set; }

        [DisplayName("Время отклика")]
        public int ResponseTime { get; set; }

        [DisplayName("Частота")]
        public int Frequency { get; set; }

        [DisplayName("Поддержка HDTV")]
        public bool HDTVSupport { get; set; }

        [DisplayName("Поддержка HDCP")]
        public bool HDCPSupport { get; set; }

        [DisplayName("Энергопотребление")]
        public int PowerUsage { get; set; }

        [DisplayName("Изогнутый")]
        public bool Curved { get; set; }

        [DisplayName("Тип блока питания")]
        public string PowerSupply { get; set; }

        [DisplayName("Оценка")]
        public int Assessment { get; set; }

        [DisplayName("Номер бренда")]
        public int BrandId { get; set; }

        [DisplayName("Название бренда")]
        public string BrandName { get; set; }
    }
}
