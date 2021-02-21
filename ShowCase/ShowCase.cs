using System;
using System.Collections.Generic;
using System.Text;

namespace MiniShop.ShowCase
{
    public partial class ShowCases
    {
        private class ShowCase : IShowCase
        {
            public string Name { get; set; }
            public int Volume { get; }
            public string DateOfCreate { get; }
            public string DateOfRemove { get; set; }
            public string IdentificationNumber { get; }

            public ShowCase(string name, int volume)
            {
                Name = name;
                Volume = volume;
                DateOfCreate = DateTime.Now.ToShortTimeString().ToString();
                IdentificationNumber = Guid.NewGuid().ToString();
            }
        }
    }
}
