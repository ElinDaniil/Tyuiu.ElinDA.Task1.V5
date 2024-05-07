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
    public partial class SortForm_EDA : Form
    {
        public string SortBy { get; set; }
        List<Elements> records;
        List<Suppliers> suppliers;
        public SortForm_EDA(List<Elements> data)
        {
            InitializeComponent();
            records = data;
            radioButtonStorageAmount.Checked = true;
        }
        private void ButtonSort_EDA_Click(object sender, EventArgs e)
        {
            if (radioButtonStorageAmount.Checked)
            {
                SortBy = "StorageAmount";
            }
            else if (radioButtonCostPerOrder.Checked)
            {
                SortBy = "CostPerOrder";
            }

            this.Close();
        }
    }
}
