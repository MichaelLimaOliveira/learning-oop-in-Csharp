namespace Capitulo6.HotelProjectConsole.Models
{
    public class Rent
    {
        public int Id { get; protected set; }
        public Bedroom Bedroom { get; protected set; }
        public Customer Customer { get; protected set; }
        public DateTime StartDate { get; protected set; }
        public DateTime? EndDate { get; protected set; }

        public Rent(int id, Bedroom bedroom, Customer customer)
        {
            Id = id;
            Bedroom = bedroom;
            Customer = customer;
            StartDate = DateTime.Now;
        }

        public bool IsActive() => EndDate == null;

        public void EndRent()
        {
            EndDate = DateTime.Now;
        }
    }
}