using Entities;
using DataAccess;
using System.Collections.Generic;
using System.Linq;

namespace Business
{
    public class InputOutputDAO:ICRUD<InputOutputEntity>
    {
        public List<InputOutputEntity> ItemList()
        {
            using(var db = new InventaryContext())
            {
                return db.InOuts.ToList();
            }
        }

        public void CreateItem(InputOutputEntity item)
        {
            using(var db = new InventaryContext())
            {
                db.InOuts.Add(item);
                db.SaveChanges();
            }
        }
        public void UpdateItem(InputOutputEntity item)
        {
            using(var db = new InventaryContext())
            {
                db.InOuts.Update(item);
                db.SaveChanges();
            }
        }
        public void DeleteItem(InputOutputEntity item)
        {
            using(var db = new InventaryContext())
            {
                db.InOuts.Remove(item);
                db.SaveChanges();
            }
        }
    }
}