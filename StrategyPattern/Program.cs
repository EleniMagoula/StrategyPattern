using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Shop;
using StrategyPattern.Shop.Create_TShirt;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our T-Shirt E-Shop!");

            int shopping_basket = 0;
            Register register = new Register();

            shopping_basket = Menu(shopping_basket);

            Console.WriteLine("Recommended payment method based on your shopping basket:");

            if (shopping_basket < 25)
            {
                register.SetPaymentStrategy(new CreditCard());
                Console.WriteLine("Credit Card");
            }
            else if (shopping_basket < 35)
            {
                register.SetPaymentStrategy(new Cash());
                Console.WriteLine("Cash");
            }
            else
            {
                register.SetPaymentStrategy(new BankTransfer());
                Console.WriteLine("Bank Transfer");
            }

            register.Pay(shopping_basket);

            // get different behaviours at runtime, by calling the same method based on factors:
            // same method => Pay(int shopping_basket)
            // behaviours => payment strategies [Cash, Debit/Credit Card and Bank/Money Transfer]
            // factors => price of the T-Shirt
        }

        private static int Menu(int shopping_basket)
        {
            bool keepBuying = true;

            do
            {
                Console.WriteLine("Choose a color number: \r\n" +
                "[1] Red, [2] Orange, [3] Yellow, [4] Green, [5] Blue, [6] Indigo, [7] Violet");
                var color = Console.ReadLine();

                switch (color)
                {
                    case "1":
                        shopping_basket += (int)Color.Red;
                        break;
                    case "2":
                        shopping_basket += (int)Color.Orange;
                        break;
                    case "3":
                        shopping_basket += (int)Color.Yellow;
                        break;
                    case "4":
                        shopping_basket += (int)Color.Green;
                        break;
                    case "5":
                        shopping_basket += (int)Color.Blue;
                        break;
                    case "6":
                        shopping_basket += (int)Color.Indigo;
                        break;
                    case "7":
                        shopping_basket += (int)Color.Violet;
                        break;
                    default:
                        Console.WriteLine("Something went wrong. Please try again!");
                        break;
                }

                Console.WriteLine("Choose a size number: \r\n" +
                    "[1] XS, [2] S, [3] M, [4] L, [5] XL, [6] XXL, [7] XXXL");
                var size = Console.ReadLine();

                switch (size)
                {
                    case "1":
                        shopping_basket += (int)Size.XS;
                        break;
                    case "2":
                        shopping_basket += (int)Size.S;
                        break;
                    case "3":
                        shopping_basket += (int)Size.M;
                        break;
                    case "4":
                        shopping_basket += (int)Size.L;
                        break;
                    case "5":
                        shopping_basket += (int)Size.XL;
                        break;
                    case "6":
                        shopping_basket += (int)Size.XXL;
                        break;
                    case "7":
                        shopping_basket += (int)Size.XXXL;
                        break;
                    default:
                        Console.WriteLine("Something went wrong. Please try again!");
                        break;
                }

                Console.WriteLine("Choose a fabric number: \r\n" +
                    "[1] Wool, [2] Cotton, [3] Polyester, [4] Rayon, [5] Linen, [6] Cashmere, [7] Silk");
                var fabric = Console.ReadLine();

                switch (fabric)
                {
                    case "1":
                        shopping_basket += (int)Fabric.Wool;
                        break;
                    case "2":
                        shopping_basket += (int)Fabric.Cotton;
                        break;
                    case "3":
                        shopping_basket += (int)Fabric.Polyester;
                        break;
                    case "4":
                        shopping_basket += (int)Fabric.Rayon;
                        break;
                    case "5":
                        shopping_basket += (int)Fabric.Linen;
                        break;
                    case "6":
                        shopping_basket += (int)Fabric.Cashmere;
                        break;
                    case "7":
                        shopping_basket += (int)Fabric.Silk;
                        break;
                    default:
                        Console.WriteLine("Something went wrong. Please try again!");
                        break;
                }

                Console.WriteLine("Do you want to continue purchasing T-Shirts? Y/N");
                string answer = Console.ReadLine();

                if (answer == "N" || answer == "n")
                    break;

            } while (keepBuying);
            return shopping_basket;
        }

    }
}
