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
    public partial class FormMain : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        public FormMain()
        {
            InitializeComponent();
        }

        private void добавитьБрендToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormAddBrand>();
            form.ShowDialog();
        }

        private void списокБрендовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormBrands>();
            form.ShowDialog();
        }

        private void списокМониторовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormMonitors>();
            form.ShowDialog();
        }

        private void добавитьМониторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormAddMonitor>();
            form.ShowDialog();
        }

        private void анализToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormAnalize>();
            form.Show();
        }

        private void границыПараметровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormMarks>();
            form.Show();
        }
    }
}
