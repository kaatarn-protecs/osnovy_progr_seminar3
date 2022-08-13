// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
int q = 0;
while (true)
{
    Console.WriteLine("Введите число: ");
    if (int.TryParse(Console.ReadLine(), out q)) break;
    else
    {
        Console.WriteLine("Вы ввели некорректное число!");
        Console.WriteLine("Для прерывания программы нажмите `CTRL + C`");
    }
}

void PrintCubes(int a)
{
    for (int i = 1; i <= a; ++i) // Перебираем от 1 до a
        Console.WriteLine($"{i, 4} | {i * i * i} \t");
}

if (q < 1)
{
    Console.WriteLine("Введите число >= 1");
    return;
}

Console.WriteLine($"Таблица кубов числа {q}:");
PrintCubes(q);