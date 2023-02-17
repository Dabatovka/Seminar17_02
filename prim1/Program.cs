//Написать прог. которая будет принимать на вход два числа,
// и выводить является ли второе число кратное первлму,
// если не кратное то выводить остаток от деления.

Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введитк второк число: ");
int num2 = int.Parse(Console.ReadLine());
if (num1 % num2 == 0){
    Console.WriteLine("кратно");}
else{
    Console.WriteLine($"не кратно, остаток {num1 % num2}");
}