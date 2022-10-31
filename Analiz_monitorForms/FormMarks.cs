using Analiz_monitorService.BindingModel;
using Analiz_monitorService.Interface;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace Analiz_monitorForms
{
    public partial class FormMarks : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly IMarkParametr _serviceMP;

        public FormMarks(IMarkParametr serviceMP)
        {
            _serviceMP = serviceMP;
            InitializeComponent();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormAddMarkParam>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void FormMarks_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                List<MarkParametrBindingModel> list = _serviceMP.GetList();
                if (list != null)
                {
                    dataGridView_Params.DataSource = list;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (dataGridView_Params.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView_Params.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        _serviceMP.DeleteElement(id);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    LoadData();
                }
            }
        }

        private void buttonUpd_Click(object sender, EventArgs e)
        {
            if (dataGridView_Params.SelectedRows.Count == 1)
            {
                var form = Container.Resolve<FormAddMarkParam>();
                form.Id = Convert.ToInt32(dataGridView_Params.SelectedRows[0].Cells[0].Value);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }
    }
}
