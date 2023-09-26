using System;
using System.Collections.Generic;

namespace Example2
{
    static class Program
    {
        static void Main(string[] args)
        {
            // Ввод ФИО
            Console.Write("Введите фамилию: ");
            string surname = Console.ReadLine();

            Console.Write("Введите имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите отчество: ");
            string patronimyc = Console.ReadLine();

            // Создание строки
            string fio = $"{surname} {name} {patronimyc}"; 
            Console.WriteLine($"ФИО: {fio}");

            // Длина строки
            int fioLength = fio.Length;
            Console.WriteLine($"1.1) Длина строки: {fioLength}");

            // Кол-во совпадающих букв
            int secondLetterСount = matchingLetters(2);
            Console.WriteLine($"1.2) Количество букв в строке, сопадающих со второй буквой фамилии: {secondLetterСount}");

            // Разделение строки
            string[] fioArray = fio.Split(' ');
            surname = fioArray[0];
            name = fioArray[1];
            patronimyc = fioArray[2];

            // Замена строчных на прописные
            // В отчестве заменить гласные строчные буквы на прописные
            patronimyc = vowelToUpperCase(patronimyc);
            Console.WriteLine($"1.4) Замена строчных на прописные в отчестве: {patronimyc}");

            // Преобразование строк в StringBuilder
            StringBuilder surnameSb = new StringBuilder(surname);
            StringBuilder nameSb = new StringBuilder(name);
            StringBuilder patronimycSb = new StringBuilder(patronimyc);

            // Вставить между буквами фамилии и имени знак '-'
            nameSb = insertDashBetweenEveryLetter(nameSb);
            surnameSb = insertDashBetweenEveryLetter(surnameSb);
            Console.WriteLine($"1.6) Вставить между буквами фамилии и имени знак '-': {nameSb} {surnameSb}");

            // Объединение строк класса String Builder и добавление комментария
            StringBuilder fioSb = $"{surnameSb} {nameSb} {patronimycSb}";
            fioSb.Append("\n Выполнил студент группы БО211ПИН");
            Console.WriteLine("Полученный объект класса StringBuilder: " + fioSb);

            Console.ReadLine();
        }

        int matchingLetters(int letterNumber) {
            char secondLetter = fio[--letterNumber];
            int matchingLetterСount = 0;
            foreach (char letter in fio) {
                if (letter == secondLetter) matchingLetterСount++;
            }
            return matchingLetterСount;
        }

        string vowelToUpperCase(string word) {
            HashSet<char> vowels = new HashSet<char> {'а', 'у', 'е', 'о', 'э', 'я', 'и', 'ю'};
            int wordLength = word.Length;
            for (int i = 0; i < wordLength; i++) {
                char currentLetter = word[i];
                if (vowels.Contains(currentLetter)) {
                    char newLetter = Char.ToUpper(currentLetter);
                    word = word.Replace(currentLetter, newLetter);
                }
            }
            return word;
        }

        StringBuilder insertDashBetweenEveryLetter(StringBuilder word) {
            int wordLength = word.Length;
            for (int i = 1; i < wordLength; i++) {
                word.Insert(wordLength - i, "-");
            }
            return word;
        }
    }
}