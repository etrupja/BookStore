namespace BookStore.Tests
{
    public static class MathHelper
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int FindMaxValue(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }

        public static double GetAverage(List<int> numbers)
        {
            //Shume a numrave (1,2,3)
            //Sasia e numrave
            //Shuma e numrave / Sasia e numrave

            int shuma = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                shuma += numbers[i];
            }

            return shuma / numbers.Count;
        }

        public static bool AreAllPositive(List<int> allNumbers) //2, 2, 4
        {
            for (int i = 0; i < allNumbers.Count; i++)
            {
                if (allNumbers[i] < 0)
                    return false;
            }

            return true;
        }


        public static bool AreAllEvenNumbers(List<int> allNumbers)
        {
            for (int i = 0; i < allNumbers.Count; i++)
            {
                if (allNumbers[i] % 2 != 0)
                    return false;
            }

            return true;
        }

        public static double GetProfit(int totalValue, double taxValueInPrct)
        {
            return totalValue * (1 - taxValueInPrct);
        }
    }
}
