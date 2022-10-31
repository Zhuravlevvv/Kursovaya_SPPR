using Analiz_monitor;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace Analiz_monitorService
{
    [Table("Analiz_monitor")]
    public class DBContext : DbContext
    {
        public DBContext()
        {
            //настройки конфигурации для entity
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        public virtual DbSet<Brand> Brands { get; set; }

        public virtual DbSet<Monitor> Monitors { get; set; }

        public virtual DbSet<MarkParametr> MarkParametrs { get; set; }
    }
}
