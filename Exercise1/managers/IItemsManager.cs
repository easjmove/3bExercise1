using Exercise1.models;
using System.Collections.Generic;

namespace Exercise1.managers
{
    public interface IItemsManager
    {
        Item Add(Item newItem);
        Item Delete(int id);
        IEnumerable<Item> GetAll(string name);
        Item GetById(int id);
        Item Update(int id, Item updates);
    }
}