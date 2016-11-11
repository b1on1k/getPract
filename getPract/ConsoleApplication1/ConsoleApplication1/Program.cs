using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            long sum = 0;
            for (long i = 12; i < 1000000; i++)
            {
                if (isThis(i))
                {
                    Console.WriteLine(i);
                    sum += i;
                }
            }
            Console.WriteLine("Your sum is: "+sum);
            Console.ReadKey();
        }

        public static bool isThis(long a)
        {
            String str = a.ToString();
            char[] chars = str.ToCharArray();
            int sum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (sum > a)
                    break;
                sum += Convert.ToInt32(Math.Pow(Int32.Parse(""+chars[i]), 5)); 
            }
            if (sum == a)
                return true;
            else
                return false;
        }
    }
}
