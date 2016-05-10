using System.Collections.Generic;
using HomeWork2.Coin;

namespace HomeWork2
{
    class ProviderCoin
    {
        private readonly ICoinList _coinList;

        public ProviderCoin(ICoinList coinList)
        {
            _coinList = coinList;
        }

        public List<CoinObject> GetInformation()
        {
            return _coinList.List;
        }
    }
}
