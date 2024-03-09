using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama_gelişmiş_hali
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("indirim yapmak=1");
                Console.WriteLine("zam yapmak=2");
                Console.WriteLine("çıkış yapmak=3");
                Console.Write("Yapmak istediğiniz işlemi sayı ile seçiniz: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1 || choice == 2)
                {
                    Console.Write("Fiyatı giriniz: ");
                    double price = double.Parse(Console.ReadLine().Replace('.',','));
                   string message = choice == 1 ? "indirim" : "zam";
                    string operation = choice == 1 ? "İndirimli fiyat" : "zamlı fiyat";

                    while (true)
                    {
                        try
                        {
                            Console.Write($"Yapılacak {message} miktarını giriniz: ");
                            double discount = double.Parse(Console.ReadLine());
                            

                            if (choice == 1 && discount <= 0)
                            {
                                Console.WriteLine("Hatalı indirim oranı. Lütfen tekrar deneyin.");
                                continue;
                            }
                            else if (choice == 2 && discount <= 0)
                            {
                                Console.WriteLine("Hatalı zam oranı. Lütfen tekrar deneyin.");
                                continue;
                            }

                            double discountRate = 0.01 * discount;

                            double discountedPrice = choice == 1 ? price * (1 - discountRate) : price + (price * discountRate);
                            
                            Console.WriteLine($"{operation}: {discountedPrice}");
                            Console.ReadLine();
                            break;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Geçersiz bir değer girdiniz. Lütfen sayısal bir değer girin.");
                        }
                    }
                }
                else if (choice == 3)
                {
                    break;
                }
            }
        }
    }
}
