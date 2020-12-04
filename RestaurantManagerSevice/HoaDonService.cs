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

        public List<Bill_info> getBillInfoByid(int id_bill)
        {
            return db.Bill_info.Where(bill => bill.id_bill == id_bill).ToList();
        }

        public List<Bill> getBillStatus(int status)
        {
            return db.Bills.Where(bill => bill.status == status).ToList();
        }

        public void updateBill(Bill bill)
        {
            Bill b = db.Bills.Where(bil => bil.id_bill == bill.id_bill).FirstOrDefault();
            db.Entry(b).CurrentValues.SetValues(bill);
            db.SaveChanges();
        }

        public List<Bill> GetBillsByTable(int id_table)
        {
            return db.Bills.Where(bill => bill.id_table == id_table).ToList();
        }

        public int getSumBill()
        {
            return db.Bills.Count();
        }

        public float getSumPriceAllBill()
        {
            float sum = 0;
            List<Bill_info> listBill = db.Bill_info.ToList();
            foreach (Bill_info bill in listBill)
            {
                Food food = db.Foods.Where(f => f.id_food == bill.id_food).FirstOrDefault();
                float price = float.Parse(food.price.ToString());
                sum = sum + (price * float.Parse(bill.count_food.ToString()));
            }

            return sum;
        }

        public List<Bill> filterBill(DateTime from ,DateTime to)
        {
            return db.Bills.Where(bill => bill.Datecheckout >= from && bill.Datecheckout <= to).ToList();
        }

        public int sumBillFilter(DateTime from, DateTime to){
            return db.Bills.Where(bill => bill.Datecheckout >= from && bill.Datecheckout <= to).Count();
        }

        public float getSumFriceFilter(DateTime from, DateTime to)
        {
            List<Bill> bil = db.Bills.Where(bill => bill.Datecheckout >= from && bill.Datecheckout <= to).ToList();
            float sum = 0;
            foreach(Bill b in bil)
            {
                List<Bill_info> listBill = db.Bill_info.Where(bil_info => bil_info.id_bill == b.id_bill).ToList();
                foreach (Bill_info bill in listBill)
                {
                    Food food = db.Foods.Where(f => f.id_food == bill.id_food).FirstOrDefault();
                    float price = float.Parse(food.price.ToString());
                    sum = sum + (price * float.Parse(bill.count_food.ToString()));
                }
            }
            return sum;
        }
    }
}
