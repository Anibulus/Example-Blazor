using Entities;
using DataAccess;
using System.Collections.Generic;
using System.Linq;

namespace Business
{
    public class StorageDAO:ICRUD<StorageEntity>
    {
        public List<StorageEntity> ItemList()
        {
            using(var db = new InventaryContext())
            {
                return db.Storages.ToList();
            }
        }

        public void CreateItem(StorageEntity item)
        {
            using(var db = new InventaryContext())
            {
                db.Storages.Add(item);
                db.SaveChanges();
            }
        }
        public void UpdateItem(StorageEntity item)
        {
            using(var db = new InventaryContext())
            {
                db.Storages.Update(item);
                db.SaveChanges();
            }
        }
        public void DeleteItem(StorageEntity item)
        {
            using(var db = new InventaryContext())
            {
                db.Storages.Remove(item);
                db.SaveChanges();
            }
        }
    }
}