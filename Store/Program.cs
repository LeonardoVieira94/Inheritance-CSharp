using Store.Entities;
using System.Globalization;

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the quantity of products: ");
            int n = int.Parse(Console.ReadLine());
            List<Product> products = new List<Product>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Commom, used or imported(c/u/i)? ");
                char opt = char.Parse(Console.ReadLine());
                if (opt == 'c')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    products.Add(new Product(name, price));
                }
                else if (opt == 'i')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Customs Fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    products.Add(new ImportedProduct(name, price, customsFee));
                }
                else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Manufacture Date(DD/MM/YYYY): ");
                    DateTime mDate = DateTime.Parse(Console.ReadLine());

                    products.Add(new UsedProduct(name, price, mDate));
                }

            }
            Console.WriteLine("PRICE TAGS: ");
            foreach (Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}