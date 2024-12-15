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
        }
    }
}
