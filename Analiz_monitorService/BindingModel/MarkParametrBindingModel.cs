using Analiz_monitor;

namespace Analiz_monitorService.BindingModel
{
    public class MarkParametrBindingModel
    {
        public int Id { get; set; }

        public Marks Mark { get; set; }
        public int Down { get; set; }
        public int Average { get; set; }
        public int Up { get; set; }
    }
}
