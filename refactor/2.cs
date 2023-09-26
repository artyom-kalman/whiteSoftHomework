using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    static class Program
    {
        static void Main(string[] args)
        {
            //Ввод ФИО
            Console.Write("Введите фамилию: ");
            string secondname = Console.ReadLine();
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите отчество: ");
            string lastname = Console.ReadLine();

            //Создание строки
            string line = new String('-', 20);
            Console.WriteLine(line);
            string fio = secondname + " " + name + " " + lastname; 
            Console.WriteLine("ФИО:");
            Console.WriteLine(fio);
            

            //Длина строки
            int length = fio.Length;
            Console.WriteLine("1.1) Длина строки: " + length);

            //Кол-во совпадающих букв
            char s2 = fio[1];
            int s2count = 0;
            for (int i = 0; i < length; i++)
            {
                if (fio[i] == s2) s2count++;
            }
            Console.WriteLine("1.2) Количество букв в строке, сопадающих со второй буквой фамилии: " + s2count);

            //Разделение строки
            string[] fioarr = fio.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            secondname = fioarr[0];
            name = fioarr[1];
            lastname = fioarr[2];

            //Замена строчных на прописные
            int lastnamelength = lastname.Length;
            for (int i = 0; i < lastnamelength; i++)
            {
                char letter = lastname[i];
                if (letter == 'а' || letter == 'у' || letter == 'е' || letter == 'о' || letter == 'э' || letter == 'я' || letter == 'и' || letter == 'ю')
                {
                    letter = Char.ToUpper(letter);
                    lastname = lastname.Replace(fio[i], letter);
                }
            }
            Console.WriteLine("1.4) Замена строчных на прописные в отчестве: " + lastname);

            //Преобразование строк в StringBuilder
            StringBuilder secondnamesb = new StringBuilder(secondname);
            StringBuilder namesb = new StringBuilder(name);
            StringBuilder lastnamesb = new StringBuilder(lastname);

            //Вставить между буквами фамилии и имени знак '-'
            int namelength = namesb.Length;
            int secondnamelength = secondnamesb.Length;
            for (int i = 1; i <  namelength; i++) namesb.Insert(namelength - i, "-");
            for (int i = 1; i < secondnamelength; i++) secondnamesb.Insert(secondnamelength - i, "-");
            Console.WriteLine("1.6) Вставить между буквами фамилии и имени знак '-': {0} {1}" , namesb , secondnamesb);

            //Объединение строк класса String Builder и добавление комментария
            StringBuilder fiosb = secondnamesb;
            fiosb.Append(" " + namesb + " " + lastnamesb);
            fiosb.Append("\n Выполнил студент группы БО211ПИН");
            Console.WriteLine("Полученный объект класса StringBuilder: " + fiosb);

            Console.ReadLine();
        }
    }
}