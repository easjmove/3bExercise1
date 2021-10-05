using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1.models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ItemQuality { get; set; }
        public int Quantity { get; set; }

        public Item()
        {
        }

        public Item(int id, string name, int itemquality, int quantity)
        {
            Id = id;
            Name = name;
            ItemQuality = itemquality;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return "Id: " + Id + " - Name: " + Name + " - ItemQuality: " + ItemQuality + " - Quantity: " + Quantity;
        }
    }
}
