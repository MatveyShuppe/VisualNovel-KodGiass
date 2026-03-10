using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Визуальная_новелла
{
    abstract class Characters
    {
        protected string characteristics;
        protected string name;
        public int reputation { get; set; } = 0;
        protected void Speak()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.ResetColor();
        }

    }
    class Lelush : Characters   //главный персонаж, Лилуш
    {
        public static Lelush Instance { get; private set; }
        public Lelush()
        {
            if (Instance == null)
            {
                Instance = this;
            }
        }
        public void Characteristics(string characteristics)
        {
            this.characteristics = characteristics;
            Console.WriteLine(characteristics);
        }

        public void Speak(string speech, bool isTransferToNewLine = true)
        {

            Console.ForegroundColor = ConsoleColor.Green;
            name = "Лилуш: ";
            if (isTransferToNewLine)
            {
                Console.Write(name);
                Console.WriteLine(speech);
            }
            else
            {
                Console.Write(name);
                Console.Write(speech);
            }
            Console.ResetColor();
        }
    }
    class Nanali : Characters    //сестра Лилуша
    {
        public static Nanali Instance { get; private set; }
        public Nanali()
        {
            if (Instance == null)
            {
                Instance = this;
            }
        }
        public void IncrementReputation()
        {
            reputation++;

        }
        public void Characteristics(string characteristics)
        {
            this.characteristics = characteristics;
            Console.WriteLine(characteristics);
        }
        public void Speak(string speech, bool isTransferToNewLine = true)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            name = "Нанали: ";
            if (isTransferToNewLine)
            {
                Console.Write(name);
                Console.WriteLine(speech);
            }
            else
            {
                Console.Write(name);
                Console.Write(speech);
            }
            Console.ResetColor();
        }
    }
    class Kenzhi : Characters   //принц
    {
        public static Kenzhi Instance { get; private set; }
        public Kenzhi()
        {
            if (Instance == null)
            {
                Instance = this;
            }
        }
        public void Characteristics(string characteristics)
        {
            this.characteristics = characteristics;
            Console.WriteLine(characteristics);
        }
        public void IncrementReputation()
        {
            reputation++;

        }
        public void Speak(string speech, bool isTransferToNewLine = true)
        {

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            name = "Принц Кенжи: ";
            if (isTransferToNewLine)
            {
                Console.Write(name);
                Console.WriteLine(speech);
            }
            else
            {
                Console.Write(name);
                Console.Write(speech);
            }
            Console.ResetColor();
        }
    }
    class Suzaku : Characters     //лучший друг лелуша
    {    
        public static Suzaku Instance { get; private set; }
        public Suzaku()
        {
            if (Instance == null)
            {
                Instance = this;
            }
        }
        public void IncrementReputation()
        {
            reputation++;

        }
        public void Characteristics(string characteristics)
        {
            this.characteristics = characteristics;
            Console.WriteLine(characteristics);
        }
        public void Speak(string speech, bool isTransferToNewLine = true)  //Возможность разговора
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            name = "Сузаку: ";

            if (isTransferToNewLine)
            {
                Console.Write(name);
                Console.WriteLine(speech);
            }
            else
            {
                Console.Write(name);
                Console.Write(speech);
            }
            Console.ResetColor();
        }
    }
    class Shirli : Characters       //подруга Лелуша
    {
        public static Shirli Instance { get; private set; }
        public Shirli()
        {
            if (Instance == null)
            {
                Instance = this;
            }
        }
        public void Characteristics(string characteristics)
        {
            this.characteristics = characteristics;
            Console.WriteLine(characteristics);
        }
        public void IncrementReputation()
        {
            reputation++;

        }
        public void Speak(string speech, bool isTransferToNewLine = true)
        {

            Console.ForegroundColor = ConsoleColor.Magenta;
            name = "Ширли: ";
            if (isTransferToNewLine)
            {
                Console.Write(name);
                Console.WriteLine(speech);
            }
            else
            {
                Console.Write(name);
                Console.Write(speech);
            }
            Console.ResetColor();
        }

    }
    
}
