using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Services;
using Core.Models;

namespace Core.Controller
{
    public class PlatformController
    {
        private UserService servicUser = new UserService();
        public (bool, User?) Login()
        {
            Console.Write("Enter Name: ");
            string? name = Console.ReadLine();
            Console.Write("Enter Password: ");
            string? password = Console.ReadLine();
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(password))
            {
                User? userID = servicUser.Login(name, password);
                if (userID != null)
                {
                    Console.WriteLine("Succes");
                    Console.ReadKey();
                    return (true, userID);
                }
            }
            return (false, null);
        }
        public (bool, User?) Create()
        {
            Console.Write("Enter Name: ");
            string? name = Console.ReadLine();
            Console.Write("Enter Password: ");
            string? password = Console.ReadLine();
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(password))
            {
                User? userID = servicUser.Create(name, password);
                if (userID != null)
                {
                    return (true, userID);
                }
            }
            return (false, null);
        }
        public (bool, User?) Update(User? user)
        {
            if (user == null)
            {
                return (false, null);
            }
            Console.Write("Enter new Password: ");
            string? password = Console.ReadLine();
            if (!string.IsNullOrEmpty(password))
            {
                User cloneUser = user.Clone() as User;
                cloneUser = servicUser.Update(cloneUser, password);
                if (cloneUser != null)
                {
                    Console.WriteLine("Пароль успешно изменен");
                    return (true, cloneUser);
                }
            }
            return (true, null);
        }
        public (bool, User?) Delete(User? user)
        {
            if (user == null)
            {
                return (false, null);
            }
            servicUser.Delete(user);
            Console.WriteLine("Пользователь удален");
            return (false, null);



        }
    }
}

