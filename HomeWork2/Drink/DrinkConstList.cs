using System.Collections.Generic;

namespace HomeWork2.Drink
{
    class DrinkConstList: IDrinkList
    {
        public DrinkConstList()
        {
            Init();
        }

        public List<Drink> List { get; set; }

        public void Init()
        {
            List = new List<Drink>();
            List.Add(new Drink(10, 5, "Чай"));
            List.Add(new Drink(15, 3, "Кофе"));
            List.Add(new Drink(12, 10, "Молоко"));
            List.Add(new Drink(15, 7, "Какао"));
            List.Add(new Drink(11, 15, "Сок"));
            List.Add(new Drink(5, 6, "Вода"));
            List.Add(new Drink(20, 12, "Горячий шоколад"));
            List.Add(new Drink(14, 8, "Йогурт"));
            List.Add(new Drink(15, 20, "Газировка"));
            List.Add(new Drink(15, 7, "Кефир"));
        }
    }
}
