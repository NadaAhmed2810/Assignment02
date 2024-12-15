using System.Linq.Expressions;

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
        }
    }
}
