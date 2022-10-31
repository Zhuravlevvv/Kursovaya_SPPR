using Analiz_monitor;
using Analiz_monitorService.BindingModel;
using Analiz_monitorService.Interface;
using Analiz_monitorService.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analiz_monitorService.ImplementationsBD
{
    public class MonitorBD : IMonitor
    {
        private DBContext context;

        public MonitorBD(DBContext context)
        {
            this.context = context;
        }

        public void CreateElement(MonitorBindingModel model)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    Monitor element = context.Monitors.FirstOrDefault(rec => rec.Name == model.Name);
                    if (element != null)
                    {
                        throw new Exception("Уже есть монитор с таким названием");
                    }
                    Monitor mon = new Monitor
                    {
                        Name = model.Name,
                        Diagonal = model.Diagonal,
                        Resolution = model.Resolution,
                        MatrixType = model.MatrixType,
                        ResponseTime = model.ResponseTime,
                        Frequency = model.Frequency,
                        HDTVSupport = model.HDTVSupport,
                        HDCPSupport = model.HDCPSupport,
                        PowerUsage = model.PowerUsage,
                        Curved = model.Curved,
                        PowerSupply = model.PowerSupply,
                        Assessment = model.Assessment,
                        BrandId = model.BrandId
                    };
                    context.Monitors.Add(mon);
                    context.SaveChanges();

                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public void DelElement(int id)
        {
            Monitor element = context.Monitors.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                context.Monitors.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }

        public void UpdElement(MonitorBindingModel model)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    Monitor element = context.Monitors.FirstOrDefault(rec => rec.Id == model.Id);
                    if (element == null)
                    {
                        throw new Exception("Элемент не найден");
                    }
                    element.Name = model.Name;
                    element.Diagonal = model.Diagonal;
                    element.Resolution = model.Resolution;
                    element.MatrixType = model.MatrixType;
                    element.ResponseTime = model.ResponseTime;
                    element.Frequency = model.Frequency;
                    element.HDTVSupport = model.HDTVSupport;
                    element.HDCPSupport = model.HDCPSupport;
                    element.PowerUsage = model.PowerUsage;
                    element.Curved = model.Curved;
                    element.PowerSupply = model.PowerSupply;
                    element.Assessment = model.Assessment;
                    element.BrandId = model.BrandId;
                    context.SaveChanges();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public MonitorViewModel GetElement(int id)
        {
            Monitor element = context.Monitors.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new MonitorViewModel
                {
                    Id = element.Id,
                    Name = element.Name,
                    Diagonal = element.Diagonal,
                    Resolution = element.Resolution,
                    MatrixType = element.MatrixType,
                    ResponseTime = element.ResponseTime,
                    Frequency = element.Frequency,
                    HDTVSupport = element.HDTVSupport,
                    HDCPSupport = element.HDCPSupport,
                    PowerUsage = element.PowerUsage,
                    Curved = element.Curved,
                    PowerSupply = element.PowerSupply,
                    Assessment = element.Assessment,
                    BrandName = element.Brand.Name
                };
            }
            throw new Exception("Элемент не найден");
        }

        public List<MonitorViewModel> GetList()
        {
            List<MonitorViewModel> result = context.Monitors
                .Select(rec => new MonitorViewModel
                {
                    Id = rec.Id,
                    Name = rec.Name,
                    Diagonal = rec.Diagonal,
                    Resolution = rec.Resolution,
                    MatrixType = rec.MatrixType,
                    ResponseTime = rec.ResponseTime,
                    Frequency = rec.Frequency,
                    HDTVSupport = rec.HDTVSupport,
                    HDCPSupport = rec.HDCPSupport,
                    PowerUsage = rec.PowerUsage,
                    Curved = rec.Curved,
                    PowerSupply = rec.PowerSupply,
                    Assessment = rec.Assessment,
                    BrandId = rec.BrandId,
                    BrandName = rec.Brand.Name
                }).ToList();
            return result;
        }
    }
}
