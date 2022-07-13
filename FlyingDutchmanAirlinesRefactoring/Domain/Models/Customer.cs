using FlyingDutchmanAirlinesRefactoring.Domain.Models.BaseEntities;

namespace FlyingDutchmanAirlinesRefactoring.Domain.Models
{
    public sealed class Customer : BaseEntity<int>
    {
        public Customer(string name)
        {
            Bookings = new HashSet<Booking>();
            Name = name;
        }

        public string Name { get; set; }


        public IReadOnlyCollection<Booking> Bookings { get; set; }
    }
}
