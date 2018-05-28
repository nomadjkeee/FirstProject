using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;
namespace ConsoleApp3
{
    class ProductT
    {
        int _id;
        List<ProductT> t = new List<ProductT>();
        public int Id { get { return _id; } }
        public ProductT()
        {

        }

        public ProductT(int num)
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

            var fruit = new[] { "appleT", "bananaT", "orangeT", "strawberryT", "kiwiT", "potatoT", "grapeT", "pineappleT" };

            var testProductT = new Faker<ProductT>("uk")
                .CustomInstantiator(f => new ProductT(userIds++))
                .RuleFor(u => u.Name, f => f.PickRandom(fruit))
                .RuleFor(u => u.Country, f => f.Address.Country());

            ProductT ProductItem = testProductT.Generate();
            t.Add(ProductItem);


        }
        public void ShowPRoduct()
        {
            foreach (ProductT p in t)
                Console.WriteLine(p);

        }
        public override string ToString()
        {
            string result = string.Format("{0}. Name - {1}, Country - {2} ", Id, Name, Country);
            return result;
        }
        public void Delete(ProductT ob)
        {
            t.Remove(ob);
        }

        public void WriteDDR()
        {
           

            var file = MemoryMappedFile.CreateFromFile(@"h:\123.txt", FileMode.Open, Name, 20000); // последний параметр - размер выделяемой памяти

            using (var streamwriter = new StreamWriter(file.CreateViewStream()))
            {
                foreach (ProductT p in t)
                {
                    streamwriter.WriteLine(p);
                }
               
                streamwriter.Close();
            }
         
            file.Dispose();
        }
    }
}
