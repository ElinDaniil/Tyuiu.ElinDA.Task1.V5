using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LaboratoryWorkBasicDataBase
{
    public partial class ChartsForm_EDA : Form
    {
        private List<Elements> records;
        public ChartsForm_EDA(List<Elements> data)
        {
            InitializeComponent();
            records = data;
        }
        private void ChartsForm_EDA_Load(object sender, EventArgs e)
        {

        }

        private void Chart_Click(object sender, EventArgs e)
        {
            // Создание нового графика
            Chart chart = new Chart();
            chart.Width = 600;
            chart.Height = 400;

            // Добавление графика на форму
            this.Controls.Add(chart);

            // Определение типа диаграммы
            chart.Series.Add("StorageAmount");
            chart.Series.Add("CostPerOrder");

            foreach (Elements element in records)
            {
                chart.Series["StorageAmount"].Points.AddXY(element.OrderName, element.StorageAmount);
                chart.Series["CostPerOrder"].Points.AddXY(element.OrderName, element.CostPerOrder);
            }

            // Настройка оси X
            chart.ChartAreas[0].AxisX.Interval = 1;
            chart.ChartAreas[0].AxisX.Title = "OrderName";
            chart.ChartAreas[0].AxisX.LabelStyle.Angle = -45;

            // Настройка оси Y
            chart.ChartAreas[0].AxisY.Title = "Values";

            // Установка заголовка графика
            chart.Titles.Add("График StorageAmount и CostPerOrder по OrderName");

            // Показываем график
            chart.Visible = true;
        }
    }
}
