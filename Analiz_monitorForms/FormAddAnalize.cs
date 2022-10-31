using Analiz_monitor;
using System;
using System.Windows.Forms;
using Unity;

namespace Analiz_monitorForms
{
    public partial class FormAddAnalize : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        public TrebMonitor model { set; get; }

        public FormAddAnalize()
        {
            InitializeComponent();
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            try
            {
                model = new TrebMonitor
                {
                    Mark = (Marks)comboBox_Mark.SelectedValue
                };

                MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormAddAnalize_Load_1(object sender, EventArgs e)
        {
            comboBox_Mark.DataSource = Enum.GetValues(typeof(Marks));
        }
    }
}
