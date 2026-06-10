namespace MovieTicketBooking
{
    internal class NoSeatsAvailableException: ApplicationException
    {
        public override string Message
        {
            get
            {
                return "No seats available for this movie.";
            }
        }
    }
}
