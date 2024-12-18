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
            //        Console.WriteLine("Char is not Vowel");
            //        break;
            //}
            #endregion
            #region Q6: Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            //Console.Write("Enter A Number:");
            //int num=int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 12; i++) Console.WriteLine(num * i);
            #endregion
        }
    }
}
