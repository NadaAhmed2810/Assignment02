using System.ComponentModel;
using System.Diagnostics.Metrics;

namespace Assignment02
{
    internal class Program
    {
        static void Getmin (int num1,int num2)
        {
            if (num1 > num2) Console.WriteLine($"Min Element: {num2}");
            else Console.WriteLine($"Min Element: {num1}");
        }
        static void Main(string[] args)
        {

            #region Q1: Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.

            //Console.Write("Enter a Number to check if can divide by 3 and 4 or not : ");
            //int num=int.Parse(Console.ReadLine());
            // if (num % 3 == 0 && num % 4 == 0) Console.WriteLine("Yes");
            // else Console.WriteLine("No");

            #endregion
            #region Q2: Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            //Console.Write("Enter a Number to check if the number positive or negative : ");
            //int num=int.Parse(Console.ReadLine());
            //switch (num)
            //{
            //    case > 0:
            //        Console.WriteLine("positive");
            //        break;
            //    case < 0:
            //        Console.WriteLine("negative");
            //        break;
            //    default: 
            //        Console.WriteLine("Zero not negative and not positive ");
            //        break;

            //}

            #endregion
            #region Q3:Write a program that takes 3 integers from the user then prints the max element and the min element.
            //int num1, num2, num3;
            //Console.WriteLine("Enter 3 number to get the min num and max num ");
            //Console.Write("enter the first number: ");
            //num1=int.Parse(Console.ReadLine());
            //Console.Write("enter the second number: ");
            //num2 = int.Parse(Console.ReadLine());
            //Console.Write("enter the third number: ");
            //num3 = int.Parse(Console.ReadLine());
            //if (num1>num2 && num1 > num3)
            //{
            //    Console.WriteLine($"Max Element: {num1}");
            //    Getmin(num2, num3);
            //}
            //else if(num2>num1 && num2 > num3)
            //{
            //    Console.WriteLine($"Max Element: {num2}");
            //    Getmin(num1, num3);
            //}
            //else
            //{
            //    Console.WriteLine($"Max Element: {num3}");
            //    Getmin(num1, num2);
            //}
            #endregion
            #region Q4:Write a program that allows the user to insert an integer number then check If a number is even or odd.
            //Console.Write("Enter a Number to check if the number even or odd: ");
            //int num=int.Parse(Console.ReadLine());
            //if (num % 2 == 0) Console.WriteLine("number is even: ");
            //else Console.WriteLine("number is odd: ");
            #endregion
            #region Q5: Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            //Console.Write("Enter a char to check if vowel or not : ");
            //char c=char.Parse(Console.ReadLine());
            //switch (c)
            //{
            //    case 'a':
            //    case 'i':
            //    case 'e':
            //    case 'o':
            //    case 'u':
            //    case 'A':
            //    case 'E':
            //    case 'I':
            //    case 'O':
            //    case 'U':
            //        Console.WriteLine("Char is Vowel");
            //        break;
            //    default:
            //        Console.WriteLine("Char is Consonant");
            //        break;
            //}
            #endregion
            #region Q6: Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            //Console.Write("Enter A Number:");
            //int num=int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 12; i++) Console.WriteLine(num * i);
            #endregion
            #region Q7: Write a program that takes two integers then prints the power.
            //Console.WriteLine("To calc power to number");
            //int Base ,power,res=1;
            //Console.Write("Enter Base: ");
            //Base=int.Parse(Console.ReadLine());
            //Console.Write("Enter power: ");
            //power = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= power; i++) res *= Base;
            //Console.WriteLine(res);
            #endregion
            #region Q8: Write a program to enter marks of five subjects and calculate total, average and percentage.
            //Console.WriteLine("Enter five grades :");
            //double g1, g2, g3, g4, g5, total, avg, percentge;
            //Console.Write("Enter g1:");
            //g1 = double.Parse(Console.ReadLine());
            //Console.Write("Enter g2:");
            //g2 = double.Parse(Console.ReadLine());
            //Console.Write("Enter g3:");
            //g3 = double.Parse(Console.ReadLine());
            //Console.Write("Enter g4:");
            //g4 = double.Parse(Console.ReadLine());
            //Console.Write("Enter g5:");
            //g5 = double.Parse(Console.ReadLine());
            //total = g1 + g2 + g3 + g4 + g5;
            //Console.WriteLine($"Total:{total} ");
            //avg = total / 5;
            //Console.WriteLine($"Average:{avg}");
            //percentge = total * 100 / 500;
            //Console.WriteLine($"percentge:{percentge}");
            #endregion
            #region Q9: Write a program to input the month number and print the number of days in that month.
            //Console.Write("Enter number of Month:");
            //int month = int.Parse(Console.ReadLine());
            //switch (month)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        Console.WriteLine($"Number of month: {month}");
            //        Console.Write("Days in Month: 31 ");
            //        break;
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        Console.WriteLine($"Number of month: {month}");
            //        Console.Write("Days in Month: 30 ");
            //        break;
            //    case 2:
            //        Console.WriteLine($"Number of month: {month}");
            //        Console.Write("Days in Month: 29 ");
            //        break;
            //    default:
            //        Console.WriteLine("invalid input");
            //        break;
            //}
            #endregion
            #region Q10: Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.
            //Console.WriteLine("Enter the coordinates of the three points:");

 
            //Console.Write("Point 1 (x1 y1): ");
            //string[] p1 = Console.ReadLine().Split(' ');
            //double x1 = double.Parse(p1[0]);
            double y1 = double.Parse(p1[1]);
            //Console.Write("Point 2 (x2 y2): ");
            //string[] p2 = Console.ReadLine().Split(' ');
            //double x2 = double.Parse(p2[0]);
            //double y2 = double.Parse(p2[1]);

            //Console.Write("Point 3 (x3 y3): ");
            //string[] p3 = Console.ReadLine().Split(' ');
            //double x3 = double.Parse(p3[0]);
            //double y3 = double.Parse(p3[1]);
            //if ((y2 - y1) / (x2 - x1) == (y3 - y2) / (x3 - x2)) Console.WriteLine("The points are collinear and lie on a straight line.");
            //else Console.WriteLine("The points are not collinear and not lie on a straight line.");
            #endregion

        }
    }
}
