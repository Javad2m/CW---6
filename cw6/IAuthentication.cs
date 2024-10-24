
namespace HW____;

public interface IAuthentication
{

    public void regist(string email, string password, int role);

    public bool login(string email, string pass);
}
