using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
 public class WorkWithOneString
    {
        private string InputPhrase;
        private string[] InputPhraseToArray;
        public WorkWithOneString(string _inputPhrase)
        {
            InputPhrase = _inputPhrase;
        }

        private bool IsStringPalindrom()
        {
            int minIndex = 0;
            int maxIndex = InputPhrase.Length - 1;
            while (true)
            {
                if (minIndex > maxIndex)
                {
                    return true;
                }
                char a = InputPhrase[minIndex];
                char b = InputPhrase[maxIndex];

                while (!char.IsLetterOrDigit(a))
                {
                    minIndex++;
                    if (minIndex > maxIndex)
                    {
                        return true;
                    }
                    a = InputPhrase[minIndex];
                }

                while (!char.IsLetterOrDigit(b))
                {
                    maxIndex--;
                    if (minIndex > maxIndex)
                    {
                        return true;
                    }
                    b = InputPhrase[maxIndex];
                }
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                minIndex++;
                maxIndex--;
            }
        }

        private int NumberOfStringInPhrase()
        {           
            InputPhraseToArray = InputPhrase.Split().ToArray();
            return InputPhraseToArray.Length;
        }

        private string ReverseInputPharse()
        {
            Array.Reverse(InputPhraseToArray);
            return string.Join(" ", InputPhraseToArray);
        }

        public void ToConsole()
        {
            if (!string.IsNullOrEmpty(InputPhrase))
            {
                Console.WriteLine(InputPhrase + ":  {0}", IsStringPalindrom() ? "Палиандром" : "Не палиандром");
                Console.WriteLine();
                Console.WriteLine("Ваша строка иммеет {0} Слов", NumberOfStringInPhrase());
                Console.WriteLine();
                Console.WriteLine("Перевернутая строка : {0}", ReverseInputPharse());
            }
            else Console.WriteLine("Ошибка- Вы ввели пустая строка");
            Console.Read();
        }
    }
}
