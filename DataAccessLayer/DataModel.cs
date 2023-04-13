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

        #region Category Operations
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
                    c.picture = !reader.IsDBNull(3) ? reader.GetString(3) : "none.png";
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
        public Category getCategory(int id)
        {
            try
            {
                cmd.CommandText = "SELECT CategoryID, CategoryName, Description FROM Categories WHERE CategoryID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Category c = new Category();
                while (reader.Read())
                {
                    c.ID = reader.GetInt32(0);
                    c.categoryName = reader.GetString(1);
                    c.description = !reader.IsDBNull(2) ? reader.GetString(2) : "Açıklama Yok";
                }
                return c;
            }
            catch
            {
                return null;
            }
            finally { con.Close(); }
        }
        public Category categoryAdd(Category model)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Categories(CategoryName,Description,Picture) VALUES(@cName,@description,@picture) SELECT @@IDENTITY";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cName", model.categoryName);
                cmd.Parameters.AddWithValue("@description", model.description);
                cmd.Parameters.AddWithValue("@picture", model.picture);
                con.Open();
                model.ID = Convert.ToInt32(cmd.ExecuteScalar());
                return model;
            }
            catch
            {
                return null;
            }
            finally { con.Close(); }
        }
        public bool updateCategories(Category c)
        {
            try
            {
                cmd.CommandText = "UPDATE Categories SET CategoryName = @cName, Description = @description, Picture = @picture  WHERE CategoryID = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cName", c.categoryName);
                cmd.Parameters.AddWithValue("@description", c.description);
                cmd.Parameters.AddWithValue("@id", c.ID);
                cmd.Parameters.AddWithValue("@picture", c.picture);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally { con.Close(); }
        }
        public bool removeCategory(int id)
        {
            try
            {
                cmd.CommandText = "DELETE Categories WHERE CategoryID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("id", id);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally { con.Close(); }
        }
        #endregion

        #region Customers Operations
        public List<Customers> customerList()
        {
            List<Customers> cstmrs = new List<Customers>();
            try
            {
                cmd.CommandText = "SELECT [CustomerID],[CompanyName],[ContactName],[ContactTitle],[Address],[City],[Region],[PostalCode],[Country],[Phone],[Fax] FROM Customers";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Customers c = new Customers();
                while (reader.Read())
                {
                    c.ID = reader.GetString(0);
                    c.companyName = reader.GetString(1);
                    c.contactName = reader.GetString(2);
                    c.contactTitle = reader.GetString(3);
                    c.address = reader.GetString(4);
                    c.city = reader.GetString(5);
                    c.region = reader.GetString(6);
                    c.postalCode = reader.GetString(7);
                    c.country = reader.GetString(8);
                    c.phone = reader.GetString(9);
                    c.fax = reader.GetString(10);
                    cstmrs.Add(c);
                }
                return cstmrs;
            }
            catch
            {
                return null;
            }
            finally { con.Close(); }
        }
        public Customers getCustomers(string id)
        {
            try
            {
                cmd.CommandText = "SELECT [CustomerID],[CompanyName],[ContactName],[ContactTitle],[Address],[City],[Region],[PostalCode],[Country],[Phone],[Fax] FROM Customers WHERE CustomerID = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Customers c = new Customers();
                while (reader.Read())
                {
                    c.ID = reader.GetString(0);
                    c.companyName = reader.GetString(1);
                    c.contactName = reader.GetString(2);
                    c.contactTitle = reader.GetString(3);
                    c.address = reader.GetString(4);
                    c.city = reader.GetString(5);
                    c.region = reader.GetString(6);
                    c.postalCode = reader.GetString(7);
                    c.country = reader.GetString(8);
                    c.phone = reader.GetString(9);
                    c.fax = reader.GetString(10);
                }
                return c;
            }
            catch
            {
                return null;
            }
            finally { con.Close(); }
        }
        public void customerAdd(Customers model)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Customers([CustomerID],[CompanyName],[ContactName],[ContactTitle],[Address],[City],[Region],[PostalCode],[Country],[Phone],[Fax]) VALUES(@ID, @companyName, @contactName, @contactTitle, @address, @city, @region, @postalCode, @country, @phone, @fax) SELECT @@IDENTITY";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID", model.ID);
                cmd.Parameters.AddWithValue("@companyName", model.companyName);
                cmd.Parameters.AddWithValue("@contactName", model.contactName);
                cmd.Parameters.AddWithValue("@contactTitle", model.contactTitle);
                cmd.Parameters.AddWithValue("@address", model.address);
                cmd.Parameters.AddWithValue("@city", model.city);
                cmd.Parameters.AddWithValue("@region", model.region);
                cmd.Parameters.AddWithValue("@postalCode", model.postalCode);
                cmd.Parameters.AddWithValue("@country", model.country);
                cmd.Parameters.AddWithValue("@phone", model.phone);
                cmd.Parameters.AddWithValue("@fax", model.fax);
                cmd.ExecuteNonQuery();
            }
            finally { con.Close(); }
        }
        public bool updateCustomer(Customers model)
        {
            try
            {
                cmd.CommandText="UPDATE Customers SET CompanyName = @companyName, ContactName = @contactName, ContactTitle = @contactTitle, Address = @address, City = @city, Region = @region, PostalCode = @postalCode, Country = @country, Phone = @phone, Fax = @fax";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID", model.ID);
                cmd.Parameters.AddWithValue("@companyName", model.companyName);
                cmd.Parameters.AddWithValue("@contactName", model.contactName);
                cmd.Parameters.AddWithValue("@contactTitle", model.contactTitle);
                cmd.Parameters.AddWithValue("@address", model.address);
                cmd.Parameters.AddWithValue("@city", model.city);
                cmd.Parameters.AddWithValue("@region", model.region);
                cmd.Parameters.AddWithValue("@postalCode", model.postalCode);
                cmd.Parameters.AddWithValue("@country", model.country);
                cmd.Parameters.AddWithValue("@phone", model.phone);
                cmd.Parameters.AddWithValue("@fax", model.fax);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally { con.Close(); }
        }
        public bool removeCustomer(string id)
        {
            try
            {
                cmd.CommandText = "DELETE Customers WHERE CustomerID = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
             }
            catch
            {
                return false;
            }
            finally { con.Close(); }
        }
        #endregion

        #region Employee Operations
        public Employee employeeLogin(string userName, string password)
        {
            Employee model = new Employee();
            try
            {
                cmd.CommandText = "SELECT EmployeeID FROM Employees WHERE UserName = @uName AND Password = @password";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@uName", userName);
                cmd.Parameters.AddWithValue("@password", password);
                con.Open();
                int id = Convert.ToInt32(cmd.ExecuteScalar());
                if (id > 0)
                {
                    model = GetEmployee(id);
                }
                return model;
            }
            catch
            {
                return null;
            }
            finally { con.Close(); }
        }
        public Employee GetEmployee(int id)
        {
            try
            {
                cmd.CommandText = "SELECT [EmployeeID], [UserName], [Password], [LastName], [FirstName], [Title], [TitleOfCourtesy], [BirthDate], [HireDate], [Address], [City], [Region], [PostalCode], [Country], [HomePhone], [Extension], [Notes], [ReportsTo], [PhotoPath], [TitleOfCourtesy] + ' ' + [FirstName] + ' ' + [LastName] FROM Employees WHERE EmployeeID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                if (con.State != System.Data.ConnectionState.Open)
                {
                    con.Open();
                }
                SqlDataReader reader = cmd.ExecuteReader();
                Employee model = new Employee();
                while (reader.Read())
                {
                    model.ID = reader.GetInt32(0);
                    model.userName = reader.GetString(1);
                    model.password = reader.GetString(2);
                    model.lastName = reader.GetString(3);
                    model.firstName = reader.GetString(4);
                    model.title = reader.GetString(5);
                    model.titleOfCourtesy = reader.GetString(6);
                    model.birthDate = reader.GetDateTime(7);
                    model.hireDate = reader.GetDateTime(8);
                    model.adress = reader.GetString(9);
                    model.city = reader.GetString(10);
                    model.region = !reader.IsDBNull(11) ? reader.GetString(11) : "";
                    model.postalCode = reader.GetString(12);
                    model.country = reader.GetString(13);
                    model.homePhone = reader.GetString(14);
                    model.extension = reader.GetString(15);
                    model.notes = reader.GetString(16);
                    model.reportsTo = !reader.IsDBNull(17) ? reader.GetInt32(17) : 0;
                    model.photoPath = reader.GetString(18);
                    model.fullName = reader.GetString(19);
                }
                return model;
            }
            catch
            {
                return null;
            }
            finally { con.Close(); }
        }
        #endregion

        #region Orders Operations

        #endregion

        #region Product Operations
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
        #endregion

        #region Shippers Operations

        #endregion

        #region Suppliers Operations

        #endregion



    }
}
