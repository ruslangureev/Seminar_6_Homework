Console.Write("Введите количество цифр: ");
int size = int.Parse(Console.ReadLine());
int count = 0;
string resul = " ";
int number1 = 1;

for (int i = 0; i < size; ++i)
{
    Console.Write($"Введите {number1} число: ");
    double number = double.Parse(Console.ReadLine());
    resul = resul + number + ",";
    if (number > 0)
    ++count;
    ++number1;
}
Console.Write($"Среди введенных чисел {resul} больше нуля: {count}");

