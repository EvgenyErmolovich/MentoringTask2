using System;

namespace Task2
{
    public static class Convert
    {
        public static int ConvertToInt(string input)
        {
            string output = "";
            int result = 0;
            try
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] < 'A' && input[i] != ' ') output += input[i];
                }
            }
            catch (NullReferenceException exp)
            {
                Console.WriteLine(exp.Message);
                return result;
            }

            try
            {
                if (output == "") throw new StringWithoutNumbersException("Your string doesn't contain numbers!");
                int length = output.Length - 1;
                for (int i = length; i >= 0; i--)
                {
                    result += (output[i] - '0') * (int)Math.Pow(10, length - i);
                }
            }
            catch(StringWithoutNumbersException exp)
            {
                Console.WriteLine(exp.Message);
            }

            return result;
        }
    }
}
