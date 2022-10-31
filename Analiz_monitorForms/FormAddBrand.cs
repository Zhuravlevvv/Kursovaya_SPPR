using Analiz_monitorService.BindingModel;
using Analiz_monitorService.Interface;
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
    public partial class FormAddBrand : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        public int Id { set { id = value; } }

        private readonly IBrand service;

        private int? id;

        public FormAddBrand(IBrand service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void FormAddBrand_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    BrandBindingModel view = service.GetElement(id.Value);
                    if (view != null)
                    {
                        textBoxName.Text = view.Name;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Введите Название", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (id.HasValue)
                {
                    service.UpdElement(new BrandBindingModel
                    {
                        Id = id.Value,
                        Name = textBoxName.Text
                    });
                }
                else
                {
                    service.CreateElement(new BrandBindingModel
                    {
                        Name = textBoxName.Text
                    });
                }
                MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
