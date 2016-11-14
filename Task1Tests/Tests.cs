using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;

namespace Task1Tests
{
    class Tests
    {
        static void Main(string[] args)
        {
            CountDownWatch cdw = new CountDownWatch(1234);
            Subscriber1 sb1=new Subscriber1();
            Subscriber2 sb2=new Subscriber2();
            cdw.TimeIsOver += sb1.OverTime;
            cdw.TimeIsOver += sb2.OverTime;
            cdw.CountDown();
            Console.ReadLine();

        }
    }
}
