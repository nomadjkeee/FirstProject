using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using Bogus.DataSets;
namespace ConsoleApp3
{
    class ProductG : IProduct
    {
        int _id;
        List<ProductG> p = new List<ProductG>();
        public int Id { get { return _id; } }
        public ProductG()
        {
            
        }
        
        public ProductG(int num)
        {
           this._id = num;
        }
        public string Country { get; set; }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        int userIds = 1;

        public void AddProduct()
        {

            var fruit = new[] { "apple", "banana", "orange", "strawberry", "kiwi", "potato", "grape", "pineapple" };
            
            var testProductG = new Faker<ProductG>("uk")
                .CustomInstantiator(f => new ProductG(userIds++))
                .RuleFor(u => u.Name, f => f.PickRandom(fruit))
                .RuleFor(u => u.Country, f => f.Address.Country());
            
                ProductG ProductItem = testProductG.Generate();
                p.Add(ProductItem);
               

        }
        public  void ShowPRoduct()
        {
           foreach(ProductG p in p)
                Console.WriteLine(p);

        }
        public override string ToString()
        {
            string result = string.Format("{0}. Name - {1}, Country - {2} ", Id, Name, Country);
            return result;
        }
        public void DeleteProduct(Object ob)
        {
            p.Remove((ProductG)ob);
        }
        public void ReadFile()
        {
            String line;
            try
            {
                
                StreamReader sr = new StreamReader("H:\\Test.txt");

                
                line = sr.ReadLine();

               
                while (line != null)
                {
                    
                    Console.WriteLine(line);
                  
                    line = sr.ReadLine();
                }

                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("End of Read");
            }
        }
        public void WriteFile()
        {
            try
            {

                StreamWriter sw = new StreamWriter("H:\\Test.txt");
                foreach(ProductG p in p)
                {
                    sw.WriteLine(p);
                }
                
                
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("End of write");
            }
        }


    }




}
