using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesAppMediaBazaar
{
    class Item
    {
        private int id;
        private string type;
        private string name;
        private string model;
        private int quantity;

        public int ID
        {
            get { return this.id; }
        }
        public string Type
        {
            get { return this.type; }
        }
        public int Quantity
        {
            get { return this.quantity; }
        }
        public Item(int id,string type,string name,string model,int quantity)
        {
            this.id = id;
            this.type = type;
            this.name = name;
            this.model = model;
            this.quantity = quantity;
        }
        public string ToString()
        {
            return $"#{this.id} |  {this.type}  {this.name}  {this.model}  Quantity:{this.quantity}";
        }
      

    }
}
