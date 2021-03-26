using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Реализовать инвентарь на базе строкового списка и меню для управления им.
            // Пункты меню:
            //-Показать содержимое рюкзака
            //-Добавить предмет в рюкзак
            //- Удалить предмет из рюкзака
            // - Выйти из программы
            List<string> inventory = new List<string>();
            bool exit = false;
            while (exit == false)
            {
                Console.Write("Выбор команды: ");
                int command = int.Parse(Console.ReadLine());
                switch(command)
                {
                    case 1:
                        AddItem(inventory);
                        Console.WriteLine("Ваш рюкзак сейчас");
                        CheckInventory(inventory);
                        break;
                    case 2:
                        DeleteItem(inventory);
                        Console.WriteLine("Ваш рюкзак сейчас");
                        CheckInventory(inventory);
                        break;
                    case 3:
                        CheckInventory(inventory);
                        break;
                    case 4:
                        Exit();
                        break;
                }
            }
        }

        public static List<string> AddItem(List<string> inventory)
        {
            Console.WriteLine();
            Console.Write("Какой предмет хотите взять ?: ");
            string item = Console.ReadLine();
            inventory.Add(item);
            return inventory;
        }

        public static List<string> DeleteItem(List<string> inventory)
        {
            Console.WriteLine();
            Console.Write("Какой предмет хотите выкинуть ?: ");
            string item = Console.ReadLine();
            inventory.Remove(item);
            return inventory;
        }

        public static void CheckInventory(List<string> inventory)
        {
            for (int i = 0; i < inventory.Count; i++)
            {
                Console.WriteLine(inventory[i] + " ");
            }
        }

        public static bool Exit()
        {
            bool exit = true;
            return exit;
        }
    }
}
