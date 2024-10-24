
using cw6;

namespace HW____;

public class Book
{
    public string Name { get; set; }

    public string Author { get; set; }

    public int Id { get; set; }

    public bool IsActive { get; set; }

    public int assignment { get; set; }

    public GenreEnum Genre { get; set; }
   


    public DateTime Time { get; set; }


    public Book(string name, string author, int id, bool isactive, int assign , GenreEnum genre)
    {
        Name = name;
        Author = author;
        Id = id;
        IsActive = isactive;
        assignment = assign;
        Genre = genre;
       
    }

   

}
