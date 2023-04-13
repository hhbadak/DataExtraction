﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace DataAccessLayer
{
    public class Orders
    {
        public int ID { get; set; }
        public string customerID { get; set; }
        public int employeeID { get; set; }
        public string employee { get; set; }
        public DateTime orderDate { get; set; }
        public DateTime requiredDate { get; set; }
        public DateTime shippedDate { get; set; }
        public int shipVia { get; set; }
        public decimal freight { get; set; }
        public string shipName { get; set; }
        public string shipAddress { get; set; }
        public string shipCity { get; set; }
        public string shipRegion { get; set; }
        public string shipPostalcode { get; set; }
        public string shipCountry { get; set; }
    }
}
