using System;
namespace DataBase;

public class Account
{
    private int NextIdUser = 1;
    private User[] Users;
    public Account()
    {
        {
            string path = @"D:\ДЗ С#\hschool\hschool_beggining_csh\Game\User";
            FileStream basa = new FileStream(path, FileMode.OpenOrCreate);
            StreamReader stream = new StreamReader(basa);


        }
    }
    public bool Login(out User? user)
    {
        System.Console.Write("введите логин: ");
        string? email = Console.ReadLine();
        System.Console.Write("введите пароль:");
        string? pass = Console.ReadLine();
        user = Search(login, pass);
        return user != null;
    }

    private User? Search(string? login, string? pass)
    {
        if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(pass))
        {
            System.Console.WriteLine("ERROR");
            return null;
        }

        foreach (User user in Users)
        {
            if (user == null)
            {
                continue;
            }
            if (user.Email == login && user.Password == pass)
            {
                System.Console.WriteLine("Login Succesful");
                return user;

            }
        }
        System.Console.WriteLine("ERROR input");
        return null;

    }
    public bool Registr(out User? user)
    {
        System.Console.WriteLine("введите имя");
        string? name = Console.ReadLine();
        System.Console.WriteLine("введите пароль");
        string? pass = Console.ReadLine();
        System.Console.WriteLine("введите почту");
        string? email = Console.ReadLine();
        user = SearchSimple(name, pass, email);
        if (user != null)
        {
            Users[user.Id - 1] = user;
        }
        return user != null;

    }
    private User? SearchSimple(string? name, string? password, string? email)
    {
        if (string.IsNullOrEmpty(email)
 || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(name))
        {
            System.Console.WriteLine("error input");
            return null;
        }
        return new User(NextIdUser++, name, password, email);

    }


}
