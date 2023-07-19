using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program1
    {

        static void Main(string[] args)
        {
            IProduct product = new Electronics  //lose coupling
            {
                Brand = "SAMSUNG",
                Name = "AC",
                Description = "MODEL456",
                Price = "400"
            };
            product.DisplayProductInfo();


            IProduct cloth = new Cloth
            {
                Size = "XXL",
                Name = "SHIRT",
                Description = "WHITE",
                Price = "200"
            };
            cloth.DisplayProductInfo();

            IProduct book = new Books
            {
                Author = "James",
                Name = "LETUSC",
                Description = "BOOK",
                Price = "300"
            };
            book.DisplayProductInfo();

            Console.ReadKey();

        }







    }

    public interface IProduct
    {

        string Name { get; set; }
        string Price { get; set; }
        string Description { get; set; }
        void DisplayProductInfo();
    }



    public class Electronics : IProduct
    {
        public string Brand { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }

        public void DisplayProductInfo()
        {
            Console.WriteLine($"Product Name {Name}");
            Console.WriteLine($"Product price {Price}");
            Console.WriteLine($"Product Description {Description}");
            Console.WriteLine($"Product Brand {Brand}");
        }
    }


    public class Cloth : IProduct
    {
        public string Size { get; set; }
        public string Brand { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }

        public void DisplayProductInfo()
        {
            Console.WriteLine($"Product size{Size}");
            Console.WriteLine($"Product Name {Name}");
            Console.WriteLine($"Product price {Price}");
            Console.WriteLine($"Product Description {Description}");
            Console.WriteLine($"Product Brand {Brand}");
        }
    }
    public class Books : IProduct
    {
        public string Author { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }

        public void DisplayProductInfo()
        {
            Console.WriteLine($" Product Name {Name}");
            Console.WriteLine($" Product Price {Price}");
            Console.WriteLine($" Product Description {Description}");
            Console.WriteLine($" Product Author {Author}");
        }

    }
}




