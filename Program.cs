// Task 19 Напишите программу, которая принимает на вход число и проверяет, является ли оно палиндромом.
// int NumberOfDigits(int number)
// {
//     int ostatok = 0;
//     int digits = 0;
//     while (ostatok != number)
//         {
//         digits ++;  
//         ostatok = number%Convert.ToInt32(Math.Pow(10, digits));    
//         }
// return digits;
// }
// bool Skan(int number)
// {
// int cifr = NumberOfDigits(number);
// int stepen = cifr-1;
// int delitel = Convert.ToInt32(Math.Pow(10, stepen));
// while (cifr>1)
// {
//     if (number/delitel == number%10)
//         {
//             number = number%delitel;
//             number = number / 10;
//             cifr = NumberOfDigits(number);
//             stepen = cifr-1;
//             delitel = Convert.ToInt32(Math.Pow(10, stepen));
//         }
//     else return false;
// }
// return true;
// }
// Console.WriteLine("Введите число ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Число {number} является палиндромом - {Skan(number)}");

// // Task 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// double Range (double x1, double y1, double z1, double x2, double y2, double z2)
// {
//     double r = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
//     r = Math.Round(r, 2);
//     return r;
// }
// Console.Write("Enter the x coordinates of the first point  ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Enter the Y coordinates of the first point  ");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Enter the Z coordinates of the first point  ");
// double z1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Enter the X coordinates of the second point  ");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Enter the Y coordinates of the second point  ");
// double y2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Enter the Z coordinates of the second point  ");
// double z2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine($"The Range between the points are - {Range(x1,y1,z1,x2,y2,z2)}");


// Task 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// void Kyb(int n)
// {
//     int count = 1;
//     Console.WriteLine("|  Number |  Kyb |");
//     while (count<n)
//     {
//         Console.WriteLine($"|    {count}    |   {count*count*count}   |");
//         count++;
//     }
// }
// Console.Write("Please Enter N number ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("This is a Kyb table: ");
// Console.WriteLine("");
// Kyb(n);