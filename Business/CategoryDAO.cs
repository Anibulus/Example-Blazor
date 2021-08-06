using Entities;
using DataAccess;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Business
{
    public class CategoryDAO : ICRUD<CategoryEntity>, IDisposable
    {

        bool disposed = false;
        public List<CategoryEntity> ItemList()
        {
            using(var db = new InventaryContext())
            {
                return db.Categories.ToList();
            }
        }

        public void CreateItem(CategoryEntity item)
        {
            using(var db = new InventaryContext())
            {
                db.Categories.Add(item);
                db.SaveChanges();
            }
        }
        public void UpdateItem(CategoryEntity item)
        {
            using(var db = new InventaryContext())
            {
                db.Categories.Update(item);
                db.SaveChanges();
            }
        }
        public void DeleteItem(CategoryEntity item)
        {
            using(var db = new InventaryContext())
            {
                db.Categories.Remove(item);
                db.SaveChanges();
            }
        }
        
        public void Dispose()
        {
            Dispose(disposing: true);
            // This object will be cleaned up by the Dispose method.
            // Therefore, you should call GC.SuppressFinalize to
            // take this object off the finalization queue
            // and prevent finalization code for this object
            // from executing a second time.
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;
            disposed = true;
        }
    }
}