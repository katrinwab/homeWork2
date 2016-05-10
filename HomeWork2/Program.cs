using System;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            var uc = new UnityContainer();
            uc.LoadConfiguration("Const");
            var provDrink = uc.Resolve<ProviderDrink>();
            var listDrink = provDrink.GetInformation();
            foreach (var item in listDrink)
            {
                Console.Write("{2} Стоит {0}, Осталось {1}\n", item.Cost, item.Count, item.Name);
            }
            var provCoin = uc.Resolve<ProviderCoin>();
            var listCoin = provCoin.GetInformation();
            foreach (var item in listCoin)
            {
                Console.Write("{0} Заблокированно {1}\n", item.Rating, item.IsBlocked);
            }
            Console.ReadLine();
        }
    }
}
