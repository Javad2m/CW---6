
namespace HW____;
public class User
{


    public int UserId { get; set; }

    public string Email { get; set; }

    public string Password { get; private set; }


    public StatEnum RoleEnum { get; set; }

    public User(string email, string pass, StatEnum role, int userid)

    {

        Email = email;
        Password = pass;
        RoleEnum = role;
        UserId = userid;
    }


    public void Setpass(string pass)
    {
        Password = pass;
    }
}

