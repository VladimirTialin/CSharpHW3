try
{
    Console.Write("Введите число: ");
    int NumberOfPalindrom = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Наше число является палиндромом? ");
    Palindrom(NumberOfPalindrom);
}
catch
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Ошибочка вышла. Повтори ввод!");
    Console.ResetColor();
}
// Функция палиндром, наверное самая удачная у меня))
 void Palindrom(int number)
{
    int result = 0;
    int temp = number;
   while (number > 0)
    {
        result = result * 10 + number % 10;
        number /= 10;
    }
    if (temp == result)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"{temp} - > да");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine($"{temp} - > нет");
    }
    Console.ResetColor();
}