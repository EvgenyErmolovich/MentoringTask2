using System;
using System.Text.RegularExpressions;

namespace Task2
{
    public static class Convert
    {
        public static int ConvertToInt(string input)
        {
            int result = 0;
            Regex regex = new Regex(@"\d");
            try
            {
                MatchCollection matches = regex.Matches(input);         
                int length = matches.Count - 1;
                if (length < 0) throw new StringWithoutNumbersException("Your string doesn't contain numbers!");
                for (int i = length; i >= 0; i--)
                {
                    result += (matches[i].Value[0] - '0') * (int)Math.Pow(10, length - i);
                }
            }
            catch (ArgumentNullException exp)
            {
                Console.WriteLine(exp.Message);
            }
            catch (StringWithoutNumbersException exp)
            {
                Console.WriteLine(exp.Message);
            }

            return result;
        }
    }
}
