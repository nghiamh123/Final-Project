using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagerSevice
{
    public class TableService
    {
        RestaurantManagerEntities1 db = new RestaurantManagerEntities1();
        public List<TalbleFood> getTable()
        {
            return db.TalbleFoods.Where(tb => tb.status == false).ToList();
        }

        public void updateStatus(TalbleFood talbleFood)
        {
            TalbleFood tb = db.TalbleFoods.Where(tbl => tbl.id_table == talbleFood.id_table).FirstOrDefault();
            db.Entry(tb).CurrentValues.SetValues(talbleFood);
            db.SaveChanges();
        }
    }
}
