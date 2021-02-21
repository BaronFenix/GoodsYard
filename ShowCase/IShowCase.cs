using System;
using System.Collections.Generic;
using System.Text;

namespace MiniShop.ShowCase
{
    internal interface IShowCase
    {
        string Name { get; set; }
        int Volume { get; }
        string DateOfCreate { get; }
        public string DateOfRemove { get; set; }
        string IdentificationNumber { get; }
    }
}
