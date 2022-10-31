using Analiz_monitorService.BindingModel;
using Analiz_monitorService.Interface;
using Analiz_monitorService.ViewModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace Analiz_monitorForms
{
    public partial class FormAddMonitor : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        public int Id { set { id = value; } }

        private readonly IBrand serviceB;

        private readonly IMonitor serviceM;

        private int? id;

        public FormAddMonitor(IBrand serviceB, IMonitor serviceM)
        {
            InitializeComponent();
            this.serviceB = serviceB;
            this.serviceM = serviceM;
        }

        private void FormCreateZakaz_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    MonitorViewModel view = serviceM.GetElement(id.Value);
                    if (view != null)
                    {
                        textBoxName.Text = view.Name;
                        numericUpDownDiagonal.Value = view.Diagonal;
                        comboBoxResolution.Text = view.Resolution;
                        comboBoxMatrixType.Text = view.MatrixType;
                        numericUpDownResponseTime.Value = view.ResponseTime;
                        textBoxFrequency.Text = Convert.ToString(view.Frequency);
                        checkBoxHDTV.Checked = view.HDTVSupport;
                        checkBoxHDCP.Checked = view.HDCPSupport;
                        textBoxPowerUsage.Text = Convert.ToString(view.PowerUsage);
                        checkBoxCurved.Checked = view.Curved;
                        comboBoxPowerSupply.Text = view.PowerSupply;
                        numericUpDownAssessment.Value = view.Assessment;
                        comboBoxBrand.SelectedValue = view.BrandId;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            try
            {
                List<BrandBindingModel> listV = serviceB.GetList();
                if (listV != null)
                {
                    comboBoxBrand.DisplayMember = "Name";
                    comboBoxBrand.ValueMember = "Id";
                    comboBoxBrand.DataSource = listV;
                    comboBoxBrand.SelectedItem = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Введите название", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxResolution.Text == null)
            {
                MessageBox.Show("Выберите разрешение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxMatrixType.Text == null)
            {
                MessageBox.Show("Выберите тип матрицы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxFrequency.Text))
            {
                MessageBox.Show("Введите частоту", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxPowerUsage.Text))
            {
                MessageBox.Show("Введите энегопотребление", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                serviceM.CreateElement(new MonitorBindingModel
                {
                    Name = textBoxName.Text,
                    Diagonal = Convert.ToInt32(numericUpDownDiagonal.Value),
                    Resolution = Convert.ToString(comboBoxResolution.Text),
                    MatrixType = Convert.ToString(comboBoxMatrixType.Text),
                    ResponseTime = Convert.ToInt32(numericUpDownResponseTime.Value),
                    Frequency = Convert.ToInt32(textBoxFrequency.Text),
                    HDTVSupport = checkBoxHDTV.Checked,
                    HDCPSupport = checkBoxHDCP.Checked,
                    PowerUsage = Convert.ToInt32(textBoxPowerUsage.Text),
                    Curved = checkBoxCurved.Checked,
                    PowerSupply = Convert.ToString(comboBoxPowerSupply.Text),
                    Assessment = Convert.ToInt32(numericUpDownAssessment.Value),
                    BrandId = Convert.ToInt32(comboBoxBrand.SelectedValue)
                });
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
