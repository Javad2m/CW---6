

namespace HW____;

public class UserService : IAuthentication
{
    private int uid = 5;
    
    public bool userCheck(string email)
    {
        bool result = false;
        foreach (var item in Storage.users)
        {
            
            if (item.Email == email)
            {
                return true;
            }

        }
        return result;
    }


    public void regist(string email, string password, int role)
    {
        StatEnum rols;
        if (role == 1)
        {
            rols = StatEnum.admin;
        }
        else
        {
            rols = StatEnum.user;
        }

        Storage.users.Add(new User(email, password, rols, uid)); 
        uid++;
        

    }

    public bool login(string email, string pass)
    {
        bool result = false;
        foreach (var item in Storage.users)
        {
         
            if (item.Email == email && item.Password == pass)
            {
                return true;
            }

        }
        return result;

    }

    public int IDD(string email)
    {
        int id = 0;
        foreach (var item in Storage.users)
        {
           
            if (item.Email == email)

            {
                id = item.UserId;
            }
        }
        return id;
    }

    public bool isUser(string email)
    {
        bool result = false;
        foreach (var item in Storage.users)
        {
           
            if (item.Email == email && item.RoleEnum == StatEnum.user)
            {
                return true;
            }

        }
        return result;
    }


    

}
