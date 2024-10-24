
namespace HW____;

public interface ILibraryService
{

    public void BorrowBook(int id, string email);

    public void ReturnBook(int Bookid);
    public void GetListOfLibraryBooks();
    public void GetListOfUserBooks(int id);

    public void AddBook(string name, string aAuthor, int gnr);

    public void Remove(int id);
}
