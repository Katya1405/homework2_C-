// По двум заданным числам проверять является ли одно квадратом другого

Console.WriteLine("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());
if (numberA == numberB * numberB)
{
    Console.WriteLine("Число " + numberA + " является квадратом числа " + numberB);
}
else if (numberB == numberA * numberA)
{
    Console.WriteLine("Число " + numberB + " является квадратом числа " + numberA);
}
else
{
    Console.WriteLine("Данные числа не являются квадратами друг друга");
}