using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaStringP1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string tekst = "Hrvatska ima more";
            string tekst2 = "Italija je prvak svijeta";

            Console.Write(tekst.Substring(0, 8));
            Console.WriteLine(tekst2.Substring(7, tekst.Length));

            Console.ReadKey();
        }
    }
}
