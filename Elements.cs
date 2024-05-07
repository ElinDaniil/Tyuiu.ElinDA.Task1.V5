using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryWorkBasicDataBase
{
    public class Elements
    {
        public int OrderCode { get; set; }
        public string OrderName { get; set; }
        public int StorageAmount { get; set; }
        public int CostPerOrder { get; set; }
        public string OrderDescription { get; set; }

    }
    public class Suppliers
    {
        public int SupplierCode { get; set; }
        public int OrderCode { get; set; }
        public string SupplierName { get; set; }
        public int DaysUntilArrival { get; set; }
        public int AmountOfOrder { get; set; }

    }
    public class FilterAppliedEventArgs : EventArgs
    {
        public List<Elements> FilteredRecords { get; }

        public FilterAppliedEventArgs(List<Elements> filteredRecords)
        {
            FilteredRecords = filteredRecords;
        }
    }
}
