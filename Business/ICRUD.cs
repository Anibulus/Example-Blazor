using System.Collections.Generic;

namespace Business
{
    public interface ICRUD<T>
    {
         List<T> ItemList();

         void CreateItem(T item);
         void UpdateItem(T item);
         void DeleteItem(T item);
    }
}