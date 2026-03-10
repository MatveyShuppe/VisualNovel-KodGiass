using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Визуальная_новелла
{
    interface IScene
    {
        void Povestvovanie();
        
    }
    class MainScene : Statistics,  IScene
    {
        private MainScene nextScene;
        //protected Statistics stats;
        public MainScene(MainScene nextScene)
        {
            this.nextScene = nextScene;
            //stats = new Statistics();
        }
        public void Povestvovanie()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔=========╗");
            Console.Write("║ ");
            Console.ResetColor();
            Console.Write("ГЛАВА 1 ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("║");
            Console.WriteLine("╚=========╝");
            Console.ResetColor();
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Используйте любую клавишу для продолжения между фразами");
            Thread.Sleep(3000);
            Console.Clear();
            
            Console.WriteLine("В мире, погрязшем во лжи, люди ищут счастья, мир разделён на Британцев и Одиннадцатых");
            Console.ReadLine();
            Console.WriteLine("В ходе конца войны между Британией и Японией, японцы проиграли эту битву");
            Console.ReadLine();
            Console.WriteLine("Япония была уничтожена, и на этой территории теперь находится Зона 11," +
                " японцы потеряли свой сувенеритет и были прозваны одиннадцатыми");
            Console.ReadLine();
            Console.WriteLine("Британия стала великой державой благодаря своим продвинутым военным технологиям");
            Console.ReadLine();
            Console.WriteLine("А именно благодаря системе Nightmare");
            Console.ReadLine();
            Console.WriteLine("Данная система работает как робот напрямую управляемый человеком, правда чья огневая мощь в 10 раз сильнее танков");
            Console.ReadLine();
            Console.WriteLine("Лилуш Британский столкнулся с бесчестием этого мира и не справедливостью, когда в детстве у него на глазах");
            Console.WriteLine("убили его мать, а его младшая сестра потеряла зрение и возможность ходить, отца его лучшего друга убили");
            Console.ReadLine();
            Console.WriteLine("Он решил изменить этот мир ради создания будущего, в котором его сестра будет счастлива");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("*Стук в дверь*");
            Console.ReadLine();
            Console.WriteLine("Лилуш резко пробудился ото сна");
            Console.ReadLine();
            Shirli.Instance.Speak("Лилуш...");
            Console.ReadLine();
            Shirli.Instance.Speak("Ты один?", false);
            Console.Write(", прошептал знакомый женский голос");
            Console.WriteLine();
            Console.ReadLine();
            Lelush.Instance.Speak("Да, ты что-то хотела, Ширли?");
            Console.ReadLine();
            Shirli.Instance.Speak("Я хотела с тобой поговорить...");
            Console.ReadLine();
            Shirli.Instance.Characteristics("Ширли Кенберг - молодая девушка, лет 18, учится в академии Эшвард");
            Shirli.Instance.Characteristics("вместе с Лилушем, тайно влюблена в него, но ни за что не признается");
            Shirli.Instance.Characteristics("в своих чувствах (в будущем сыграет большую роль в сюжете)");
            Console.ReadLine();
            Console.WriteLine("Перед вами выбор: ");
            Console.WriteLine("Выслушать ее(1) или нет(2)"); //укрепит отношения между Ширли и главным героем
            Choice(nextScene);


        }

        public void Povestvovanie(MainScene secondscene)
        {
            if (Shirli.Instance.reputation > 0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("╔=========╗");
                Console.Write("║ ");
                Console.ResetColor();
                Console.Write("ГЛАВА 2 ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("║");
                Console.WriteLine("╚=========╝");
                Console.ResetColor();
                Thread.Sleep(2000);
                Console.Clear();
                Lelush.Instance.Speak("Что ты хотела обсудить со мной?");
                Console.ReadLine();
                Shirli.Instance.Speak("Я бы хотела извиниться за то, что наговорила тебе в прошлый раз, я была не в настроении и не думала, что говорила");
                
                Console.ReadLine();
                Lelush.Instance.Speak("Ничего страшного, я уже и забыл об этом");
                Console.ReadLine();
                Shirli.Instance.Speak("Правда??...");
                Console.ReadLine();
                Shirli.Instance.Speak("Я так рада!!! Я так долго мучала себя, думала, что сделала тебе больно, ведь ты всю неделю ходишь какой-то...");
                Console.ReadLine();
                Shirli.Instance.Speak("Не такой..");
                Console.ReadLine();
                Lelush.Instance.Speak("Что, правда?");
                Console.ReadLine();
                Shirli.Instance.Speak("Да, у тебя точно ничего не произошло?");
                Console.ReadLine();
                Lelush.Instance.Speak("Нет, ничего..");
                Console.ReadLine();
                Shirli.Instance.Speak("Ты ведь знаешь, меня не обмануть, но если ты не хочешь говорить об этом, то я не буду настаивать");
                Console.ReadLine();
                Shirli.Instance.Speak("Во всяком случае знай: Я всегда буду на твоей стороне, и всегда поддержу тебя");
                Console.ReadLine();
                Shirli.Instance.Speak("Ведь я... ");
                Console.ReadLine();
                Lelush.Instance.Speak("Что?");
                Console.ReadLine();
                Shirli.Instance.Speak("Ведь я... лю...");
                Console.ReadLine();
                Console.WriteLine("*В этот момент прозвенел звонок*");
                Console.ReadLine();
                Console.WriteLine("На следующей перемене Ширли не удалось найти Лилуша");
                Console.ReadLine();
                Console.Clear();
            }
            Console.WriteLine("После уроков Лелуш отправился как обычно играть в шахматы на деньги");
            Console.ReadLine();
            Console.WriteLine("Партии со сверстниками не вызывают в нём интереса, так как практически никто не может победить его");
            Console.ReadLine();
            Console.WriteLine("Именно поэтому он отправился играть с дворянами в главное здание управления, в котором проводился балл");
            Console.ReadLine();
            Console.WriteLine("Комната для игры выглядела на удивление огромной, похожей даже на зал");
            Console.ReadLine();
            Console.WriteLine("В помещении находилось примерно 200 человек");
            Console.ReadLine();
            Console.WriteLine("Перед Лелушем стоял его опонент, с виду очень знатный британский интеллегент");
            Console.ReadLine();
            Lelush.Instance.Speak("*Но я то знаю, что душа его черна, на самом деле это он в людях делает вид, что стоит что-то из себя*", false);
            Console.WriteLine(", с оскалом про себя сказал Лелуш");
            Console.ReadLine();
            Lelush.Instance.Speak("*В этом мире не должно быть так, что, проезжая на автобусе вокруг города с одной стороны из окна виден огромный чистый мегаполис");
            Console.ReadLine();
            Lelush.Instance.Speak("А с другой развалины прежнего города, разваленный именно такими людьми как тот, что стоит напротив меня*");
            Console.ReadLine();
            Console.WriteLine("И так пришло время начинать партию");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("После обычной перестановки фигур на доске Лелуш сделал очень необычный ход, он пошёл королём");
            Console.ReadLine();
            Lelush.Instance.Speak("Битву не выиграть, если не сдвинуть короля");
            Console.ReadLine();
            Console.WriteLine("*Резкий грохот*");
            Console.ReadLine();
            Console.WriteLine("В этот момент на здание парламента напали");
            Console.ReadLine();
            Console.WriteLine("Террористы назвали себя освободителями Японии под названием *Чёрные рыцари*");
            Console.ReadLine();
            Console.WriteLine("Практически сразу на терракт отреагировали военные силы под командыванием Принца");
            Console.ReadLine();
            Kenzhi.Instance.Speak("Думаете можете вот так просто помешать мирным жителям отдыхать? Я вам этого не позволю!");
            Console.ReadLine();
            Console.WriteLine("В попытках сбежать из этого безумия Лилуш был найден британскими военными");
            Console.ReadLine();
            Lelush.Instance.Speak("Пожалуйста, не стреляйте, я Британец, я свой");
            Console.ReadLine();
            Console.WriteLine("Но они его не послушали");
            Console.ReadLine();
            Console.WriteLine("В этот момент перед ним появилась загадочная женщина с светлозелёными волосами");
            Console.ReadLine();
            Console.WriteLine("Она предложила ему заключить с ней контракт, ведь если он действительно хочет изменить этот мир, то ему необходима будет сила");
            Console.ReadLine();
            Console.WriteLine("Женщину тут же расстреляли, но в Лилуша ни одна пуля не попала");
            Console.ReadLine();
            Lelush.Instance.Speak("Спасибо тебе, незнакомка...");
            Console.ReadLine();
            Lelush.Instance.Speak("ЛИЛУШ БРИТАНСКИЙ ПОВЕЛЕВАЕТ, УМРИТЕ!!!");
            Console.ReadLine();
            Console.WriteLine("Солдаты исполнили его приказ и застрелились...");
            Console.ReadLine();
            Console.WriteLine("Лилуш получил способность, сокрытую в его левом глазу, позволяющую отдать любому человеку один раз приказ",
                ", который он должен беспрекословно исполнить");
            Console.ReadLine();
            Console.WriteLine("С помощью этой силы, Лилушу удалось завладеть Nightmare'ом ");
            Console.ReadLine();
            Console.WriteLine("Теперь перед вами выбор: ");
            Console.ReadLine();
            Console.WriteLine("Угнать этот Nightmare для того, чтобы спастись(1) или Присоединиться к восстанию(2)");
            Choice2(nextScene);
        }
        public void Povestvovanie2(MainScene thirdscene)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔=========╗");
            Console.Write("║ ");
            Console.ResetColor();
            Console.Write("ГЛАВА 3 ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("║");
            Console.WriteLine("╚=========╝");
            Console.ResetColor();
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("К нему пришел его давний друг Сузаку, оказалось он тоже присоединился к чёрным рыцарям, но он не доверял зоро и не знал, что зеро-Лилуш");
            Console.ReadLine();
            Suzaku.Instance.Speak("Зеро, так?");
            Console.ReadLine();
            Lelush.Instance.Speak("Да, вы что-то хотели сэр Сузаку?");
            Console.ReadLine();
            Suzaku.Instance.Speak("Хотел узнать, что вы за человек");
            Console.ReadLine();
            Suzaku.Instance.Speak("Вдруг ни с того ни с сего обьявились из ниоткуда и прямо как чудо смогли помочь нам выиграть эту битву, предоставляете такие технологии...");
            Console.ReadLine();
            Suzaku.Instance.Speak("Я не понимаю зачем вам это");
            Console.ReadLine();
            Console.WriteLine("Лилуш потупился сразу ответить");
            Console.ReadLine();
            Lelush.Instance.Speak("Я хочу изменить этот мир");
            Console.ReadLine();
            Lelush.Instance.Speak("Ради своей цели я постараюсь сделать всё возможное и ни за что не проиграю");
            Console.ReadLine();
            Suzaku.Instance.Speak("хех");
            Console.ReadLine();
            Suzaku.Instance.Speak("Ты напоминаешь мне моего давнего друга");
            Console.ReadLine();
            Suzaku.Instance.Speak("мы с ним давно не виделись, но однажды в детстве он сказал мне...");
            Console.ReadLine();
            Lelush.Instance.Speak("Я уничтожу Британию");
            Console.ReadLine();
            Suzaku.Instance.Speak("Невозможно...Так ты...");
            Console.ReadLine();
            Lelush.Instance.Speak("Давно не виделись друг мой");
            Console.ReadLine();
            Suzaku.Instance.IncrementReputation();
            Console.WriteLine("Репутация с Сузаку выросла");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Лилуш и Сузаку проговорили всю ночь, в том числе и придумали план дальнейших действий");
            Console.ReadLine();
            Console.WriteLine("Они сочлись на том, что самым важным шагом будет убийство принца");
            Console.ReadLine();
            Console.WriteLine("Но дело это не из лёгких, необходимо много людей для выполнения плана");
            Console.ReadLine();
            Console.WriteLine("А план был таким: ");
            Console.ReadLine();
            Console.WriteLine("Чёрные рыцари должны устроить мятеж на перевозное здание, в котором обязан находится главнокомандующий во время боевых действий");
            Console.ReadLine();
            Console.WriteLine("Во время подготовки к операции к Лилушу пришла в голову идея зайти домой, поговорить с Нанали");
            Console.ReadLine();
            Console.WriteLine("Перед вами выбор: " +
                "Навестить Нанали(1) или Не делать этого(2)");
            Choice3(nextScene);
        }
        public void Endpovestvovanie(MainScene endscene)
        {
            Console.WriteLine("На следующий день началась операция...");
            Console.ReadLine();
            if (shirli.reputation > 0 && nanali.reputation > 0 && suzaku.reputation > 0)
            {
                Console.WriteLine("10 минутами ранее...");
                Console.ReadLine();
                Console.WriteLine("Неожиданно для всех в главный штаб пришли Ширли и Нанали");
                Console.ReadLine();
                Console.WriteLine("Они не знали кто такой Зоро на самом деле, но он смог их вдохновить, и наши героини решили внести хотя бы какой-то вклад в будущее освобождения Японии ");
                Console.ReadLine();
                Console.WriteLine("Лилуш не может так рисковать дорогими ему людьми, но в итоге принимает решение оставить их в безопасной зоне, так как вылазка уже была совсем скоро" +
                    "и времени на них не было ");
                Console.ReadLine();
                Console.Clear();
            }
                Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔=========╗");
            Console.Write("║ ");
            Console.ResetColor();
            Console.Write(" Финал ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("     ║");
            Console.WriteLine("╚=========╝");
            Console.ResetColor();
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Сразу после выступления Лилуша и отряда черных рыцарей на принца,  принял командование на себя и пошёл в оборону, но он недооценил соперника");
            Console.ReadLine();
            Console.WriteLine("Лилуш вместе с новобранцами пробрался внутрь здания, где находился принц, им был оказан отпор, но благодаря силе Гиасса пройти дальше у них " +
                "не составило труда");
            Console.ReadLine();
            Console.WriteLine("У Лилуша изначально был продуман план, как пробраться в комнату незаметно, да так чтобы принц даже не понял, что они уже внутри");
            Console.ReadLine();
            Console.WriteLine("Но к сожалению Лилуш просчитался");
            Console.ReadLine();
            Console.WriteLine("Войдя в комнату Лилуш увидел, что комната пуста");
            Console.ReadLine();
            Console.WriteLine("Кроме трона...");
            Console.ReadLine();
            Console.WriteLine("На нём восседает принц Кенжи");
            Console.ReadLine();
            Console.WriteLine("Принц заметил Лилуша");
            Console.ReadLine();
            Kenzhi.Instance.Speak("Не-ет, Зеро, как ты здесь оказался?");
            Console.ReadLine();
            Kenzhi.Instance.Speak("Тебя не должно было быть здесь, ваши основные войска ведь ещё слишком далеко");
            Console.ReadLine();
            Lelush.Instance.Speak("ХАХАХА, я всегда знал, брат, что ты тугодум и ни на что более, кроме издёвок над нищими не способен");
            Console.ReadLine();
            Lelush.Instance.Speak("Ты соишком глуп, чтобы понять как легко я тебя обставил");
            Console.ReadLine();
            Lelush.Instance.Speak("ТЫ");
            Console.ReadLine();
            Lelush.Instance.Speak("БАЛЛАСТ!!!");
            Console.ReadLine();
            Lelush.Instance.Speak("В мире должно быть меньше таких как вы, из-за твоей тупости мама и умерла!");
            Console.ReadLine();
            Console.WriteLine("Принц явно не ожидал такого поворота событий и был ошарашен услышанным");
            Console.ReadLine();
            Lelush.Instance.Speak("Прости уж Кенджи Британский, таков уж мир, сейчас ты умрёшь");
            Console.ReadLine();
            Console.WriteLine("После сказанных Лилушем слов на него с потолка свалились армейцы и повалили его на землю");
            Console.ReadLine();
            Console.WriteLine("Прямо по плану в этот момент должны были выскочить новобранцы и окружить отряд, но этого не последовало");
            Console.ReadLine();
            Lelush.Instance.Speak("Что? Но как?");
            Console.ReadLine();
            Kenzhi.Instance.Speak("АЗХАХАХАХАХАХ, ЧТО КАК?!");
            Console.ReadLine();
            Kenzhi.Instance.Speak("Ну да, точно, как я сразу не догадался, твоя манера речи, твои действия, твои способности на поле боя, Зеро - это ведь ты Лилуш?");
            Console.ReadLine();
            Kenzhi.Instance.Speak("Но как ты остался жив? Нам докладывали, что вас сослали и отправили отряд Nightmare'ов разобраться с вами");
            Console.ReadLine();
            Kenzhi.Instance.Speak("Лилуш, только не говори, что удача улыбнулась тебе и ты выжил? Постой, а Лилуш Ламперуш, ученик Академии Эшвард, это ведь тоже ты?");
            Console.ReadLine();
            Kenzhi.Instance.Speak("Ты, но под другой фамилией, тогда всё складывается");
            Console.ReadLine();
            Kenzhi.Instance.Speak("Но всё равно Лилуш, я смог обставить тебя и ПОБЕДИТЬ, я предугадал твои действия и теперь это ты умрёшь, при чём окончательно...");
            Console.ReadLine();
            Kenzhi.Instance.Speak("Вот только я одного не понимаю зачем тебе всё это? У тебя ведь есть всё, возьми ты тогда фамилию отца, а не матери," +
                " сейчас весь мир бы был пред тобой на коленях");
            Console.ReadLine();
            Kenzhi.Instance.Speak("Ах да, точно, Нанали...");
            Console.ReadLine();
            Lelush.Instance.Speak("Не смей произносить её имя, гад!");
            Console.ReadLine();
            Kenzhi.Instance.Speak("Кстати, как она там?");
            Console.ReadLine();
            FinalChoice();
        }
    }
    

}
