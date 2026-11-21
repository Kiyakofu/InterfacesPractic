using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesPractic
{
    interface ISort
    {
        void SortAsc();
        void SortDesc();
        void SortByParam(bool isAsc);
    }
}
