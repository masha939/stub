using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stub
{
    public class FileManager
    {

        public bool FindLogFile(string fileName)
        {
           FileDataObject obj = new FileDataObject(); //класс поиска по файловой системе
           //TestDataObject obj = new TestDataObject(); // заглушка,для тестирования

            List<string> files = obj.GetFiles();

            foreach (var file in files) 
            {
                if (file.Contains(fileName))  //поиск названия файла 
                {
                    return true;
                }
            }

            return false;
        }
       
    }
}
