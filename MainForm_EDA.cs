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
    public partial class MainForm_EDA : Form
    {
        List<Elements> records;
        List<Suppliers> suppliers;

        public MainForm_EDA()
        {
            InitializeComponent();
            ToolTip t = new ToolTip();
            t.SetToolTip(ButtonFileOpen_EDA, "Open CSV file");
            t.SetToolTip(ButtonFileSave_EDA, "Save current table file as CSV");
            t.SetToolTip(ButtonTableFilter_EDA, "Filter current table");
            t.SetToolTip(ButtonGraphBuild_EDA, "Build Graph");
            t.SetToolTip(ButtonSort_EDA, "Sort current table");
            t.SetToolTip(ButtonOpenCalculationsForm_EDA, "Do some calculation magic");
            t.SetToolTip(ButtonAddRow_EDA, "Add new row");
            t.SetToolTip(ButtonDeleteRow_EDA, "Delete selected row");
        }

        private void MainForm_EDA_Load(object sender, EventArgs e)
        {
            BusinessDataView_EDA.DataSource = records;
        }
        

        
        private void SortDataByCriteria(string criteria)
        {
            if (BusinessDataView_EDA.DataSource is List<Elements> records)
            {
                if (criteria.Equals("StorageAmount"))
                {
                    records = records.OrderBy(record => record.StorageAmount).ToList();
                }
                else if (criteria.Equals("CostPerOrder"))
                {
                    records = records.OrderBy(record => record.CostPerOrder).ToList();
                }

                BusinessDataView_EDA.DataSource = records; // Обновляем источник данных DataGridView
            }
        }


        






        
        public void ShowSearchResults(Suppliers searchResult)
        {
            // Отображение результатов поиска в SuppliersForm_EDA
            SuppliersForm_EDA.ShowSearchResult(searchResult);
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
                    records = csv.GetRecords<Elements>().ToList();
                }
                BusinessDataView_EDA.DataSource = records;

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

        private void ButtonSort_EDA_Click(object sender, EventArgs e)
        {
            SortForm_EDA formSort = new SortForm_EDA(records);
            formSort.ShowDialog();

            if (!string.IsNullOrEmpty(formSort.SortBy))
            {
                
                // Сортируем данные по выбранному критерию
                switch (formSort.SortBy)
                {
                    case "StorageAmount":
                        records = records.OrderBy(r => r.StorageAmount).ToList();
                        break;
                    case "CostPerOrder":
                        records = records.OrderBy(r => r.CostPerOrder).ToList();
                        break;
                }

                // Обновляем DataGrid с отсортированными данными
                BusinessDataView_EDA.DataSource = records;
            }
        }

        private void ButtonAddRow_EDA_Click(object sender, EventArgs e)
        {
            // Создание нового объекта Elements и добавление его в список records
            Elements newElement = new Elements
            {
                OrderCode = 0, // Устанавливайте значения по умолчанию или оставляйте пустыми, в зависимости от вашей логики
                OrderName = "",
                StorageAmount = 0,
                CostPerOrder = 0,
                OrderDescription = ""
            };

            records.Add(newElement);

            // Обновление отображения DataGridView после добавления новой записи
            BusinessDataView_EDA.DataSource = null; // Сброс источника данных
            BusinessDataView_EDA.DataSource = records; // Подключение обновленных данных
        }

        private void ButtonDeleteRow_EDA_Click(object sender, EventArgs e)
        {
            if (BusinessDataView_EDA.SelectedRows.Count > 0)
            {
                int selectedIndex = BusinessDataView_EDA.SelectedRows[0].Index;

                if (selectedIndex >= 0 && selectedIndex < records.Count)
                {
                    records.RemoveAt(selectedIndex);

                    // Обновление отображения DataGridView после удаления записи
                    BusinessDataView_EDA.DataSource = null; // Сброс источника данных
                    BusinessDataView_EDA.DataSource = records; // Подключение обновленных данных
                }
            }
        }

        private void ButtonGraphBuild_EDA_Click(object sender, EventArgs e)
        {
            this.ChartAmount_EDA.Series[0].Points.Clear();
            this.ChartCost_EDA.Series[0].Points.Clear();
            int counter = 0;
            foreach (var element in records)
            {
                // Получаем значения StorageAmount и CostPerOrder для каждого элемента
                int storageAmount = element.StorageAmount;
                int costPerOrder = element.CostPerOrder;
                this.ChartAmount_EDA.Series[counter].Points.Add(storageAmount);
                this.ChartCost_EDA.Series[counter].Points.Add(costPerOrder);

                // Здесь можете обновлять граф на основе полученных значений storageAmount и costPerOrder
                // Например, обновление данных на графике
            }
            MessageBox.Show("Граф успешно обновлен на основе данных из CSV файла!");

        }

        private void ButtonOpenCalculationsForm_EDA_Click(object sender, EventArgs e)
        {
            CalculationForm_EDA statisticsForm = new CalculationForm_EDA(records);
            statisticsForm.Show();
        }

        private void ButtonTableFilter_EDA_Click(object sender, EventArgs e)
        {
            FilterRowsForm_EDA filterForm = new FilterRowsForm_EDA(records); // Передаем данные из загруженного CSV файла на форму фильтрации
            filterForm.FilterApplied += FilterForm_FilterApplied; // Подписываемся на событие "Фильтр применен"
            filterForm.ShowDialog();
        }
        private void FilterForm_FilterApplied(object sender, FilterEventArgs e)
        {
            // Отображаем отфильтрованные данные в DataGrid на основной форме
            BusinessDataView_EDA.DataSource = e.FilteredRecords;
        }
        private void ButtonOpenSuppliers_EDA_Click(object sender, EventArgs e)
        {
            SuppliersForm_EDA SuppliersOpen = new SuppliersForm_EDA(records);
            SuppliersOpen.ShowDialog();
        }

        private void ButtonSeekThroughSuppliers_EDA_Click(object sender, EventArgs e)
        {
            SearchForm_EDA Search = new SearchForm_EDA(suppliers, records);
            Search.ShowDialog();
        }

        private void ButtonSearch_EDA_Click(object sender, EventArgs e)
        {
            string searchText = TextBoxSearch_EDA.Text.ToLower(); // Получаем текст для поиска из TextBox и приводим к нижнему регистру

            if (records != null && !string.IsNullOrWhiteSpace(searchText))
            {
                var searchResults = records.Where(record =>
                    record.OrderName.ToLower().Contains(searchText) ||
                    record.OrderDescription.ToLower().Contains(searchText)
                ).ToList(); // Ищем совпадения по наименованию заказа и описанию

                BusinessDataView_EDA.DataSource = searchResults; // Отображаем результаты в DataGridView
            }
        }
        private void FilterForm_FilterApplied(object sender, FilterAppliedEventArgs e)
        {
            // Отображение отфильтрованных данных в DataGrid на основной форме
            BusinessDataView_EDA.DataSource = e.FilteredRecords;
        }
    }
}
