using System;
namespace TechnicalTestCore
{
    internal class Summations
    {
        public static int SumOfNumbersFrom1TillNrAsInt(int maxNrAsInt)
        {
            // Adapt the method body to make the corresponding unit test in 'TechnicalTestUnitTests' pass
            int i;
            int result = 0;
            for (i=1; i<=maxNrAsInt; i++)
            {
                
                result = result + i ;

            }

            return result;
        }

        public static string SumOfNumbersFrom1TillNrAsString(string maxNrAsString)
        {
            // Adapt the method body to make the corresponding unit test in 'TechnicalTestUnitTests' pass
            int a = Convert.ToInt32(maxNrAsString);
            long b = 0;
            string result;
 for (int i =1 ; i<=a;i++ )
            {
                b = b + i;
            }
 result=Convert.ToString(b);
            return result;
        }
    }
}
