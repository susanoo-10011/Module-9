using System;

namespace Task2
{
    static class Program
    {
        static void Main(string[] args)
        {
            NumberReader reader = new NumberReader();
            reader.NumberEnteredEvent += SortSurname;
            while (true)
            {
                try
                {
                    reader.Read();
                    break;
                }
                catch (SortingException ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }

            Console.ReadKey();
        }
        
        static void SortSurname(int number)
        {
            string[] arraySurnames = { "Смирнов", "Попов", "Кузнецов", "Карпов", "Иванов" };
            switch (number)
            {
                case 1:
                    //сортировка А-Я
                    Array.Sort(arraySurnames);
                    foreach (string s in arraySurnames)
                    {
                        Console.WriteLine(s);
                    }
                    break;

                case 2:
                    //Сортировка Я-А 
                    Array.Sort(arraySurnames, (x, y) => String.Compare(y, x));
                    foreach (string s in arraySurnames)
                    {
                        Console.WriteLine(s);
                    }
                    break;
            }
        }
    }
}
