using System.Collections.Generic;

namespace HomeWork2.Coin
{
    interface ICoinList
    {
        List<CoinObject> List { get; set; }

        void Init();
    }
}
