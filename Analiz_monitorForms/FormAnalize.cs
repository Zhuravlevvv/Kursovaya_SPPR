using Analiz_monitor;
using Analiz_monitorService.BindingModel;
using Analiz_monitorService.Interface;
using Analiz_monitorService.ViewModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace Analiz_monitorForms
{
    public partial class FormAnalize : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly IMonitor _serviceM;
        private readonly IMarkParametr _serviceMP;
        private readonly IBrand _serviceB;

        public int Id { set { id = value; } }
        private int? id;

        private List<TrebMonitor> TrebMonitors;

        public FormAnalize(IMonitor serviceM, IMarkParametr serviceMP, IBrand serviceB)
        {
            _serviceM = serviceM;
            _serviceMP = serviceMP;
            _serviceB = serviceB;
            InitializeComponent();
            TrebMonitors = new List<TrebMonitor>();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormAddAnalize>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (form.model != null)
                {
                    if (id.HasValue)
                    {
                        form.model.Id = id.Value;
                    }
                    TrebMonitors.Clear();
                    TrebMonitors.Add(form.model);
                }
                LoadData();
            }
        }

        private void LoadData()
        {
            try
            {
                if (TrebMonitors != null)
                {
                    dataGridView_Treb.DataSource = null;
                    dataGridView_Treb.DataSource = TrebMonitors;
                    dataGridView_Treb.Columns[0].Visible = false;
                    //F_Products.Columns[0].Visible = false;
                    //  F_Products.Columns[1].Visible = false;
                    //   F_Products.Columns[2].Visible = false;
                    // F_Products.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Del_Click(object sender, EventArgs e)
        {
            if (dataGridView_Treb.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        TrebMonitors.RemoveAt(dataGridView_Treb.SelectedRows[0].Cells[0].RowIndex);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    LoadData();
                }
            }
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            List<MonitorViewModel> mons = _serviceM.GetList(); //Мониторы
            for (int i = 0; i < mons.Count; i++)
            {
                if (Convert.ToString(comboBoxResolution.Text) != "" && Convert.ToString(comboBoxResolution.Text) != mons[i].Resolution)
                {
                    mons.Remove(mons[i]);
                    i--;
                }
                else if (Convert.ToString(comboBoxMatrixType.Text) != "" && Convert.ToString(comboBoxMatrixType.Text) != mons[i].MatrixType)
                {
                    mons.Remove(mons[i]);
                    i--;
                }
                else if (Convert.ToInt32(numericUpDownResponseTime.Value) > mons[i].ResponseTime)
                {
                    mons.Remove(mons[i]);
                    i--;
                }
                else if (textBoxFrequency.Text != "" && Convert.ToInt32(textBoxFrequency.Text) > mons[i].Frequency)
                {
                    mons.Remove(mons[i]);
                    i--;
                }
                else if (Convert.ToString(comboBoxPowerSupply.Text) != "" && Convert.ToString(comboBoxPowerSupply.Text) != mons[i].PowerSupply)
                {
                    mons.Remove(mons[i]);
                    i--;
                }
                else if (comboBoxBrand.Text != "" && Convert.ToInt32(comboBoxBrand.SelectedValue) != mons[i].BrandId)
                {
                    mons.Remove(mons[i]);
                    i--;
                }
                else if (Convert.ToInt32(numericUpDownDiagonal.Value) > mons[i].Diagonal)
                {
                    mons.Remove(mons[i]);
                    i--;
                }
                else if (checkBox.Checked == true && checkBoxHDTV.Checked != mons[i].HDTVSupport)
                {
                    mons.Remove(mons[i]);
                    i--;
                }
                else if (checkBox.Checked == true && checkBoxHDCP.Checked != mons[i].HDCPSupport)
                {
                    mons.Remove(mons[i]);
                    i--;
                }
                else if (checkBox.Checked == true && checkBoxCurved.Checked != mons[i].Curved)
                {
                    mons.Remove(mons[i]);
                    i--;
                }
            }   

            foreach (var treb in TrebMonitors) //требования которые мы выбрали
            {
                for(int i = 0; i < mons.Count; i++)
                {
                    if (GetMarky(mons[i], mons[i].Assessment) != treb.Mark)
                    {
                        mons.Remove(mons[i]);
                        i--;
                    }
                }

                /*int i = 0;
                foreach (var mon in mons)
                {
                    if (GetMarky(mon, mon.Assessment) != treb.Mark)
                    {
                        mons.Remove(mons[i]);
                        i--;
                    }
                    i++;
                }*/
            }
            var form = Container.Resolve<FormResult>();
            form.list = mons;
            form.Show();
        }

        public Marks GetMarky(MonitorViewModel monitor, int chislo)
        {
            Marks m = Marks.Рабочий;
            double prin = -100;

            List<MarkParametrBindingModel> markParametrs = _serviceMP.GetList();

            foreach (MarkParametrBindingModel mp in markParametrs)
            {
                double down = mp.Down;
                double av = mp.Average;
                double up = mp.Up;
                double p = -100;
                if (chislo < av)
                {
                    if (down == 0)
                    {
                        p = 0;
                    }
                    else
                    {
                        p = (chislo - down) / down;
                    }
                }
                else if (chislo == av)
                {
                    p = 1;
                }
                else
                {
                    p = 2 - (chislo / av);
                }
                if (p > prin)
                {
                    prin = p;
                    m = mp.Mark;
                }

            }
            return m;
        }

        private void FormAnalize_Load(object sender, EventArgs e)
        {
            try
            {
                List<BrandBindingModel> listV = _serviceB.GetList();
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
    }
}
