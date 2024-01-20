#region Convert
//string name;
//int age;

//Console.Write("Enter your name: ");
//name = Console.ReadLine();
//Console.Write("Enter yor age:");
//age = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"{name}, {age} years old.");
#endregion

#region 11
// 11.
//int number = 4;
//for (int i = 1; i <= number; i++)
//{
//    string str = string.Concat(Enumerable.Repeat(i, i));
//    Console.WriteLine(str);
//}

//for (int i = 1; i <= number; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write($"{i}");
//    }
//    Console.Write("\n");
//}
#endregion

#region 12
// 12
//int length = 5;
//int number = 1;

//for (int i = 1; i <= length; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        // Console.Write($"{(i, j)} ");
//        Console.Write($"{number++} ");
//    }
//    Console.WriteLine();
//}
#endregion

#region 13
// 13
//int length = 5;
//int space = length - 1;
//int number = 1;

//for (int i = 1; i <= length; i++)
//{
//    Console.Write(new String(' ', space--));
//    for (int j = 1; j <= i; j++)
//    {
//        // Console.Write($"{(i, j)} ");
//        Console.Write($"{number++} ");
//    }
//    Console.WriteLine();
//}

//    1
//   2 3
//  4 5 6
// 7 8 9 10
//11 12 13 14 15
#endregion

#region 14
// 14,
//int length = 5;
//int space = length - 1;

//for (int i = 1; i <= length; i++)
//{
//    Console.Write(new String(' ', space--));
//    for (int j = 1; j <= i; j++)
//    {
//        // Console.Write($"{(i, j)} ");
//        Console.Write("* ");
//    }
//    Console.WriteLine();
//}
#endregion

#region 15 factorial
//int number = 6;
//int factorial = 1;

//for (int i = 1; i <= number; i++)
//{
//    // factorial = factorial * i;
//    factorial *= i;
//}

//Console.WriteLine($"{number}! = {factorial}");
#endregion

#region 16
int number;
int summary = 0;

// მომხმარებელმა შემოიყვანოს
Console.Write("Enter number: ");
number = Convert.ToInt32(Console.ReadLine());

Console.Write("The even numbers are: ");

for (int i = 1; i <= number; i++) // 2 + 4 + 6 + 8 + 10
{
    Console.Write((i * 2) + " ");
    //Console.Write($"{i*2} ");
    summary += i * 2;
}

//Console.WriteLine();
Console.WriteLine($"\nThe Sum of even Natural Number upto {number} terms: {summary}");
#endregion

//https://www.w3resource.com/csharp-exercises/for-loop/index.php#google_vignette

// Array
// https://www.w3resource.com/csharp-exercises/array/index.php
// 1. ... stores elements in an array and prints them.
