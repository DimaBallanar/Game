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
            if (choose == 1)
            {
                Account regisrt = new Account();
                regisrt.Registr();



            }
            else if (choose == 2)
            {
                Account login = new Account();
                login.Login();

            }
            else
            {
                Console.WriteLine("выход");
            }
        }
    }
}