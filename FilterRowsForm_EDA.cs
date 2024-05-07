using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using System.IO;
using System.Globalization;
using Microsoft.VisualBasic;

namespace LaboratoryWorkBasicDataBase
{
    
    public partial class FilterRowsForm_EDA : Form
    {
        private List<Elements> originalRecords;
        public event EventHandler<FilterEventArgs> FilterApplied;
        public FilterRowsForm_EDA(List<Elements> records)
        {
            InitializeComponent();
            originalRecords = records;
        }
        private DataGridView BusinessDataView;
        private void FilterRowsForm_EDA_Load(object sender, EventArgs e)
        {

        }

        private void ButtonDeleteRows_EDA_Click(object sender, EventArgs e)
        {
            int costFilter;
            int storageFilter;
            // Получаем значения критериев из текстовых полей
            
            if (InputCostTextBox_EDA.Text == null || InputStorageTextBox_EDA.Text == null)
            {
                MessageBox.Show("Фильтрация невозможна, потому что существуют пустые поля");
            }
            // Фильтруем записи на основе заданных критериев

            else
            {
                costFilter = int.Parse(InputCostTextBox_EDA.Text);
                storageFilter = int.Parse(InputStorageTextBox_EDA.Text);
                List<Elements> filteredRecords = originalRecords.Where(record =>
                (record.CostPerOrder > costFilter || record.CostPerOrder < costFilter) &&
                (record.StorageAmount > storageFilter || record.StorageAmount < storageFilter)
            ).ToList();

                // Генерируем событие "Фильтр применен" и передаем отфильтрованные записи
                FilterApplied?.Invoke(this, new FilterEventArgs(filteredRecords));
                MessageBox.Show("Фильтрация завершена!");
                this.Close();
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    public class FilterEventArgs : EventArgs
    {
        public List<Elements> FilteredRecords { get; }

        public FilterEventArgs(List<Elements> filteredRecords)
        {
            FilteredRecords = filteredRecords;
        }
    }
}
