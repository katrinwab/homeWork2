using System;
using System.Collections.Generic;

namespace HomeWork2.Drink
{
    interface IDrinkList
    {
        List<Drink> List { get; set; }

        void Init();
    }
}
