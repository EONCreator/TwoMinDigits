namespace TwoMinDigits
{
    public class TwoMinCalculator
    {
        public static int SumOfTwoMin(int[] arr)
        {
            if (arr.Length == 0)
                throw new ArgumentException("Array must not be empty.");

            int p1 = arr[0];
            int? p2 = null;

            for (int i = 1; i < arr.Length; i++)
            {
                int a = arr[i];
                if (a < p1)
                {
                    p2 = p1;
                    p1 = a;
                }
                else if (p2 == null || a < p2) p2 = a;
            }

            return p2 == null ? p1 : p1 + p2.Value;
        }
    }
}
