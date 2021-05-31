namespace Methods
{
    public class Calc
    {
        public static int Add(params int[] numbers)
        {
            int total = 0;
            foreach (var number in numbers)
            {
                total += number;
            }

            return total;
        }
    }
}