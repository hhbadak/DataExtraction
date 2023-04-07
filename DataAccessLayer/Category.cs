using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Category
    {
        public int ID { get; set; }
        public string categoryName { get; set; }
        public string description { get; set; }
        public byte[] picture { get; set; }
    }
}
