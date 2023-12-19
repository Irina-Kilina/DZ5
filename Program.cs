// Задача 1: Создание строки из двумерного массива символов

// char[,] charArray = new char[,] { { 'a', 'b' }, { 'c', 'd' } };
// string result = CreateStringFrom2DArray(charArray);
// Console.WriteLine(result);

// static string CreateStringFrom2DArray(char[,] array)
// {
// string result = "";
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
//     result += array[i, j];
// }
// }
// return result;
// }

//Задача 2: Замена заглавных букв на строчные в строке.

// void Main(string[] args)
// {
//     string input = "aBcD1ef!-";
//     string result = input.ToLower();
//     Console.WriteLine(result);
// }
// Main(args);

//Задача 3: Проверка строки на палиндром

// void Main(string[] args)
// {
//     string input = "шалаш";
//     bool isPalindrome = IsPalindrome(input);
//     Console.WriteLine(isPalindrome? "Да" : "Нет");

// }
// bool IsPalindrome(string str)
// {
//     string normalized = new
// string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
// return normalized.SequenceEqual(normalized.Reverse());
// }
// Main(args);