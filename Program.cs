// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine ("Ведите целое число дня недели до 7: ");
int x = int.Parse (Console.ReadLine());
if (x == 1)
{
    Console.WriteLine("Рабочий день недели понедельник");
}
else if (x > 1 && x < 3)
{
    Console.WriteLine("Рабочий день недели вторник");
}
else if (x > 2 && x < 4)
{
    Console.WriteLine("Рабочий день недели среда");
}
else if (x > 3 && x < 5)
{
    Console.WriteLine("Рабочий день недели четверг");
}
else if (x > 4 && x < 6)
{
    Console.WriteLine("Рабочий день недели пятница");
}
else if (x > 5 && x < 7)
{
    Console.WriteLine("Выходной день недели суббота");
}
else if (x == 7)
{
    Console.WriteLine("Выходной день недели воскресение");
}
