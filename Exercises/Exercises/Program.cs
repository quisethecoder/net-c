// See https://aka.ms/new-console-template for more information

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            /*Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num <= 10 && num >= 1)
            {
                Console.WriteLine("This is a valid number.");
            }
            else
            {
                Console.WriteLine("This is not a valid number.");
            }
            
            Exercise 2
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if (number > number2)
            {
                Console.WriteLine("This highest number is " + number);
            }
            else if (number < number2)
            {
                Console.WriteLine("This highest number is " + number2);
            }
            else
            {
                Console.WriteLine("That is not a number");
            }
            
            Exercise 3
            
            Console.WriteLine("Enter width of image: ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter height of image: ");
            int height = Convert.ToInt32(Console.ReadLine());

            if (width < height)
            {
                Console.WriteLine("Landscape");
            }
            else
            {
                Console.WriteLine("Portrait");
            }
            
            Exercise 4
            */
            Console.WriteLine("Enter the speed limit: ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the speed of the car: ");
            var speedOfCar = Convert.ToInt32(Console.ReadLine());
            

            if (speedOfCar < speedLimit)
            {
                Console.WriteLine("Don't stop him");
            }
            else if (speedOfCar > speedLimit)
            {
                var demeritPoints = (speedOfCar - speedLimit )/ 5;
                Console.WriteLine($"Points: {demeritPoints}");
                if (demeritPoints > 12)
                {
                    Console.WriteLine("Your license will be suspended");
                }
            }
            
        }
    }
}