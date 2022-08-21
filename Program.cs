// Напишите программу, которая принимает на вход пятизначное число и 
//проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
/*
Console.Write("Введите пятизначное число - ");
string number = Console.ReadLine();
if (number.Length == 5) 
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine("Число является палиндромом");
    }
    else Console.WriteLine("Число  не является палиндромом");
}
else Console.WriteLine("Повторите ввод, число не пятизначное");
*/


//Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

/*
Console.Write("Ввведите координату х1: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ввведите координату y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ввведите координату z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ввведите координату х2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ввведите координату y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ввведите координату z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

//  d = √ (x b - x a)^ 2 + (y b - y a) ^2 + (z b - z a)^2.

double result = Math.Sqrt(Math.Pow(x1 - x2,2) + Math.Pow(y1 - y2,2) + Math.Pow(z1 - z2,2));

Console.WriteLine($"Расстояние между точками-   {Math.Round(result,2)}");
*/


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Ввведите число - ");
int num = Convert.ToInt32(Console.ReadLine());

int i = 1;
while (i<= num)
{
    Console.Write(Math.Pow(i, 3) + "\t");
    i++;
}