using Analiz_monitor;
using Analiz_monitorService.BindingModel;
using Analiz_monitorService.Interface;
using System;
using System.Windows.Forms;

namespace Analiz_monitorForms
{
    public partial class FormAddMarkParam : Form
    {
        public MarkParametrBindingModel model { set; get; }

        public int Id { set { id = value; } }

        private readonly IMarkParametr _serviceMP;

        private int? id;

        public FormAddMarkParam(IMarkParametr serviceMP)
        {
            _serviceMP = serviceMP;
            InitializeComponent();
        }

        private void FormAddMarkParam_Load(object sender, EventArgs e)
        {
            comboBox_Mark.DataSource = Enum.GetValues(typeof(Marks));
            if (id.HasValue)
            {
                try
                {
                    MarkParametrBindingModel view = _serviceMP.GetElement(id.Value);
                    if (view != null)
                    {
                        comboBox_Mark.Text = Convert.ToString((Marks)view.Mark);
                        numericUpDown_MalDown.Value = view.Down;
                        numericUpDown_MalAr.Value = view.Average;
                        numericUpDown_MalUp.Value = view.Up;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            try
            {
                _serviceMP.CreateElement(new MarkParametrBindingModel
                {
                    Mark = (Marks)comboBox_Mark.SelectedValue,
                    Down = (int)numericUpDown_MalDown.Value,
                    Average = (int)numericUpDown_MalAr.Value,
                    Up = (int)numericUpDown_MalUp.Value
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
    }
}
