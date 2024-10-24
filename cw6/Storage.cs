

using cw6;

namespace HW____;

public static class Storage
{
    public static List<Book> books { get; set; } = new List<Book>();
    public static List<User> users { get; set; } = new List<User>();

    



    static Storage()
    {
      
        books.Add(new Book("hokm", "david", 111, true, 0 , GenreEnum.cultural));
        books.Add(new Book("shelem", "pasha", 112, true, 0, GenreEnum.sports));
        books.Add(new Book("poker", "alex", 113, true, 0, GenreEnum.specialized));     
        books.Add(new Book("mench", "cris", 114, true, 0, GenreEnum.sports));      
        books.Add(new Book("nard", "leo", 115, true, 0, GenreEnum.Scientific));
                
        users.Add(new User("javad@gmail.com", "1234", StatEnum.admin, 1));      
        users.Add(new User("ali@gmail.com", "1234", StatEnum.user, 2));
        users.Add(new User("moradi", "1234", StatEnum.user, 3));
        users.Add(new User("javad", "1234", StatEnum.admin, 4));



    }



}
