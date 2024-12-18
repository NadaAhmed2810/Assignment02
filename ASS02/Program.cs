using System.Diagnostics;
using System.Linq.Expressions;
using System.Net.Security;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ASS02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Value Type Casting
            #region implicit casting -Safe Casting
            //int x = 4;//4 byte
            //long y = x;
            #endregion
            #region Explicit Casting_UnSafe Casting _Not recommended 
            //long X = 102020304050; //8 byte
            //int Y;
            //checked 
            //{
            //    Y = (int)X;
            //}
            //Console.WriteLine(Y);
            //int X = 88;
            //double Y = X;//Y=(double)X
            //double X = 88.22;
            //int Y =(int) X;
            //Console.WriteLine(Y);

            #endregion
            #region Parse[Convert from string to any data type]
            //int num=int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Data User ");
            //string Name;
            //Console.Write("Enter Name : ");
            //Name=Console.ReadLine();
            //int  Age;
            //Console.Write("Enter Age : ");
            //Age = int.Parse(Console.ReadLine());
            //double Salary;
            //Console.Write("Enter Salary : ");
            //Salary = double.Parse(Console.ReadLine());

            //Console.Clear();
            //Console.WriteLine("Name: " + Name + " Age: " + Age + " Salary: "+ Salary);

            #endregion
            #region convert [convert from any data type to any data type]
            //Console.WriteLine("Enter Data User ");
            //string Name;
            //Console.Write("Enter Name : ");
            //Name=Console.ReadLine();
            //int  Age;
            //Console.Write("Enter Age : ");
            //Age = Convert.ToInt32(Console.ReadLine());
            //double Salary;
            //Console.Write("Enter Salary : ");
            //Salary = Convert.ToDouble(Console.ReadLine());

            //Console.Clear();
            //Console.WriteLine("Name: " + Name + " Age: " + Age + " Salary: "+ Salary);

            #endregion
            #endregion
            #region operators
            #region Unary operators[++,--]
            //int x = 5;
            //x++;
            //++x;//prefix
            //Console.WriteLine(++x);
            //Console.WriteLine(x++);
            //Console.WriteLine(--x);
            //Console.WriteLine(x--);
            #endregion
            #region Binary operators[+,-,*,/,%]
            //int sum, sub, mul, div, mod;
            //int A = 10;
            //int B = 5;
            //sum = A + B;
            //Console.WriteLine(sum);
            //sub = A - B;
            //Console.WriteLine(sub);
            //mul = A * B;
            //Console.WriteLine( mul);
            //div = A / B;
            //Console.WriteLine( div);
            //mod = A % B;
            //Console.WriteLine(mod);


            #endregion
            #region Assignment operators
            //int x = 10;
            //x+= 10;
            //x-= 10;
            //x*= 10;
            //x /= 10;
            //x %= 10;

            #endregion
            #region realational operator
            //int A = 50;
            //int B = 70;
            //Console.WriteLine(A == B);
            //Console.WriteLine(A != B);
            //Console.WriteLine(A <= B);
            //Console.WriteLine(A >= B);
            //Console.WriteLine(A > B);
            //Console.WriteLine(A < B);

            #endregion
            #region logical operators short circuit
            //Console.WriteLine(!true);
            //Console.WriteLine(true && false);
            //Console.WriteLine(false && true);
            //Console.WriteLine(true && true);
            //Console.WriteLine(false && false);
            //Console.WriteLine(true || false);
            //Console.WriteLine(false || true);
            //Console.WriteLine(true || true);
            //Console.WriteLine(false || false);

            #endregion
            #region Bitwise operator long circuit 
            //Console.WriteLine(true & false);
            //Console.WriteLine(false & true);
            //Console.WriteLine(true & true);
            //Console.WriteLine(false & false);
            //Console.WriteLine(true | false);
            //Console.WriteLine(false | true);
            //Console.WriteLine(true | true);
            //Console.WriteLine(false | false);


            #endregion
            #region ternary operator [conditional operator]
            //int x =3 ;
            //String message = x > 4 ? "x Greater than 4" : "x Less than or equal 4";
            //Console.WriteLine(message);
            #endregion

            #endregion
            #region operator priority
            /*
             1. unary operator [prefix]
             2. ()
             3.  / * %
             4. + -
             */
            //int A = 20,B=15,C=10,D=5,res;
            //res = (A + B) * C / D;// 70
            //res = A++ * C; //200
            //res = ++A * C; //210
            #endregion
            #region String formating
            // Equation = X + Y = Result
            // Equation = 10 + 5 = 15
            //int X = 10, Y = 5, Result = 15;
            //Console.WriteLine(" Equation"+" = "+ X +" + "+ Y  +" = "+Result );//7 object
            //string immutable data type
            #region Composite Format
            //string mes=String.Format("Equation = {0} + {1} = {2}", X, Y, Result);
            //Console.WriteLine(mes);
            #endregion

            #region string manipolaition
            //string interpolation =>$
            //Console.WriteLine($"Equation = {X} + {Y}= {Result}");


            #endregion
            #endregion
            #region If Else - switch case
            //Console.WriteLine("Enter Month Number ");
            //int monthnum=int.Parse(Console.ReadLine());
            //if (monthnum == 1) 
            //    Console.WriteLine("jan");
            //else if (monthnum == 2)
            //    Console.WriteLine("feb");
            //else if (monthnum == 3)
            //    Console.WriteLine("mar");
            //else 
            //    Console.WriteLine("invalid input");

            //switch (monthnum) {
            //    case 1:
            //        Console.WriteLine("jan");
            //             break;
            //    case 2:
            //        Console.WriteLine("feb");
            //        break;
            //    case 3:
            //        Console.WriteLine("mar");
            //        break;
            //    default:Console.WriteLine("Invalid Input");
            //            break; 

            //}
            //String Name=Console.ReadLine();
            //if (Name == "Mostafa" || Name=="mostafa")
            //    Console.WriteLine("Hello,Mostafa");
            //else if (Name == "Aliaa")
            //    Console.WriteLine("Hello,Aliaa");
            //else if (Name == "Ahmed")
            //    Console.WriteLine("Hello,Ahmed");
            //switch (Name)
            //{
            //    case "Mostafa":
            //    case"mostafa":
            //        Console.WriteLine("Hello,Mostafa");
            //        break;
            //    case "Aliaa":
            //        Console.WriteLine("Hello,Aliaa");
            //        break;
            //    case "Ahmed":
            //        Console.WriteLine("Hello,Ahmed");
            //        break;

            //}
            //less than 5 not jump 
            #endregion
            #region GOTO
            //Console.Write("Enter Option: ");
            //3000=>Option01 ,Option 02,Option03
            //2000=>Option01,Option 02
            //1000=>option 01
            //int Option =int.Parse(Console.ReadLine());
            //switch (Option)
            //{
            //    case 3000:
            //        Console.WriteLine("Option03");
            //        goto case 2000;
            //    case 2000:
            //        Console.WriteLine("Option02");
            //        goto case 1000;
            //    case 1000:
            //        Console.WriteLine("Option01");
            //        break;
            //}
            #endregion
            #region Evaluation of switch case
            #region C#06
            //Console.WriteLine("Enter Age");
            //int Age =int.Parse(Console.ReadLine());
            //switch (Age)
            //{
            //    case < 22:
            //        Console.WriteLine("Age less than 22");
            //        break;
            //    case  > 22:
            //        Console.WriteLine("Age greater  than 22");
            //        break;
            //    default:
            //        Console.WriteLine("Age equal 22");
            //         break; 
            //}
            #endregion
            #region C#07
            //object obj=new object();
            //obj = "Mostafa";
            //obj = 1;
            //obj = 'C';
            //obj = true;
            //switch (obj)
            //{
            //    case int Number when Number >10 && Number <20:
            //        Console.WriteLine($"{Number} is int ");
            //        break;
            //    case string s:
            //        Console.WriteLine($"{s} is  string");
            //        break;
            //    case bool b:
            //        Console.WriteLine($"{b} is  boolean");
            //        break;
            //    case char c:
            //        Console.WriteLine($"{c} is  char");
            //        break;

            //}
            #endregion
            #region C#08
            #region Ex01
            //Console.WriteLine("Enter option");
            //int x = int.Parse(Console.ReadLine());
            //string message = x
            //    switch {
            //        1 => "option 1",
            //        2 => "option 2"
            //       , 3 => "option 3",
            //        _=> "invalid"
            //     };
            //Console.WriteLine(message);
            #endregion
            #region Ex02
            //Employee employee = new Employee();
            //employee.Name = "ali";
            //employee.Age = 20;
            //employee.Id = 10;
            //string message = employee switch
            //{
            //    { Id: 10, Name: "Alaa", Age: 20 } => $"{employee.Id} : {employee.Name} : {employee.Age}",
            //    { Id: 10, Name: "ali", Age: 20 } => $"{employee.Id} : {employee.Name} : {employee.Age}",
            //    { Id: 20, Name: "mona", Age: 22 } => $"{employee.Id} : {employee.Name} : {employee.Age}"
            //};
            //Console.WriteLine(message);
            #endregion
            #endregion
            #region C#09           
            //Employee employee = new Employee();
            //employee.Name = "ali";
            //employee.Age = 20;
            //employee.Id = 10;
            //string message = employee switch
            //{
            //    { Age: <20 and <25 } => $"{employee.Id} : {employee.Name} : {employee.Age}",
            //    { Age: >20 } => $"{employee.Id} : {employee.Name} : {employee.Age}",
            //    {  Age: <22 } => $"{employee.Id} : {employee.Name} : {employee.Age}"
            //};
            //Console.WriteLine(message);
            #endregion
            #endregion
            

        }
    }
}
