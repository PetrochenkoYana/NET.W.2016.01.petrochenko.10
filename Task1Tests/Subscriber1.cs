using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;

namespace Task1Tests
{
    class Subscriber1
    {
        public void OverTime(object sender, CountDownEventArgs e) => Console.WriteLine(e.Message);
    }
}
