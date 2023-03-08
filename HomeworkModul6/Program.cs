using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeworkModul6
{
    class Money
    {
        int euro;
        int cent;

        public Money(int euro, int cent)
        {
            this.euro = euro;
            this.cent = cent;
        }
        public static Money operator -(Money money, int num)
        {
            var newValue = (money.euro * 100 + money.cent) - num;
            return new Money((int)newValue / 100, (int)newValue % 100);
        }
        public void Print()
        {
            Console.WriteLine("You have {0} euro {1} cent", euro, cent);
        }
    }
    class Product
    {
        string name;
        Money price;
        public Product(string name, Money price)
        {
            this.name = name;
            this.price = price;
        }
        public void DecreasePrice(int num)
        {
            this.price = price - num;
        }
        public void Print()
        {
            Console.WriteLine("Name: {0}; Price: {1}", name, price);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Write how much euro you have: ");
            int euro  = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write how much cent you have: ");
            int cent = Convert.ToInt32(Console.ReadLine());
            Money money = new Money (euro, cent);
            money.Print();
            Console.WriteLine("Write what do you want to buy: ");
            string name = Console.ReadLine();
            Console.WriteLine("Write how much does it costs? ");
            Console.WriteLine("Write euro: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write cent: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Money price = new Money(a, b);
            Product product = new Product(name, price);
            Console.WriteLine("Write how much you want to decrease a price: ");
            int num = Convert.ToInt32(Console.ReadLine());
            product.DecreasePrice(num);
            product.Print(); 
        }
    }
}
