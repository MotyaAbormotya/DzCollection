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

            int number = 0;
            int result = 0;

            bool isValidInput = false;
            bool exit = false;

            while (exit == false)
            {
                mySum = Console.ReadLine();
                isValidInput = int.TryParse(mySum, out number);
                if (isValidInput == true)
                {
                    numbers.Add(number);
                }
                else
                {
                    switch (mySum)
                    {
                        case "sum":
                            result = AdditionNumber(numbers);
                            Console.WriteLine(result);
                            numbers = new List<int>();
                            break;
                        case "exit":
                            exit = true;
                            break;
                    }
                }
            }
        }

        public static int AdditionNumber(List<int> numbers)
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


