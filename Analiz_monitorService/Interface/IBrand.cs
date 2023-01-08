using Analiz_monitorService.BindingModel;
using System.Collections.Generic;

namespace Analiz_monitorService.Interface
{
    public interface IBrand
    {
        void CreateElement(BrandBindingModel model);

        void UpdElement(BrandBindingModel model);

        void DelElement(int id);

        List<BrandBindingModel> GetList();

        BrandBindingModel GetElement(int id);
    }
}
