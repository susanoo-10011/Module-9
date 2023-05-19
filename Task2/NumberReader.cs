using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class NumberReader
    {
        public delegate void NumberEnteredDelegate(int number);
        public event NumberEnteredDelegate NumberEnteredEvent;

        public void Read()
        {
            Console.WriteLine("Введите значения 1 или 2");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int sortOption))
            {
                throw new SortingException("Некорректный ввод. Введите 1 или 2.");
            }

            if (sortOption != 1 && sortOption != 2)
            {
                throw new SortingException("Некорректный ввод. Введите 1 или 2.");
            }
            NumberEntered(sortOption);
        }

        protected virtual void NumberEntered(int number)
        {
            NumberEnteredEvent?.Invoke(number);
        }
    }
}
