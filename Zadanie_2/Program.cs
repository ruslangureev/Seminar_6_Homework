Console.WriteLine("Первая прямая задана уравнением y = k1 * x + b1");
Console.Write("k1 = ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("b1 = ");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Вторая прямая задана уравнением y = k2 * x + b2");
Console.Write("k2 = ");
double k2 = double.Parse(Console.ReadLine());
Console.Write("b2 = ");
double b2 = double.Parse(Console.ReadLine());

if (k2 == k1 && b2 == b1)
{
    Console.WriteLine("Прямые совпадают");
}
else if (k2 == k1 && b2 != b1)
{
    Console.WriteLine("Прямые параллельны");
}
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Координаты точки пересечения этих прямых ({x},{y})");
}

