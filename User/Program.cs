using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("1-регистрация");
            System.Console.WriteLine("2-авторизация");
            System.Console.WriteLine("3-выход");
            int choose = Convert.ToInt32(Console.ReadLine());
            if (choose == 1)
            {
                Account regisrt = new Account();
                regisrt.Registr(out User? user);

                ApplicationTransaction applicationTransaction = new ApplicationTransaction();
                applicationTransaction.SignIn();

            }
            else if (choose == 2)
            {
                ApplicationTransaction applicationTransaction = new ApplicationTransaction();
                applicationTransaction.SignIn();
            }
            else
            {
                Console.WriteLine("выход");
            }
        }
    }
}