namespace TwoMinDigits
{
    public class TwoMinCalculator
    {
        public static int SumOfTwoMin(int[] arr)
        {
            if (arr.Length == 0)
                throw new ArgumentException("Array must not be empty.");

            if (arr.Length == 1)
                throw new ArgumentException("Array must contain minimum two elements.");

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

            try
            {
                return checked(p1 + p2.Value);
            }
            catch (OverflowException)
            {
                throw new OverflowException("Sum of two minimum values exceeds the range of int.");
            }
        }
    }
}
