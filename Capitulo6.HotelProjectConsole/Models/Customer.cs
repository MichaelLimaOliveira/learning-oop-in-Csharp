namespace Capitulo6.HotelProjectConsole.Models
{
    public class Customer
    {
        public long Id { get; protected set; }
        public string Name { get; protected set; }
        public string Email { get; protected set; }

        public Customer(long id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }

        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new Exception("Cannot set name to empty or null!");

            Name = name;
        }

        public void SetEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                throw new Exception("Cannot set email to empty or null!");

            Email = email;
        }
    }
}