// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int CountNum(int num)
{
    int count = 0;
    for (int i = 1; i <= num; i++)
    {
        int temp = InputNum($"Введите число {i}: ");
        if (temp > 0)
            count++;
    }
    return count;
}

int number = InputNum("Введите количество чисел: ");
int res = CountNum(number);
Console.WriteLine(res);