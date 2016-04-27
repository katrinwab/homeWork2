using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            var uc = new UnityContainer();
            uc.LoadConfiguration("DrinkConst");
            var prov = uc.Resolve<IProvider>();
            prov.GetInformation();
        }
    }
}
