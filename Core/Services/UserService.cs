﻿using Core.Models;
using Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Core.Services
{
    public class UserService
    {
        private readonly UserRepository _UserRepsitory = new UserRepository();
        public User? Login(string login, string password)
        {
            User? user = _UserRepsitory.GetByName(login);
            if (user != null && user.Password.Equals(password))
            {
                return user;
            }
            Console.WriteLine("Ошибка ввода, попробуйте еще раз");
            Console.ReadKey();
            return null;
        }
        public User? Create(string name, string password)
        {
            try
            {
                if (!_UserRepsitory.Exist(name))
                {
                    User newUser = new User(name, password);
                    Console.WriteLine("Регистрация прошла успешно");
                    Console.ReadKey();
                    return _UserRepsitory.Create(newUser);
                    
                }
                Console.WriteLine("Error");
                Console.ReadKey();
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        public User? Update(User user, string password)
        {

            if (user == null) throw new ArgumentNullException(nameof(user));
            try
            {
                user.Password = password;
                return _UserRepsitory.Update(user);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        public bool Delete(User user)
        {
            if (user == null) throw new ArgumentNullException(nameof(user));
            try
            {
                _UserRepsitory.Delete(user.Id);
                Console.WriteLine("Пользователь успешно удален");
                Console.ReadKey();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
    }
}
