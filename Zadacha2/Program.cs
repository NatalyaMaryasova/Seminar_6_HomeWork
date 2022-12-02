// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

var k1 = ReadInt("Введите значение для k1:");
var b1 = ReadInt("Введите значение для b1:");
var k2 = ReadInt("Введите значение для k2:");
var b2 = ReadInt("Введите значение для b2:");

if (k1 != k2)
{
    var x = -(b1 - b2) / (k1 - k2);
    var y = k1 * x + b1;
    Console.WriteLine($"Прямые пересекаются в точке: ({x};{y})");
}
else Console.WriteLine("Прямые параллельны");


double ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToDouble(Console.ReadLine());
}
