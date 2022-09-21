// НАаписать программу, которая найдет точку пересечения двух прямых,
// заданных уравнениями y1 = k1*x+b1, y2 = k2*x+b2;
// значения b1, k1, b2, k2 задаются пользователем

Console.Clear();

Console.WriteLine("Введите параметры для прямых:");
float k1 = Convert.ToInt32(Console.ReadLine());
float b1 = Convert.ToInt32(Console.ReadLine());
float k2 = Convert.ToInt32(Console.ReadLine());
float b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"k1 = {k1}, b1 = {b1}, k2 = {k2}, b2 = {b2}");

float CrossPoint_X = (b2 - b1) / (k1 - k2);
float CrossPoint_Y = (k1*b2 - k2*b1) / (k1 - k2);

Console.WriteLine($"Координаты пересечения: ({CrossPoint_X}, {CrossPoint_Y})");