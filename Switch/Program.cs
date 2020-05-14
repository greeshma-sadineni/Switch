using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter number:");
            num = Convert.ToInt32(Console.ReadLine());
            if (num == 9 || num == 10)

                Console.WriteLine("Excellent");
            
            else if (num == 7|| num ==8)
                Console.WriteLine(" Notable");
            else if (num == 6)
                Console.WriteLine("Good");
             else if (num == 5)
                Console.WriteLine("pass");
            else if (num == 0|| num == 1||num ==2 ||num == 3 ||num == 4)
                Console.WriteLine("Fail");
            else
                Console.WriteLine("No not exists");



        }
    }
}
