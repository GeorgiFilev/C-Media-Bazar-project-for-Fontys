using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepotAppMediaBazaar
{
    class Product
    {
        private int Id;
        private ProductType Type;
        private string Name;
        private string Model;
        private int Quantity;
        private string Department;


        public int ID { get { return this.Id; } }
        public ProductType type { get { return this.Type; } }
        public string name { get { return this.Name; } }
        public string model { get { return this.Model; } }
        public int quantity
        {
            get
            {
                if (this.Quantity < 0)
                {
                    return 0;
                }
                else
                {
                    return this.Quantity;
                }
            }
        }
        public string department { get { return this.Department; } }

        public Product(ProductType type, string name, string model, int quantity, string department)
        {
            this.Type = type;
            this.Name = name;
            this.Model = model;
            this.Quantity = quantity;
            this.Department = department;
        }
        public Product(int id, string type, string name, string model, int quantity, string department)
        {
            this.Id = id;
            this.Type = (ProductType)Enum.Parse(typeof(ProductType), type, true);
            this.Name = name;
            this.Model = model;
            this.Quantity = quantity;
            this.Department = department;
        }
        public override string ToString()
        {
            return $"{this.Id} {this.Name} {this.Model}";
        }

    }
}
