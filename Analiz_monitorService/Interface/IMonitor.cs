using Analiz_monitorService.BindingModel;
using Analiz_monitorService.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analiz_monitorService.Interface
{
    public interface IMonitor
    {
        void CreateElement(MonitorBindingModel model);

        void UpdElement(MonitorBindingModel model);

        void DelElement(int id);

        List<MonitorViewModel> GetList();

        MonitorViewModel GetElement(int id);
    }
}
