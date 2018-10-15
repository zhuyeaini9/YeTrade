using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime a = new DateTime(2001, 1, 1);
            Console.WriteLine(a.ToShortDateString());
        }
    }
}
