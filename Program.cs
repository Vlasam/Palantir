// По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine ("Ведите первое число: ");
int x = int.Parse (Console.ReadLine());
Console.WriteLine ("Ведите второе число: ");
int y = int.Parse (Console.ReadLine());
if (y * y == x )
{
    Console.WriteLine ("Первое число квадрат второго");
}
else if (x * x == y )
{
    Console.WriteLine ("Второе число квадрат первого");
}
else if (x == y)
{
    Console.WriteLine ("Условие не выполняется");
}
else if ( x * x > y )
{
    Console.WriteLine ("Условие не выполняется");
}
else if ( y * y > x)
{
    Console.WriteLine ("Услвие не выполняется");
}