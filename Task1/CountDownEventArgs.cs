using System;
using System.Net.Http;

namespace Task1
{
    public class CountDownEventArgs:EventArgs
    {
        public string Message { get; set; }
        public CountDownEventArgs(string str)
        {
            Message = str;
        }
    }
}