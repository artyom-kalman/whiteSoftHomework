using System;
using System.Collections.Generic;

namespace Example3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Подключение файла и чтение строки из него
            string path = @"../Text.txt";
            StreamReader text = new StreamReader(path);
            string line = text.ReadLine();
            text.Close();

            // Разбиение текста на предложения
            string[] sentences = line.Split(". ", StringSplitOptions.RemoveEmptyEntries);
            string[] wordsInText = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            const int NUMBER_OF_SENTENCES = 24;
            HashSet<char> lowercase = HashSet<char> { 'а', 'б', 'в', 'г', 'д', 'е', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ы', 'э', 'ю', 'я', 'ё', 'ж', 'з' };
            int sentencesLength = sentences.Length;            

            // Соединиение строк для образования предложений
            for (int i = 0; i < sentencesLength; i++)
            {
                int k = sentences.Length - 1 - i;
                string sentence = sentences[k];

                char secontToLastLetter = sentence[sentence.Length - 2];
                char lastLetter = sentence[sentence.Length - 1];

                if (lowercase.Contains(sentence[0])) {
                    sentences[k - 1] += ". " + sentences[k];
                    for (int j = k; j < sentencesLength - 1; j++) 
                        sentences[j] = sentences[j + 1];
                }

                bool patterMatched = (lastLetter == 'г' && (secontToLastLetter == '.' || secontToLastLetter == 'г') || secontToLastLetter == ' ');
                if (patterMatched) {
                    sentences[k] += ". " + sentences[k + 1];
                    for (int j = k + 1; j < sentencesLength - 1; j++) { 
                        sentences[j] = sentences[j + 1];
                    }
                }
            }

            // Подсчёт слов в строках
            int[] wordsInSentence = countWordsInText(sentences);

            // Нахождение слова с наибольшим количеством гласных подряд
            int consonantMaxPosition = mostConsecutiveСonsonantsPosition(wordsInText);
            int consonantMax = consonantCount(wordsInText[consonantMaxPosition]);

            // Сортировка строчного массива по возрастанию количества содержащихся в них слов
            Array.Sort(sentences, (x, y) => x.Length.CompareTo(y.Length));

            // Вывод
            for (int j = 0; j < NUMBER_OF_SENTENCES; j++) {
                sentences[j] += ".";
                wordsInSentence[j]++;
                Console.WriteLine((j + 1) + ")" + sentences[j] + " Количество слов: " + wordsInSentence[j]);
            }

            Console.WriteLine($"Слово с наибольшим количестовм согласных, идущих подряд: {wordsInText[consonantMaxPosition]}");
            Console.WriteLine($"Количество согласных, идущих подряд: {consonantMax}");
            Console.ReadLine();
        }

        int[] countWordsInText(string[] text) {
            int textLength = text.Length;
            int[] wordsInSentence = new int[textLength];

            for (int i = 0; i < textLength; i++) {
                string sentence = text[i];
                wordsInSentence[i] = sentence.Count(x => x == ' ');
            }
            return wordsInSentence;
        }

        int mostConsecutiveСonsonantsPosition(string[] words) {
            int consonantMaxPosition = 0;
            int consonantMax = consonantCount(wordsInText[0]);
            for (int i = 1; i < wordsInText.Length; i++) {
                int consonantNumber = consonantCount(wordsInText[i]);
                if (consonantNumber > consonantMax) {
                    consonantMax = consonantNumber;
                    consonantMaxPosition = i;
                }
            }
            return consonantMaxPosition;
        }

        int consonantCount(string str)
        {
            HashSet<char> consonants = new HashSet<char> {'б', 'в', 'г', 'д', 'ж', 'з', 'й', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'ф', 'х', 'ц', 'ч', 'ш', 'щ'};
            int consonantCountMax = 0;
            int consonantCountCurrent = 0;
            bool previousConsonant = false;
            for (int k = 0; k < str.Length; k++)
            {
                if (consonants.Contains(str[k])) {
                    consonantCountCurrent++;
                    previousConsonant = true;
                    continue;
                } 
                consonantCountMax = (consonantCountCurrent > consonantCountMax)
                    ? consonantCountCurrent
                    : consonantCountMax;

                consonantCountCurrent = 0;
                previousConsonant = false;
            }
            return consonantCountMax;
        }
    }
}
