using Analiz_monitorService.BindingModel;
using Analiz_monitorService.Interface;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace Analiz_monitorForms
{
    public partial class FormBrands : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly IBrand _serviceB;

        public FormBrands(IBrand serviceB)
        {
            _serviceB = serviceB;
            InitializeComponent();
        }

        private void FormBrands_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                List<BrandBindingModel> list = _serviceB.GetList();
                if (list != null)
                {
                    dataGridView_Brands.DataSource = list;
                   // dataGridView_Brands.Columns[0].Visible = false;
                   // dataGridView_Brands.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormAddBrand>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void buttonUpd_Click(object sender, EventArgs e)
        {
            if (dataGridView_Brands.SelectedRows.Count == 1)
            {
                var form = Container.Resolve<FormAddBrand>();
                form.Id = Convert.ToInt32(dataGridView_Brands.SelectedRows[0].Cells[0].Value);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void button_Del_Click(object sender, EventArgs e)
        {
            if (dataGridView_Brands.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView_Brands.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        _serviceB.DelElement(id);
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
