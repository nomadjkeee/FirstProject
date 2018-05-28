using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate void Mess(string Message);
    


    partial class Drink
    {

        
        public event Mess Info;
        
        List<Drink> list = new List<Drink>();

       
        public Drink()
        {
            water = 1000;
            cofee = 1000;
            sugar = 1000;

        }

        public Drink(string _name, int _water, int _sugar, int _cofee)
        {
            name = _name;
            water = Water - _water;
            sugar = Sugar - _sugar;
            cofee = Cofee - _cofee;
            
        }

        private string name;
        private static int water;
        private static int sugar;
        private static int cofee;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Sugar
        {
            get { return sugar; }

        }

        public int Water
        {
            
            get { return water; }

        }

        public int Cofee
        {
            get { return cofee; }

        }

    

        public void Balance() { BalanceCofee();BalanceSugar();BalanceWater(); }
        public void BalanceWater()
        {
            if (water < 10)
            {
                Info("Little small water");
                Console.WriteLine("Water " + Water);
            }
        }
        public void BalanceCofee()
        {
            if (cofee < 10)
            {
                Info("Little small coffee");
                Console.WriteLine("coffee " + Cofee);
            }

        }
        public void BalanceSugar()
        {
            if (sugar < 10)
            {
                Info("little small sugar");
                Console.WriteLine("sugar " + Sugar);
            }
            
        }

        public void Show(string msg) {Info(msg);}

        public void AddToList(Drink d) {list.Add(d);}
        public override string ToString()
        {
            string result;
            result = string.Format("Name - {0}, Water - {1}, sugar - {2}, cofee - {3} \n", name, water, sugar, cofee);
            return result;
        }

        private static void Drink_Info(string Message)
        {
            Console.WriteLine(Message);
        }
    }
}
