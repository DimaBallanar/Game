using System;
namespace DataBase;
public class User
{
       public string Name { get; set; }
    public string Password { get; set; }
     

    public User(/*int id,*/ string name, string password/*, string email*/) //: this(id)
    {
    
        Name = name;
        Password = password;
    
    }
}


