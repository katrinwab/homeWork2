using System.Collections.Generic;
using System.Linq;
using HomeWork2.Coin;

namespace HomeWork2
{
    class ProviderCoin : IProvider
    {
        private readonly ICoinList _coinList;

        public ProviderCoin(ICoinList coinList)
        {
            _coinList = coinList;
        }

        public List<ISubject> GetInformation()
        {
            return _coinList.List.Cast<ISubject>().ToList();
        }
    }
}
