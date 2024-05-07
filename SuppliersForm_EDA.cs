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
    public partial class SuppliersForm_EDA : Form
    {
        List<Elements> records;
        List<Suppliers> suppliers;
        public SuppliersForm_EDA(List<Elements> data)
        {
            InitializeComponent();
            records = data;
        }

        
        public static void ShowSearchResult(Suppliers searchResult)
        {
            // Отображение результатов поиска на форме
            // Например, обновление DataGrid с найденной информацией
            // BusinessDataView_EDA.DataSource = searchResult;
        }

        private void SuppliersForm_EDA_Load(object sender, EventArgs e)
        {

        }

        private void ButtonFileOpen_EDA_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var reader = new StreamReader(openFileDialog.FileName))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    suppliers = csv.GetRecords<Suppliers>().ToList();
                }
                BusinessDataView_EDA.DataSource = suppliers;

                MessageBox.Show("CSV файл успешно прочитан!");
            }
        }

        private void ButtonFileSave_EDA_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (.csv)|.csv";
            saveFileDialog.Title = "Сохранить файл CSV";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                    {
                        var csvWriter = new CsvWriter(sw, CultureInfo.InvariantCulture);
                        csvWriter.WriteRecords(BusinessDataView_EDA.DataSource as List<Elements>);
                    }

                    MessageBox.Show("CSV файл успешно сохранен!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при сохранении файла: " + ex.Message);
                }
            }
        }

        private void ButtonAddRow_EDA_Click(object sender, EventArgs e)
        {
            // Создание нового объекта Elements и добавление его в список records
            Suppliers newElement = new Suppliers
            {
                
                SupplierCode = 0,// Устанавливайте значения по умолчанию или оставляйте пустыми, в зависимости от вашей логики
                OrderCode = 0,
                SupplierName = "",
                DaysUntilArrival = 0,
                AmountOfOrder = 0,
            };

            suppliers.Add(newElement);

            // Обновление отображения DataGridView после добавления новой записи
            BusinessDataView_EDA.DataSource = null; // Сброс источника данных
            BusinessDataView_EDA.DataSource = suppliers; // Подключение обновленных данных
        }

        private void ButtonDeleteRow_EDA_Click(object sender, EventArgs e)
        {
            if (BusinessDataView_EDA.SelectedRows.Count > 0)
            {
                int selectedIndex = BusinessDataView_EDA.SelectedRows[0].Index;

                if (selectedIndex >= 0 && selectedIndex < suppliers.Count)
                {
                    suppliers.RemoveAt(selectedIndex);

                    // Обновление отображения DataGridView после удаления записи
                    BusinessDataView_EDA.DataSource = null; // Сброс источника данных
                    BusinessDataView_EDA.DataSource = suppliers; // Подключение обновленных данных
                }
            }
        }

        private void ButtonSeekThroughSuppliers_EDA_Click(object sender, EventArgs e)
        {
            SearchForm_EDA Search = new SearchForm_EDA(suppliers, records);
            Search.ShowDialog();
        }
    }
}
