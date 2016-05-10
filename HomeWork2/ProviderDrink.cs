using System.Collections.Generic;
using System.Linq;
using HomeWork2.Drink;

namespace HomeWork2
{
    class ProviderDrink
    {
        private readonly IDrinkList _drinkList;

        public ProviderDrink(IDrinkList drinkList)
        {
            _drinkList = drinkList;
        }

        public List<DrinkObject> GetInformation()
        {
            return _drinkList.List;
        }
    }
}
