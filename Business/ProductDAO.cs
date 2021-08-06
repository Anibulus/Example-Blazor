using Entities;
using DataAccess;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Business
{
    public class ProductDAO:ICRUD<ProductEntity>,IDisposable
    {
        bool disposed = false;

        public List<ProductEntity> ItemList()
        {
            using(var db = new InventaryContext())
            {
                return db.Products.ToList();
            }
        }


        public static List<ProductEntity> Listado()
        {
            using(var db = new InventaryContext())
            {
                return db.Products.ToList();
            }
        }

        public ProductEntity SelectItem(string id)
        {
            using(var db = new InventaryContext())
            {
                return db.Products.ToList().LastOrDefault(x=>x.ProductId==id);
            }
        }

        public void CreateItem(ProductEntity item)
        {
            using(var db = new InventaryContext())
            {
                db.Products.Add(item);
                db.SaveChanges();
            }
        }
        public void UpdateItem(ProductEntity item)
        {
            using(var db = new InventaryContext())
            {
                db.Products.Update(item);
                db.SaveChanges();
            }
        }
        public void DeleteItem(ProductEntity item)
        {
            using(var db = new InventaryContext())
            {
                db.Products.Remove(item);
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