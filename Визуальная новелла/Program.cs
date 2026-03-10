using Визуальная_новелла;

namespace Matvey
{ 
    class Program
    {
        static void Main(string[] args)
        {
                   


            MainMenu menu = new MainMenu();         //Создаём главное меню
            MainScene endscene = new MainScene(null);
            MainScene thirdscene = new MainScene(endscene);                                                   //
           MainScene secondscene = new MainScene(thirdscene);      //Создаём сцены и переносим в скобочки следуюшую сцену, для того, чтобы работала переменная nextscene
            MainScene startscene = new MainScene(secondscene);      //
            menu.ShowMenu(startscene);          //Запускаем главное меню, а следственно и всю игру

            



        }
    }
}

