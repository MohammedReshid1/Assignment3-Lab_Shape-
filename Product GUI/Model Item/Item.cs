using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinApp.Model_Item
{
    internal class Item
    {   
        private static List<Item> items = new List<Item>();
        public string number { get; set; }
        public DateTime dates { get; set; }
        public string inventory_number { get; set; }
        public string object_name { get; set; }
        public string count { get; set; }
        public string price { get; set; }
        public bool isAvailable { get; set; }

        public static Item findOne(string number)
        {
            return items.Find(p => p.object_name == number);
        }

        public string save()
        {
            items.Add(this);
            return object_name;
        }

        public static List<Item> getAll()
        {
            return items;
        }

    }
}
