using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Module_9
{
    class Program
    {
        static void Main(string[] args)
        {

            Exception[] arrayException = new Exception[5];
            arrayException[0] = new MyException();
            arrayException[1] = new TimeoutException();
            arrayException[2] = new DivideByZeroException();
            arrayException[3] = new FileNotFoundException();
            arrayException[4] = new ArgumentException();

            foreach (Exception exception in arrayException)
            {
                try
                {
                    throw exception;
                }
                catch (MyException)
                {
                    Console.WriteLine("Сообщение об ошибке моего исключения");
                }
                catch (TimeoutException)
                {
                    Console.WriteLine("Срок действия интервала времени, выделенного для операции, истек");
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("Файл не найден");
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.ReadKey();
        }
    }



}
