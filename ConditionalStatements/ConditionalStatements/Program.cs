// See https://aka.ms/new-console-template for more information

using System.Globalization;

namespace ConditionalStatements
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var season = Season.Winter;

            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's autumn and a beautiful");
                    break;
                case Season.Winter:
                    Console.WriteLine("It's winter and it's snowing :(");
                    break;
                case Season.Spring:
                    Console.WriteLine("It's spring and the flowers are blooming");
                    break;
                case Season.Summer:
                    Console.WriteLine("It's summer and it is the best season of them all!");
                    break;
                default:
                    Console.WriteLine("That is not a season");
                    break;
            }
            /*
            int hour = 10;
            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It is morning");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It is afternoon");
            }
            else
            {
                Console.WriteLine("It is evening");
            }
            */

            //bool isGoldCustomer = false;

            /*
            float price;
            if (isGoldCustomer)
            {
                price = 19.05f;
            }
            else
            {
                price = 29.95f;
            }
            */
            //float price = (isGoldCustomer) ? 19.95f : 29.95f;
            //Console.WriteLine(price);


        }
    }
}