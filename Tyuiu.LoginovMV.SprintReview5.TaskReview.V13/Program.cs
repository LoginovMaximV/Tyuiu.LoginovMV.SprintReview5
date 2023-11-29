using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LoginovMV.SprintReview5.TaskReview.V13.Lib;
using System.IO;

namespace Tyuiu.LoginovMV.SprintReview5.TaskReview.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5| Выполнил: Логинов М.В | ИИПб-23-2";
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Спринт #5                                                                                                  *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                                                    *");
            Console.WriteLine("* Задание #7                                                                                                 *");
            Console.WriteLine("* Вариант #13                                                                                                *");
            Console.WriteLine("* Выполнил: Логинов М.В   | ИИПб-23-2                                                                        *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                   *");
            Console.WriteLine("* Создать папку в ручную С: DataSprint5 и скопировать в неё файл) в котором есть набор значений.             *");
            Console.WriteLine("* в котором есть набор символьных данных.Удалить все английские слова из файла.                              *");
            Console.WriteLine("* Полученный результат сохранить в файл OutPutDataFileTask7V13.txt.                                          *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                           *");
            Console.WriteLine("**************************************************************************************************************");
            string path = @"C:\Users\Валерий\source\repos\Tyuiu.LoginovMV.SprintReview5\DataSprint5\InPutDataFileTask7V13.txt";
            string savepath = @"C:\Users\Валерий\source\repos\Tyuiu.LoginovMV.SprintReview5\DataSprint5\OutPutDataFileTask7V13.txt";
            Console.WriteLine("Данные находятся в файле:" + path);
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                 *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("Находится в файле: ");
            savepath = ds.LoadDataAndSave(path);
            Console.WriteLine(savepath);
            Console.ReadKey();
        }
    }
}
