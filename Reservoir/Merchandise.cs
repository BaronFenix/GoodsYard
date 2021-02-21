using System;
using System.Collections.Generic;
using System.Text;

namespace MiniShop.Reservoir
{
    public partial class GoodsYard
    {
        private class Merchandise : IGoodsYard
        {
            public string NameOfItem { get; }
            public uint Cost { get; }
            public uint Volume { get; }
            public string IdentificateNumber { get; }
            public Merchandise(string nameOfItem, uint cost, uint volume)
            {
                NameOfItem = nameOfItem;
                Cost = cost;
                Volume = volume;
                IdentificateNumber = Guid.NewGuid().ToString();
            }
        }
    }
}
