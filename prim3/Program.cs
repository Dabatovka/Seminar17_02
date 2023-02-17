//Написать программу, которая на принимает на вход два числа и проверяет,
//является ли одно число квадратом другого.

Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());
if (а * а == b || Math.Pow(b, 2)== a)
{
    Console.WriteLine("Да");

}
else
{
    Console.WriteLine("Нет");
}