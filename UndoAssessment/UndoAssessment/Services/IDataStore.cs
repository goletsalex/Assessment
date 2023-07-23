using System.Collections.Generic;

namespace UndoAssessment.Services
{
    public interface IDataStore<T>
    {
        bool AddItem(T item);
        bool UpdateItem(T item);
        bool DeleteItem(string id);
        T GetItem(string id);
        IEnumerable<T> GetItems();
    }
}

