using Analiz_monitor;
using Analiz_monitorService.BindingModel;
using Analiz_monitorService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Analiz_monitorService.ImplementationsBD
{
    public class BrandBD : IBrand
    {
        private DBContext context;

        public BrandBD(DBContext context)
        {
            this.context = context;
        }

        public void CreateElement(BrandBindingModel model)
        {
            Brand element = context.Brands.FirstOrDefault(rec => rec.Name == model.Name);
            if (element != null)
            {
                throw new Exception("Уже есть бренд с таким названием");
            }
            context.Brands.Add(new Brand
            {
                Name = model.Name
            });
            context.SaveChanges();
        }

        public void DelElement(int id)
        {
            Brand element = context.Brands.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                context.Brands.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }

        public BrandBindingModel GetElement(int id)
        {
            Brand element = context.Brands.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new BrandBindingModel
                {
                    Id = element.Id,
                    Name = element.Name,
                };
            }
            throw new Exception("Элемент не найден");
        }

        public List<BrandBindingModel> GetList()
        {
            List<BrandBindingModel> result = context.Brands
                .Select(rec => new BrandBindingModel
                {
                    Id = rec.Id,
                    Name = rec.Name,
                }).ToList();
            return result;
        }

        public void UpdElement(BrandBindingModel model)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    Brand element = context.Brands.FirstOrDefault(rec => rec.Id == model.Id);
                    if (element == null)
                    {
                        throw new Exception("Элемент не найден");
                    }
                    element.Name = model.Name;
                    context.SaveChanges();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

    }
}
