// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да
int num = 0;
while (true)
{
    Console.WriteLine("Введите число ");
    if (int.TryParse(Console.ReadLine(), out num)) break;
    else
    {
        Console.WriteLine("Некорректное число! Повторите ввод!");
        Console.WriteLine("Для прерывания программы нажмите `CTRL + C`");
    }
}

bool GetPal(int number)
{
    int oldValue = number;
    int newValue = 0;
    while (number > 0 || number < 0)
    {
        int ost = number % 10;
        newValue = newValue * 10 + ost;
        number = number / 10;
    }
    return Math.Abs(newValue) == Math.Abs(oldValue);
}

if (GetPal(num)) Console.WriteLine($"{num} -> Да");
else Console.WriteLine($"{num} -> Нет");