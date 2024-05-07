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
    public partial class SearchForm_EDA : Form
    {
        private List<Suppliers> suppliers;
        private List<Elements> records;

        public SearchForm_EDA(List<Suppliers> data_suppliers, List<Elements>  data_orders)
        {
            InitializeComponent();
            suppliers = data_suppliers;
            records = data_orders;
        }

        private void SearchForm_EDA_Load(object sender, EventArgs e)
        {

        }

        private void ButtonSearch_EDA_Click(object sender, EventArgs e)
        {
            if (suppliers != null && suppliers.Any())
            {
                int orderCodeToSearch = Int32.Parse(OrderCodeTextBox_EDA.Text);
                var searchResultsSuppliers = suppliers.Where(s => s.OrderCode == orderCodeToSearch).ToList();
                var searchResultsOrders = records.Where(s => s.OrderCode == orderCodeToSearch).ToList();

                if (searchResultsSuppliers.Any() & searchResultsOrders.Any())
                {
                    BusinessDataView_EDA.DataSource = searchResultsSuppliers;
                }
                else
                {
                    MessageBox.Show("Строки с таким OrderCode не найдены в базе данных.");
                }
            }
            else
            {
                MessageBox.Show("Сначала загрузите второй CSV файл.");
            }
        }
    }
}
