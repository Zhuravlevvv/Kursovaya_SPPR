using Analiz_monitorService.BindingModel;
using Analiz_monitorService.Interface;
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
    public partial class FormMonitors : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly IMonitor service;

        public FormMonitors(IMonitor service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void FormMonitors_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                List<MonitorViewModel> list = service.GetList();
                if (list != null)
                {
                    dataGridView_Monitors.DataSource = list;
                    dataGridView_Monitors.Columns[0].Visible = false;
                    //dataGridView_Monitors.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormAddMonitor>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void buttonUpd_Click(object sender, EventArgs e)
        {
            if (dataGridView_Monitors.SelectedRows.Count == 1)
            {
                var form = Container.Resolve<FormAddMonitor>();
                form.Id = Convert.ToInt32(dataGridView_Monitors.SelectedRows[0].Cells[0].Value);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (dataGridView_Monitors.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView_Monitors.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        service.DelElement(id);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    LoadData();
                }
            }
        }
    }
}
