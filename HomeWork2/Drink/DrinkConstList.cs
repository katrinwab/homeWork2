using System.Collections.Generic;

namespace HomeWork2.Drink
{
    class DrinkConstList: IDrinkList
    {
        public DrinkConstList()
        {
            Init();
        }

        public List<DrinkObject> List { get; set; }

        public void Init()
        {
            List = new List<DrinkObject>();
            List.Add(new DrinkObject(10, 5, "Чай"));
            List.Add(new DrinkObject(15, 3, "Кофе"));
            List.Add(new DrinkObject(12, 10, "Молоко"));
            List.Add(new DrinkObject(15, 7, "Какао"));
            List.Add(new DrinkObject(11, 15, "Сок"));
            List.Add(new DrinkObject(5, 6, "Вода"));
            List.Add(new DrinkObject(20, 12, "Горячий шоколад"));
            List.Add(new DrinkObject(14, 8, "Йогурт"));
            List.Add(new DrinkObject(15, 20, "Газировка"));
            List.Add(new DrinkObject(15, 7, "Кефир"));
        }
    }
}
