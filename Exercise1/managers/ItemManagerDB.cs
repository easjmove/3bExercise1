using Exercise1.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1.managers
{
    public class ItemManagerDB : IItemsManager
    {
        private ItemContext _context;
        public ItemManagerDB(ItemContext context)
        {
            _context = context;
        }

        public Item Add(Item newItem)
        {
            newItem.Id = 0;
            _context.Items.Add(newItem);
            _context.SaveChanges();
            return newItem;
        }

        public Item Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Item> GetAll(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return _context.Items.ToList();
            }
            IEnumerable<Item> items = from item in _context.Items
                                      where item.Name.Contains(name)
                                      select item;
            return items;
        }

        public Item GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Item Update(int id, Item updates)
        {
            throw new NotImplementedException();
        }
    }
}
