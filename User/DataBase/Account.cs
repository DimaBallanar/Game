using System;
using System.IO;
using System.Text;

namespace DataBase;

public class Account
{
    string[] Lines=File.ReadAllLines(@"D:\ДЗ С#\hschool\hschool_beggining_csh\Game\User\DataBase\DT.txt");
    public Account()
    {
        //{
        //    Lines = File.ReadAllLines(@"D:\ДЗ С#\hschool\hschool_beggining_csh\Game\User\DataBase\DT.txt");
        //}
    }
    public bool Login()
    {
        System.Console.Write("введите логин: ");
        string? login = Console.ReadLine();
        System.Console.Write("введите пароль:");
        string? pass = Console.ReadLine();
        string user = Search(login, pass);
        return user != null;
    }

    private string Search(string? login, string? pass)
    {
        if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(pass))
        {
            Console.WriteLine("ERROR");
            return null;
        }
        for (int i = 0; i < Lines.Length; i++)
        {
            string[] strings = Lines[i].Split(',');
            if (strings[0] == login && strings[1] == pass)
            {
                Console.WriteLine("Login Succesful");
                string user = login + ',' + pass;

                return user;
            }
        }
        System.Console.WriteLine("ERROR input");
        return null;

    }
    public bool Registr()
    {
        System.Console.WriteLine("введите логин");
        string? name = Console.ReadLine();
        System.Console.WriteLine("введите пароль");
        string? pass = Console.ReadLine();

        if (SearchSimple(name, pass))

        {
            //using StreamWriter sw = new StreamWriter(@"D:\ДЗ С#\hschool\hschool_beggining_csh\Game\User\DataBase\DT.txt");
            //StringBuilder sb = new StringBuilder();
            File.AppendAllText(@"D:\ДЗ С#\hschool\hschool_beggining_csh\Game\User\DataBase\DT.txt", $"{name},{pass}");
            //Lines.AppendAllLines($"{name},{pass}");
            Console.WriteLine("Регистрация завершена");
        }
        return Login();

    }
    private bool SearchSimple(string? name, string? password)
    {
        if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password))
        {
            System.Console.WriteLine("ERROR");
            return Registr();
        }
        for (int i = 0; i < Lines.Length; i++)
        {
            string[] strings = Lines[i].Split(',');
            if (strings[0] == name)
            {
                Console.WriteLine("такой пользователь уже существует");
                return Registr();
            }
        }
        return true;

    }


}
