using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stats
{
    class Program
    {
        static void Main(string[] args)
        {

            //Пользователь вводит числа, и программа их запоминает.
            //Как только пользователь введёт команду sum, программа выведет сумму всех веденных чисел.
            //Выход из программы должен происходить только в том случае, если пользователь введет команду exit.

            List<int> numbers = new List<int>();
            string sum = "sum";
            string mySum = string.Empty;
            string yes = "yes";

            int number = 0;
            int result = 0;

            bool isValidInput = false;
            bool exit = false;

            while (exit == false)
            {
                do
                {
                    mySum = Console.ReadLine();
                    isValidInput = int.TryParse(mySum, out number);
                    if (isValidInput == true)
                    {
                        numbers.Add(number);
                    }
                    else if (mySum == sum)
                    {
                        result = CalculatingTheNumber(numbers);
                        Console.WriteLine(result);
                    }
                } while (sum != mySum);

                Console.WriteLine("Если вы хотите выйти, напиши yes, если нет, нажмите любую кнопку: ");
                string exitStr = Console.ReadLine();

                if (exitStr == yes)
                {
                    exit = true;
                }

                numbers = new List<int>();
            }
        }

        public static int CalculatingTheNumber(List<int> numbers)
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


