using System.Collections.Generic;
using System.Linq;
using HomeWork2.Drink;

namespace HomeWork2
{
    class ProviderDrink: IProvider
    {
        private readonly IDrinkList _drinkList;

        public ProviderDrink(IDrinkList drinkList)
        {
            _drinkList = drinkList;
        }

        public List<ISubject> GetInformation()
        {
            return _drinkList.List.Cast<ISubject>().ToList();
        }
    }
}
