using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDzCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Посчитать сумму элементов массива
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
            int result = SummationValuesInCollection(numbers);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        public static int SummationValuesInCollection(List<int> numbers)
        {
            int result = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                result += numbers[i];
            }

            return result;
        }
    }
}
