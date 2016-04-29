using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            var uc = new UnityContainer();
            uc.LoadConfiguration();
            var prov = uc.Resolve<IProvider>();
            var list = prov.GetInformation();
        }
    }
}
