

using cw6;

namespace HW____;

public class BookService : ILibraryService
{

    public void GetListOfLibraryBooks()
    {
        foreach (var item in Storage.books)
        {

            if (item.IsActive == true)
            {
                Console.WriteLine($"Name OF Book : {item.Name}");
                Console.WriteLine($"Name of the Author : {item.Author}");
                Console.WriteLine($"Book ID : {item.Id}");
                Console.WriteLine($"Book Genre : {item.Genre}");
                Console.WriteLine("-------------");
            }


        }
    }

    public void GetListOfLibraryBook()
    {
        foreach (var item in Storage.books)
        {
            Console.WriteLine($"Name OF Book : {item.Name}");
            Console.WriteLine($"Name of the Author : {item.Author}");
            Console.WriteLine($"Book ID : {item.Id}");
            Console.WriteLine($"Book Genre : {item.Genre}");
            Console.WriteLine("-------------");

        }
    }

    public void BorrowBook(int id, string email)
    {
        int userid = 0;


        foreach (var item in Storage.users)
        {

            if (item.Email == email)
            {
                userid = item.UserId;
                break;
            }
        }
        foreach (var item in Storage.books)
        {

            if (item.Id == id)
            {
                item.assignment = userid;
                item.IsActive = false;
                item.Time = DateTime.Now;

                break;
            }
        }

    }

    public void GetListOfUserBooks(int id)
    {
        foreach (var item in Storage.books)
        {

            if (item.assignment == id)
            {
                Console.WriteLine($"Name OF Book : {item.Name}");
                Console.WriteLine($"Name of the Author : {item.Author}");
                Console.WriteLine($"Book ID : {item.Id}");
                Console.WriteLine($"Time : {item.Time}");

                Console.WriteLine("-------------");
            }
        }
    }


    public void ReturnBook(int Bookid)
    {
        foreach (var item in Storage.books)
        {

            if (item.Id == Bookid)
            {
                item.assignment = 0;
                item.IsActive = true;

            }


        }
    }



    public bool checkId(int id)
    {
        bool res = false;

        foreach (var item in Storage.books)
        {

            if (item.Id == id)
            {
                res = true;
            }
        }
        return res;
    }


    public bool haveBook(int id)
    {
        bool check = false;
        foreach (var item in Storage.books)
        {

            if (item.assignment == id)
            {
                check = true;
            }
        }
        return check;
    }


    public bool isBook(int id)
    {
        bool check = false;
        foreach (var item in Storage.books)
        {

            if (item.Id == id && item.IsActive == true)
            {
                check = true;
            }
        }
        return check;
    }

    private int bbi = 116;
    public void AddBook(string name, string aAuthor, int gnr)
    {
        GenreEnum gn = GenreEnum.sports;
        if (gnr == 1)
        {
            gn = GenreEnum.Scientific;
        }
        else if (gnr == 2)
        {
            gn = GenreEnum.cultural;
        }
        else if (gnr == 3)
        {
            gn = GenreEnum.sports;
        }
        else if (gnr == 4)
        {
            gn = GenreEnum.specialized;
        }
        Storage.books.Add(new Book(name, aAuthor, bbi, true, 0, gn));
        bbi++;
    }

    public void Search(string test)
    {
        int count = 0;
        foreach (var item in Storage.books)
        {
            if (item.Name.Contains(test) == true)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Author);
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Genre);
                Console.WriteLine("---");
                count++;
            }
        }
        if (count == 0)
        {
            Console.WriteLine("No items found");
        }
    }

    public void Remove(int id)
    {
        foreach (var item in Storage.books)
        {
            if (item.Id == id)
            {
                Storage.books.Remove(item);
                break;
            }
        }
    }


    public string ConvertToName(int id)
    {
        string check = string.Empty;

        foreach (var item in Storage.users)
        {
            if (item.UserId == id)
            {
                check = item.Email;
            }
        }
        return check;
    }




    public void ShowBorrow()
    {
        foreach (var item in Storage.books)
        {
            if (item.IsActive == false)
            {
                Console.WriteLine($"{item.Name} For {ConvertToName(item.assignment)} ");
            }
        }
    }


}
