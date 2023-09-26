using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Подключение файла и чтение строки из него
            string path = @"E:\Учёба\ЯП\ЛР8\8.2\Text2.txt";
            StreamReader text = new StreamReader(path);
            string line = text.ReadLine();
            text.Close();

            //Разбиение строки с помощью разделителя ". "
            string[] ourhistory = line.Split(new string[] { ". " }, StringSplitOptions.RemoveEmptyEntries);
            string[] WordsInText = line.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            //Объявление переменных
            int i;
            int k;
            int j;
            int vowelmaxposition = 0;
            char PenultimateLetter;
            char LastLetter;
            string str;
            string clipboardstring;
            int clipboardint;
            int[] Vowels = new int[WordsInText.Length];
            int[] WordsCount = new int[24];
            int length = ourhistory.Length;
            char[] lowercase = { 'а', 'б', 'в', 'г', 'д', 'е', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ы', 'э', 'ю', 'я', 'ё', 'ж', 'з' };
            
            //Соединиение строк для образования предложений
            for (i = 0; i < length; i++)
            {
                k = ourhistory.Length - 1 - i;
                str = ourhistory[k];
                PenultimateLetter = str[str.Length - 2];
                LastLetter = str[str.Length - 1];
                for (j = 0; j < lowercase.Length; j++)
                {
                    if (str[0] == lowercase[j])
                    {
                        ourhistory[k - 1] += ". " + ourhistory[k];
                        for (j = k; j < length - 1; j++) ourhistory[j] = ourhistory[j + 1];
                    }
                }
                if (LastLetter == 'г' & (PenultimateLetter == '.' || PenultimateLetter == 'г') || PenultimateLetter == ' ')
                {
                    ourhistory[k] += ". " + ourhistory[k + 1];
                    for (j = k + 1; j < length - 1; j++) ourhistory[j] = ourhistory[j + 1];
                }
            }

            //Подсчёт слов в строках
            for (i = 0; i < 24; i++)
            {
                str = ourhistory[i];
                for (j = 0; j < str.Length; j++) if (str[j] == ' ') WordsCount[i]++;
            }

            str = "Hello";
            str = str.Remove(0, str.Length - 3);
            str = str.Substring(0, str.Length - 3);


            //Нахождение стова с наибольшим количеством гласных подряд
            str = WordsInText[0];
            Vowels[0] = VowelsCount(str);
            int vowelmax = Vowels[0];
            for (i = 1; i < WordsInText.Length; i++)
            {
                str = WordsInText[i];
                Vowels[i] = VowelsCount(str);
                Console.WriteLine(Vowels[i]);
                if (Vowels[i] > vowelmax)
                {
                    vowelmax = Vowels[i];
                    vowelmaxposition = i;
                }
            }

            //Сортировка строчного массива по возрастанию количества содержащихся в них слов
            for (i = 0; i < 24; i++)
            {
                for (j = i + 1; j < 24; j++)
                {
                    if (WordsCount[i] > WordsCount[j])
                    {
                        clipboardstring = ourhistory[j];
                        ourhistory[j] = ourhistory[i];
                        ourhistory[i] = clipboardstring;
                        clipboardint = WordsCount[j];
                        WordsCount[j] = WordsCount[i];
                        WordsCount[i] = clipboardint;
                    }
                }
            }

            //Вывод
            for (j = 0; j < 24; j++)
            {
                ourhistory[j] += ".";
                WordsCount[j]++;
                Console.WriteLine((j + 1) + ")" + ourhistory[j] + " Количество слов: " + WordsCount[j]);
            }
            Console.WriteLine("\nСлово с наибольшим количестовм согласных, идущих подряд: {0}. Количество согласных, идущих подряд: {1}", WordsInText[vowelmaxposition], vowelmax);
            Console.ReadLine();
        }

        static int VowelsCount(string str)
        {
            int vowelcount = 0;
            int vowelcount1 = 0;
            for (int k = 0; k < str.Length; k++)
            {
                vowelcount1 = 0;
                if (str[k] == 'б' || str[k] == 'й' || str[k] == 'ц' || str[k] == 'к' || str[k] == 'н' || str[k] == 'г' || str[k] == 'ш' || str[k] == 'щ' || str[k] == 'х' || str[k] == 'ъ' || str[k] == 'ф' || str[k] == 'в' || str[k] == 'п' || str[k] == 'р' || str[k] == 'л' || str[k] == 'д' || str[k] == 'ж' || str[k] == 'ь' || str[k] == 'ч' || str[k] == 'с' || str[k] == 'м' || str[k] == 'т')
                {
                    vowelcount1++;
                    for (int i = k + 1; i < str.Length; i++)
                    {
                        if (str[i] == 'б' || str[i] == 'й' || str[i] == 'ц' || str[i] == 'к' || str[i] == 'н' || str[i] == 'г' || str[i] == 'ш' || str[i] == 'щ' || str[i] == 'х' || str[i] == 'ъ' || str[i] == 'ф' || str[i] == 'в' || str[i] == 'п' || str[i] == 'р' || str[i] == 'л' || str[i] == 'д' || str[i] == 'ж' || str[i] == 'ь' || str[i] == 'ч' || str[i] == 'с' || str[i] == 'м' || str[i] == 'т') vowelcount1++;
                        else break;
                    }
                    if (vowelcount < vowelcount1) vowelcount = vowelcount1;
                }
            }
            return vowelcount;
        }
    }
}
