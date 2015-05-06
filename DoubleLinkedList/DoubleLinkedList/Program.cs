using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            List list = new List();

            list.AddNew("GG", "estla", 23);
            list.AddNew("Dom", "Est Gay", 44);
            list.AddNew("Etre", "Certain", 33);

           object[] info = list.Get(1);
           Console.WriteLine(info[0]);
           Console.WriteLine(info[1]);
           Console.WriteLine(info[2]);

           object[] infof = list.Get(2);
           Console.WriteLine(infof[0]);
           Console.WriteLine(infof[1]);
           Console.WriteLine(infof[2]);

           object[] infogg = list.Get(3);
           Console.WriteLine(infogg[0]);
           Console.WriteLine(infogg[1]);
           Console.WriteLine(infogg[2]);

           list.RemoveAt(1);

           object[] infoff = list.Get(2);
           Console.WriteLine(infoff[0]);
           Console.WriteLine(infoff[1]);
           Console.WriteLine(infoff[2]);
        }
    }
}
