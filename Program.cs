using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luxury_Perfume_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            string brand1 = "Chanel";
            string name1 = "No 5";
            int price1 = 1900;
            int volume1 = 100;
            bool isAvailable1 = true;

            string brand2 = "Dior";
            string name2 = "Sauvage";
            int price2 = 100;
            int volume2 = 60;
            bool isAvailable2 = true;

            string brand3 = "Tom Ford";
            string name3 = "Oud Wood";
            int price3 = 2000;
            int volume3 = 50;
            bool isAvailable3 = true;


            if (isAvailable1 == true)
            {
                Console.WriteLine("Chanel No 5 is Available.");
            }
            else
            {
                Console.WriteLine("Chanel No 5 is Out of Stock.");
            }


            if (isAvailable2 == true)
            {
                Console.WriteLine("Dior Sauvage is Available.");
            }
            else
            {
                Console.WriteLine("Dior Sauvage is Out of Stock.");
            }


            if (isAvailable3 == true)
            {
                Console.WriteLine("Tom Ford Oud Wood is Available.");
            }
            else
            {
                Console.WriteLine("Tom Ford Oud Wood is Out of Stock.");
            }



            int choice = 0;
            while (choice != 5)
            {
                Console.WriteLine("☆๑✧🧴◆◇◈Luxury Perfumes◈◇◆🧴✧๑☆");
                Console.WriteLine("1.Chanel No 5");
                Console.WriteLine("2.Dior Sauvage");
                Console.WriteLine("3.Tom Ford Oud Wood");
                Console.WriteLine("4.Show All Perfumes");
                Console.WriteLine("5.Exit");

                Console.WriteLine("Enter Your Choice");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:

                        Console.WriteLine("Chanel No 5");
                        Console.WriteLine($"Brand1: {brand1}");
                        Console.WriteLine($"Name1: {name1}");
                        Console.WriteLine($"Price1: ${price1}");
                        Console.WriteLine($"Volume1: {volume1}");
                        Console.WriteLine($"Is Available1: {isAvailable1}");

                        break;


                    case 2:

                        Console.WriteLine("Dior Sauvage");
                        Console.WriteLine($"Brand2: {brand2}");
                        Console.WriteLine($"Name2: {name2}");
                        Console.WriteLine($"Price2: ${price2}");
                        Console.WriteLine($"Volume2: {volume2}");
                        Console.WriteLine($"Is Available2: {isAvailable2}");

                        break;


                    case 3:

                        Console.WriteLine("Tom Ford Oud Wood");
                        Console.WriteLine($"Brand3: {brand3}");
                        Console.WriteLine($"Name3: {name3}");
                        Console.WriteLine($"Price3: ${price3}");
                        Console.WriteLine($"Volume3: {volume3}");
                        Console.WriteLine($"Is Available3: {isAvailable3}");

                        break;

                    case 4:

                        Console.WriteLine("Show All Perfumes");

                        Console.WriteLine("↬◈◈◈◈◈Chanel No 5◈◈◈◈◈↫");
                        Console.WriteLine($"Brand1: {brand1}");
                        Console.WriteLine($"Name1: {name1}");
                        Console.WriteLine($"Price1: ${price1}");
                        Console.WriteLine($"Volume1: {volume1}");
                        Console.WriteLine($"Is Available1: {isAvailable1}");

                        Console.WriteLine("↬◈◈◈◈◈Dior Sauvage◈◈◈◈◈↫");
                        Console.WriteLine($"Brand2: {brand2}");
                        Console.WriteLine($"Name2: {name2}");
                        Console.WriteLine($"Price2: ${price2}");
                        Console.WriteLine($"Volume2: {volume2}");
                        Console.WriteLine($"Is Available2: {isAvailable2}");

                        Console.WriteLine("↬◈◈◈◈◈Tom Ford Oud Wood◈◈◈◈◈↫");
                        Console.WriteLine($"Brand3: {brand3}");
                        Console.WriteLine($"Name3: {name3}");
                        Console.WriteLine($"Price3: ${price3}");
                        Console.WriteLine($"Volume3: {volume3}");
                        Console.WriteLine($"Is Available3: {isAvailable3}");

                        break;

                    case 5:
                        Console.WriteLine("Say GoodBye!");
                        break;

                    default:

                        Console.WriteLine("Invalid Choice");

                        break;
                }

            }

        }




    }
}
