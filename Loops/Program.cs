using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ForLoop();
            ForEachLoop();
            Console.ReadKey();

        }
        static void ForLoop()
        {int numOfTacos = 10; for (int i = 0; i < 5; i++) { Console.WriteLine(i); } for (int i = 0; i < numOfTacos; numOfTacos--) { Console.WriteLine($"I eat a taco and now I have {numOfTacos} taco(s)!"); } System.Threading.Thread.Sleep(10); Console.WriteLine("nom nom nom"); Console.WriteLine("I am sad that I have no more tacos."); }

        static void ForEachLoop()
        { String[] shrimp = {"Pineapple Shrimp", "Coconut shrimp", "Blackened shrimp", "Shrimp gumbo", "Shrimp Parm", "Shrimp cocktail", "Cajuin shrimp", "Shrimp Scampi" }; foreach (var item in shrimp) { Console.WriteLine($"I like {item}."); } }
    }
}
