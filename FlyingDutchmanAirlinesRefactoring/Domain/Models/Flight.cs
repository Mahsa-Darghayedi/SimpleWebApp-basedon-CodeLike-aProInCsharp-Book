using FlyingDutchmanAirlinesRefactoring.Domain.Models.BaseEntities;

namespace FlyingDutchmanAirlinesRefactoring.Domain.Models
{
    public class Flight : BaseEntity<string>
    {

        public int Origin { get; set; }
        public int Destination { get; set; }

        //Parent
        public Airport AirportOrigin { get; private set; }
        public Airport AirportDestination { get; private set; }

        //Children
        public IReadOnlyCollection<Booking> Bookings { get;  set; }
    }
}
