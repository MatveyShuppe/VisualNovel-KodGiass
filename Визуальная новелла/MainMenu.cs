using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Визуальная_новелла
{
    class MainMenu
    {

        protected int key;
        public void ShowMenu(MainScene startScene)
        {
            Console.WriteLine("Главное Меню: ");
            Console.WriteLine("Для выбора используйте цифры");
            Console.WriteLine("Новая Игра(1)");
            Console.WriteLine("Выход(2)");
            
            
                while (key != 1 && key != 2)
                {
                    key = int.Parse(Console.ReadLine());

                    if (key != 1 && key != 2)
                    {
                        Console.WriteLine("Введите числа от 1 до 2");
                    }
                }
                switch (key)
                {
                    case 1:
                        {
                            NewGame(startScene);
                            break;

                        }
                    case 2:
                        {
                            Console.WriteLine("Вы вышли из игры!");
                            break;
                        }
                }
            
            
        }

        public void NewGame(MainScene startScene)
        {
            Console.Clear();
            startScene.Povestvovanie();
        }

        public void Exit()
        {
            Console.WriteLine("Вы вышли из игры!");
        }
    }
}
