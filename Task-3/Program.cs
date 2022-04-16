using System;
using Task_3.Task2Class;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string username1;
            string password1;
         
            User user = new User();

            do
            {
                Console.Write("Username enter:");
                username1 = Console.ReadLine();
            } while (username1.Length<6);
            do
            {
                Console.Write("Password enter:");
                password1 = Console.ReadLine();
            } while (!user.GetPassword(password1)||password1.Length<6);

            Admin admin = new Admin(username1,password1,true,"SectionNAME"); 
            admin.Show();
            

      
         

            



            //Console.WriteLine("Username:");
            //user.UserName = Console.ReadLine();

            //Console.WriteLine("Password:");
            //user.Password = Console.ReadLine();





            #region Task2
            //Car car = new Car(2011, "BMW", "X6");
            ////car.Showinfo();

            //Bus bus = new Bus(2011, 50);
            ////bus.Showinfo();

            //Vehicle[] Arr = { car, bus };

            //foreach (var item in Arr)
            //{
            //    item.Showinfo();
            //}

            #endregion
        }
        #region Overloading
        //public static int Sum(int x, int y)
        //{
        //    return x + y;
        //}
        //public static int Sum(int x, int y, int z)
        //{
        //    return x + y + z;
        //}
        //public static int Sum(int x, int y, int k, int z)
        //{
        //    return x + y + k + z;
        //}
        //public static int Sum(int y, int x, int k, int m, int r)
        //{
        //    return y + x + k + r + m;
        //}

        //public static int Minus(int y, int x)
        //{
        //    return x - y;
        //}
        //public static int Minus(int x, int y, int k, int r)
        //{
        //    return y - x - k - r;
        //}
        //public static int Minus(int y, int x, int k)
        //{
        //    return x - y - k;
        //}
        //public static int Minus(int x, int y, int k, int r, int h)
        //{
        //    return y - x - k - r - h;
        //}

        //public int MultiPlay(int x, int y)
        //{
        //    return x * y;
        //}
        //public static int MultiPlay(int x, int y, int k)
        //{
        //    return x * y * k;
        //}
        //public static int MultiPlay(int x, int y, int k, int h)
        //{
        //    return x * y * k * h;
        //}
        //public static int MultiPlay(int x, int y, int k, int h, int r)
        //{
        //    return x * y * k * h * r;
        //}

        //public static double Divide(int y, int x)
        //{
        //    return (double) x / y;
        //}
        //public static double Divide(int y, int x, int z)
        //{
        //    return (double) x / y / z;
        //}
        //public static double Divide(int y, int x, int z, int k)
        //{
        //    return (double)x / y / z / k;
        //}
        //public static double Divide(int y, int x, int z, int k, int r)
        //{
        //    return (double)x / y / z / k / r;
        //}
        #endregion

    }
}
