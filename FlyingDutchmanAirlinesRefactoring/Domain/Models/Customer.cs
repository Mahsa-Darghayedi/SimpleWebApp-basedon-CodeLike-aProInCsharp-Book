using FlyingDutchmanAirlinesRefactoring.Domain.Models.BaseEntities;

namespace FlyingDutchmanAirlinesRefactoring.Domain.Models
{
    public class Customer : BaseEntity<int>
    {
        public string Name { get; set; }


        public IReadOnlyCollection<Booking> Bookings { get; set; }
    }
}
