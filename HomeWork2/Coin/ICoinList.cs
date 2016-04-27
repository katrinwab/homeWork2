using System.Collections.Generic;

namespace HomeWork2.Coin
{
    interface ICoinList
    {
        List<Coin> List { get; set; }

        void Init();
    }
}
