using Analiz_monitorService.BindingModel;
using Analiz_monitorService.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace Analiz_monitorForms
{
    public partial class FormResult : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        public List<MonitorViewModel> list;
        BindingSource sourse;

        public FormResult()
        {
            list = new List<MonitorViewModel>();
            InitializeComponent();
        }

        private void FormResult_Load(object sender, EventArgs e)
        {
            sourse = new BindingSource();
            sourse.DataSource = list;
            dataGridView1.DataSource = sourse;
        }
    }
}
