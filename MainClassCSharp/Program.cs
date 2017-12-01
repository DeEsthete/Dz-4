using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClassCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Fridgecs[] fridge = new Fridgecs[5];
            fridge[0] = new Fridgecs("2000", "White Bear", 20000, 10, 5);
            fridge[1] = new Fridgecs("2500", "White Bear", 25000, 9, 5);
            fridge[2] = new Fridgecs("3000", "White Bear", 40000, 12, 7);
            fridge[3] = new Fridgecs("3000s", "White Bear", 45000, 11, 6);
            fridge[4] = new Fridgecs("L100", "White Bear", 42000, 21, 15);
            Console.ReadLine();
        }
    }
}
