using System;
using System.Collections.Generic;
using System.Text;

namespace MiniShop.Reservoir
{
    interface IGoodsYard
    {
        string NameOfItem { get; }
        uint Cost { get; }
        uint Volume { get; }
        string IdentificateNumber { get; }
    }
}
