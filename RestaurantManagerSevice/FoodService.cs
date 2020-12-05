using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagerSevice
{
 
    public class FoodService
    {
        RestaurantManagerEntities1 db = new RestaurantManagerEntities1();
        public List<Food> getAllFood()
        {
            var listFood = db.Foods.ToList();
            return listFood;
        }

        public void addFood(Food food)
        {
            db.Foods.Add(food);
            db.SaveChanges();
        }

        public void deleteFood(int id)
        {
            Food food = db.Foods.Where(f => f.id_food == id).FirstOrDefault();
            db.Foods.Remove(food);
            db.SaveChanges();
        }

        public void updateFood(Food food)
        {
            Food f = db.Foods.Where(fo => fo.id_food == food.id_food).FirstOrDefault();
            db.Entry(f).CurrentValues.SetValues(food);
            db.SaveChanges();
        }

        public List<Food>  getListFoodBySearch(String find)
        {
            return db.Foods.Where(f => f.foodname.ToLower().StartsWith(find.ToLower())).ToList();
        }
    }
}
