using System.IO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cafe
{
    public static class Choise_of_Menus
    {
        public static void MainMenuChoise()
        {
            short pos_main_menu = Arrows.Arrow(3, 8);

            switch (pos_main_menu)
            {
                case 3:
                    Console.Clear();
                    Console.WriteLine("Для выхода нажмите Escape\nВыберите пункт из меню:\n***************************************\n  Квадратная - 500\n  Круглая - 300 \n  Прямоугольная - 600");
                    short Form = Arrows.Arrow(3, 5);
                    switch (Form)
                    {
                        case 3:
                            Form Квадратная = new Form("Квадратная", 500);
                            MenuOrder.MainMenu(Квадратная.Cost, Квадратная.Name);
                            break;
                        case 4:
                            Form Круглая = new Form("Круглая", 300);
                            MenuOrder.MainMenu(Круглая.Cost, Круглая.Name);
                            break;
                        case 5:
                            Form Прямоугольная = new Form("Прямоугольная", 600);
                            MenuOrder.MainMenu(Прямоугольная.Cost, Прямоугольная.Name);
                            break;
                    }
                    break;



                case 4:
                    Console.Clear();
                    Console.WriteLine("Для выхода нажмите Escape\nВыберите пункт из меню:\n***************************************\n  Маленький корж - 300\n  Средний корж - 500 \n  Большой корж - 600");
                    short Size = Arrows.Arrow(3, 5);
                    switch (Size)
                    {
                        case 3:
                            Size Маленький = new Size("Маленький корж", 300);
                            MenuOrder.MainMenu(Маленький.Cost, Маленький.Name);
                            break;
                        case 4:
                            Size Средний = new Size("Средний корж", 500);
                            MenuOrder.MainMenu(Средний.Cost, Средний.Name);
                            break;
                        case 5:
                            Size Большой = new Size("Большой корж", 600);
                            MenuOrder.MainMenu(Большой.Cost, Большой.Name);
                            break;
                    }
                    break;



                case 5:
                    Console.Clear();
                    Console.WriteLine("Для выхода нажмите Escape\nВыберите пункт из меню:\n***************************************\n  Клубничный корж - 100\n  Малиновый корж - 100 \n  Банановый корж - 100\n  Яблочный корж - 100\n  Шоколадный корж - 100");
                    short Taste = Arrows.Arrow(3, 7);
                    switch (Taste)
                    {
                        case 3:
                            Taste Клубничный = new Taste("Клубничный корж", 100);
                            MenuOrder.MainMenu(Клубничный.Cost, Клубничный.Name);
                            break;
                        case 4:
                            Size Малиновый = new Size("Малиновый корж", 100);
                            MenuOrder.MainMenu(Малиновый.Cost, Малиновый.Name);
                            break;
                        case 5:
                            Size Банановый = new Size("Банановый корж", 100);
                            MenuOrder.MainMenu(Банановый.Cost, Банановый.Name);
                            break;
                        case 6:
                            Size Яблочный = new Size("Яблочный корж", 100);
                            MenuOrder.MainMenu(Яблочный.Cost, Яблочный.Name);
                            break;
                        case 7:
                            Size Шоколадный = new Size("Шоколадный корж", 100);
                            MenuOrder.MainMenu(Шоколадный.Cost, Шоколадный.Name);
                            break;
                    }
                    break;



                case 6:
                    Console.Clear();
                    Console.WriteLine("Для выхода нажмите Escape\nВыберите пункт из меню:\n***************************************\n  Шоколадная глазурь с арахисом и изюмом - 247\n  Апельсиновая глазурь - 146 \n  Глазурь с ромом - 300\n  Глазурь зеркальная шоколадная - 245");
                    short Glaze = Arrows.Arrow(3, 6);
                    switch (Glaze)
                    {
                        case 3:
                            Glaze ШМСАИИ = new Glaze("Шоколадная глазурь с арахисом и изюмом", 247);
                            MenuOrder.MainMenu(ШМСАИИ.Cost, ШМСАИИ.Name);
                            break;
                        case 4:
                            Glaze Апельсиновая = new Glaze("Апельсиновая глазурь", 146);
                            MenuOrder.MainMenu(Апельсиновая.Cost, Апельсиновая.Name);
                            break;
                        case 5:
                            Glaze Ромом = new Glaze("Глазурь с ромомь", 300);
                            MenuOrder.MainMenu(Ромом.Cost, Ромом.Name);
                            break;
                        case 6:
                            Glaze Шоколадная = new Glaze("Глазурь зеркальная шоколадная", 245);
                            MenuOrder.MainMenu(Шоколадная.Cost, Шоколадная.Name);
                            break;
                    }
                    break;



                case 7:
                    Console.Clear();
                    Console.WriteLine("Для выхода нажмите Escape\nВыберите пункт из меню:\n***************************************\n  Солёная карамель - 50\n  Бабл гам - 50 \n  Лесые ягоды - 50\n  Топпинг со вкусом халвы - 50");
                    short Topping = Arrows.Arrow(3, 8);
                    switch (Topping)
                    {
                        case 3:
                            Topping Карамель = new Topping("Солёная карамель", 50);
                            MenuOrder.MainMenu(Карамель.Cost, Карамель.Name);
                            break;
                        case 4:
                            Topping БаблГам = new Topping("Бабл гам", 50);
                            MenuOrder.MainMenu(БаблГам.Cost, БаблГам.Name);
                            break;
                        case 5:
                            Topping Ромом = new Topping("Лесые ягоды", 50);
                            MenuOrder.MainMenu(Ромом.Cost, Ромом.Name);
                            break;
                        case 6:
                            Topping Халва = new Topping("Топпинг со вкусом халвы", 50);
                            MenuOrder.MainMenu(Халва.Cost, Халва.Name);
                            break;
                    }
                    break;



                case 8:
                    Console.Clear();
                    Console.WriteLine("Вы сделали заказ! Если хотите создать ещё один, нажмите Escape, иначе Enter");
                    var txt = $"Дата заказа: {DateTime.Now}" + $"\n\t\t\tСумма заказа: {MenuOrder.totalCost}" + $"\n\t\t\tСостав торта: {MenuOrder.orderComposition}" + "\n******************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************\n";
                    File.AppendAllText("C:\\Users\\SonicXTails\\Desktop\\Check.txt", txt);
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Escape)
                    {
                        MenuOrder.totalCost = 0;
                        MenuOrder.orderComposition = "";
                        MenuOrder.MainMenu();
                    }
                    else if (key.Key == ConsoleKey.Enter)
                        Environment.Exit(0);
                    break;
            }
        }
    }
}
