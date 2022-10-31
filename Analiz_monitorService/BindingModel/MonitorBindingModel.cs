namespace Analiz_monitorService.BindingModel
{
    public class MonitorBindingModel
    {
        public int Id { get; set; }

        public string Name { get; set; } 

        public int Diagonal { get; set; } 

        public string Resolution { get; set; }

        public string MatrixType { get; set; } 

        public int ResponseTime { get; set; } 

        public int Frequency { get; set; } 

        public bool HDTVSupport { get; set; }

        public bool HDCPSupport { get; set; }

        public int PowerUsage { get; set; } 

        public bool Curved { get; set; } 

        public string PowerSupply { get; set; }

        public int Assessment { get; set; }

        public int BrandId { get; set; }
    }
}
