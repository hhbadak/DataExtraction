using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Products
    {
        public int ID { get; set; }
        public string productName { get; set; }
        public string barcode { get; set; }
        public int supplierID { get; set; }
        public string supplierName { get; set; }
        public int categoryID { get; set; }
        public string categoryName { get; set; }
        public string quantityPerUnit { get; set; }
        public decimal unitPrice { get; set; }
        public Int16 unitInStock { get; set; }
        public Int16 unitsOnOrder { get; set; }
        public Int16 reorderLevel { get; set; }
        public bool discontinued { get; set; }
        public string imagePath { get; set; }
        public bool isFastProduct { get; set; }
    }
}
