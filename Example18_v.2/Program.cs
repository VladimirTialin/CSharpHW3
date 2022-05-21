/*Задача 19: Напишите программу, которая принимает
на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да
*/
try
{
    Console.Write("Введите число: ");
    int NumberOfPalindrom = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Является ли число {NumberOfPalindrom} - палиндромом?");
    if (NumberOfPalindrom == Palindrom(NumberOfPalindrom))
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"{NumberOfPalindrom} - > да");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine($"{NumberOfPalindrom} - > нет");
    }
    Console.ResetColor();
}
catch
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Ошибочка вышла. Повтори ввод!");
    Console.ResetColor();
}
//Сама функция палиндрома
 int Palindrom(int number)
{
    int result = 0;
   while (number > 0) 
    {
        result = result * 10 + number % 10;
        number /= 10;
    }
            return result;
}