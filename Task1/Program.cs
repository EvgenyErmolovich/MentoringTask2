using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = "";

            while(true)
            {
                Console.WriteLine("Enter string or 0 if you want to see result");
                string input = Console.ReadLine();
                if (input == "0") break;
                try
                {
                    if (input == "") throw new EmptyStringException("Your string is empty!");
                    result += input[0];
                }
                catch(EmptyStringException exp)
                {
                    Console.WriteLine(exp.Message);
                }
            }
            Console.WriteLine(result);

            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}
