using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LaboratoryWorkBasicDataBase
{
    public partial class CalculationForm_EDA : Form
    {
        private List<Elements> records;
        public CalculationForm_EDA(List<Elements> data)
        {
            InitializeComponent();
            records = data;
        }

        private void CalculateStatistics()
        {
            int totalStorageAmount = records.Sum(x => x.StorageAmount);
            int totalCostPerOrder = records.Sum(x => x.CostPerOrder);
            double averageStorageAmount = records.Average(x => x.StorageAmount);
            double averageCostPerOrder = records.Average(x => x.CostPerOrder);
            int minStorageAmount = records.Min(x => x.StorageAmount);
            int maxStorageAmount = records.Max(x => x.StorageAmount);
            int minCostPerOrder = records.Min(x => x.CostPerOrder);
            int maxCostPerOrder = records.Max(x => x.CostPerOrder);

            // Присваиваем значения элементам управления на форме
            TextBoxTotalStorageAmount_EDA.Text = totalStorageAmount.ToString();
            TextBoxTotalCostPerOrder_EDA.Text = totalCostPerOrder.ToString();
            TextBoxAverageStorageAmount_EDA.Text = averageStorageAmount.ToString();
            TextBoxAverageCostPerOrder_EDA.Text = averageCostPerOrder.ToString();
            TextBoxMinStorageAmount_EDA.Text = minStorageAmount.ToString();
            TextBoxMaxStorageAmount.Text = maxStorageAmount.ToString();
            TextBoxMinCostPerOrder_EDA.Text = minCostPerOrder.ToString();
            TextBoxMaxCostPerOrder_EDA.Text = maxCostPerOrder.ToString();
        }
        private void CalculationForm_EDA_Load(object sender, EventArgs e)
        {
            int totalStorageAmount = records.Sum(x => x.StorageAmount);
            int totalCostPerOrder = records.Sum(x => x.CostPerOrder);
            double averageStorageAmount = records.Average(x => x.StorageAmount);
            double averageCostPerOrder = records.Average(x => x.CostPerOrder);
            int minStorageAmount = records.Min(x => x.StorageAmount);
            int maxStorageAmount = records.Max(x => x.StorageAmount);
            int minCostPerOrder = records.Min(x => x.CostPerOrder);
            int maxCostPerOrder = records.Max(x => x.CostPerOrder);

            // Присваиваем значения элементам управления на форме
            TextBoxTotalStorageAmount_EDA.Text = totalStorageAmount.ToString();
            TextBoxTotalCostPerOrder_EDA.Text = totalCostPerOrder.ToString();
            TextBoxAverageStorageAmount_EDA.Text = averageStorageAmount.ToString();
            TextBoxAverageCostPerOrder_EDA.Text = averageCostPerOrder.ToString();
            TextBoxMinStorageAmount_EDA.Text = minStorageAmount.ToString();
            TextBoxMaxStorageAmount.Text = maxStorageAmount.ToString();
            TextBoxMinCostPerOrder_EDA.Text = minCostPerOrder.ToString();
            TextBoxMaxCostPerOrder_EDA.Text = maxCostPerOrder.ToString();
        }

        private void ButtonClose_EDA_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
