// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.WriteLine("Введите число от 1 до 7: ");
int day = int.Parse(Console.ReadLine());
int saturday = 6;
int sunday = 7;
if (day == saturday || day == sunday)
{
    Console.WriteLine("Выбранный день является выходным");
}
else
{
    Console.WriteLine("Выбранный день не является выходным");
}