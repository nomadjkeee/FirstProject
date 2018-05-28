using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   partial class Drink
    {
        

        public void Menu()
        {
            bool m = true;
            string check = null;
            Info("This is cofee machine. Please check your drink... \n");
            Info("\t\t 1. Expresso");
            Info("\t\t 2. Americano");
            Info("\t\t 3. Ristretto");
            Info("\t\t 4. Tea");
            Info("\t\t 5. Show balance in machine");
            Info("\t\t 6. Exit\n");


            while (m)
            {
                
                check = default(string);
                Console.WriteLine("Check Drink\n");
                
                check = Console.ReadLine();
               

                switch(check)
                {
                    case "1":
                        {
                            MakeDrink("Expresso");
                            break;
                        }
                    case "2":
                        {
                            MakeDrink("Americano");
                            break;
                        }
                    case "3":
                        {
                            MakeDrink("Ristretto");
                            break;
                        }
                    case "4":
                        {
                           MakeDrink("Tea");
                            break;
                        }
                    case "6":
                        {
                            m = false;
                            break;
                        }
                    case "5":
                        {
                            Console.WriteLine("in cofee machine");
                            Console.WriteLine("Water - {0}",water);
                            Console.WriteLine("Sugar - {0}",sugar);
                            Console.WriteLine("Cofee - {0}",cofee);
                            break;
                        }
                    default:
                        {
                            // Console.WriteLine("One more please\n");
                            
                            continue;
                        }
                        
                }

                
            }
            
                 
        }
        public void MakeDrink(string name)
        {
            Balance();
            Drink d;
            int sugar;

            switch (name)
            {
                case "Expresso":
                    {
                        Console.WriteLine("How many sugar do you want ? ");
                        sugar = Console.Read();
                        d = new Drink("Expresso", 60, sugar, 2);
                        AddToList(d);
                        break;
                        
                    }
                case "Americano":
                    {
                        Console.WriteLine("How many sugar do you want ? ");
                        sugar = Console.Read();
                        d = new Drink("Americano", 120, sugar, 3);
                        AddToList(d);
                        //евент написати у кожноиу свычу щоб виводити на екран що кава зробленна
                        break;
                        
                    }
                case "Ristretto":
                    {
                        Console.WriteLine("How many sugar do you want ? ");
                        sugar = Console.Read();
                        d = new Drink("Ristretto", 30, sugar, 4);
                        AddToList(d);
                        break;
                    }
                case "Tea":
                    {
                        Console.WriteLine("How many sugar do you want ? ");
                        sugar = Console.Read();
                        d = new Drink("Tea", 180, sugar, 0);
                        AddToList(d);
                        break;
                    }
                default:
                    {
                        break;
                        
                    }
                    
                  

            }
           
        }
    }
}
