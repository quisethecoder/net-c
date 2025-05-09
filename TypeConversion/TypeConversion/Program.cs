// See https://aka.ms/new-console-template for more information
using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
          //  byte b = 1;
            //int i = b;
            //Console.WriteLine(i);

            //int i = 1;
            //byte b = (byte) i;
            //Console.WriteLine(b);

            try
            {
                var number = "1234";
                byte b = Convert.ToByte(number);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("Number could not be converted to a byte");
                
            }

           
            //int i = Convert.ToInt32(number);
            

        }
    }
}