using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagerSevice
{
    public class HoaDonService
    {
        RestaurantManagerEntities1 db = new RestaurantManagerEntities1();

        public void addBill(Bill bill)
        {
            db.Bills.Add(bill);
            db.SaveChanges();
        }

        public List<Bill> getAllBill()
        {
            return db.Bills.ToList();
        }

        public void addBillInfo(Bill_info bill_Info)
        {
            db.Bill_info.Add(bill_Info);
            db.SaveChanges();
        }

        public float getSumPrice(int id_bill)
        {
            float sum = 0;
            List<Bill_info> listBill = db.Bill_info.Where(bill => bill.id_bill == id_bill).ToList();
            foreach (Bill_info bill in listBill)
            {
                Food food = db.Foods.Where(f => f.id_food == bill.id_food).FirstOrDefault();
                float price = float.Parse(food.price.ToString());
                sum = sum + (price * float.Parse(bill.count_food.ToString()));
            }

            return sum;
        }
    }
}
