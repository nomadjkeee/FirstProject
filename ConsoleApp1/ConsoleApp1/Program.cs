using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   
    
   

    class Program
    {

        static void Main(string[] args)
        {
            Drink drink = new Drink();
            drink.Info += Drink_Info;
            drink.Menu();
            Console.WriteLine("hello world;");
        }

        private static void Drink_Info(string Message)
        {
            Console.WriteLine(Message);
        }
    }
}
