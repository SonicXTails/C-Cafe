using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
    public class MenuOrder
    {
        public static int totalCost = 0;
        public static string orderComposition = "";

        static public void MainMenu(int itemCost = 0, string itemName = "")
        {
            totalCost += itemCost;
            orderComposition += itemName + " / ";

            Console.Clear();
            Console.WriteLine("Приветствуем вас в кондитерской ЛЕПЁХА!\nВыберете интересующие вас параметры:\n***************************************");
            Console.WriteLine("  1. Форма торта"); // 3
            Console.WriteLine("  2. Размер торта"); // 4
            Console.WriteLine("  3. Вкус коржа"); // 5
            Console.WriteLine("  4. Добавление глазури на торт"); //6
            Console.WriteLine("  5. Топпинг"); // 7
            Console.WriteLine("  Заказать!\n\n"); // 8

            Console.WriteLine($"Сумма вашего заказа: {totalCost}");
            Console.WriteLine($"Состав торта (заказа):{orderComposition}");

            Choise_of_Menus.MainMenuChoise();

        }
    }
}
