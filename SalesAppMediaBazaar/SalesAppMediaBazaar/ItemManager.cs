using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SalesAppMediaBazaar
{
    class ItemManager
    {
        private List<Item> items;
        private List<string> types;
        public ItemManager()
        {
            items = new List<Item>();
            types = new List<string>();
        }


        public void AddItem(int id, string type, string name, string model, int quantity)
        {
            Item item = new Item(id,type,name,model,quantity);
            this.items.Add(item);
        }
        public void AddType(string type)
        {
            types.Add(type);
        }
        public List<string> GetTypes()
        {
            return this.types;
        }
        public string[] SelectType(string type)
        {
            List<string> newlist = new List<string>();
            foreach(Item item in items)
            {
                if(item.Type==type)
                {
                    newlist.Add(item.ToString());
                }
            }
            return newlist.ToArray();
        }
        
    }
}
