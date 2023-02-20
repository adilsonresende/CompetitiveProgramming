using System;

namespace CodeWarsBusiness._6kyu
{
    public class NarcissisticNumberBusiness
    {
        public bool Narcissistic(int value)
        {
            bool result;
            string numberAsString = value.ToString();
            int pow = numberAsString.Length;
            long total = 0;

            foreach(char c in numberAsString)
            {
                int number = Convert.ToInt32(c.ToString());
                total += Convert.ToInt64(Math.Pow(number, pow));
            }

            result = (total == value);
            return result;
        }
    }
}
