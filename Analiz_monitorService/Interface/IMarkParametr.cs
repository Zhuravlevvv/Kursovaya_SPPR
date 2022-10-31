using Analiz_monitor;
using Analiz_monitorService.BindingModel;
using System.Collections.Generic;

namespace Analiz_monitorService.Interface
{
    public interface IMarkParametr
    {
        void CreateElement(MarkParametrBindingModel model);

        void UpdElement(MarkParametrBindingModel model);

        void DelElement(MarkParametrBindingModel model);

        void DeleteElement(int id);

        List<MarkParametrBindingModel> GetList();

        MarkParametrBindingModel GetElement(int id);

        MarkParametrBindingModel GetElement(Marks mark);
    }
}
