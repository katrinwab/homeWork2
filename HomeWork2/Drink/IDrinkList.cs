using System.Collections.Generic;

namespace HomeWork2.Drink
{
    interface IDrinkList
    {
        List<DrinkObject> List { get; set; }

        void Init();
    }
}
