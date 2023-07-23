using System.Collections.Generic;
using System.Linq;
using UndoAssessment.Models;

namespace UndoAssessment.Services
{
    internal abstract class DataStore<T> : IDataStore<T>
        where T : IModel
    {
        protected List<T> items;

        public bool AddItem(T item)
        {
            items.Add(item);

            return true;
        }

        public bool UpdateItem(T item)
        {
            var oldItem = items.First(arg => arg.Id == item.Id);
            oldItem = item;

            return true;
        }

        public bool DeleteItem(string id)
        {
            var qtyRemoved = items.RemoveAll(item => item.Id == id);

            return qtyRemoved != 0;
        }

        public T GetItem(string id) => items.FirstOrDefault(s => s.Id == id);

        public IEnumerable<T> GetItems() => items;
    }
}
