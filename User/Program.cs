using DataBase;
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
            Account account = new Account();
            if (choose == 1)
            {
                account.Registr();
            }
            else if (choose == 2)
            {
                account.Login();
            }
            else
            {
                Console.WriteLine("выход");
            }
        }
    }
}