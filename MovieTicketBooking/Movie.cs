namespace MovieTicketBooking
{
    internal class Movie
    {
        public int MovieId { get; }
        public string MovieName { get; }
        public int TicketPrice { get; }
        private int _availableSeats;

        public int AvailableSeats
        { get { return _availableSeats; } }
        public Movie(int movieId, string movieName, int availableSeats, int ticketPrice)
        {
            MovieId = movieId;
            MovieName = movieName;
            _availableSeats = availableSeats;
            TicketPrice = ticketPrice;
        }
        public void BookSeat()
        {
            if (_availableSeats <= 0)
            {
                throw new NoSeatsAvailableException();
            }
            _availableSeats--;
        }
        public void CancelSeat()
        {
            _availableSeats++;
        }
    }
}

