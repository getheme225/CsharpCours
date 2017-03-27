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

        private bool IsStringPalindrom(string value)
        {
            int minIndex = 0;
            int maxIndex = value.Length - 1;
            while (true)
            {
                if (minIndex > maxIndex)
                {
                    return true;
                }
                char a = value[minIndex];
                char b = value[maxIndex];

                while (!char.IsLetterOrDigit(a))
                {
                    minIndex++;
                    if (minIndex > maxIndex)
                    {
                        return true;
                    }
                    a = value[minIndex];
                }

                while (!char.IsLetterOrDigit(b))
                {
                    maxIndex--;
                    if (minIndex > maxIndex)
                    {
                        return true;
                    }
                    b = value[maxIndex];
                }
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                minIndex++;
                maxIndex--;
            }
        }

        private int NumberOfStringInPhrase(string input)
        {
            int stringCount;
            InputPhraseToArray = input.Split().ToArray();
            stringCount = InputPhraseToArray.Length;
            return stringCount;
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
                Console.WriteLine(InputPhrase + ":  {0}", IsStringPalindrom(InputPhrase) ? "Палиандром" : "Не палиандром");
                Console.WriteLine("Ваша строка иммеет {0} Слов", NumberOfStringInPhrase(InputPhrase));
                Console.WriteLine();
                Console.WriteLine("Перевернутая строка : {0}", ReverseInputPharse());
                
            }
            else Console.WriteLine("Ошибка- Вы ввели пустая строка");
            Console.Read();
        }
    }
}
