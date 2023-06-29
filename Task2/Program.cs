// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double InputNum(string message)
{
    Console.Write(message);
    return double.Parse(Console.ReadLine()!);
}


double[] CrossPoint(double num1, double num2, double num3, double num4)
{
    double resX = (num3 - num1) / (num2 - num4);
    double resY = num4 * resX + num3;
    double[] array = new double[2];
    array[0] = resX;
    array[1] = resY;
    return array;

}

void PrintArray(double[] array)
{
    for (int i = 0; i < 2; i++)
    {
        Console.Write(array[i] + " ");
    }
}

double number1 = InputNum("Введите значение b1: ");
double number2 = InputNum("Введите значение k1: ");
double number3 = InputNum("Введите значение b2: ");
double number4 = InputNum("Введите значение k2: ");

double[] result = CrossPoint(number1, number2, number3, number4);
PrintArray(result);
Console.WriteLine();
if (result[0] != result[1]) Console.WriteLine("Прямые не пересекаются");