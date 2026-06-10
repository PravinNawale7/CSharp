namespace LibraryManagementSystem
{
    internal class Program
    {
        List<Book> books = new List<Book>();

        public void PrintHeader()
        {
            Console.WriteLine("ID\tTitle\tAuthor\tPrice");
            Console.WriteLine("---------------------------------------");
        }

        public void AddBook()
        {
            Console.WriteLine("Enter the Book ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Name of the Book: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the Author of the Book: ");
            string author = Console.ReadLine();
            Console.WriteLine("Enter the Price Of the Book: ");
            double price = Convert.ToDouble(Console.ReadLine());

            var book = books.Find(b => b.BookId == id);
            if (book != null)
            {
                Console.WriteLine("Book ID already exists.");
                return;
            }

            Book b = new Book(id, name, author, price);

            books.Add(b);

            Console.WriteLine("Book Added Successfully");
            Console.WriteLine($"Book ID : {id}");
            Console.WriteLine($"Title   : {name}");
        }

        public void RemoveBook()
        {
            Console.WriteLine("Enter the Book Id to Remove: ");
            int id = Convert.ToInt32(Console.ReadLine());
            var book = books.Find((book) => book.BookId == id);

            if (book == null)
            {
                Console.WriteLine("Book Not Found");
                return;
            }

            books.Remove(book);

            Console.WriteLine("Book Removed Successfully");

        }
        public void SearchBook()
        {
            Console.WriteLine("Enter the Book id to search: ");
            int id = Convert.ToInt32(Console.ReadLine());
            var book = books.Find(book => book.BookId == id);

            if (book == null)
            {
                Console.WriteLine("Book Not Found");
                return;
            }

            Console.WriteLine("Book Found");
            Console.WriteLine();

            PrintHeader();

            Console.WriteLine(
                $"{book.BookId}\t{book.Title}\t{book.Author}\t{book.Price}"
            );

        }

        public void HighPriceBook()
        {
            var book = from b in books
                       where b.Price > 500
                       select b;

            if (!book.Any())
            {
                Console.WriteLine("No Books Found Above 500");
                return;
            }

            Console.WriteLine("Books Above 500");
            Console.WriteLine();

            PrintHeader();

            foreach (var b in book)
            {
                Console.WriteLine(
                    $"{b.BookId}\t{b.Title}\t{b.Author}\t{b.Price}"
                );
            }


        }

        public void SortedBook()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No Books Available");
                return;
            }

            var sortedBooks =
                from b in books
                orderby b.Price
                select b;

            Console.WriteLine("Books Sorted By Price");
            Console.WriteLine();

            PrintHeader();

            foreach (var book in sortedBooks)
            {
                Console.WriteLine(
                    $"{book.BookId}\t{book.Title}\t{book.Author}\t{book.Price}"
                );
            }
        }

        public void DisplayBook()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No Books Available");
                return;
            }
            Console.WriteLine("All Books");
            Console.WriteLine();

            PrintHeader();

            foreach (var book in books)
            {
                Console.WriteLine(
                    $"{book.BookId}\t{book.Title}\t{book.Author}\t{book.Price}"
                );
            }
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Welcome to the Library Management System !!!");

            try
            {

                while (true)
                {
                    Console.WriteLine("Please Select an Option");
                    Console.WriteLine("1. Add Book");
                    Console.WriteLine("2. Remove Book");
                    Console.WriteLine("3. Search Book");
                    Console.WriteLine("4. Display Book");
                    Console.WriteLine("5. Display Books Above 500");
                    Console.WriteLine("6. Display Books Sorted By Price");
                    Console.WriteLine("7 .Exit");

                    Console.WriteLine("Enter Your choice (1-7)");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            p.AddBook();
                            break;
                        case 2:
                            p.RemoveBook();
                            break;
                        case 3:
                            p.SearchBook();
                            break;
                        case 4:
                            p.DisplayBook();
                            break;
                        case 5:
                            p.HighPriceBook();
                            break;
                        case 6:
                            p.SortedBook();
                            break;
                        case 7:
                            Console.WriteLine("Exiting the system. Goodbye!");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                {
                    Console.WriteLine(e.Message);
                }

            }

        }
    }
}
