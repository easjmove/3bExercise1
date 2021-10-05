using Exercise1.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1.managers
{
    public class ItemsManager : IItemsManager
    {
        private static int _nextId = 1;
        private static readonly List<Item> Data = new List<Item>
        {
            new Item {Id = _nextId++, Name = "Cola", ItemQuality = 1, Quantity = 5},
            new Item {Id = _nextId++, Name = "Sparkling water", ItemQuality = 3, Quantity = 15},
            // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers
        };

        public IEnumerable<Item> GetAll(string name)
        {
            List<Item> items = new List<Item>(Data);
            if (name != null)
            {
                items = items.FindAll(item => item.Name != null && item.Name.StartsWith(name, StringComparison.OrdinalIgnoreCase));
            }

            return items;
        }

        public Item GetById(int id)
        {
            return Data.Find(item => item.Id == id);
        }

        public Item Add(Item newItem)
        {
            newItem.Id = _nextId++;
            Data.Add(newItem);
            return newItem;
        }

        public Item Delete(int id)
        {
            Item item = Data.Find(item1 => item1.Id == id);
            if (item == null) return null;
            Data.Remove(item);
            return item;
        }

        public Item Update(int id, Item updates)
        {
            Item item = Data.Find(item1 => item1.Id == id);
            if (item == null) return null;
            item.Name = updates.Name;
            item.ItemQuality = updates.ItemQuality;
            item.Quantity = updates.Quantity;
            return item;
        }
    }
}
