using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
 public class WorkWithOneString
    {
        private string inputPhrase;
        private string[] inputPhraseToArray;
        public WorkWithOneString(string _inputPhrase)
        {
            inputPhrase = _inputPhrase;
        }

        private bool IsStringPalindrom()
        {
            int minIndex = 0;
            int maxIndex = inputPhrase.Length - 1;
            while (true)
            {
                if (minIndex > maxIndex)
                {
                    return true;
                }
                char a = inputPhrase[minIndex];
                char b = inputPhrase[maxIndex];

                while (!char.IsLetterOrDigit(a))
                {
                    minIndex++;
                    if (minIndex > maxIndex)
                    {
                        return true;
                    }
                    a = inputPhrase[minIndex];
                }

                while (!char.IsLetterOrDigit(b))
                {
                    maxIndex--;
                    if (minIndex > maxIndex)
                    {
                        return true;
                    }
                    b = inputPhrase[maxIndex];
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
            inputPhraseToArray = inputPhrase.Split().ToArray();
            return inputPhraseToArray.Length;
        }

        private string ReverseInputPharse()
        {
            Array.Reverse(inputPhraseToArray);
            return string.Join(" ", inputPhraseToArray);
        }

        public void ToConsole()
        {
            if (!string.IsNullOrEmpty(inputPhrase))
            {
                Console.WriteLine(inputPhrase + ":  {0}", IsStringPalindrom() ? "Палиандром" : "Не палиандром");
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
