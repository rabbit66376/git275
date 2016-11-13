using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OK I got a new move");
            var data = new feature.data();
            data.name = "Johnson";

            Console.WriteLine(data.name);
            Console.Read();
        }
    }
}
