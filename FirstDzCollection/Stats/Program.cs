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
            string userCommand = string.Empty;

            int number = 0;
            int result = 0;

            bool isValidInput = false;
            bool exit = false;

            while (exit == false)
            {
                userCommand = Console.ReadLine();
                isValidInput = int.TryParse(userCommand, out number);
                numbers.Add(number);
                switch (userCommand)
                {
                    case "sum":
                       result = SumNumber(numbers);
                        Console.WriteLine(result);
                        numbers = new List<int>();
                        break;
                    case "exit":
                            exit = true;
                        break;
                }
            }
        }



        public static int SumNumber(List<int> numbers)
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


