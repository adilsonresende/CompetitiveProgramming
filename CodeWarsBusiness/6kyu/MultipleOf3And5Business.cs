namespace CodeWarsBusiness._6kyu
{
    public class MultipleOf3And5Business
    {
        public int Solution(int value)
        {
            int total = 0;

            for (int i = 0; i < value; i++)
            {
                if(i % 3 == 0 || i % 5 == 0)
                {
                    total += i;
                }
            }

            return total;
        }
    }
}
