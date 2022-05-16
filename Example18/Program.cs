/*Задача 19: Напишите программу, которая принимает
на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да
*/
bool Palindrom (string number)
{
    for (int i = 0; i < number.Length / 2; i++)
    {
        if (number[i] != number[number.Length - i - 1])
        {
         return false;   
        } 
    }  
    return true;   
}
try
{
Console.Write("Введите число: ");
UInt64 addNumber = Convert.ToUInt64(Console.ReadLine());
Console.WriteLine($"Является ли число {addNumber} - палиндромом?");
    if (Palindrom(Convert.ToString(addNumber) ?? "0"))
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"{addNumber} - > да"); 
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine($"{addNumber} - > нет"); 
    }
    Console.ResetColor();
}
catch
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(" Ошибка ввода! Вы попытались ввести отрицательное значение, текст, либо символы!\n Братишка! Повтори ввод!");
    Console.ResetColor();
}
