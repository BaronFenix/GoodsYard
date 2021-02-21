using System;
using System.Collections.Generic;
using System.Text;

namespace MiniShop.ShowCase
{
    public delegate void ShowcaseStateHandler(ShowcaseEventArgs args);
    public class ShowcaseEventArgs
    {
        public string Message { get; private set; }
        public string ShowcaseName { get; private set; }
        public int Volume { get; private set; }
        public string Guid { get; private set; }
        public ShowcaseEventArgs(string message,string showcaseName,int volume, string guid)
        {
            Message = message;
            ShowcaseName = showcaseName;
            Volume = volume;
            Guid = guid;
        }
    }
}
