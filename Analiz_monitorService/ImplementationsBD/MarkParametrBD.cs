using Analiz_monitor;
using Analiz_monitorService.BindingModel;
using Analiz_monitorService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Analiz_monitorService.ImplementationsBD
{
    public class MarkParametrBD : IMarkParametr
    {
        private DBContext context;

        public MarkParametrBD(DBContext context)
        {
            this.context = context;
        }

        public void CreateElement(MarkParametrBindingModel model)
        {
            MarkParametr element = context.MarkParametrs.FirstOrDefault(rec => rec.Mark == model.Mark);
            if (element != null)
            {
                throw new Exception("Уже есть такой MarkParametr");
            }
            context.MarkParametrs.Add(new MarkParametr
            {
                Down = model.Down,
                Average = model.Average,
                Up = model.Up,
                Mark = model.Mark
            });
            context.SaveChanges();
        }

        public void DelElement(MarkParametrBindingModel model)
        {
            MarkParametr element = context.MarkParametrs.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                context.MarkParametrs.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }

        public void DeleteElement(int id)
        {
            MarkParametr element = context.MarkParametrs.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                context.MarkParametrs.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }

        public MarkParametrBindingModel GetElement(int id)
        {
            MarkParametr element = context.MarkParametrs.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new MarkParametrBindingModel
                {
                    Id = element.Id,
                    Down = element.Down,
                    Average = element.Average,
                    Up = element.Up,
                    Mark = element.Mark
                };
            }
            throw new Exception("Элемент не найден");
        }

        public MarkParametrBindingModel GetElement(Marks mark)
        {
            throw new NotImplementedException();
        }

        public List<MarkParametrBindingModel> GetList()
        {
            List<MarkParametrBindingModel> result = context.MarkParametrs
                .Select(rec => new MarkParametrBindingModel
                {
                    Id = rec.Id,
                    Down = rec.Down,
                    Average = rec.Average,
                    Up = rec.Up,
                    Mark = rec.Mark
                })
                .ToList();
            return result;
        }

        public void UpdElement(MarkParametrBindingModel model)
        {

        }
    }
}
