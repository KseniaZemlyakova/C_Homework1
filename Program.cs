// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Задача.2: напишите программу, которая на вход принимает два числа и выдает, какое 
// большее, а какое меньшее
// Console.WriteLine("vvedite chislo");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("vvedite chislo");
// int y = Convert.ToInt32(Console.ReadLine());

// if(x<y)
// {
//     Console.WriteLine("max=" + y+" min=" + x);
// }
// else if(y<x)
// {
//     Console.WriteLine("max=" + x + " min="+ x);
// }
// else
// {
//     Console.WriteLine("Chisla ravni");
// }

//Задача 4: Напишите программу, которая принимает на вход три числа и выдает
// максимальное из этих чисел

// Console.WriteLine("vvedite chislo");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("vvedite chislo");
// int y = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("vvedite chislo");
// int z = Convert.ToInt32(Console.ReadLine());

// int max=x;

// if(max<y)
// {
//     max=y;
// }
// else if(max<z)
// {
//     max=z;
// }
// Console.WriteLine("max="+max);

//Задача 6: Напишите программу, которая на вход принимает число и выдает, является
// ли это число четным (делится без остатка на 2)

// Console.WriteLine("vvedite chislo");
// int x = Convert.ToInt32(Console.ReadLine());

// if(x%2==0)
// {
//     Console.WriteLine(x+" delitsya na 2 bez ostatka");
// }
// else{
//     Console.WriteLine(x+" ne delitsya na 2 bez ostatka");
// }

//Задача 8: Напишите программу, которая на вход принимает число (N)
// а на выходе показывает все четные числа от 1 до N

Console.WriteLine("vvedite chislo");
int x = Convert.ToInt32(Console.ReadLine());
int num=2;
while(num<x)
{
    Console.WriteLine(num);
    num=num+2;
}