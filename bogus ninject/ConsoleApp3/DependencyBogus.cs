using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;

namespace ConsoleApp3
{
    class Program
    {
        public static IKernel AppKernel;
        
        /// <summary>
        /// дз без меню так як відстаю трохи
        /// з оперативкою щось не дуже вийшло все інше працює
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            ProductG p = new ProductG();
            ProductT t = new ProductT();
            //for(int i = 0;i<5;i++)
            //{
            //    t.AddProduct();
            //}

            //p.ShowPRoduct();
            //p.WriteFile();
            //p.ReadFile();
            for (int i = 0; i < 5; i++)
            {
                p.AddProduct();
            }
            t.AddProduct();
            t.ShowPRoduct();
            t.WriteDDR();


            Console.ReadLine();

            AppKernel = new StandardKernel(new UseG());
            

            var useG = AppKernel.Get<ProductG>();

            useG.AddProduct();
           

            Console.ReadLine();

        }
    }
}
