using HW____;

UserService userService = new UserService();
BookService bookService = new BookService();

int option = 0;


do
{
    Console.Clear();
    Console.WriteLine("Welcome to our Library.");
    Console.WriteLine("1.Register.");
    Console.WriteLine("2.Log in.");
    Console.WriteLine("3.Exit.");
    option = Convert.ToInt32(Console.ReadLine());

    switch (option)
    {
        case 1:
            Console.Clear();
            Console.WriteLine("Pls Enter The Email : ");
            string mail = Console.ReadLine();
            Console.WriteLine("Pls Enter The Password : ");
            string pass = Console.ReadLine();
            Console.WriteLine("Pls Enter The Role (Admin :: 1 /// User :: 0) : ");
            int role = Convert.ToInt32(Console.ReadLine());
            if (role == 0 || role == 1)
            {
                if (userService.userCheck(mail) == true)
                {
                    Console.WriteLine("The email is duplicate, please enter another email !");
                    Console.ReadKey();
                }
                else
                {
                    userService.regist(mail, pass, role);
                    Console.WriteLine("Registration was successful");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("The entered role is not correct");
                Console.ReadKey();
            }

            break;

        case 2:

            Console.Clear();
            Console.WriteLine("Pls Enter The Email : ");
            string maill = Console.ReadLine();
            Console.WriteLine("Pls Enter The Password : ");
            string ppass = Console.ReadLine();
            if (userService.login(maill, ppass) == false)
            {
                Console.WriteLine("Username or password is incorrect !");
                Console.ReadKey();
            }
            else if (userService.isUser(maill) == false)
            {
                int inpp = 0;
                do
                {
                    Console.Clear();
                    Console.WriteLine("You have successfully logged in");
                    Console.WriteLine("-------------");
                    Console.WriteLine("1.Add Book");
                    Console.WriteLine("2.Search");
                    Console.WriteLine("3.Remove");
                    Console.WriteLine("4.List Of Books");
                    Console.WriteLine("5.Show Borrow List");
                    Console.WriteLine("6.Exit.");
                    inpp = Convert.ToInt32(Console.ReadLine());

                    if (inpp == 1)
                    {
                        Console.WriteLine("Enter The Books Name : ");
                        string nbook = Console.ReadLine();
                        Console.WriteLine("Enter The Books Author : ");
                        string abook = Console.ReadLine();
                        Console.WriteLine("Pls Chose Genre :");
                        Console.WriteLine("1.Scientific");
                        Console.WriteLine("2.cultural");
                        Console.WriteLine("3.sports");
                        Console.WriteLine("4.specialized");
                        int gnr = Convert.ToInt32(Console.ReadLine());
                        bookService.AddBook(nbook, abook, gnr);
                    }
                    else if (inpp == 2)
                    {
                        Console.WriteLine("Pls Enter The Letters");
                        string lett = Console.ReadLine();
                        bookService.Search(lett);
                        Console.ReadKey();
                    }
                    else if (inpp == 3)
                    {
                        Console.WriteLine("Pls Enter The Books ID");
                        int ib = Convert.ToInt32(Console.ReadLine());
                        bookService.Remove(ib);
                        Console.WriteLine("Done");
                        Console.ReadKey();
                    }
                    else if (inpp == 4)
                    {
                        bookService.GetListOfLibraryBook();
                        Console.ReadKey();
                    }
                    else if (inpp == 5)
                    {
                        bookService.ShowBorrow();
                        Console.ReadKey();
                    }

                }
                while (inpp < 6);
            }
            else
            {
                int inp = 0;
                do
                {
                    Console.Clear();
                    Console.WriteLine("You have successfully logged in");
                    Console.WriteLine("-------------");
                    Console.WriteLine("1.List Of Book");
                    Console.WriteLine("2.Borrow Book");
                    Console.WriteLine("3.Get List Of User Books");
                    Console.WriteLine("4.Return Book");
                    Console.WriteLine("5.Exit.");
                    inp = Convert.ToInt32(Console.ReadLine());
                    if (inp == 1)
                    {
                        bookService.GetListOfLibraryBooks();
                        Console.ReadKey();
                    }
                    else if (inp == 2)
                    {
                        Console.Write("Pls Enter The Books ID : ");
                        int bid = Convert.ToInt32(Console.ReadLine());
                        if (bookService.isBook(bid) == false)
                        {
                            Console.WriteLine("ID not found in library");
                            Console.ReadKey();
                        }
                        else
                        {
                            bookService.BorrowBook(bid, maill);
                            Console.WriteLine("The book was lent to you");
                            Console.ReadKey();
                        }
                    }
                    else if (inp == 3)
                    {
                        if (bookService.haveBook(userService.IDD(maill)) == false)
                        {
                            Console.WriteLine("You Dont Have Ani Book !");
                            Console.ReadKey();
                        }
                        else
                        {
                            bookService.GetListOfUserBooks(userService.IDD(maill));
                            Console.ReadKey();
                        }
                    }
                    else if (inp == 4)
                    {
                        if (bookService.haveBook(userService.IDD(maill)) == false)
                        {
                            Console.WriteLine("You Dont Have Ani Book !");
                            Console.ReadKey();
                        }
                        else
                        {
                            bookService.GetListOfUserBooks(userService.IDD(maill));
                            Console.Write("Please enter the desired book ID : ");
                            int chose = Convert.ToInt32(Console.ReadLine());
                            if (bookService.checkId(chose) == false)
                            {
                                Console.WriteLine("The entered ID is not correct!");
                            }
                            else
                            {
                                bookService.ReturnBook(chose);
                                Console.WriteLine("The corresponding book was returned to the library");
                                Console.ReadKey();
                            }
                        }
                    }
                }
                while (inp < 5);
            }

            break;


    }
}
while (option < 3);
