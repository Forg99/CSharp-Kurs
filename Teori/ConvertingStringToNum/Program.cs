using System;


namespace ConvertingStringToNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textAge = "23";
            int age = Convert.ToInt32(textAge);
            Console.WriteLine(age);
            Console.WriteLine(age.GetType());
            Console.WriteLine(textAge.GetType());

            string textBigNumber = "-900000000";
            long BigNumber = Convert.ToInt64(textBigNumber);
            Console.WriteLine(BigNumber);
            Console.WriteLine(BigNumber.GetType());
            Console.WriteLine(textBigNumber.GetType());

            string textNegative = "-55,2";
            double Negative = Convert.ToDouble(textNegative);
            Console.WriteLine(BigNumber);
            Console.WriteLine(Negative.GetType());

            string textPrecision = "5,000001";
            float precision = Convert.ToSingle(textPrecision);
            Console.WriteLine(precision);
            Console.WriteLine(precision.GetType());

            string textMoney = "14,99";
            decimal Money = Convert.ToDecimal(textMoney);
            Console.WriteLine(Money);
            Console.WriteLine(Money.GetType());

        }
    }
}
