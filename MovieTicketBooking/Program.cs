namespace MovieTicketBooking
{
    internal class Program
    {
        Dictionary<int, Movie> movies = new Dictionary<int, Movie>();
        public Program()
        {
            movies.Add(1, new Movie(1, "Avengers", 10, 250));
            movies.Add(2, new Movie(2, "Pushpa", 8, 200));
            movies.Add(3, new Movie(3, "Bahubali", 5, 300));
        }
        public void DisplayMovies()
        {
            Console.WriteLine();
            Console.WriteLine("Available Movies");
            Console.WriteLine("ID\tMovie\t\tSeats\tPrice");
            Console.WriteLine("----------------------------------------");
            foreach (var movie in movies.Values)
            {
                Console.WriteLine($"{movie.MovieId}\t{movie.MovieName}\t\t{movie.AvailableSeats}\t{movie.TicketPrice}");
            }
            Console.WriteLine();
        }

        public void BookTicket()
        {
            DisplayMovies();
            Console.Write("Enter Movie ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            if (!movies.ContainsKey(id))
            {
                Console.WriteLine("Movie Not Found.");
                return;

            }
            movies[id].BookSeat();
            Console.WriteLine("Ticket Booked Successfully.");
            Console.WriteLine($"Remaining Seats: {movies[id].AvailableSeats}");
        }
        public void CancelTicket()
        {
            Console.Write("Enter Movie ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            if (!movies.ContainsKey(id))
            {
                Console.WriteLine("Movie Not Found.");
                return;
            }
            movies[id].CancelSeat();
            Console.WriteLine("Ticket Cancelled Successfully.");
            Console.WriteLine($"Available Seats: {movies[id].AvailableSeats}");
        }
        public void CheckStatus()
        {
            Console.Write("Enter Movie ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            if (!movies.ContainsKey(id))
            {
                Console.WriteLine("Movie Not Found.");
                return;
            }
            Movie movie = movies[id];
            Console.WriteLine();
            Console.WriteLine("Movie Details");
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Movie ID : {movie.MovieId}");
            Console.WriteLine($"Movie Name : {movie.MovieName}");
            Console.WriteLine($"Available Seats : {movie.AvailableSeats}");
            Console.WriteLine($"Ticket Price : Rs. {movie.TicketPrice}");
            Console.WriteLine("--------------------------------");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Welcome to Movie Ticket Booking System");
            while (true)
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine("1. Book Ticket");
                    Console.WriteLine("2. Cancel Ticket");
                    Console.WriteLine("3. Check Status");
                    Console.WriteLine("4. Display Movies");
                    Console.WriteLine("5. Exit");
                    Console.Write("Enter Choice (1-5): ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            p.BookTicket();
                            break;
                        case 2:
                            p.CancelTicket();
                            break;
                        case 3:
                            p.CheckStatus();
                            break;
                        case 4:
                            p.DisplayMovies();
                            break;
                        case 5:
                            Console.WriteLine("Exiting...");
                            return;
                        default:
                            Console.WriteLine("Invalid Choice.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}