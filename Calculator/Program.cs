using System;
using Singleton;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

           
            // Console.WriteLine("Enter 1st number :");

           
            // int fnum = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("Enter 2nd number :");


            // int snum = Convert.ToInt32(Console.ReadLine());

            // int sum = pamal.Add(fnum, snum);

            // Console.WriteLine("Sum is :" + sum);

            // Console.ReadKey();

           Singleton.Singleton fromTeachaer = Singleton.Singleton.GetSingleton;
           fromTeachaer.InstanceMessage("From Tacher");
            
            Singleton.Singleton fromStudent = Singleton.Singleton.GetSingleton;
            fromStudent.InstanceMessage("From Student");
            Console.ReadLine();



        }
    }
}
