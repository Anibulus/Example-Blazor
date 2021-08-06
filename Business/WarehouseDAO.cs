using Entities;
using DataAccess;
using System.Collections.Generic;
using System.Linq;

namespace Business
{
    public class WarehouseDAO:ICRUD<WarehouseEntity>
    {
        public List<WarehouseEntity> ItemList()
        {
            using(var db = new InventaryContext())
            {
                return db.Warehouses.ToList();
            }
        }

        public void CreateItem(WarehouseEntity item)
        {
            using(var db = new InventaryContext())
            {
                db.Warehouses.Add(item);
                db.SaveChanges();
            }
        }
        public void UpdateItem(WarehouseEntity item)
        {
            using(var db = new InventaryContext())
            {
                db.Warehouses.Update(item);
                db.SaveChanges();
            }
        }
        public void DeleteItem(WarehouseEntity item)
        {
            using(var db = new InventaryContext())
            {
                db.Warehouses.Remove(item);
                db.SaveChanges();
            }
        }
    }
}