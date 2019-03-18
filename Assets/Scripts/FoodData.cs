using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Data 
{
    public struct Food
    {
        public string name;
        public int calories;
        public int carbs;

        public Food(string n, int c, int ca)
        {
            name = n;
            calories = c;
            carbs = ca;
        }
    }

    public List<Food> list = new List<Food>();
    
    public Data()
    {                         //food  calories.gram  sugar.grams
        list.Add(new Food("Apple", 65, 19));
        list.Add(new Food("Carrot", 41, 3));
        list.Add(new Food("Banana", 105, 14));
        list.Add(new Food("Pear", 100, 17));
        list.Add(new Food("Tomato", 18, 3));
        list.Add(new Food("Onion", 40, 5));
        list.Add(new Food("Stawberry", 46, 7));
        list.Add(new Food("Potato Chips", 160, 1));
        list.Add(new Food("Cake", 400, 15));
        list.Add(new Food("Sub", 450, 3));
        list.Add(new Food("Bread", 150, 5));
        list.Add(new Food("Potato Chips", 160, 1));
        list.Add(new Food("Steak", 160, 0));
        list.Add(new Food("Coca-Cola", 110, 30));
        list.Add(new Food("Pepsi", 150, 41));
        list.Add(new Food("Slurpee", 170, 45));
        list.Add(new Food("Broccoli", 25, 2));
        list.Add(new Food("Swiss", 70, 0));
        list.Add(new Food("Mozzarella", 80, 0));
        list.Add(new Food("Milk", 130, 11));
        list.Add(new Food("Soda Water", 0, 0));
        list.Add(new Food("Juice", 120, 25));
        list.Add(new Food("Ramen", 210, 1));
        list.Add(new Food("Salad", 340, 2));
        list.Add(new Food("Microwave Meal", 400, 10));
    }
    public Food getFood(string food)
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].name.ToLower().Equals(food.ToLower()))
            {
                return list[i];
            }
        }
        return new Food("err",-1,-1);
    }
    public int getCalories(string food)
    {
        for (int i = 0; i < list.Count;i++)
        {
            if (list[i].name.ToLower().Equals(food.ToLower())){
                return list[i].calories;
            }
        }
        return -1;
    }
    public int getCarbs(string food)
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].name.ToLower().Equals(food.ToLower()))
            {
                return list[i].carbs;
            }
        }
        return -1;
    }
}
