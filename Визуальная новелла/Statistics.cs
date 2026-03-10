using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
namespace Визуальная_новелла
{
    class Statistics : MainMenu
    {
        protected Kenzhi kenzhi;        //
        protected Lelush lelush;       //
        protected Nanali nanali;       //Создаём персонажей
        protected Shirli shirli;       //
        protected Suzaku suzaku;       //
                                            // protected Shirli shirli;
        /*protected Suzaku suzaku;
        protected Lelush lelush;*/
        public Statistics()
        {
           shirli = new Shirli();
            suzaku = new Suzaku();
            lelush = new Lelush();
            kenzhi = new Kenzhi();
            nanali = new Nanali();
        }
        
        static private int numeroseOFchoices = 0;
        public void ShowChoices()
        {
            Console.WriteLine("Всего выборов было сделано: ", numeroseOFchoices);
        }
        public void Choice(MainScene secondscene)
        {
            numeroseOFchoices++; 
            while (key != 1 && key != 2)
            {

                key = int.Parse(Console.ReadLine());

                if (key != 1 && key !=2)
                {
                    Console.WriteLine("Введите числа от 1 до 2");
                }
            }
            switch (key)
            {
                
                case 1:
                {
                    Shirli.Instance.IncrementReputation();
                    Console.WriteLine("Репутация с Ширли повысилась");
                    Console.ReadLine();
                    Lelush.Instance.Speak("Да, конечно");
                    Console.ReadLine();
                    Console.Clear();
                    secondscene.Povestvovanie(secondscene);

                    break;
                }
                case 2:
                {
                    Console.Write("Нет, извини...");
                    Console.WriteLine("Мне пора идти");
                    Console.Clear();   
                    secondscene.Povestvovanie(secondscene);
                    break;
                }
                
            }
            
        }
        public void Choice2(MainScene thirdscene)
        {
            numeroseOFchoices++;
            while (key != 1 && key != 2 && key != null)
            {

                key = int.Parse(Console.ReadLine());

                if (key != 1 && key != 2 && key != null)
                {
                    Console.WriteLine("Введите числа от 1 до 2");
                }
            }
            switch (key)
            {

                case 1:
                {
                     Console.Clear();
                     Console.WriteLine("Поздравляем, вы достигли нейтральной концовки: ");
                    Console.WriteLine("Лилуш успешно сбежал, и вернулся спокойно домой, но спустя пару лет Правительство узнает о том, что он сделал и привлекает его к ответственности");
                    Console.WriteLine("Которую нести он не захочет и бросится в бега, c Ширли он так и не сможет встретиться");
                    break;
                }
                case 2:
                {
                    Console.WriteLine("Вы решили присоединиться к восстанию и возглавить его");
                    
                    Console.ReadLine();
                    Console.WriteLine("Лилушу пришлось вступить в битву с принцем Кенджи, но благодаря его навыкам лидерства отряд Чёрных рыцарей смог выдержать неравный бой");
                    Console.ReadLine();
                    Console.WriteLine("В ходе битвы из-за того, что Лилуш ещё студент ему пришлось скрыть свою личность и стать *Зеро*");
                    Console.ReadLine();
                    Console.WriteLine("Так как Лилуш из богатой семьи, он обеспечил группировку не только своими мозгами, но и технологиями и укрытием, что также поможет ему завоевать доверие");
                    Console.WriteLine("Во время обдумывания дальнейшего плана действий, к Лилушу в комнату зашёл кое-кто, кого Лилуш совсем не ожидал увидеть");
                    Console.Clear();
                    thirdscene.Povestvovanie2(thirdscene);
                    break;
                }
            }
        }
        public void Choice3(MainScene endscene)
        {
            numeroseOFchoices++;
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
                        Console.Clear();
                        Lelush.Instance.Speak("Я дома");
                        Console.ReadLine();
                        Nanali.Instance.Speak("С возвращением, братец!");
                        Console.ReadLine();
                        Lelush.Instance.Speak("Нанали, как дела дома обстоят?");
                        Console.ReadLine();
                        Lelush.Instance.Speak("Как день прошёл?");
                        Console.ReadLine();
                        Nanali.Instance.Speak("Я видела новости о чёрных рыцарях, и о терракте на место в котором ты был, это ты мне лучше скажи как ты");
                        Console.ReadLine();
                        Lelush.Instance.Speak("Мне ничего не угрожало, знаешь, эти чёрные рыцари оказывается не такие уж и плохие какими кажутся");
                        Console.ReadLine();
                        Lelush.Instance.Speak("Они хотят свободы для граждан Японии и равных прав");
                        Console.ReadLine();
                        Lelush.Instance.Speak("Но не переживай, тебе нечего бояться, старший брат защитит тебя любой ценой");
                        Console.ReadLine();
                        Nanali.Instance.Speak("Спасибо большое");
                        Console.ReadLine();
                        Nanali.Instance.IncrementReputation();
                        Console.WriteLine("Репутация с Нанали увеличилась");
                        Console.ReadLine();
                        endscene.Endpovestvovanie(endscene);
                        break;
                }
                case 2:
                {
                        Console.Clear();
                        endscene.Endpovestvovanie(endscene);
                    break;
                }
            }
        }
        public void FinalChoice()
        {
            numeroseOFchoices++;
            if (shirli.reputation > 0 && nanali.reputation > 0 && suzaku.reputation > 0)
            {
                Nanali.Instance.Speak("Сейчас сам и узнаешь...");
                Console.ReadLine();
                Kenzhi.Instance.Speak("чт");
                Console.ReadLine();
                Console.WriteLine("*ВЗРЫВ*");
                Console.ReadLine();
                Console.WriteLine("В комнату влетела огромная рука, что разнесла стены и отбросила солдат вместе с Принцем");
                Console.ReadLine();
                Lelush.Instance.Speak("Что? Но как? Я ведь приказал вам не высовываться!");
                Console.ReadLine();
                Nanali.Instance.Speak("Ой, братец, чтобы ты без меня делал");
                Console.ReadLine();
                Nanali.Instance.Speak("Я с самого начала вместе с Ширли спрятались в Nightmare, чтобы в трудную минуту помочь, мы ведь имеем дело с Кенджи, нельзя его недооценивать");
                Console.ReadLine();
                Lelush.Instance.Speak("Не знаю, право не знаю, что бы я без вас делал");
                Console.ReadLine();
                Console.WriteLine("В этот момент в комнату влетел спецотряд чёрных рыцарей под предвадительством Капитана Сузаку");
                Console.ReadLine();
                Console.WriteLine("Разгорелась жёсткая битва между армейцами и рыцарями");
                Console.ReadLine();
                Console.WriteLine("В ходе этой заварушки принц попытался удрать, но Лилуш его настиг");
                Console.ReadLine();

                Console.WriteLine("Лилуш достал револьвер");
                Console.ReadLine();
                Kenzhi.Instance.Speak("Ну Лилуш, ну мы же братья, зачем тебе меня убивать, вспомни наше детство, ах как прекрасно оно было, а маму помнишь? Все было так..");
                Console.ReadLine();
                Console.WriteLine("*Выстрел*");
                Console.ReadLine();
                Console.WriteLine("Лилуш выстрелил в сантиметре от головы принца");
                Console.ReadLine();
                Lelush.Instance.Speak("Уже слишком поздно выяснять отношения, такие люди как вы - жалкое лживое говно, которому главное - лишь бы свою шкуру спасти");
                Console.ReadLine();
                Lelush.Instance.Speak("Я уже всё решил - прощай брат, и да унеси же ты с собой цветущие воспоминания нашего детства...");
                Console.ReadLine();
                Console.WriteLine("*Выстрел*");
                Console.ReadLine();
                Console.WriteLine("Лилуш убил принца");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("ПОЗДРАВЛЯЕМ! ВЫ ДОСТИГЛИ ЛУЧШЕЙ КОНЦОВКИ! Власть наконец свергнута и кажется люди достигли того, чего желали");
                Console.ReadLine();
                Console.WriteLine("Но к сожалению оказалось всё не так радужно, ведь после смерти принца на престол встал новый правитель, в чьих целях не было изменение порядка " +
                    "зависимости Японии");
                Console.ReadLine();
                Console.WriteLine("Но наши умелые бойцы не остановятся на этом, они проложат путь в свободное будущее общими усилиями");
                Console.ReadLine();
                Console.WriteLine("Продолжение Следует...");
                Console.ReadLine();
                ShowChoices();
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Над проектом работал Шуппе Матвей");
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("Visual Novel: Code Giass");
            }
            else
            {
                Kenzhi.Instance.Speak("Отвечай, отродье!");
                Console.ReadLine();
                Lelush.Instance.Speak("Ни за что");
                Console.ReadLine();
                Kenzhi.Instance.Speak("Ну тогда и умри");
                Console.ReadLine();
                Lelush.Instance.Speak("ЛЕЛУШ БРИТАНСКИЙ ПОВЕЛЕВАЕТ: ПОДЧИНИСЬ МНЕ");
                Console.ReadLine();
                Kenzhi.Instance.Speak("Э? ахахахах, тоже мне шутник");
                Console.ReadLine();
                Lelush.Instance.Speak("Невозможно, мой Гиасс всегда срабатывает, неужели эта сила подвела меня?");
                Console.ReadLine();
                Lelush.Instance.Speak("*Или секунду, неужели это потому, что я уже использовал на нём свой Гиасс, во время первой схватки*");
                Console.ReadLine();
                Kenzhi.Instance.Speak("Всё, мне надоела твоя болтовня, сгинь!");
                Console.ReadLine();
                Lelush.Instance.Speak("Неееет, Нанали!");
                Console.ReadLine();
                Console.WriteLine("*Выстрел*");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("СОЖАЛЕЕМ, НО ВСЕ ВАШИ РЕШЕНИЯ В ИГРЕ ПРИВЕЛИ К ХУДШЕЙ КОНЦОВКЕ!");
                Console.WriteLine("Лилуш погибает от рук принца, чёрные рыцари проигрывают битву и зацветают так и не успев распуститься, всех рыцарей садят под стражу, " +
                    "а Нанали, как и Ширли с Сузаку были публично расстрелены на площади, как организаторы террактов и подстрекатели");
                Console.ReadLine();
                ShowChoices();
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Над проектом работал Шуппе Матвей");
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("Visual Novel: Code Giass");
            }
        }
    }
}
