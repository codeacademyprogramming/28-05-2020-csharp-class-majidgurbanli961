
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkLast
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anbarda Olan materiallar Laptop Sd Card Usb Hab");
            Console.WriteLine("Zehmet olmasa account nomrenizi daxil edin");
            string account = Console.ReadLine();
            Console.WriteLine("Zehmet olmasa customer adinizi daxil edin");
            string customer = Console.ReadLine();
            Console.WriteLine("Zehmet olmasa provider adinizi daxil edin");
            string provider = Console.ReadLine();
            Console.WriteLine(" Materiali second ");
            string article = Console.ReadLine();
            Console.WriteLine(" Material sayini secin ");
            string quantity = Console.ReadLine();
            Console.WriteLine("Edv li qiymet ucun true edv siz qiymet ucun false secin");
            string isEdv = Console.ReadLine();
             bool.TryParse(isEdv, out bool isBoolEdv);

            Invoice first = new Invoice(account, customer, provider);
            first.Article = article;
            first.Quantity = quantity;
            double totalPrice =   first.PriceReturner(isBoolEdv);
            Console.WriteLine($"Umumi qiymet {totalPrice}");


        }
    }
    class Invoice
    {
        private readonly string account;
        private readonly string customer;
        private readonly string provider;
        private string article;
        private string quantity;
        public string Article { 
            get { return article;  }
            set {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine( "Error");

                }
                else
                {
                    article = value;
                }
              
            }
        }
        public string Quantity
        {
            get { return quantity; }
            set {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Error");

                }
                else
                {
                    quantity = value;
                }
            }
        }

        public Invoice(string account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }
        public double PriceReturner(bool isEdv)
        {
            double totalPrice = 0;
            double numberQuantity = 0;
            Console.WriteLine($" Account nomreniz {account} Alici adi { customer}, Satici adi { provider},  ");
            if (article == "Laptop")
            {
                totalPrice = 1400;
                if (isEdv == true)
                {
                    double.TryParse($"{quantity}", out numberQuantity);
                    
                    totalPrice = 1400 *numberQuantity  + (1400 * 0.18);
                    return totalPrice;
                }
                else
                {
                    return totalPrice*numberQuantity;
                }
            }
            if (article == "Sd Card")
            {
                totalPrice = 30;
                if (isEdv == true)
                {
                    double.TryParse($"{quantity}", out numberQuantity);

                    totalPrice = 30 * numberQuantity + (30 * 0.18);
                    return totalPrice;
                }
                else
                {
                    return totalPrice * numberQuantity;
                }
            }
            if (article == "Usb Hab")
            {
                totalPrice = 12;
                if (isEdv == true)
                {
                    double.TryParse($"{quantity}", out numberQuantity);

                    totalPrice = 12 * numberQuantity + (12 * 0.18);
                    return totalPrice;
                }
                else
                {
                    return totalPrice * numberQuantity;
                }
            }
            else
            {
                Console.WriteLine("Anbarda bele material yoxdur");
            }




            return totalPrice;

        }

    }
}
