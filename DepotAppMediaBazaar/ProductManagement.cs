using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepotAppMediaBazaar
{
    class ProductManagement
    {
        SQLConnProduct connProduct = new SQLConnProduct();
        List<Product> pendingProducts = new List<Product>();
        List<Product> currentProducts = new List<Product>();
        List<string> departments = new List<string>();
        public ProductManagement()
        {
            
        }

        //home
        public string GetName(string email)
        {
            if (connProduct.GetNameFromDb(email)[1] == "Male")
            {
                return $"Welcome Mr. {connProduct.GetNameFromDb(email)[0]}";
            }
            else
            {
                return $"Welcome Ms. {connProduct.GetNameFromDb(email)[0]}";
            }

        }

        public void AddProductDB(ProductType type, string name, string model, int quantity, string department)
        {
            connProduct.AddProductToDB(type, name, model, quantity, department);
        }
        public void UpdatePendingProductsFromDB()
        {
            pendingProducts = connProduct.GetPendingProductsInfoFromDB().ToList();
        }
        public void UpdateCurrentProductsFromDB()
        {
            currentProducts = connProduct.GetCurrentProductsInfoFromDB().ToList();
        }
       
        public void InsertIntoCurrentStock(string id)
        {
            connProduct.InsertIntoCurrentStockDB(id);
        }
        public void UpdateProducts(string id, string type, string model, string name, int quantity, string department)
        {
            connProduct.UpdateProductInformationDB(id, type, model, name, quantity, department);
        }
  
        // Return pending products to array
        public string[] PendingProducts()
        {
            UpdatePendingProductsFromDB();
            List<string> pendingPr = new List<string>();
            foreach  (Product pr in pendingProducts)
            {
                pendingPr.Add(pr.ToString());
            }
            return pendingPr.ToArray();
        }
        public string[] CurrentProducts()
        {
            UpdateCurrentProductsFromDB();
            List<string> currentPr = new List<string>();
            foreach (Product pr in currentProducts)
            {
                currentPr.Add(pr.ToString());
            }
            return currentPr.ToArray();
        }
        // Get details of a current product and return in into array
        public string[] GetCurrentProductDetails(string id)
        {
            UpdateCurrentProductsFromDB();
            List<string> productDetails = new List<string>();
            foreach (Product pr in currentProducts)
            {
                if(pr.ID == Convert.ToInt32(id))
                {
                    productDetails.Add(pr.ID.ToString());
                    productDetails.Add(pr.type.ToString());
                    productDetails.Add(pr.name);
                    productDetails.Add(pr.model);
                    productDetails.Add(pr.quantity.ToString());
                    productDetails.Add(pr.department.ToString());
                }
            }
            return productDetails.ToArray();
        }
        // Get details of a pending product and return in into array
        public string[] GetPendingProductDetails(string id)
        {
            UpdatePendingProductsFromDB();
            List<string> productDetails = new List<string>();
            foreach (Product pr in pendingProducts)
            {
                if (pr.ID == Convert.ToInt32(id))
                {
                    productDetails.Add(pr.ID.ToString());
                    productDetails.Add(pr.type.ToString());
                    productDetails.Add(pr.name);
                    productDetails.Add(pr.model);
                    productDetails.Add(pr.quantity.ToString());
                    productDetails.Add(pr.department.ToString());
                }
            }
            return productDetails.ToArray();
        }
       

        public Product[] GetAvailableProducts()
        {
            UpdateCurrentProductsFromDB();
            List<Product> availableProducts = new List<Product>();
            foreach (Product product in currentProducts)
            {
                if(product.quantity > 0)
                {
                    availableProducts.Add(product);
                }
            }
            return availableProducts.ToArray();
        }

        public Product[] GetUnavailableProducts()
        {
            UpdateCurrentProductsFromDB();
            List<Product> unavailableProducts = new List<Product>();
            foreach (Product product in currentProducts)
            {
                if (product.quantity == 0)
                {
                    unavailableProducts.Add(product);
                }
            }
            return unavailableProducts.ToArray();
        }

        public Product[] GetCurrentProductsPerDepartment(string department)
        {
            UpdateCurrentProductsFromDB();
            List<Product> productDetails = new List<Product>();
            foreach(Product pr in currentProducts)
            {
                if (pr.department == department)
                {
                    productDetails.Add(pr);
                }
            }
            return productDetails.ToArray();
        }

        public void UpdateDepartmentsList() //updates list from db
        {
            departments = connProduct.UpdateListDepartments().ToList();
        }
        public string[] GetDepartments()
        {
            return this.departments.ToArray();
        }

    }
}
