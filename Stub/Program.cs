using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = "file1.txt";//название файла,который ищем

            FileManager mgr = new FileManager();// экземляр класса, с логикой поиска файла 

            if (mgr.FindLogFile(fileName))//если вернул метод true
            {
                Console.WriteLine("Файл {0} найден!", fileName);
            }
            else
            {
                Console.WriteLine("Файл {0} не найден!", fileName);
            }

            Console.ReadKey();
        }
    }
}
