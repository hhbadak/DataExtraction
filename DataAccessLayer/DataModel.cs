using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAccessLayer
{
    public class DataModel
    {
        SqlConnection con; SqlCommand cmd;

        public DataModel()
        {
            con = new SqlConnection(ConnectionStrings.conStr);
            cmd = con.CreateCommand();
        }

        public List<Category> categoryList()
        {
            List<Category> categoryList = new List<Category>();
            try
            {
                cmd.CommandText = "SELECT CategoryID, CategoryName, Description, Picture FROM Categories";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Category c = new Category();
                    c.ID = reader.GetInt32(0);
                    c.categoryName = reader.GetString(1);
                    c.description = reader.GetString(2);
                    c.picture = (byte[])reader["Picture"];
                    categoryList.Add(c);
                }
                return categoryList;
            }
            catch
            {
                return null;
            }
            finally { con.Close(); }
        }
        public List<Products> productList()
        {
            List<Products> productList = new List<Products>();
            try
            {
                cmd.CommandText = "SELECT p.ProductID, p.ProductName, s.CompanyName, c.CategoryName, p.QuantityPerUnit, p.UnitPrice, p.UnitsInStock, p.UnitsOnOrder, p.ReorderLevel  FROM Products AS p\r\nJOIN Categories AS c ON c.CategoryID = p.CategoryID\r\nJOIN Suppliers AS s ON s.SupplierID = p.SupplierID\r\nWHERE Discontinued = 1";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Products p = new Products();
                    p.ID = reader.GetInt32(0);
                    p.productName = reader.GetString(1);
                    p.supplierName = reader.GetString(2);
                    p.categoryName = reader.GetString(3);
                    p.quantityPerUnit = reader.GetString(4);
                    p.unitPrice = reader.GetDecimal(5);
                    p.unitInStock = reader.GetInt16(6);
                    p.unitsOnOrder = reader.GetInt16(7);
                    p.reorderLevel = reader.GetInt16(8);
                    productList.Add(p);
                }
                return productList;
            }
            catch
            {
                return null;
            }
            finally { con.Close(); }
        }
        public void productAdd(Products p)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Products(ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued) VALUES (@pName, @sID, @cID, @qpUnit, @uPrice, @uiStock, @uoOrder, @rLevel, 1)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@pName", p.productName);
                cmd.Parameters.AddWithValue("@sID", p.supplierID);
                cmd.Parameters.AddWithValue("@cID", p.categoryID);
                cmd.Parameters.AddWithValue("@qpUnit", p.quantityPerUnit);
                cmd.Parameters.AddWithValue("@uPrice", p.unitPrice);
                cmd.Parameters.AddWithValue("@uiStock", p.unitInStock);
                cmd.Parameters.AddWithValue("@uoOrder", p.unitsOnOrder);
                cmd.Parameters.AddWithValue("@rLevel", p.reorderLevel);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            finally { con.Close(); }
        }
    }
}
