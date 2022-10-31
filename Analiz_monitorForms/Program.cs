using Analiz_monitorService;
using Analiz_monitorService.ImplementationsBD;
using Analiz_monitorService.Interface;
using System;
using System.Data.Entity;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;

namespace Analiz_monitorForms
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = BuildUnityContainer();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<FormMain>());
        }

        public static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();
            currentContainer.RegisterType<DbContext, DBContext>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IBrand, BrandBD>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IMonitor, MonitorBD>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IMarkParametr, MarkParametrBD>(new HierarchicalLifetimeManager());

            return currentContainer;
        }
    }
}
