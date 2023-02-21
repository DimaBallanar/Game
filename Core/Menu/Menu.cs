using Core.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Controller;
using Core.Models;


namespace Core.Menu
{
    public static class Menu
    {
        static PlatformController ControllerUser = new PlatformController();
        public static void MenuStart(bool autorizationIn, string? numberMenu, User? user)
        {
            PlatformController ControllerUser = new PlatformController();
            while (true)
            {
                Console.Clear();
                if (!autorizationIn)
                {
                    Console.Clear();
                    Console.WriteLine("1 Регистрация");
                    Console.WriteLine("2 Авторизация");
                    Console.WriteLine("0 Выход из программы");
                    Console.WriteLine("Введите номер меню");
                    numberMenu = Console.ReadLine();
                    if (numberMenu.Equals("1"))
                    {
                        Console.Clear();
                        while (true)
                        {
                            (bool, User?) result = ControllerUser.Create();
                            break;
                        }
                    }

                    else if (numberMenu.Equals("2"))
                    {
                        Console.Clear();
                        while (true)
                        {
                            Console.Clear();                           
                            (bool, User?) result = ControllerUser.Login();
                            autorizationIn = result.Item1;
                            user = result.Item2;
                            break;
                        }
                    }                                   
                }

                else if (autorizationIn)
                {
                    Console.Clear();
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine($"{user.Name}");

                        Console.WriteLine("1 Изменение аккаунта");
                        Console.WriteLine("2 Просмотр статистики");
                        Console.WriteLine("3 Игра БлекДжек");
                        Console.WriteLine("0 Выход из Аккаунта");
                        Console.WriteLine("Введите номер меню");
                        numberMenu = Console.ReadLine();
                        if (numberMenu.Equals("1"))
                        {
                            Console.Clear();
                            Console.WriteLine("1 Изменение пароля");
                            Console.WriteLine("2 Удаление аккаунта");
                            Console.WriteLine("0 выход");
                            numberMenu = Console.ReadLine();
                            if (numberMenu.Equals("1"))
                            {                               
                                (bool, User?) result = ControllerUser.Update(user);

                            }
                            else if (numberMenu.Equals("2"))
                            {                               
                                (bool, User?) result = ControllerUser.Delete(user);
                                autorizationIn = result.Item1;
                                user = result.Item2;
                                break;
                            }

                        }
                        else if (numberMenu.Equals("2"))
                        {

                            // просмотр статистики игр
                        }
                        else if (numberMenu.Equals("3"))
                        {

                            // блекджек
                        }
                        else if (numberMenu.Equals("4"))
                        {

                            //морской бой
                        }
                        else if (numberMenu.Equals("0"))
                        {
                            autorizationIn = false;
                            break;
                        }
                    }
                }
                else if (numberMenu.Equals("0"))
                {
                    break;
                }

            }
            Console.WriteLine("Hello");
        }
    }
}