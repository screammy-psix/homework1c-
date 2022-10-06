//Задача 1: Напишите программу, 
//которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

void Homework1()
{
    int a = -9;
    int b = -3;
    if (a > b)
    {
        Console.WriteLine("max=" + a);
        Console.WriteLine("min="+ b);
    }
    else
    {
        Console.WriteLine("max=" + b);
        Console.WriteLine("min="+ a);
    }
}

void Homework2()
//Задача 2: Напишите программу, 
//которая принимает на вход три числа и 
//выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
{
    int a = 44;
    int b = 5;
    int c = 78;
    int max = a;
    if (b > max)
    {
        max=b;
    }
    if (c > max)
    {
        max = c;
    }
        Console.WriteLine("max=" + max);
}
void Homework3()
//Задача 3: Напишите программу, 
//которая на вход принимает число и выдаёт, 
//является ли число чётным 
//(делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет
{
    int number = 4;
    if (number % 2 == 0)
    {
        Console.WriteLine($"{number} да");
    } 
    else
    {
      Console.WriteLine($"{number} нет");  
    }
}
void Homework4()
//Задача 4: Напишите программу, 
//которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8
{
    int number = 5;
    int counter = 2;
    while (counter <= number)
    {
        Console.WriteLine(counter);
        counter +=2;
    }
}
Homework4();